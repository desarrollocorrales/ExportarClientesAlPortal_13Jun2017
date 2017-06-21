using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClientesMicrosipPortal.guis
{
    public partial class frmConfiguracion : Form
    {
        private clases.ConfiguracionMicrosip _configMicro;
        private clases.ConfiguracionMysql _configMySQL;
        private string _path = string.Empty;

        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CteMPortal\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                this._path = pathConfigFile + fileName;

                if (file != null)
                {
                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(this._path, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        // microsip
                        this.tbServidorM.Text = list[0].Substring(2);           // sucursal
                        this.tbBaseDatosM.Text = list[1].Substring(2);           // servidor
                        this.tbPuertoM.Text = list[2].Substring(2);           // base de datos
                        this.tbUsuarioM.Text = list[3].Substring(2);               // usuario
                        this.tbContraseniaM.Text = list[4].Substring(2);         // contraseña

                        // mysql
                        this.tbServidorMs.Text = list[5].Substring(2);           // sucursal
                        this.tbBaseDeDatosMs.Text = list[6].Substring(2);           // servidor
                        this.tbPuertoMs.Text = list[7].Substring(2);           // base de datos
                        this.tbUsuarioMs.Text = list[8].Substring(2);               // usuario
                        this.tbContraseniaMs.Text = list[9].Substring(2);         // contraseña

                        bool pruebaConn = pruebaConMicro();

                        if (pruebaConn)
                        {
                            this._cargaInfo();

                            this.cmbVendedores.SelectedValue = Convert.ToInt64(list[11].Substring(2));
                            this.cmbCobrador.SelectedValue = Convert.ToInt64(list[15].Substring(2));
                            this.cmbCPAnterior.SelectedValue = Convert.ToInt64(list[18].Substring(2));
                            this.cmbCPNueva.SelectedValue = Convert.ToInt64(list[20].Substring(2));
                            this.tbUserMicrosip.Text = list[13].Substring(2);
                        }

                        pruebaConn = pruebaConMysql();

                        if (pruebaConn)
                        {
                            this._cargaInfoMs();

                            this.cmbVendedorMS.SelectedValue = Convert.ToInt64(list[22].Substring(2));
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnProbarConnMicrosip_Click(object sender, EventArgs e)
        {
            try
            {
                bool pruebaConn = this.pruebaConMicro();

                if (pruebaConn)
                    MessageBox.Show("Conexión Exitosa!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    throw new Exception("Falló la conexión a la base de datos del Microsip");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool pruebaConMicro()
        {
            this._configMicro = new clases.ConfiguracionMicrosip();
            this._configMicro.empresa = "";
            this._configMicro.path = this.tbServidorM.Text + ":" + this.tbBaseDatosM.Text;
            this._configMicro.user = this.tbUsuarioM.Text;
            this._configMicro.pass = this.tbContraseniaM.Text;
            this._configMicro.port = this.tbPuertoM.Text;

            ClientesMicrosipPortal.clases.Firebird_DAL fireB = new clases.Firebird_DAL(this._configMicro);

            bool result = fireB.pruebaConn();

            return result;
        }

        private void btnTestConnMS_Click(object sender, EventArgs e)
        {
            try
            {
                bool pruebaConn = this.pruebaConMysql();

                if (pruebaConn)
                    MessageBox.Show("Conexión Exitosa!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    throw new Exception("Falló la conexión a la base de datos");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public bool pruebaConMysql()
        {
            this._configMySQL = new clases.ConfiguracionMysql();
            this._configMySQL.server = this.tbServidorMs.Text;
            this._configMySQL.user = this.tbUsuarioMs.Text;
            this._configMySQL.pass = this.tbContraseniaMs.Text;
            this._configMySQL.database = this.tbBaseDeDatosMs.Text;
            this._configMySQL.port = this.tbPuertoMs.Text;

            ClientesMicrosipPortal.clases.Mysql_DAL mySQL = new clases.Mysql_DAL(this._configMySQL);

            bool result = mySQL.pruebaConn();

            return result;
        }

        private void btnCargaInfo_Click(object sender, EventArgs e)
        {
            try
            {
                bool pruebaConn = pruebaConMicro();

                if (!pruebaConn)
                    throw new Exception("Falló la conexión a la base de datos del Microsip");

                this._cargaInfo();

                bool pruebaConnMs = pruebaConMysql();

                if (!pruebaConnMs)
                    throw new Exception("Falló la conexión a la base de datos Logística");

                this._cargaInfoMs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _cargaInfo()
        {
            try
            {
                clases.Firebird_DAL fireB = new clases.Firebird_DAL(this._configMicro);
                List<clases.Vendedores> vendedores = fireB.getVendedores();
                List<clases.Cobradores> cobradores = fireB.getCobradores();
                List<clases.CondPago> condPagoA = fireB.getCondPago();
                List<clases.CondPago> condPagoN = fireB.getCondPago();

                this.cmbVendedores.DataSource = vendedores;
                this.cmbVendedores.DisplayMember = "nombre";
                this.cmbVendedores.ValueMember = "vendedorId";

                this.cmbCobrador.DataSource = cobradores;
                this.cmbCobrador.DisplayMember = "nombre";
                this.cmbCobrador.ValueMember = "cobradorId";

                this.cmbCPAnterior.DataSource = condPagoA;
                this.cmbCPAnterior.DisplayMember = "nombre";
                this.cmbCPAnterior.ValueMember = "condPagoId";

                this.cmbCPNueva.DataSource = condPagoN;
                this.cmbCPNueva.DisplayMember = "nombre";
                this.cmbCPNueva.ValueMember = "condPagoId";

                long vendedorId = vendedores.Where(w => w.esPred.Equals("S")).Select(s => s.vendedorId).FirstOrDefault();
                long cobradorId = cobradores.Where(w => w.esPred.Equals("S")).Select(s => s.cobradorId).FirstOrDefault();
                long condPagoId = condPagoA.Where(w => w.esPred.Equals("S")).Select(s => s.condPagoId).FirstOrDefault();

                this.cmbCobrador.SelectedValue = cobradorId;
                this.cmbVendedores.SelectedValue = vendedorId;
                this.cmbCPAnterior.SelectedValue = condPagoId;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _cargaInfoMs()
        {
            try
            {
                clases.Mysql_DAL mysql = new clases.Mysql_DAL(this._configMySQL);

                List<clases.Vendedores> vendedores = mysql.getVendedores();

                this.cmbVendedorMS.DataSource = vendedores;
                this.cmbVendedorMS.DisplayMember = "nombre";
                this.cmbVendedorMS.ValueMember = "vendedorId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                foreach (Control x in this.groupBox1.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }

                // validaciones
                foreach (Control x in this.groupBox2.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }

                if (this.cmbVendedores.SelectedIndex == -1)
                    throw new Exception("Seleccione un vendedor");

                if (string.IsNullOrEmpty(this.tbUserMicrosip.Text))
                    throw new Exception("Defina el usuario de microsip");

                if (this.cmbCobrador.SelectedIndex == -1)
                    throw new Exception("Seleccione un cobrador");

                if (this.cmbCPAnterior.SelectedIndex == -1)
                    throw new Exception("Seleccione una condicion de pago anterior");

                if (this.cmbCPNueva.SelectedIndex == -1)
                    throw new Exception("Seleccione una condicion de pago nueva");

                string condAnt = ((clases.CondPago)this.cmbCPAnterior.SelectedItem).nombre;
                string condNva = ((clases.CondPago)this.cmbCPNueva.SelectedItem).nombre;

                if (condAnt.Equals(condNva))
                    throw new Exception("Seleccione una condicion de pago nueva diferente");

                if (this.cmbVendedorMS.SelectedIndex == -1)
                    throw new Exception("Seleccione un vendedor del sistema");

                // define texto del archivo
                string cadena = string.Empty;

                // MICROSIP
                cadena += "S_" + this.tbServidorM.Text + "||";
                cadena += "S_" + this.tbBaseDatosM.Text + "||";
                cadena += "D_" + this.tbPuertoM.Text + "||";
                cadena += "U_" + this.tbUsuarioM.Text + "||";
                cadena += "C_" + this.tbContraseniaM.Text + "||";

                // MYSQL
                cadena += "S_" + this.tbServidorMs.Text + "||";
                cadena += "S_" + this.tbBaseDeDatosMs.Text + "||";
                cadena += "D_" + this.tbPuertoMs.Text + "||";
                cadena += "U_" + this.tbUsuarioMs.Text + "||";
                cadena += "C_" + this.tbContraseniaMs.Text + "||";

                cadena += "V_" + this.cmbVendedores.SelectedIndex + "||";
                cadena += "V_" + ((clases.Vendedores)this.cmbVendedores.SelectedItem).vendedorId + "||";
                cadena += "V_" + ((clases.Vendedores)this.cmbVendedores.SelectedItem).nombre + "||";

                cadena += "U_" + this.tbUserMicrosip.Text + "||";

                cadena += "C_" + this.cmbCobrador.SelectedIndex + "||";
                cadena += "C_" + ((clases.Cobradores)this.cmbCobrador.SelectedItem).cobradorId + "||";
                cadena += "C_" + ((clases.Cobradores)this.cmbCobrador.SelectedItem).nombre + "||";

                cadena += "C1" + this.cmbCPAnterior.SelectedIndex + "||";
                cadena += "C1" + ((clases.CondPago)this.cmbCPAnterior.SelectedItem).condPagoId + "||";

                cadena += "C2" + this.cmbCPNueva.SelectedIndex + "||";
                cadena += "C2" + ((clases.CondPago)this.cmbCPNueva.SelectedItem).condPagoId + "||";

                cadena += "V_" + this.cmbVendedorMS.SelectedIndex + "||";
                cadena += "V_" + ((clases.Vendedores)this.cmbVendedorMS.SelectedItem).vendedorId + "||";
                cadena += "V_" + ((clases.Vendedores)this.cmbVendedorMS.SelectedItem).nombre + "||";

                cadena += "C1" + ((clases.CondPago)this.cmbCPAnterior.SelectedItem).nombre + "||";
                cadena += "C2" + ((clases.CondPago)this.cmbCPNueva.SelectedItem).nombre + "||";

                // prosigue con la creación del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.EncryptFile("milagros", cadena, this._path);

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    Modelos.ConectionString.connFB = new clases.ConfiguracionMicrosip();
                    Modelos.ConectionString.connMySQL = new clases.ConfiguracionMysql();

                    Modelos.ConectionString.connFB.empresa = "";
                    Modelos.ConectionString.connFB.path = this.tbServidorM.Text + ":" + this.tbBaseDatosM.Text;
                    Modelos.ConectionString.connFB.user = this.tbUsuarioM.Text;
                    Modelos.ConectionString.connFB.pass = this.tbContraseniaM.Text;
                    Modelos.ConectionString.connFB.port = this.tbPuertoM.Text;

                    Modelos.ConectionString.connMySQL.server = this.tbServidorMs.Text;
                    Modelos.ConectionString.connMySQL.user = this.tbUsuarioMs.Text;
                    Modelos.ConectionString.connMySQL.pass = this.tbContraseniaMs.Text;
                    Modelos.ConectionString.connMySQL.database = this.tbBaseDeDatosMs.Text;
                    Modelos.ConectionString.connMySQL.port = this.tbPuertoMs.Text;

                    Modelos.parametros.vendedorId = ((clases.Vendedores)this.cmbVendedores.SelectedItem).vendedorId;
                    Modelos.parametros.userMicro = this.tbUserMicrosip.Text;
                    Modelos.parametros.cobradorId = ((clases.Cobradores)this.cmbCobrador.SelectedItem).cobradorId;
                    Modelos.parametros.cpAnterior = ((clases.CondPago)this.cmbCPAnterior.SelectedItem).condPagoId;
                    Modelos.parametros.cpNuevo = ((clases.CondPago)this.cmbCPNueva.SelectedItem).condPagoId;

                    Modelos.parametros.nomVendedor = ((clases.Vendedores)this.cmbVendedores.SelectedItem).nombre;
                    Modelos.parametros.nomCobrador = ((clases.Cobradores)this.cmbCobrador.SelectedItem).nombre;

                    MessageBox.Show("La configuracion se ha guardado con exito!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
