using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
   public class MarcaNegocio
    {

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            //SqlConnection conexion = new SqlConnection();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ID, Nombre, Estado from Marcas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();

                    aux.ID = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

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

        public void agregar(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values("
                    + nuevo.Nombre + ")";

                datos.setearConsulta("insert into Marcas(" +
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

        public void modificar(Marca modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                /*string valores = "values("
                    + modificar.Codigo + ", '"
                    + modificar.Nombre + "', '"
                    + modificar.Descripcion + "', '"
                    + modificar.UrlImagen + "', "
                    + modificar.Marca.ID + "', '"
                    + modificar.Categoria.ID + "', '"
                    + modificar.UrlImagen + "', '"
                    + modificar.Precio + "', '"
                    + modificar.Stock + "', '"
                    + modificar.Estado + ")";*/

                datos.setearConsulta(
                    "update Marcas" +
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
                datos.setearConsulta("select ID, Nombre, Estado from Marcas");
                datos.ejecutarLectura();

                Marca aux = new Marca();

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
                    "update Marcas" +
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
