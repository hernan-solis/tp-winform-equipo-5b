using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public AccesoDatos() //constructor 
        {
            conexion = new SqlConnection(""); //falta enviar la ruta por parametro
            comando = new SqlCommand();
        }

    }
}
