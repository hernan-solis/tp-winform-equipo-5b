using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dominio
{
    public class Articulo
    {
        public Articulo() {
            //Inicializo la lista de imagenes para evitar errores de referencia nula
            Imagenes = new List<Imagen>();
        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public float Precio { get; set; }
        public List<Imagen> Imagenes { get; set; }
    }
}
