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
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {

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

    
    }
}
