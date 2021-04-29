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
            //SqlConnection conexion = new SqlConnection();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ID, Codigo, Nombre, Descripcion, m.Nombre, c.Nombre , UrlImagen, Stock, Estado Precio from Articulos A, ELEMENTOS m, ELEMENTOS c Where A.IDMarca = m.ID and A.IDCategoria = c.ID ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.ID = (int)datos.Lector["ID"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
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
                datos.cerrarConexion();
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
                    + nuevo.UrlImagen + "', '" 
                    + nuevo.Marca.ID + ", "
                    + nuevo.Categoria.ID + ", '"
                    + nuevo.UrlImagen + "', "
                    + nuevo.Precio+ ", "
                    + nuevo.Stock + ", "
                    + nuevo.Estado + ")";

                datos.setearConsulta("insert into Articulos(" +
                    "Codigo," +
                    " Nombre," +
                    " Descripcion," +
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
                    "update Articulos" +
                    " set"+
                    "Codigo = '" + modificar.Codigo+"',"+
                    " Nombre = '" + modificar.Nombre + "'," +
                    " Descripcion = '" + modificar.Descripcion + "'," +
                    " IdMarca = '" + modificar.Marca.ID + "'," +
                    " IDCategoria = '" + modificar.Categoria.ID + "'," +
                    " UrlImagen = '" + modificar.UrlImagen + "'," +
                    " Precio = " + modificar.Precio + "," +
                    " Stock = " + modificar.Stock + "," +
                    " Estado = " + modificar.Estado+
                    "where ID = '"+modificar.ID+ "'"
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

        public void eliminar(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            { 
                datos.setearConsulta("select ID, Codigo, Descripcion, m.Nombre, c.Nombre , UrlImagen, Stock, Estado Precio from Articulos A, ELEMENTOS m, ELEMENTOS c Where A.IDMarca = m.ID and A.IDCategoria = c.ID ");
                datos.ejecutarLectura();

                Producto aux = new Producto();

                aux.Codigo = (string)datos.Lector["Codigo"];

                if(aux.Codigo != codigo)
                {
                    datos.cerrarConexion();
                   // return;???
                }

                if(aux.Codigo == codigo)
                {
                    aux.Estado = false;
                }

                datos.setearConsulta(
                    "update Articulos" +
                    " set" +
                    " Estado = " + aux.Estado +
                    "where ID = '" + aux.ID + "'"
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
