using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public Marca(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public Marca()
        {

        }
    }
}
