namespace PracticaProductos
{
    partial class FormAdd
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
            this.lbTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.errorProviderAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.paTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFoto = new System.Windows.Forms.Label();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.nupCodigo = new System.Windows.Forms.NumericUpDown();
            this.lbMarca = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.errorAdd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            this.paTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(44, 300);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(30, 15);
            this.lbTipo.TabIndex = 36;
            this.lbTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Television",
            "Lavadora",
            "Microondas",
            "Frigorifico",
            "Secadora",
            "Lavavajillas",
            "Horno",
            "AireAcondicionado",
            "Estufa"});
            this.cbTipo.Location = new System.Drawing.Point(160, 300);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 23);
            this.cbTipo.TabIndex = 34;
            this.cbTipo.Validating += new System.ComponentModel.CancelEventHandler(this.cbTipo_Validating);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(75, 28);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(265, 18);
            this.lbInfo.TabIndex = 33;
            this.lbInfo.Text = "Introduce los datos del nuevo producto";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(28, 259);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 15);
            this.lbResultado.TabIndex = 32;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(160, 220);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(223, 23);
            this.tbDescripcion.TabIndex = 30;
            this.tbDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescripcion_Validating);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(160, 140);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(223, 23);
            this.tbNombre.TabIndex = 28;
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombre_Validating);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btCancelar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.Location = new System.Drawing.Point(302, 19);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 33);
            this.btCancelar.TabIndex = 26;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btAceptar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAceptar.Location = new System.Drawing.Point(182, 19);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(99, 33);
            this.btAceptar.TabIndex = 25;
            this.btAceptar.Text = "Guardar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(44, 260);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(36, 15);
            this.lbStock.TabIndex = 24;
            this.lbStock.Text = "Stock";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(44, 220);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lbDescripcion.TabIndex = 23;
            this.lbDescripcion.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 22;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(44, 180);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(40, 15);
            this.lbPrecio.TabIndex = 21;
            this.lbPrecio.Text = "Precio";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(44, 140);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 15);
            this.lbNombre.TabIndex = 20;
            this.lbNombre.Text = "Nombre";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(44, 100);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(46, 15);
            this.lbCodigo.TabIndex = 19;
            this.lbCodigo.Text = "Código";
            // 
            // errorProviderAdd
            // 
            this.errorProviderAdd.ContainerControl = this;
            // 
            // nupPrecio
            // 
            this.nupPrecio.Location = new System.Drawing.Point(160, 180);
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(88, 23);
            this.nupPrecio.TabIndex = 38;
            this.nupPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.nupPrecio_Validating);
            // 
            // paTitulo
            // 
            this.paTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paTitulo.Controls.Add(this.lbInfo);
            this.paTitulo.Location = new System.Drawing.Point(1, 1);
            this.paTitulo.Name = "paTitulo";
            this.paTitulo.Size = new System.Drawing.Size(413, 74);
            this.paTitulo.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btAceptar);
            this.panel1.Location = new System.Drawing.Point(1, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 66);
            this.panel1.TabIndex = 40;
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(44, 380);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(31, 15);
            this.lbFoto.TabIndex = 41;
            this.lbFoto.Text = "Foto";
            // 
            // nupStock
            // 
            this.nupStock.Location = new System.Drawing.Point(160, 260);
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(88, 23);
            this.nupStock.TabIndex = 42;
            this.nupStock.Validating += new System.ComponentModel.CancelEventHandler(this.nupStock_Validating);
            // 
            // nupCodigo
            // 
            this.nupCodigo.Location = new System.Drawing.Point(160, 100);
            this.nupCodigo.Name = "nupCodigo";
            this.nupCodigo.Size = new System.Drawing.Size(88, 23);
            this.nupCodigo.TabIndex = 43;
            this.nupCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.nupCodigo_Validating);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(44, 340);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(40, 15);
            this.lbMarca.TabIndex = 44;
            this.lbMarca.Text = "Marca";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Balay",
            "LG",
            "Bosch",
            "Siemens",
            "Samsung",
            "Zanussi",
            "Fagor",
            "Mitsubishi"});
            this.cbMarca.Location = new System.Drawing.Point(160, 340);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 23);
            this.cbMarca.TabIndex = 45;
            this.cbMarca.Validating += new System.ComponentModel.CancelEventHandler(this.cbMarca_Validating);
            // 
            // errorAdd
            // 
            this.errorAdd.ContainerControl = this;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(415, 588);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.nupCodigo);
            this.Controls.Add(this.nupStock);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paTitulo);
            this.Controls.Add(this.nupPrecio);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir producto";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            this.paTitulo.ResumeLayout(false);
            this.paTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbTipo;
        private ComboBox cbTipo;
        private Label lbInfo;
        private Label lbResultado;
        private TextBox tbStock;
        private TextBox tbDescripcion;
        private TextBox tbPrecio;
        private TextBox tbNombre;
        private TextBox tbCodigo;
        private Button btCancelar;
        private Button btAceptar;
        private Label lbStock;
        private Label lbDescripcion;
        private Label label4;
        private Label lbPrecio;
        private Label lbNombre;
        private Label lbCodigo;
        private ErrorProvider errorProviderAdd;
        private NumericUpDown nupPrecio;
        private Label lbFoto;
        private Panel panel1;
        private Panel paTitulo;
        private ComboBox cbMarca;
        private Label lbMarca;
        private NumericUpDown nupCodigo;
        private NumericUpDown nupStock;
        private ErrorProvider errorAdd;
    }
}