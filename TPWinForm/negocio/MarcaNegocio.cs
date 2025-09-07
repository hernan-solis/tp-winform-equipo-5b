using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
        List<Marca> lista = new List<Marca>();
        AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("Select Id,Descripcion From MARCAS");
                //datos.ejecutarLectura();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        
        }
    }

}
