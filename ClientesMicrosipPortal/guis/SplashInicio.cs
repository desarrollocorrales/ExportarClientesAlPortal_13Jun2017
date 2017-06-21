using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using ClientesMicrosipPortal.clases;

namespace ClientesMicrosipPortal.guis
{
    public partial class SplashInicio : Form
    {
        private ConfiguracionMicrosip confMicrosip;
        private ConfiguracionMysql confMysql;

        public SplashInicio()
        {
            InitializeComponent();
        }

        private void SlashInicio_Load(object sender, EventArgs e)
        {           
        }

        private void SplashInicio_Shown(object sender, EventArgs e)
        {
            confMicrosip = new ConfiguracionMicrosip();
            confMysql = new ConfiguracionMysql();

            bool cargaExitosaMicrosip = CargaConfiguracionMicrosip();
            if (cargaExitosaMicrosip == true)
            {
                //Carga de la configuracion de microsip exitosa
                bool cargaExitosaMysql = CargaConfiguracionMysql();
                if (cargaExitosaMysql == true)
                {
                    //Carga de la configuracion de Mysql Exitosa
                    bool cargaExitosaIDVendedor = CargaIdVendedor();
                    if (cargaExitosaIDVendedor == true)
                    {
                        //carga del ID del vendedor exitosa
                        bool hayConexion = PruebaConexionPortal();
                        if (hayConexion == true)
                        {
                            this.Hide();
                            // Frm_Principal FrmPrincipal = new Frm_Principal(confMicrosip, confMysql);
                            Frm_Principal FrmPrincipal = new Frm_Principal();
                            FrmPrincipal.lstClientes = getClientes();
                            FrmPrincipal.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }

            this.Close();
        }

        private bool CargaConfiguracionMicrosip()
        {
            Application.DoEvents();
            lblAccion.Text = "Cargando configuracion de Microsip...";
            Application.DoEvents();
            bool cargaExitosaMicrosip = confMicrosip.LoadConfiguration();
            Application.DoEvents();

            if (cargaExitosaMicrosip == false)
            {
                MessageBox.Show(confMicrosip.errorMessage);
                return false;
            }

            lblAccion.Text = "Configuración cargada con exito...";
            return true;
        }
        private bool CargaConfiguracionMysql()
        {            
            Application.DoEvents();
            bool cargaExitosaMysql = confMysql.LoadConfiguration();
            Application.DoEvents();
            lblAccion.Text = "Cargando configuracion del Portal...";
            Application.DoEvents();

            if (cargaExitosaMysql == false)
            {
                MessageBox.Show(confMysql.errorMessage);
                return false;
            }

            lblAccion.Text = "Configuración cargada con exito...";
            return true;
        }
        private bool CargaIdVendedor()
        {
            Application.DoEvents();
            lblAccion.Text = "Validando ID del Vendedor...";
            Application.DoEvents();
            string sIdVendedor = ConfigurationManager.AppSettings["ID_Vendedor"];            
            Application.DoEvents();
            
            if (sIdVendedor == "0")
            {
                MessageBox.Show("Aun no se ha configurado el ID del vendedor en el archivo App.config...");
                return false;
            }

            Application.DoEvents();
            lblAccion.Text = "ID del Vendedor Correcto...";
            Application.DoEvents();

            return true;
        }
        private bool PruebaConexionPortal()
        {
            Application.DoEvents();
            lblAccion.Text = "Probando conexion a internet...";
            Application.DoEvents();
            Mysql_DAL mysqlDal = new Mysql_DAL(confMysql);
            string sRespuesta = mysqlDal.ProbarConexion();
            Application.DoEvents();
            
            if (sRespuesta != "OK")
            {
                MessageBox.Show(sRespuesta);
                return false;
            }

            Application.DoEvents();
            lblAccion.Text = "Conexion realizada con exito...";
            Application.DoEvents();

            return true;
        }

        private List<Cliente> getClientes()
        {
            Application.DoEvents();
            lblAccion.Text = "Obteniendo Clientes desde Microsip...";
            Firebird_DAL fbDAL= new Firebird_DAL(confMicrosip);
            List<Cliente> lstClientes = fbDAL.getClientesForaneos();
            if (lstClientes.Count == 0)
            {
                MessageBox.Show("No se encontro ningun cliente...");
                this.Close();
            }

            Application.DoEvents();
            lblAccion.Text = "Consulta realizada con exito...";

            return lstClientes;
        }
    }
}
