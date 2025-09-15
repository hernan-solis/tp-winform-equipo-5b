using System;
using dominio;
using negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;

        public frmDetalleArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            articulo = seleccionado;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {

                if (articulo != null)
                {
                    txtCodigoDetalle.Text = articulo.Codigo;
                    txtNombreDetalle.Text = articulo.Nombre;
                    txtDescripcionDetalle.Text = articulo.Descripcion;
                    txtMarcaDetalle.Text = articulo.Marca.Descripcion;
                    txtCategoriaDetalle.Text = articulo.Categoria.Descripcion;
                    txtPrecioDetalle.Text = articulo.Precio.ToString();
                    cargarPbx(pbxArticuloDetalle, articulo.Imagenes, lblContadorPbxDetalle, lblTotalPbxDetalle);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarPbx(PictureBox pictureBox, List<Imagen> imagenes, Label contador, Label total)
        {
            contador.Text = "0";
            total.Text = "0";

            if (imagenes != null && imagenes.Count > 0)
            {
                contador.Text = "1";
                total.Text = imagenes.Count.ToString();
                try
                {
                    pictureBox.Load(imagenes[0].Url);

                }
                catch (Exception)
                {
                    pictureBox.Load("https://freesvg.org/img/Placeholder.png");

                }

            }
        }
    }
}
