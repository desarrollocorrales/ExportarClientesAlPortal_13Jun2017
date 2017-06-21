using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientesMicrosipPortal.clases
{
    public class Cliente
    {
        public bool cambiaCP { get; set; }

        public string ClaveCliente { get; set; }
        public string Nombre { get; set; }
        public int RutaID { get; set; }
        public string Ruta { get; set; }

        public string nomCobrador { get; set; }
        public long cobradorId { get; set; }

        public string nomVendedor { get; set; }
        public long vendedorId { get; set; }

        public string usuarioCreador { get; set; }
        public long clienteId { get; set; }

        public long condPago { get; set; }
    }
}
