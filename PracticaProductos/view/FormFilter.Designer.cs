namespace PracticaProductos
{
    partial class FormFilter
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
            this.cbCodigo = new System.Windows.Forms.CheckBox();
            this.cbNombre = new System.Windows.Forms.CheckBox();
            this.cbPrecio = new System.Windows.Forms.CheckBox();
            this.cbDescripcion = new System.Windows.Forms.CheckBox();
            this.cbStock = new System.Windows.Forms.CheckBox();
            this.cbTipo = new System.Windows.Forms.CheckBox();
            this.cbMarca = new System.Windows.Forms.CheckBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.nupCodigo = new System.Windows.Forms.NumericUpDown();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.comBoxTipo = new System.Windows.Forms.ComboBox();
            this.comBoxMarca = new System.Windows.Forms.ComboBox();
            this.lbInfo2 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.errorFilter = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCodigo
            // 
            this.cbCodigo.AutoSize = true;
            this.cbCodigo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCodigo.Location = new System.Drawing.Point(38, 96);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(72, 22);
            this.cbCodigo.TabIndex = 0;
            this.cbCodigo.Text = "Código";
            this.cbCodigo.UseVisualStyleBackColor = true;
            this.cbCodigo.Click += new System.EventHandler(this.cbCodigo_Changed);
            // 
            // cbNombre
            // 
            this.cbNombre.AutoSize = true;
            this.cbNombre.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNombre.Location = new System.Drawing.Point(38, 136);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(81, 22);
            this.cbNombre.TabIndex = 1;
            this.cbNombre.Text = "Nombre";
            this.cbNombre.UseVisualStyleBackColor = true;
            this.cbNombre.Click += new System.EventHandler(this.cbNombre_Changed);
            // 
            // cbPrecio
            // 
            this.cbPrecio.AutoSize = true;
            this.cbPrecio.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPrecio.Location = new System.Drawing.Point(38, 176);
            this.cbPrecio.Name = "cbPrecio";
            this.cbPrecio.Size = new System.Drawing.Size(69, 22);
            this.cbPrecio.TabIndex = 2;
            this.cbPrecio.Text = "Precio";
            this.cbPrecio.UseVisualStyleBackColor = true;
            this.cbPrecio.Click += new System.EventHandler(this.cbPrecio_Changed);
            // 
            // cbDescripcion
            // 
            this.cbDescripcion.AutoSize = true;
            this.cbDescripcion.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDescripcion.Location = new System.Drawing.Point(38, 220);
            this.cbDescripcion.Name = "cbDescripcion";
            this.cbDescripcion.Size = new System.Drawing.Size(105, 22);
            this.cbDescripcion.TabIndex = 3;
            this.cbDescripcion.Text = "Descripción";
            this.cbDescripcion.UseVisualStyleBackColor = true;
            this.cbDescripcion.Click += new System.EventHandler(this.cbDescripcion_Changed);
            // 
            // cbStock
            // 
            this.cbStock.AutoSize = true;
            this.cbStock.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStock.Location = new System.Drawing.Point(38, 260);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(64, 22);
            this.cbStock.TabIndex = 4;
            this.cbStock.Text = "Stock";
            this.cbStock.UseVisualStyleBackColor = true;
            this.cbStock.Click += new System.EventHandler(this.cbStock_Changed);
            // 
            // cbTipo
            // 
            this.cbTipo.AutoSize = true;
            this.cbTipo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.Location = new System.Drawing.Point(38, 300);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(54, 22);
            this.cbTipo.TabIndex = 5;
            this.cbTipo.Text = "Tipo";
            this.cbTipo.UseVisualStyleBackColor = true;
            this.cbTipo.Click += new System.EventHandler(this.cbTipo_Changed);
            // 
            // cbMarca
            // 
            this.cbMarca.AutoSize = true;
            this.cbMarca.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMarca.Location = new System.Drawing.Point(38, 340);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(68, 22);
            this.cbMarca.TabIndex = 6;
            this.cbMarca.Text = "Marca";
            this.cbMarca.UseVisualStyleBackColor = true;
            this.cbMarca.Click += new System.EventHandler(this.cbMarca_Changed);
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(194, 139);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(191, 23);
            this.tbNombre.TabIndex = 8;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Enabled = false;
            this.tbDescripcion.Location = new System.Drawing.Point(194, 223);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(191, 23);
            this.tbDescripcion.TabIndex = 10;
            // 
            // nupCodigo
            // 
            this.nupCodigo.Enabled = false;
            this.nupCodigo.Location = new System.Drawing.Point(194, 95);
            this.nupCodigo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nupCodigo.Name = "nupCodigo";
            this.nupCodigo.Size = new System.Drawing.Size(97, 23);
            this.nupCodigo.TabIndex = 7;
            // 
            // nupPrecio
            // 
            this.nupPrecio.DecimalPlaces = 4;
            this.nupPrecio.Enabled = false;
            this.nupPrecio.Location = new System.Drawing.Point(194, 179);
            this.nupPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(97, 23);
            this.nupPrecio.TabIndex = 9;
            // 
            // nupStock
            // 
            this.nupStock.Enabled = false;
            this.nupStock.Location = new System.Drawing.Point(194, 263);
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(97, 23);
            this.nupStock.TabIndex = 11;
            // 
            // comBoxTipo
            // 
            this.comBoxTipo.Enabled = false;
            this.comBoxTipo.FormattingEnabled = true;
            this.comBoxTipo.Items.AddRange(new object[] {
            "Compacto",
            "Deportivo",
            "Berlina",
            "Suv",
            "Todoterreno",
            "Monovolumen",
            "Biplaza",
            "Furgoneta"});
            this.comBoxTipo.Location = new System.Drawing.Point(194, 303);
            this.comBoxTipo.Name = "comBoxTipo";
            this.comBoxTipo.Size = new System.Drawing.Size(136, 23);
            this.comBoxTipo.TabIndex = 12;
            // 
            // comBoxMarca
            // 
            this.comBoxMarca.Enabled = false;
            this.comBoxMarca.FormattingEnabled = true;
            this.comBoxMarca.Items.AddRange(new object[] {
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
            this.comBoxMarca.Location = new System.Drawing.Point(194, 343);
            this.comBoxMarca.Name = "comBoxMarca";
            this.comBoxMarca.Size = new System.Drawing.Size(136, 23);
            this.comBoxMarca.TabIndex = 13;
            // 
            // lbInfo2
            // 
            this.lbInfo2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo2.Location = new System.Drawing.Point(38, 49);
            this.lbInfo2.Name = "lbInfo2";
            this.lbInfo2.Size = new System.Drawing.Size(292, 16);
            this.lbInfo2.TabIndex = 34;
            this.lbInfo2.Text = "Una vez seleccionados, introduce los valores.";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(38, 26);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(335, 18);
            this.lbInfo.TabIndex = 33;
            this.lbInfo.Text = "Selecciona los campos por los que quieres filtrar.";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.Location = new System.Drawing.Point(276, 408);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(112, 33);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFiltrar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btFiltrar.Location = new System.Drawing.Point(152, 408);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(112, 33);
            this.btFiltrar.TabIndex = 14;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = false;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // errorFilter
            // 
            this.errorFilter.ContainerControl = this;
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(402, 453);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbInfo2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.comBoxMarca);
            this.Controls.Add(this.comBoxTipo);
            this.Controls.Add(this.nupStock);
            this.Controls.Add(this.nupPrecio);
            this.Controls.Add(this.nupCodigo);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbStock);
            this.Controls.Add(this.cbDescripcion);
            this.Controls.Add(this.cbPrecio);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.cbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar productos";
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbCodigo;
        private CheckBox cbNombre;
        private CheckBox cbPrecio;
        private CheckBox cbDescripcion;
        private CheckBox cbStock;
        private CheckBox cbTipo;
        private CheckBox cbMarca;
        private TextBox tbNombre;
        private TextBox tbDescripcion;
        private NumericUpDown nupCodigo;
        private NumericUpDown nupPrecio;
        private NumericUpDown nupStock;
        private ComboBox comBoxTipo;
        private ComboBox comBoxMarca;
        private Label lbInfo;
        private Label lbInfo2;
        private Panel paBotones;
        private Button btFiltrar;
        private Button btCancelar;
        private ErrorProvider errorFilter;
    }
}