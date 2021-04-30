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
                datos.setearConsulta("select a.id ID, Codigo, Nombre, a.Descripcion Descripcion, m.Descripcion Marca, c.Descripcion Categoria , ImagenUrl, a.Stock Stock, a.Estado Estado ,Precio, M.ID as IDMarca, C.ID as IDCategoria from Articulos A, Marcas M, Categorias C where a.IDMarca = m.id and a.IDCategoria = c.ID");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.ID = (int)datos.Lector["ID"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca((string)datos.Lector["Marca"]);
                    aux.Marca.ID = ((int)datos.Lector["IDMarca"]);

                    aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.Categoria.ID = ((int)datos.Lector["IDCategoria"]);

                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = float.Parse(datos.Lector["Precio"].ToString());
                    aux.Stock = float.Parse(datos.Lector["Stock"].ToString());
                    aux.Estado = (bool)datos.Lector["Estado"];

                    if (aux.Estado != false)
                    {
                        lista.Add(aux);
                    }
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
                string valores = "values('"
                    + nuevo.Codigo + "', '"
                    + nuevo.Nombre + "', '"
                    + nuevo.Descripcion + "', "
                    + nuevo.Marca.ID + ", "
                    + nuevo.Categoria.ID + ", '"
                    + nuevo.UrlImagen + "', "
                    + nuevo.Precio + ", "
                    + nuevo.Stock + ", 1 )";

                datos.setearConsulta("insert into Articulos(Codigo, Nombre, Descripcion,IDMarca,IDCategoria,ImagenUrl,Precio,Stock,Estado)" + valores);


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
                

                //datos.setearConsulta("update Articulos set codigo = '" + modificar.Codigo + "', nombre = '" + modificar.Nombre + "', Descripcion = '" + modificar.Descripcion +
                //    "', IdMarca = " + modificar.Marca.ID + ", IdCategoria = " + modificar.Categoria.ID + ", ImagenUrl = '" + modificar.UrlImagen + "', Precio = " + modificar.Precio + ", Stock = " + modificar.Stock + ", Estado = 1 WhERE id = " + modificar.ID + ";");

                datos.setearConsulta("update Articulos set codigo = @codigo, nombre = @nombre, Descripcion = @descripcion, IdMarca = @IDMarca, IdCategoria = @IDCategoria, ImagenUrl = @imagenUrl, Precio = @precio, Stock = @stock, Estado = 1 WhERE Id = "+modificar.ID+"");

                datos.agregarParametro("@codigo", modificar.Codigo);
                datos.agregarParametro("@nombre", modificar.Nombre);
                datos.agregarParametro("@descripcion", modificar.Descripcion);
                datos.agregarParametro("@IDMarca", modificar.Marca.ID);
                datos.agregarParametro("@IDCategoria", modificar.Categoria.ID);
                datos.agregarParametro("@imagenUrl", modificar.UrlImagen);
                datos.agregarParametro("@precio", modificar.Precio);
                datos.agregarParametro("@stock", modificar.Stock);


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

        public void eliminar(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                Producto aux = new Producto();

                    aux.ID = ID;
                    aux.Estado = false;             

                datos.setearConsulta(
                    "update Articulos set Estado = 0 where ID = " + aux.ID + ""
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
