using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public Categoria()
        {

        }

        public Categoria(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public Categoria(string Nombre,int id,bool est)
        {
            ID = id;
            this.Nombre = Nombre;
            Estado = est;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
