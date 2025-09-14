using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        private List<Imagen> imagenesAlta = new List<Imagen>();
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            articulo = seleccionado;
            Text = "Modificar Articulo";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();

            ImagenNegocio negocioImagenAlta = new ImagenNegocio();

            try
            {
                if (articulo == null) {
                    articulo = new Articulo();
                }
                    

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Precio = float.Parse(txtPrecio.Text);
                articulo.Imagenes = imagenesAlta;

                // AGREGAR LAS URL A LA LISTA DE IMAGENES DEL ARTICULO

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);

    
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    

                    MessageBox.Show("Agregado exitosamente");
                }
                  


                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text= articulo.Codigo;
                    txtNombre.Text= articulo.Nombre;
                    txtDescripcion.Text= articulo.Descripcion;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cargarPbx(pbxArticuloAlta, articulo.Imagenes, lblContadorPbxAlta, lblTotalPbxAlta);
                    tbxUrl.Text = articulo.Imagenes[0].Url;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        // HELPERS DE PBX

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

        private void cargarPbxModificado(PictureBox pictureBox, List<Imagen> imagenes, Label contador, Label total)
        {
            int indice = int.Parse(lblContadorPbxAlta.Text)+1;

            if (imagenes != null && imagenes.Count > 0)
            {
                total.Text = imagenes.Count.ToString();
                try
                {
                    pictureBox.Load(imagenes[indice].Url);

                }
                catch (Exception)
                {
                    pictureBox.Load("https://freesvg.org/img/Placeholder.png");

                }

            }
        }


        private void cargarPbxNuevoSlot(PictureBox pictureBox, List<Imagen> imagenes, Label contador, Label total)
        {

            if (imagenes != null && imagenes.Count > 0)
            {
                total.Text = imagenes.Count.ToString();
                try
                {
                    pictureBox.Load(imagenes[imagenes.Count + 1].Url);
                }
                catch (Exception)
                {
                    pictureBox.Load("https://freesvg.org/img/Placeholder.png");

                }

            }
        }

        private void cargarPbxSiguiente(PictureBox pictureBox, Articulo articulo, Label contador, Label total)
        {
            if (articulo != null && articulo.Imagenes != null && articulo.Imagenes.Count > 0)
            {
                int indexActual = int.Parse(contador.Text) - 1;
                int indexFinal = int.Parse(total.Text) - 1;

                if (indexActual < indexFinal)
                {

                    indexActual++;
                    contador.Text = (indexActual + 1).ToString();
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

        private void cargarPbxAnterior(PictureBox pictureBox, Articulo articulo, Label contador, Label total)
        {
            if (articulo != null && articulo.Imagenes != null && articulo.Imagenes.Count > 0)
            {
                int indexActual = int.Parse(contador.Text) - 1;
                int indexFinal = int.Parse(total.Text) - 1;

                if (indexActual > 0)
                {

                    indexActual--;
                    contador.Text = (indexActual + 1).ToString();
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

        private void cargarPbxSiguiente(PictureBox pictureBox, List<Imagen> imagenes, Label contador, Label total)
        {
            if (imagenes != null && imagenes.Count > 0)
            {
                int indexActual = int.Parse(contador.Text) - 1;
                int indexFinal = int.Parse(total.Text) - 1;

                if (indexActual < indexFinal)
                {

                    indexActual++;
                    contador.Text = (indexActual + 1).ToString();
                    try
                    {
                        pictureBox.Load(imagenes[indexActual].Url);
                    }
                    catch (Exception)
                    {
                        pictureBox.Load("https://freesvg.org/img/Placeholder.png");
                    }

                }
            }
        }

        private void cargarPbxAnterior(PictureBox pictureBox, List<Imagen> imagenes, Label contador, Label total)
        {
            if (imagenes != null && imagenes.Count > 0)
            {
                int indexActual = int.Parse(contador.Text) - 1;
                int indexFinal = int.Parse(total.Text) - 1;

                if (indexActual > 0)
                {

                    indexActual--;
                    contador.Text = (indexActual + 1).ToString();
                    try
                    {
                        pictureBox.Load(imagenes[indexActual].Url);
                    }
                    catch (Exception)
                    {
                        pictureBox.Load("https://freesvg.org/img/Placeholder.png");
                    }

                }
            }
        }

        private void btnAnteriorAlta_Click(object sender, EventArgs e)
        {
            if (articulo != null) {
                cargarPbxAnterior(pbxArticuloAlta, articulo.Imagenes, lblContadorPbxAlta, lblTotalPbxAlta);
                tbxUrl.Text = articulo.Imagenes[int.Parse(lblContadorPbxAlta.Text) - 1].Url;
            }
                
        }

        private void btnSiguienteAlta_Click(object sender, EventArgs e)
        {
            if (articulo != null) {
                cargarPbxSiguiente(pbxArticuloAlta, articulo.Imagenes, lblContadorPbxAlta, lblTotalPbxAlta);
                tbxUrl.Text = articulo.Imagenes[int.Parse(lblContadorPbxAlta.Text) - 1].Url;
            }
                
        }

        private void tbxUrl_Leave(object sender, EventArgs e)
        {
            if (articulo != null) {
                if ((int.Parse(lblContadorPbxAlta.Text) - 1)>0) {
                    articulo.Imagenes[int.Parse(lblContadorPbxAlta.Text) - 1].Url = tbxUrl.Text;
                     cargarPbxModificado(pbxArticuloAlta, articulo.Imagenes, lblContadorPbxAlta, lblTotalPbxAlta);
                }
                
            }
        }

        private void btnNuevaUrl_Click(object sender, EventArgs e)
        {
            if (articulo != null)
            {
                articulo.Imagenes.Add(new Imagen());
                articulo.Imagenes[articulo.Imagenes.Count - 1].Url = "";

                tbxUrl.Text = articulo.Imagenes.Last().Url;

                lblTotalPbxAlta.Text = articulo.Imagenes.Count.ToString();
                lblContadorPbxAlta.Text = articulo.Imagenes.Count.ToString();

                cargarPbxNuevoSlot(pbxArticuloAlta, articulo.Imagenes, lblContadorPbxAlta, lblTotalPbxAlta);
            }
            else {
                imagenesAlta.Add(new Imagen());
                imagenesAlta[imagenesAlta.Count - 1].Url = "";

                tbxUrl.Text = imagenesAlta.Last().Url;

                lblTotalPbxAlta.Text = imagenesAlta.Count.ToString();
                lblContadorPbxAlta.Text = imagenesAlta.Count.ToString();

                cargarPbxNuevoSlot(pbxArticuloAlta, imagenesAlta, lblContadorPbxAlta, lblTotalPbxAlta);
            }
            



        }

        private void tbxUrl_TextChanged(object sender, EventArgs e)
        {
            if (articulo != null)
            {
                if ((int.Parse(lblContadorPbxAlta.Text) - 1) > 0)
                {
                    articulo.Imagenes[int.Parse(lblContadorPbxAlta.Text) - 1].Url = tbxUrl.Text;
                    cargarPbxModificado(pbxArticuloAlta, articulo.Imagenes, lblContadorPbxAlta, lblTotalPbxAlta);
                }

            }
        }
    }
    }

