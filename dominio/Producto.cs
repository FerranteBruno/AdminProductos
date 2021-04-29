using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Producto
    {
        public int ID { get; set; }

        public int codigo { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public float stock { get; set; }

        public Marca marca { get; set; }

        public Categoria categoria { get; set; }

        public string urlImagen { get; set; }

        public float precio { get; set; }

        public bool estado { get; set; }


    }
}
