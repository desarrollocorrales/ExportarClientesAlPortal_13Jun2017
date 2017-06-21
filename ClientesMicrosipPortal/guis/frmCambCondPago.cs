using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientesMicrosipPortal.clases;

namespace ClientesMicrosipPortal.guis
{
    public partial class frmCambCondPago : Form
    {
        public List<Cliente> lstClientes = new List<Cliente>();
        public List<Cliente> lstClientesACambiar = new List<Cliente>();

        public frmCambCondPago()
        {
            InitializeComponent();
        }

        private void frmCambCondPago_Load(object sender, EventArgs e)
        {
            try
            {
                this.gcClientesCambio.DataSource = this.lstClientesACambiar;
                this.gridClientesMicrosip.DataSource = this.lstClientes;

                this.lbUsuarioMicrosip.Text = Modelos.parametros.userMicro;
                this.lbVendedor.Text = Modelos.parametros.nomVendedor;
                this.lbCobrador.Text = Modelos.parametros.nomCobrador;
                this.lbVendedorSistema.Text = Modelos.parametros.nomVenSis;

                this.lbCPA.Text = Modelos.parametros.cpaNombre;
                this.lbCPN.Text = Modelos.parametros.cpnNombre;

                Firebird_DAL fbDAL = new Firebird_DAL(Modelos.ConectionString.connFB);
                this.lstClientes = fbDAL.getClientesForaneos();

                if (this.lstClientes.Count == 0)
                {
                    MessageBox.Show("No se encontro ningun cliente...");
                    this.Close();
                }

                // filtrar lista de clientes
                this.lstClientes = this.lstClientes
                    .Where(w => w.usuarioCreador.Equals(Modelos.parametros.userMicro) &&
                                w.vendedorId == Modelos.parametros.vendedorId &&
                                w.cobradorId == Modelos.parametros.cobradorId &&
                                w.condPago == Modelos.parametros.cpAnterior)
                    .ToList();

                Application.DoEvents();

                this.gridClientesMicrosip.DataSource = null;
                this.gridClientesMicrosip.DataSource = this.lstClientes;
                this.gvClientesMicrosip.BestFitColumns();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbClientesB_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> lstClientesAux = new List<Cliente>();
            lstClientesAux = lstClientes.FindAll(o => o.Nombre.Contains(tbClientesB.Text.ToUpper()));
            gridClientesMicrosip.DataSource = lstClientesAux;
            gvClientesMicrosip.BestFitColumns();
            Application.DoEvents();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int iSelected = gvClientesMicrosip.GetSelectedRows()[0];
                Cliente clienteSeleccionado = (Cliente)gvClientesMicrosip.GetRow(iSelected);

                AgregarClienteLista(clienteSeleccionado);
                this.btnCambiar.Enabled = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AgregarClienteLista(Cliente clienteSeleccionado)
        {
            lstClientesACambiar.Add(clienteSeleccionado);
            lstClientesACambiar = lstClientesACambiar.Distinct().ToList();

            this.gcClientesCambio.DataSource = lstClientesACambiar;
            this.gridView1.BestFitColumns();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.DataRowCount > 0)
                {
                    int iSelected = gridView1.GetSelectedRows()[0];
                    Cliente clienteSeleccionado = (Cliente)gridView1.GetRow(iSelected);

                    QuitarClienteLista(clienteSeleccionado);
                }

                if (gridView1.DataRowCount == 0)
                {
                    this.btnCambiar.Enabled = false;
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void QuitarClienteLista(Cliente clienteSeleccionado)
        {
            lstClientesACambiar.Remove(clienteSeleccionado);
            lstClientesACambiar = lstClientesACambiar.Distinct().ToList();

            this.gcClientesCambio.DataSource = lstClientesACambiar;
            this.gridView1.BestFitColumns();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                lstClientesACambiar = new List<Cliente>();
                this.gcClientesCambio.DataSource = new List<clases.Cliente>();

                this.btnCambiar.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#b2bc29");
                e.Appearance.ForeColor = Color.Black;
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

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> lstClientesAExportar = (List<Cliente>)gcClientesCambio.DataSource;

                /* ACTUALIZACION A CLIENTES EN MICROSIP */

                long cpAnt = Modelos.parametros.cpAnterior;
                long cpNvo = Modelos.parametros.cpNuevo;

                Firebird_DAL fireB = new Firebird_DAL(Modelos.ConectionString.connFB);
                fireB.actClientes(lstClientesAExportar, cpAnt, cpNvo);

                /* ACTUALIZACION A CLIENTES EN MICROSIP */

                MessageBox.Show("Proceso Concluido", "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Importar Clientes Microsip - Portal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
