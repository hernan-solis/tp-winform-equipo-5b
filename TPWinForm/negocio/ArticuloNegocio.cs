using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id=A.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (float)Convert.ToDecimal(datos.Lector["Precio"]);
                    
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
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdMarca,IdCategoria) values('"+ nuevo.Codigo+"','"+nuevo.Nombre+"','"+nuevo.Descripcion+"',"+nuevo.Precio+",@idMarca,@idCategoria)");
                datos.setearParametro("@idMarca",nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.ejecutarAccion();

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

        public void modificar (Articulo modificado)
        {
            AccesoDatos datos = new AccesoDatos ();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo= @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @precio WHERE Id = @id;");
                datos.setearParametro("@codigo", modificado.Codigo);
                datos.setearParametro("@nombre", modificado.Nombre);
                datos.setearParametro("@desc", modificado.Descripcion);
                datos.setearParametro("@IdMarca", modificado.Marca.Id);
                datos.setearParametro("@IdCategoria", modificado.Categoria.Id);
                datos.setearParametro("@precio", modificado.Precio);
                datos.setearParametro("@id", modificado.Id);

                datos.ejecutarAccion();
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
