using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class frmVentanaPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }
        private void btnMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmMarca))
                {
                    return;
                }

            }

            frmMarca ventana = new frmMarca();
            ventana.MdiParent = this;
            ventana.Show();

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

        }

        private void cargar()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarPbx(PictureBox pictureBox, Articulo articulo)
        {
            if (articulo != null && articulo.Imagenes != null && articulo.Imagenes.Count > 0)
            {
                try
                {
                    pictureBox.Load(articulo.Imagenes[0].Url);
                }
                catch (Exception)
                {
                    pictureBox.Load("https://freesvg.org/img/Placeholder.png");
                }

            }
        }


        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            cargarPbx(pbxArticulo, dgvArticulos.CurrentRow.DataBoundItem as Articulo);
        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                try
                {
                    lblUrl.Text = (dgvArticulos.CurrentRow.DataBoundItem as Articulo).Imagenes[0].Url;
                    cargarPbx(pbxArticulo, dgvArticulos.CurrentRow.DataBoundItem as Articulo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo altaArticulo = new frmAltaArticulo();
            altaArticulo.ShowDialog();
        }
    }
}