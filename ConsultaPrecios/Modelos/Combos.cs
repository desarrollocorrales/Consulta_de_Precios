using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultaPrecios.Modelos
{
    public class Combos
    {
        public long precioEmpresaId { get; set; }
        public string nombre { get; set; }
    }

    public class Almacen
    {
        public long almacenId { get; set; }
        public string nombre { get; set; }
    }
}
