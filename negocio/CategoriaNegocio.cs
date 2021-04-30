using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            //SqlConnection conexion = new SqlConnection();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ID, Descripcion, Estado from Categorias");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.ID = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Descripcion"];

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
                datos.cerrarConexion();
            }

        }

        public void agregar(Categoria nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values("
                    + nuevo.Nombre + ","
                    + nuevo.Estado + ")";

                datos.setearConsulta("insert into Categorias(" +
                    " Nombre) "
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

        public void modificar(Categoria modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                /*string valores = "values("
                    + modificar.Codigo + ", '"
                    + modificar.Nombre + "', '"
                    + modificar.Descripcion + "', '"
                    + modificar.UrlImagen + "', "
                    + modificar.Categoria.ID + "', '"
                    + modificar.Categoria.ID + "', '"
                    + modificar.UrlImagen + "', '"
                    + modificar.Precio + "', '"
                    + modificar.Stock + "', '"
                    + modificar.Estado + ")";*/

                datos.setearConsulta(
                    "update Categorias" +
                    " set" +
                    " Nombre = '" + modificar.Nombre + "'," +
                    "where ID = " + modificar.ID + ""
                    );

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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID, Nombre, Estado from Categorias");
                datos.ejecutarLectura();

                Categoria aux = new Categoria();

                aux.ID = (int)datos.Lector["ID"];

                if (aux.ID != id)
                {
                    datos.cerrarConexion();
                    // return;???
                }

                if (aux.ID == id)
                {
                    aux.Estado = false;
                }

                datos.setearConsulta(
                    "update Categorias" +
                    " set" +
                    " Estado = " + aux.Estado +
                    "where ID = " + aux.ID
                    );

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
    }

}
