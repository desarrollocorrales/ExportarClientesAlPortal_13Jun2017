using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientesMicrosipPortal.clases
{
    public class Vendedores
    {
        public long vendedorId { get; set; }
        public string nombre { get; set; }
        public string esPred { get; set; }
    }

    public class Cobradores
    {
        public long cobradorId { get; set; }
        public string nombre { get; set; }
        public string esPred { get; set; }
    }

    public class CondPago
    {
        public long condPagoId { get; set; }
        public string nombre { get; set; }
        public string esPred { get; set; }
    }
}
