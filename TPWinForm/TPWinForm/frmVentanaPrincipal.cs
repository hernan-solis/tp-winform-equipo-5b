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
            //ventana.MdiParent = this;
            ventana.ShowDialog();

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
                dgvArticulos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarPbx(PictureBox pictureBox, Articulo articulo)
        {
            lblContadorPbx.Text = "0";
            lblTotalPbx.Text = "0";

            if (articulo != null && articulo.Imagenes != null && articulo.Imagenes.Count > 0)
            {
                lblContadorPbx.Text = "1";
                lblTotalPbx.Text = articulo.Imagenes.Count.ToString();
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

        private void cargarPbxSiguiente(PictureBox pictureBox, Articulo articulo)
        {
            if (articulo != null && articulo.Imagenes != null && articulo.Imagenes.Count > 0)
            {
                int indexActual = int.Parse(lblContadorPbx.Text)-1;
                int indexFinal= int.Parse(lblTotalPbx.Text) - 1;

                if (indexActual < indexFinal) {
                    
                    indexActual++;
                    lblContadorPbx.Text = (indexActual + 1).ToString();
                    try
                    {
                        pictureBox.Load(articulo.Imagenes[indexActual].Url);
                    }
                    catch (Exception)
                    {
                        pictureBox.Load("https://freesvg.org/img/Placeholder.png");
                    }

                }
            }
        }

        private void cargarPbxAnterior(PictureBox pictureBox, Articulo articulo)
        {
            if (articulo != null && articulo.Imagenes != null && articulo.Imagenes.Count > 0)
            {
                int indexActual = int.Parse(lblContadorPbx.Text) - 1;
                int indexFinal = int.Parse(lblTotalPbx.Text) - 1;

                if (indexActual > 0)
                {

                    indexActual--;
                    lblContadorPbx.Text = (indexActual + 1).ToString();
                    try
                    {
                        pictureBox.Load(articulo.Imagenes[indexActual].Url);
                    }
                    catch (Exception)
                    {
                        pictureBox.Load("https://freesvg.org/img/Placeholder.png");
                    }

                }
            }
        }


        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            
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
            cargar();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cargarPbxSiguiente(pbxArticulo, dgvArticulos.CurrentRow.DataBoundItem as Articulo);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            cargarPbxAnterior(pbxArticulo, dgvArticulos.CurrentRow.DataBoundItem as Articulo);
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro que desea ELIMINAR","Eliminado",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    articulo.eliminar(seleccionado.Id);
                    cargar();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}