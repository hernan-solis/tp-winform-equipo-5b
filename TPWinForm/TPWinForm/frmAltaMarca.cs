using dominio;
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
    public partial class frmAltaMarca : Form
    {
        private Marca marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if(marca==null)
                    marca=new Marca();
                marca.Descripcion = txtDescripcion.Text;

                if(marca.Id!=0)
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregada exitosamente");
                }
                else
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Modificada exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            //precargar en modificar
            if(marca != null) {
                txtDescripcion.Text = marca.Descripcion;
            }
        }
    }
}
