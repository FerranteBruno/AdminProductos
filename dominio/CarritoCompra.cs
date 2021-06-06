using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class CarritoCompra
    {
        public List<itemCarrito> listado { get; set; }
        public double total { get; set; }
    }
    public class itemCarrito
    {
        public int id { get; set; }
        public Producto item { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
    }
}
