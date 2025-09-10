using negocio;
using dominio;
using System;
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
    public partial class frmMarca : Form
    {
        private List<Marca> listaMarca;
        public frmMarca()
        {
            InitializeComponent();
        }


        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarca alta = new frmAltaMarca();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionada;
            seleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            frmAltaMarca modificar = new frmAltaMarca(seleccionada);
            modificar.ShowDialog();
            cargar(); 
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {

        }

        private void dgbMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarca = negocio.listar();
                dgvMarca.DataSource = listaMarca;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
