using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultaPrecios.Modelos
{
    public class Precios
    {
        public string articulo { get; set; }
        public decimal precioMay { get; set; }
        public decimal precioLista { get; set; }
        public string cveArticulo { get; set; }
        public decimal existencia { get; set; }
    }
}
