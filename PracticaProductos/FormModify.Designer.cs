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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.paTitulo = new System.Windows.Forms.Panel();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.nupCodigo = new System.Windows.Forms.NumericUpDown();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.nupPrecio = new System.Windows.Forms.NumericUpDown();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.nupStock = new System.Windows.Forms.NumericUpDown();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.paTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(44, 100);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(46, 15);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(44, 140);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 15);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(44, 180);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(40, 15);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "Precio";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(44, 220);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(44, 260);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(36, 15);
            this.lbStock.TabIndex = 4;
            this.lbStock.Text = "Stock";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(44, 300);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(30, 15);
            this.lbTipo.TabIndex = 5;
            this.lbTipo.Text = "Tipo";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(44, 340);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(40, 15);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "Marca";
            // 
            // paTitulo
            // 
            this.paTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paTitulo.Controls.Add(this.lbInfo);
            this.paTitulo.Location = new System.Drawing.Point(1, 0);
            this.paTitulo.Name = "paTitulo";
            this.paTitulo.Size = new System.Drawing.Size(413, 74);
            this.paTitulo.TabIndex = 40;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(32, 25);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(341, 18);
            this.lbInfo.TabIndex = 33;
            this.lbInfo.Text = "Modifica los datos de los productos seleccionados";
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
            // nupCodigo
            // 
            this.nupCodigo.Location = new System.Drawing.Point(160, 100);
            this.nupCodigo.Name = "nupCodigo";
            this.nupCodigo.Size = new System.Drawing.Size(88, 23);
            this.nupCodigo.TabIndex = 44;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(160, 140);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(223, 23);
            this.tbNombre.TabIndex = 45;
            // 
            // nupPrecio
            // 
            this.nupPrecio.Location = new System.Drawing.Point(160, 180);
            this.nupPrecio.Name = "nupPrecio";
            this.nupPrecio.Size = new System.Drawing.Size(88, 23);
            this.nupPrecio.TabIndex = 46;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(160, 220);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(223, 23);
            this.tbDescripcion.TabIndex = 47;
            // 
            // nupStock
            // 
            this.nupStock.Location = new System.Drawing.Point(160, 260);
            this.nupStock.Name = "nupStock";
            this.nupStock.Size = new System.Drawing.Size(88, 23);
            this.nupStock.TabIndex = 48;
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
            this.cbTipo.TabIndex = 49;
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
            this.cbMarca.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btAceptar);
            this.panel1.Location = new System.Drawing.Point(1, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 60);
            this.panel1.TabIndex = 51;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btCancelar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.Location = new System.Drawing.Point(321, 16);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(81, 33);
            this.btCancelar.TabIndex = 26;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btAceptar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAceptar.Location = new System.Drawing.Point(13, 16);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(81, 33);
            this.btAceptar.TabIndex = 25;
            this.btAceptar.Text = "Modificar";
            this.btAceptar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(119, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "Anterior";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(223, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 33);
            this.button4.TabIndex = 30;
            this.button4.Text = "Siguiente";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(415, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.nupStock);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.nupPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.nupCodigo);
            this.Controls.Add(this.lbFoto);
            this.Controls.Add(this.paTitulo);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar producto";
            this.paTitulo.ResumeLayout(false);
            this.paTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupStock)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private Panel paTitulo;
        private Label lbInfo;
        private Label lbFoto;
        private NumericUpDown nupCodigo;
        private TextBox tbNombre;
        private NumericUpDown nupPrecio;
        private TextBox tbDescripcion;
        private NumericUpDown nupStock;
        private ComboBox cbTipo;
        private ComboBox cbMarca;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button btCancelar;
        private Button btAceptar;
    }
}