using negocio;
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
        public frmMarca()
        {
            InitializeComponent();
        }


        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {

        }

        private void dgbMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            //dgbMarca.DataSource = negocio.listar;
        }
    }
}
