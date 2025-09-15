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

                    aux.Imagenes = new ImagenNegocio().listarPorIdArticulo(aux.Id);

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

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdMarca,IdCategoria) values('"+ nuevo.Codigo+"','"+nuevo.Nombre+"','"+nuevo.Descripcion+"',"+nuevo.Precio+",@idMarca,@idCategoria)");
                datos.setearParametro("@idMarca",nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.ejecutarAccion();

                imagenNegocio.agregarImagenesDeArticulo(nuevo,ultimoId());

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

            ImagenNegocio imagenNegocio = new ImagenNegocio();

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

                imagenNegocio.eliminarImagenesDeArticulo(modificado);
                imagenNegocio.agregarImagenesDeArticulo(modificado);



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
        public void eliminar (int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametro("@id", id);
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

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>(); 
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id=A.IdCategoria and ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;                     
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio) 
                    {
                    case "Comienza con":
                        consulta += "Nombre like '" + filtro + "%' ";
                        break;
                    case "Termina con":
                        consulta += "Nombre like '%" + filtro + "'";
                        break;
                    default:
                        consulta += "Nombre like '%" + filtro + "%'";
                        break;
                    }

                }
                else
                {
                    switch (criterio)
                    {
                            case "Comienza con":
                                consulta += "A.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "A.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "A.Descripcion like '%" + filtro + "%'";
                                break;
                    }
                }

                datos.setearConsulta(consulta);
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

                    aux.Imagenes = new ImagenNegocio().listarPorIdArticulo(aux.Id);

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

        public int ultimoId()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select MAX(Id) as Id from ARTICULOS");
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    return (int)datos.Lector["Id"];
                }
                else
                {
                    return 0;
                }
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
