using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientesMicrosipPortal.clases;
using System.Globalization;
using System.IO;

namespace ClientesMicrosipPortal.guis
{
    public partial class Frm_Principal : Form
    {
        public List<Cliente> lstClientes = new List<Cliente>();
        public List<Cliente> lstClientesAExportar = new List<Cliente>();

        public bool _defConfig;

        private bool _agrega = false;
        /*
        public Frm_Principal(ConfiguracionMicrosip confMicorsip, ConfiguracionMysql confMysql)
        {
            InitializeComponent();
            this.confMicrosip = confMicorsip;
            this.confMysql = confMysql;

            lstClientesAExportar = new List<Cliente>();
        }
        */
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Shown(object sender, EventArgs e)
        {
            //Dibujar el Formulario
            Application.DoEvents();
            gridClientesMicrosip.DataSource = lstClientes;
            gvClientesMicrosip.BestFitColumns();
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> lstClientesAux = new List<Cliente>();
            lstClientesAux = lstClientes.FindAll(o => o.Nombre.Contains(txbBusqueda.Text.ToUpper()));
            gridClientesMicrosip.DataSource = lstClientesAux;
            gvClientesMicrosip.BestFitColumns();
            Application.DoEvents();
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._defConfig) throw new Exception("No se ha definido la configuración");

                int iSelected = gvClientesMicrosip.GetSelectedRows()[0];
                Cliente clienteSeleccionado = (Cliente)gvClientesMicrosip.GetRow(iSelected);

