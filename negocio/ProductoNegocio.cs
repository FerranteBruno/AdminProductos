using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;


namespace negocio
{
    public class ProductoNegocio
    {

        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection conexion = new SqlConnection();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Numero, Nombre, Descripcion, m.Nombre, c.Nombre , UrlImagen, Stock, Estado Precio from Articulos A, ELEMENTOS m, ELEMENTOS c Where A.IDMarca = m.ID and A.IDCategoria = c.ID ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = datos.Lector.GetString(150);

                    aux.Marca = new Marca((string)datos.Lector["m.Nombre"]);
                    aux.Categoria = new Categoria((string)datos.Lector["c.Nombre"]);

                    aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.Precio = (float)datos.Lector["Precio"];
                    aux.Stock = (float)datos.Lector["Stock"];
                    aux.Estado = (bool)datos.Lector["Estado"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }

        public void agregar(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values("
                    + nuevo.Codigo + ", '"
                    + nuevo.Nombre + "', '"
                    + nuevo.Descripcion + "', '" 
                    + nuevo.UrlImagen + "', " 
                    + nuevo.Marca.ID + "', '"
                    + nuevo.Categoria.ID + "', '"
                    + nuevo.UrlImagen + "', '"
                    + nuevo.Precio+ "', '"
                    + nuevo.Stock + "', '"
                    + nuevo.Estado + ")";

                datos.setearConsulta("insert into Productos as p (" +
                    "Codigo," +
                    " Nombre," +
                    " Descripcion," +
                    " IdTipo," +
                    " IDMarca," +
                    " IDCategoria," +
                    " UrlImagen," +
                    " Precio," +
                    " Stock," +
                    " Estado) " 
                    + valores);

                datos.ejectutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Producto modificar)
        {

        }

        public void eliminar(int id)
        {

        }

    }
}