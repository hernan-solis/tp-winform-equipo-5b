namespace TPWinForm
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTotalPbxAlta = new System.Windows.Forms.Label();
            this.lblSeparadorPbxAlta = new System.Windows.Forms.Label();
            this.lblContadorPbxAlta = new System.Windows.Forms.Label();
            this.btnAnteriorAlta = new System.Windows.Forms.Button();
            this.btnSiguienteAlta = new System.Windows.Forms.Button();
            this.pbxArticuloAlta = new System.Windows.Forms.PictureBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.btnNuevaUrl = new System.Windows.Forms.Button();
            this.btnEliminarUrl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 40);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 80);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(19, 126);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(82, 77);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(92, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(92, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(82, 208);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(92, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(19, 171);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(19, 213);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(82, 165);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(92, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(82, 119);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(92, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(157, 556);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(67, 26);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 556);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 26);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 7);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(82, 7);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(87, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblTotalPbxAlta
            // 
            this.lblTotalPbxAlta.AutoSize = true;
            this.lblTotalPbxAlta.Location = new System.Drawing.Point(211, 320);
            this.lblTotalPbxAlta.Name = "lblTotalPbxAlta";
            this.lblTotalPbxAlta.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPbxAlta.TabIndex = 30;
            this.lblTotalPbxAlta.Text = "0";
            // 
            // lblSeparadorPbxAlta
            // 
            this.lblSeparadorPbxAlta.AutoSize = true;
            this.lblSeparadorPbxAlta.Location = new System.Drawing.Point(212, 296);
            this.lblSeparadorPbxAlta.Name = "lblSeparadorPbxAlta";
            this.lblSeparadorPbxAlta.Size = new System.Drawing.Size(10, 13);
            this.lblSeparadorPbxAlta.TabIndex = 29;
            this.lblSeparadorPbxAlta.Text = "-";
            // 
            // lblContadorPbxAlta
            // 
            this.lblContadorPbxAlta.AutoSize = true;
            this.lblContadorPbxAlta.Location = new System.Drawing.Point(211, 273);
            this.lblContadorPbxAlta.Name = "lblContadorPbxAlta";
            this.lblContadorPbxAlta.Size = new System.Drawing.Size(13, 13);
            this.lblContadorPbxAlta.TabIndex = 28;
            this.lblContadorPbxAlta.Text = "0";
            // 
            // btnAnteriorAlta
            // 
            this.btnAnteriorAlta.Location = new System.Drawing.Point(22, 401);
            this.btnAnteriorAlta.Name = "btnAnteriorAlta";
            this.btnAnteriorAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorAlta.TabIndex = 27;
            this.btnAnteriorAlta.Text = "<=";
            this.btnAnteriorAlta.UseVisualStyleBackColor = true;
            this.btnAnteriorAlta.Click += new System.EventHandler(this.btnAnteriorAlta_Click);
            // 
            // btnSiguienteAlta
            // 
            this.btnSiguienteAlta.Location = new System.Drawing.Point(131, 401);
            this.btnSiguienteAlta.Name = "btnSiguienteAlta";
            this.btnSiguienteAlta.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteAlta.TabIndex = 26;
            this.btnSiguienteAlta.Text = "=>";
            this.btnSiguienteAlta.UseVisualStyleBackColor = true;
            this.btnSiguienteAlta.Click += new System.EventHandler(this.btnSiguienteAlta_Click);
            // 
            // pbxArticuloAlta
            // 
            this.pbxArticuloAlta.Location = new System.Drawing.Point(22, 251);
            this.pbxArticuloAlta.Margin = new System.Windows.Forms.Padding(2);
            this.pbxArticuloAlta.Name = "pbxArticuloAlta";
            this.pbxArticuloAlta.Size = new System.Drawing.Size(184, 145);
            this.pbxArticuloAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticuloAlta.TabIndex = 25;
            this.pbxArticuloAlta.TabStop = false;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(24, 447);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 31;
            this.lblUrl.Text = "URL:";
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(62, 440);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(397, 20);
            this.tbxUrl.TabIndex = 32;
            this.tbxUrl.Leave += new System.EventHandler(this.tbxUrl_Leave);
            // 
            // btnNuevaUrl
            // 
            this.btnNuevaUrl.Location = new System.Drawing.Point(244, 310);
            this.btnNuevaUrl.Name = "btnNuevaUrl";
            this.btnNuevaUrl.Size = new System.Drawing.Size(115, 23);
            this.btnNuevaUrl.TabIndex = 33;
            this.btnNuevaUrl.Text = "Añadir Slot Url ";
            this.btnNuevaUrl.UseVisualStyleBackColor = true;
            this.btnNuevaUrl.Click += new System.EventHandler(this.btnNuevaUrl_Click);
            // 
            // btnEliminarUrl
            // 
            this.btnEliminarUrl.Location = new System.Drawing.Point(244, 348);
            this.btnEliminarUrl.Name = "btnEliminarUrl";
            this.btnEliminarUrl.Size = new System.Drawing.Size(115, 23);
            this.btnEliminarUrl.TabIndex = 34;
            this.btnEliminarUrl.Text = "Eliminar Slot Url ";
            this.btnEliminarUrl.UseVisualStyleBackColor = true;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 593);
            this.Controls.Add(this.btnEliminarUrl);
            this.Controls.Add(this.btnNuevaUrl);
            this.Controls.Add(this.tbxUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblTotalPbxAlta);
            this.Controls.Add(this.lblSeparadorPbxAlta);
            this.Controls.Add(this.lblContadorPbxAlta);
            this.Controls.Add(this.btnAnteriorAlta);
            this.Controls.Add(this.btnSiguienteAlta);
            this.Controls.Add(this.pbxArticuloAlta);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTotalPbxAlta;
        private System.Windows.Forms.Label lblSeparadorPbxAlta;
        private System.Windows.Forms.Label lblContadorPbxAlta;
        private System.Windows.Forms.Button btnAnteriorAlta;
        private System.Windows.Forms.Button btnSiguienteAlta;
        private System.Windows.Forms.PictureBox pbxArticuloAlta;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.Button btnNuevaUrl;
        private System.Windows.Forms.Button btnEliminarUrl;
    }
}