                if (!this._agrega)
                    //throw new Exception("No se permite agregar el cliente a la lista a exportar");
                    MessageBox.Show("El cliente '" + clienteSeleccionado.Nombre + "' se podrá agregar al portal " + 
                            "pero el cambio de condición de pago no se realizará", 
                            "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    clienteSeleccionado.cambiaCP = true;

                AgregarClienteLista(clienteSeleccionado);
                btnExportar.Enabled = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void AgregarClienteLista(Cliente cliente)
        {
            lstClientesAExportar.Add(cliente);
            lstClientesAExportar = lstClientesAExportar.Distinct().ToList();

            gridClientesAExportar.DataSource = lstClientesAExportar;
            gvClientesAExportar.BestFitColumns();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
            if (!this._defConfig) throw new Exception("No se ha definido la configuración");
            
            if (gvClientesAExportar.DataRowCount > 0)
            {
                int iSelected = gvClientesAExportar.GetSelectedRows()[0];
                Cliente clienteSeleccionado = (Cliente)gvClientesAExportar.GetRow(iSelected);

                QuitarClienteLista(clienteSeleccionado);
            }
            
            if (gvClientesAExportar.DataRowCount == 0)
            {
                btnExportar.Enabled = false;
            }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void QuitarClienteLista(Cliente cliente)
        {
            lstClientesAExportar.Remove(cliente);
            lstClientesAExportar = lstClientesAExportar.Distinct().ToList();

            gridClientesAExportar.DataSource = lstClientesAExportar;
            gvClientesAExportar.BestFitColumns();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (!this._defConfig) throw new Exception("No se ha definido la configuración");
            bool esCorrecto = ValidarExportar();
            if (esCorrecto == true)
            {
                Exportar();
            }
        }
        private bool ValidarExportar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Se van a exportar {0} clientes...", gvClientesAExportar.DataRowCount));
            sb.AppendLine("¿Son datos correctos?");

            DialogResult dr = MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                return true;
            else
                return false;
        }
        private void Exportar()
        {            
            try
            {
                List<Cliente> lstClientesAExportar = (List<Cliente>)gridClientesAExportar.DataSource;

                long idVenSis = Modelos.parametros.venSisId;

                Mysql_DAL myDAL = new Mysql_DAL(Modelos.ConectionString.connMySQL);
                // myDAL.InsertarClientes(lstClientesAExportar, idVenSis);

                /* ACTUALIZACION A CLIENTES EN MICROSIP */

                string usM = Modelos.parametros.userMicro;
                long ven = Modelos.parametros.vendedorId;
                long cob = Modelos.parametros.cobradorId;

                List<Cliente> actMicro =
                    lstClientesAExportar
                        .Where(w => w.vendedorId == ven &&
                                    w.cobradorId == cob &&
                                    w.usuarioCreador.Equals(usM))
                        .ToList();

                long cpAnt = Modelos.parametros.cpAnterior;
                long cpNvo = Modelos.parametros.cpNuevo;

                List<Cliente> lstClienteCambio = ((List<Cliente>)gridClientesAExportar.DataSource).Where(w => w.cambiaCP == true).ToList();

                actMicro = actMicro.Where(w => lstClienteCambio.Contains(w)).ToList();

                Firebird_DAL fireB = new Firebird_DAL(Modelos.ConectionString.connFB);
                //fireB.actClientes(actMicro, cpAnt, cpNvo);

                /* ACTUALIZACION A CLIENTES EN MICROSIP */

                MessageBox.Show("¡La exportacion ha finalizado con exito!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string error;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Error:");
                sb.AppendLine();
                error = ex.Message.Replace("Duplicate entry", string.Empty);
                error = error.Replace("for key", string.Empty);
                error = error.Replace("'nombre'", string.Empty);
                error = error + Environment.NewLine + "Ya existe en en portal...";
                sb.AppendLine(error);
                MessageBox.Show(sb.ToString(), (ex.GetType()).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            try
            {

                // valida si ya tiene alguna clave guardada para el archivo
                string cveActual = Properties.Settings.Default.accesoConfig;

                if (string.IsNullOrEmpty(cveActual))
                {
                    string acceso = Modelos.Utilerias.Transform("c0rr4l3s");

                    Properties.Settings.Default.accesoConfig = acceso;
                    Properties.Settings.Default.Save();
                }

                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CteMPortal\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                if (file == null)
                {
                    // no existe
                    // abrir el formulario para llenar la configuracion de conexion 
                    frmConfiguracion form = new frmConfiguracion();
                    var resultado = form.ShowDialog();

                    if (resultado != System.Windows.Forms.DialogResult.OK)
                    {
                        this._defConfig = false;
                        throw new Exception("No se ha definido la configuración");
                    }
                }

                file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                // si existe
                // obtener la cadena de conexion del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(file, "milagros");

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                    // microsip
                    string servidor = list[0].Substring(2);     // SERVIDOR
                    string baseDatos = list[1].Substring(2);    // BASE DE DATOS
                    string puerto = list[2].Substring(2);       // PUERTO
                    string usuario = list[3].Substring(2);      // USUARIO
                    string contra = list[4].Substring(2);       // CONTRASEÑA

                    // mysql
                    string servidorM = list[5].Substring(2);    // SERVIDOR
                    string baseDatosM = list[6].Substring(2);   // BASE DE DATOS
                    string puertoM = list[7].Substring(2);      // PUERTO
                    string usuarioM = list[8].Substring(2);     // USUARIO
                    string contraM = list[9].Substring(2);      // CONTRASEÑA

                    // vendedor, cobrador, usuario, condiciones pago
                    string vendedor = list[11].Substring(2);     // VENDEDOR
                    string cobrador = list[15].Substring(2);     // COBRADOR
                    string userMicro = list[13].Substring(2);    // USUARIO DE MICROSIP
                    string cpAnterior = list[18].Substring(2);   // CONDICION DE PAGO ANTERIOR
                    string cpNueva = list[20].Substring(2);      // CONDICION DE PAGO NUEVA

                    string nomVendedor = list[12].Substring(2);
                    string nomCobrador = list[16].Substring(2);

                    string nomVendSis = list[23].Substring(2);
                    string venSisId = list[22].Substring(2);

                    string cpaNombre = list[24].Substring(2);
                    string cpnNombre = list[25].Substring(2);

                    Modelos.ConectionString.connFB = new clases.ConfiguracionMicrosip();
                    Modelos.ConectionString.connMySQL = new clases.ConfiguracionMysql();

                    Modelos.ConectionString.connFB.empresa = "";
                    Modelos.ConectionString.connFB.path = servidor + ":" + baseDatos;
                    Modelos.ConectionString.connFB.user = usuario;
                    Modelos.ConectionString.connFB.pass = contra;
                    Modelos.ConectionString.connFB.port = puerto;

                    Modelos.ConectionString.connMySQL.server = servidorM;
                    Modelos.ConectionString.connMySQL.database = baseDatosM;
                    Modelos.ConectionString.connMySQL.port = puertoM;
                    Modelos.ConectionString.connMySQL.user = usuarioM;
                    Modelos.ConectionString.connMySQL.pass = contraM;

                    Modelos.parametros.vendedorId = Convert.ToInt64(vendedor);
                    Modelos.parametros.cobradorId = Convert.ToInt64(cobrador);
                    Modelos.parametros.userMicro = userMicro;
                    Modelos.parametros.cpAnterior = Convert.ToInt64(cpAnterior);
                    Modelos.parametros.cpNuevo = Convert.ToInt64(cpNueva);

                    Modelos.parametros.nomCobrador = nomCobrador;
                    Modelos.parametros.nomVendedor = nomVendedor;

                    Modelos.parametros.nomVenSis = nomVendSis;
                    Modelos.parametros.venSisId = Convert.ToInt64(venSisId);

                    Modelos.parametros.cpaNombre = cpaNombre;
                    Modelos.parametros.cpnNombre = cpnNombre;

                    this._defConfig = true;
                }

                this._cargaClientes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void _cargaClientes()
        {
            Firebird_DAL fbDAL = new Firebird_DAL(Modelos.ConectionString.connFB);
            //List<Cliente> lstClientes = fbDAL.getClientesForaneos();
            this.lstClientes = fbDAL.getClientesForaneos();
            if (this.lstClientes.Count == 0)
            {
                MessageBox.Show("No se encontro ningun cliente...");
                this.Close();
            }

            this.lbUsuarioMicrosip.Text = Modelos.parametros.userMicro;
            this.lbVendedor.Text = Modelos.parametros.nomVendedor;
            this.lbCobrador.Text = Modelos.parametros.nomCobrador;
            this.lbVendedorSistema.Text = Modelos.parametros.nomVenSis;

            this.lbError.Text = string.Empty;

            Application.DoEvents();

            this.gridClientesMicrosip.DataSource = null;
            this.gridClientesMicrosip.DataSource = this.lstClientes;
            this.gvClientesMicrosip.BestFitColumns();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmAcceso formA = new frmAcceso();

            var respuesta = formA.ShowDialog();

            if (respuesta == System.Windows.Forms.DialogResult.OK)
            {
                frmConfiguracion form = new frmConfiguracion();
                var resultado = form.ShowDialog();

                if (resultado == System.Windows.Forms.DialogResult.OK)
                    this.Frm_Principal_Load(null, null);
            }
        }

        private void gvClientesMicrosip_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.DodgerBlue;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void gridClientesMicrosip_Click(object sender, EventArgs e)
        {
            try
            {
                this._validaClientes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gvClientesMicrosip_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this._validaClientes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void _validaClientes()
        {
            if (this.gvClientesMicrosip.GetSelectedRows().Count() == 0)
                return;

            clases.Cliente cteSel = new Cliente();

            foreach (int i in this.gvClientesMicrosip.GetSelectedRows())
            {
                var dr1 = this.gvClientesMicrosip.GetRow(i);

                cteSel = (clases.Cliente)dr1;
            }

            if (Modelos.parametros.vendedorId != cteSel.vendedorId ||
                Modelos.parametros.cobradorId != cteSel.cobradorId ||
                !Modelos.parametros.userMicro.Equals(cteSel.usuarioCreador))
            {
                this.lbError.Text = 
                    "El vendedor, el cobrador y el usuario de microsip" + 
                    " deben de ser los definidos en la configuración";
                this._agrega = false;
            }
            else
            {
                this.lbError.Text = string.Empty;
                this._agrega = true;
            }
        }

        private void gvClientesAExportar_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#b2bc29");
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._defConfig) throw new Exception("No se ha definido la configuración");
                
                lstClientesAExportar = new List<Cliente>();
                this.gridClientesAExportar.DataSource = new List<clases.Cliente>();

                btnExportar.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCambCondPago_Click(object sender, EventArgs e)
        {
            try
            {
                frmCambCondPago form = new frmCambCondPago();

                form.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gvClientesAExportar_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

                int row = view.FocusedRowHandle;
                
                Cliente clienteSeleccionado = (Cliente)gvClientesAExportar.GetRow(row);
                
                if (Modelos.parametros.vendedorId != clienteSeleccionado.vendedorId ||
                    Modelos.parametros.cobradorId != clienteSeleccionado.cobradorId ||
                    !Modelos.parametros.userMicro.Equals(clienteSeleccionado.usuarioCreador))
                e.Cancel = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

