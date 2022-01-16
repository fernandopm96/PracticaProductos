namespace PracticaProductos
{
    partial class FormModify
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModify));
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.nupCodigo = new System.Windows.Forms.NumericUpDown();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.errorModify = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCodigo.Location = new System.Drawing.Point(44, 107);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(53, 18);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.Location = new System.Drawing.Point(44, 149);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(62, 18);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrecio.Location = new System.Drawing.Point(44, 192);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(50, 18);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "Precio";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescripcion.Location = new System.Drawing.Point(44, 235);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(86, 18);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStock.Location = new System.Drawing.Point(44, 277);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(45, 18);
            this.lbStock.TabIndex = 4;
            this.lbStock.Text = "Stock";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTipo.Location = new System.Drawing.Point(44, 320);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(35, 18);
            this.lbTipo.TabIndex = 5;
            this.lbTipo.Text = "Tipo";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMarca.Location = new System.Drawing.Point(44, 363);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(49, 18);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "Marca";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(25, 34);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(372, 19);
            this.lbInfo.TabIndex = 33;
            this.lbInfo.Text = "Modifica los datos de los productos seleccionados";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFoto.Location = new System.Drawing.Point(44, 405);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(37, 18);
            this.lbFoto.TabIndex = 41;
            this.lbFoto.Text = "Foto";
            // 
            // nupCodigo
            // 
            this.nupCodigo.Location = new System.Drawing.Point(160, 107);
            this.nupCodigo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nupCodigo.Name = "nupCodigo";
            this.nupCodigo.ReadOnly = true;
            this.nupCodigo.Size = new System.Drawing.Size(88, 23);
            this.nupCodigo.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(160, 149);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(223, 23);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombre_Validating);
            // 
            // nupPrecio
            // 
            this.nupPrecio.DecimalPlaces = 4;
            this.nupPrecio.Location = new System.Drawing.Point(160, 192);
            this.nupPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(88, 23);
            this.nupPrecio.TabIndex = 2;
            this.nupPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.nupPrecio_Validating);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(160, 235);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(223, 23);
            this.tbDescripcion.TabIndex = 3;
            // 
            // nupStock
            // 
            this.nupStock.Location = new System.Drawing.Point(160, 277);
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(88, 23);
            this.nupStock.TabIndex = 4;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Compacto",
            "Deportivo",
            "Berlina",
            "Suv",
            "Todoterreno",
            "Monovolumen",
            "Biplaza",
            "Furgoneta"});
            this.cbTipo.Location = new System.Drawing.Point(160, 320);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 24);
            this.cbTipo.TabIndex = 5;
            this.cbTipo.Validating += new System.ComponentModel.CancelEventHandler(this.cbTipo_Validating);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Renault",
            "Citroen",
            "Peugeot",
            "BMW",
            "Audi",
            "Mercedes",
            "Porsche",
            "Ferrari ",
            "Ford",
            "Volkswagen",
            "Kia",
            "Honda",
            "Dacia"});
            this.cbMarca.Location = new System.Drawing.Point(160, 363);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 24);
            this.cbMarca.TabIndex = 6;
            this.cbMarca.Validating += new System.ComponentModel.CancelEventHandler(this.cbMarca_Validating);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.Location = new System.Drawing.Point(293, 582);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(112, 33);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btModificar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btModificar.Location = new System.Drawing.Point(168, 582);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(112, 33);
            this.btModificar.TabIndex = 8;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // errorModify
            // 
            this.errorModify.ContainerControl = this;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(162, 405);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.pictureBox.Size = new System.Drawing.Size(184, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 52;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(415, 627);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.nupStock);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.nupPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.nupCodigo);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar producto";
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCodigo;
        private Label lbNombre;
        private Label lbPrecio;
        private Label lbDescripcion;
        private Label lbStock;
        private Label lbTipo;
        private Label lbMarca;
        private Label lbInfo;
        private Label lbFoto;
        private NumericUpDown nupCodigo;
        private TextBox tbNombre;
        private NumericUpDown nupPrecio;
        private TextBox tbDescripcion;
        private NumericUpDown nupStock;
        private ComboBox cbTipo;
        private ComboBox cbMarca;
        private Button btCancelar;
        private Button btModificar;
        private ErrorProvider errorModify;
        private PictureBox pictureBox;
    }
}