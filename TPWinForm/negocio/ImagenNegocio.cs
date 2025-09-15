using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ImagenNegocio
    {
        // constructor vacio
        public ImagenNegocio()
        {
        }

        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, IdArticulo, ImagenUrl from IMAGENES");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.Url = (string)datos.Lector["ImagenUrl"];
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

        public List<Imagen> listarPorIdArticulo(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, IdArticulo, ImagenUrl from IMAGENES where IdArticulo = "+idArticulo);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.Url = (string)datos.Lector["ImagenUrl"];
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

        public void agregar(Imagen imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into IMAGENES (IdArticulo, ImagenUrl) values (" + imagen.IdArticulo + ", '"+imagen.Url+"')");
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

        public void agregarImagenesDeArticulo (Articulo articulo)
        {

            if (articulo.Imagenes.Count == 0)
                return;


            foreach (Imagen imagen in articulo.Imagenes)
            {
                try
                {
                    AccesoDatos datos = new AccesoDatos();
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @Url)");
                    datos.setearParametro("@IdArticulo", articulo.Id);
                    datos.setearParametro("@Url", imagen.Url);
                    datos.ejecutarAccion();
                    datos.cerrarConexion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }


        }

        public void agregarImagenesDeArticulo(Articulo articulo, int id)
        {
            if (articulo.Imagenes.Count == 0)
                return;


                foreach (Imagen imagen in articulo.Imagenes)
                {
                    try {
                        AccesoDatos datos = new AccesoDatos();
                        datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @Url)");
                        datos.setearParametro("@IdArticulo", id);
                        datos.setearParametro("@Url", imagen.Url);
                        datos.ejecutarAccion();
                        datos.cerrarConexion();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    
                }
         
        }


        public void editar(Imagen imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update IMAGENES set IdArticulo = " + imagen.IdArticulo + ", ImagenUrl = '"+imagen.Url+"' where Id = " + imagen.Id + " ;");
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


        public void eliminar(Imagen imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from IMAGENES where Id = " + imagen.Id + " ;");
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

        public void eliminarImagenesDeArticulo(Articulo articulo) {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", articulo.Id);
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
