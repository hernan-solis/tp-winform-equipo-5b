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
                dgvArticulos.Columns["IdMarca"].Visible= false;
                dgvArticulos.Columns["IdCategoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
