using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace ClientesMicrosipPortal.clases
{
    public class Firebird_DAL
    {
        private FbConnection fbConexion;
        private FbCommand fbCommand;
        private FbDataAdapter fbAdapter;
        private ConfiguracionMicrosip confMicrosip;

        public Firebird_DAL(ConfiguracionMicrosip confMicrosip)
        {
            this.confMicrosip = confMicrosip;
            fbConexion = new FbConnection();
            fbConexion.ConnectionString = getConnectionString();
        }

        private string getConnectionString()
        {
            FbConnectionStringBuilder ConnectionStringBuilder = new FbConnectionStringBuilder();
            ConnectionStringBuilder.UserID = confMicrosip.user;
            ConnectionStringBuilder.Password = confMicrosip.pass;
            ConnectionStringBuilder.Port = Convert.ToInt32(confMicrosip.port);
            ConnectionStringBuilder.Database = confMicrosip.path;

            return ConnectionStringBuilder.ToString();
        }

        public List<Cliente> getClientesForaneos()
        {
            List<Cliente> lstClientes = new List<Cliente>();
            DataTable dtResultado = new DataTable();

            string sConsulta =
                            @"SELECT 
                                  CLAVES_CLIENTES.CLAVE_CLIENTE AS ClaveCliente,
                                  CLIENTES.NOMBRE AS NombreCliente,
                                  CLAVES_CAT_SEC.CLAVE AS ClaveRuta, 
                                  VIAS_EMBARQUE.NOMBRE AS Ruta,
                                  CLIENTES.COBRADOR_ID,
                                  CLIENTES.VENDEDOR_ID,
                                  CLIENTES.USUARIO_CREADOR,
                                  CLIENTES.CLIENTE_ID,
                                  V.NOMBRE AS VENDEDOR,
                                  C.NOMBRE AS COBRADOR,
                                  clientes.COND_PAGO_ID
                                FROM
                                  CLAVES_CLIENTES
                                  INNER JOIN CLIENTES ON (CLAVES_CLIENTES.CLIENTE_ID = CLIENTES.CLIENTE_ID)
                                  INNER JOIN ROLES_CLAVES_CLIENTES ON (CLAVES_CLIENTES.ROL_CLAVE_CLI_ID = ROLES_CLAVES_CLIENTES.ROL_CLAVE_CLI_ID)
                                  INNER JOIN DIRS_CLIENTES ON (CLIENTES.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID)
                                  INNER JOIN VIAS_EMBARQUE ON (DIRS_CLIENTES.VIA_EMBARQUE_ID = VIAS_EMBARQUE.VIA_EMBARQUE_ID)
                                  INNER JOIN CLAVES_CAT_SEC ON (VIAS_EMBARQUE.VIA_EMBARQUE_ID = CLAVES_CAT_SEC.ELEM_ID)
                                  INNER JOIN TIPOS_CLIENTES ON (CLIENTES.TIPO_CLIENTE_ID = TIPOS_CLIENTES.TIPO_CLIENTE_ID)
                                  LEFT JOIN VENDEDORES V ON (CLIENTES.VENDEDOR_ID = V.VENDEDOR_ID)
                                  LEFT JOIN COBRADORES C ON (CLIENTES.COBRADOR_ID = C.COBRADOR_ID)
                                WHERE
                                  ROLES_CLAVES_CLIENTES.ES_PPAL LIKE 'S' order by clientes.nombre";
            fbCommand = new FbCommand(sConsulta, fbConexion);
            fbAdapter = new FbDataAdapter(fbCommand);            
            fbAdapter.Fill(dtResultado);

            Cliente cliente;
            foreach (DataRow row in dtResultado.Rows)
            {
                cliente = new Cliente();

                if (row["ClaveCliente"] is DBNull) cliente.ClaveCliente = string.Empty;
                else cliente.ClaveCliente = Convert.ToString(row["ClaveCliente"]);

                if (row["NombreCliente"] is DBNull) cliente.Nombre = string.Empty;
                else cliente.Nombre = Convert.ToString(row["NombreCliente"]);

                if (row["ClaveRuta"] is DBNull) cliente.RutaID = 0;
                else /*cliente.RutaID = Convert.ToInt32(row["ClaveRuta"]);*/ cliente.RutaID = 0;

                if (row["Ruta"] is DBNull) cliente.Ruta = string.Empty;
                else cliente.Ruta = Convert.ToString(row["Ruta"]);

                if (row["COBRADOR_ID"] is DBNull) cliente.cobradorId = 0;
                else cliente.cobradorId = Convert.ToInt64(row["COBRADOR_ID"]);

                if (row["VENDEDOR_ID"] is DBNull) cliente.vendedorId = 0;
                else cliente.vendedorId = Convert.ToInt64(row["VENDEDOR_ID"]);

                if (row["CLIENTE_ID"] is DBNull) cliente.clienteId = 0;
                else cliente.clienteId = Convert.ToInt64(row["CLIENTE_ID"]);

                if (row["USUARIO_CREADOR"] is DBNull) cliente.usuarioCreador = string.Empty;
                else cliente.usuarioCreador = Convert.ToString(row["USUARIO_CREADOR"]);

                if (row["VENDEDOR"] is DBNull) cliente.nomVendedor = string.Empty;
                else cliente.nomVendedor = Convert.ToString(row["VENDEDOR"]);

                if (row["COBRADOR"] is DBNull) cliente.nomCobrador = string.Empty;
                else cliente.nomCobrador = Convert.ToString(row["COBRADOR"]);

                if (row["COND_PAGO_ID"] is DBNull) cliente.condPago = 0;
                else cliente.condPago = Convert.ToInt64(row["COND_PAGO_ID"]);

                lstClientes.Add(cliente);
            }

            return lstClientes;
        }

        public bool pruebaConn()
        {
            bool result = false;

            DataTable tbResultado = new DataTable();

            string sql = string.Format(
            @"SELECT 
                    ALMACEN_ID,
                    NOMBRE
                FROM
                    ALMACENES");

            fbCommand = new FbCommand(sql, fbConexion);
            fbAdapter = new FbDataAdapter(fbCommand);
            fbAdapter.Fill(tbResultado);

            result = true;

            return result;
        }

        public List<Vendedores> getVendedores()
        {
            List<Vendedores> resultado = new List<Vendedores>();
            DataTable dtResultado = new DataTable();

            string sConsulta = "select vendedor_id, nombre, es_predet FROM vendedores order by nombre asc";

            fbCommand = new FbCommand(sConsulta, fbConexion);
            fbAdapter = new FbDataAdapter(fbCommand);
            fbAdapter.Fill(dtResultado);

            foreach (DataRow row in dtResultado.Rows)
            {
                resultado.Add(new Vendedores 
                {
                    vendedorId = Convert.ToInt64(row["vendedor_id"]),
                    nombre = Convert.ToString(row["nombre"]),
                    esPred = Convert.ToString(row["es_predet"])
                });
            }

            return resultado;
        }

        public List<Cobradores> getCobradores()
        {
            List<Cobradores> resultado = new List<Cobradores>();
            DataTable dtResultado = new DataTable();

            string sConsulta = "select cobrador_id, nombre, es_predet FROM cobradores order by nombre asc";

            fbCommand = new FbCommand(sConsulta, fbConexion);
            fbAdapter = new FbDataAdapter(fbCommand);
            fbAdapter.Fill(dtResultado);

            foreach (DataRow row in dtResultado.Rows)
            {
                resultado.Add(new Cobradores
                {
                    cobradorId = Convert.ToInt64(row["cobrador_id"]),
                    nombre = Convert.ToString(row["nombre"]),
                    esPred = Convert.ToString(row["es_predet"])
                });
            }

            return resultado;
        }

        public List<CondPago> getCondPago()
        {
            List<CondPago> resultado = new List<CondPago>();
            DataTable dtResultado = new DataTable();

            string sConsulta = "select cond_pago_id, nombre, es_predet FROM condiciones_pago order by nombre asc";

            fbCommand = new FbCommand(sConsulta, fbConexion);
            fbAdapter = new FbDataAdapter(fbCommand);
            fbAdapter.Fill(dtResultado);

            foreach (DataRow row in dtResultado.Rows)
            {
                resultado.Add(new CondPago
                {
                    condPagoId = Convert.ToInt64(row["cond_pago_id"]),
                    nombre = Convert.ToString(row["nombre"]),
                    esPred = Convert.ToString(row["es_predet"])
                });
            }

            return resultado;
        }

        public void actClientes(List<Cliente> actMicro, long cpAnt, long cpNvo)
        {
            fbConexion.Open();
            FbTransaction trans = fbConexion.BeginTransaction();

            fbCommand = new FbCommand();
            fbCommand.Connection = fbConexion;
            fbCommand.Transaction = trans;
            try
            {
                string sConsulta = "update clientes set cond_pago_id = {0} where cliente_id = {1} and cond_pago_id = {2}";

                foreach (Cliente cl in actMicro)
                {
                    fbCommand.CommandText = string.Format(
                        sConsulta, cpNvo, cl.clienteId, cpAnt);

                    fbCommand.ExecuteNonQuery();
                }

                trans.Commit();
                fbConexion.Close();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                if (fbConexion.State != ConnectionState.Closed)
                    fbConexion.Close();

                throw ex;
            }
        }
    }
}
