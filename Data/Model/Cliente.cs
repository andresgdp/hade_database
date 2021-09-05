using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hade_database.Data.Model
{
    public class Cliente
    {
        public int dniCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public string correoCliente { get; set; }
        public string direccionCliente { get; set; }

    }
}
