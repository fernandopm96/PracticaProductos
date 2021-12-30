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
            this.lbCod = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(31, 76);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(46, 15);
            this.lbCod.TabIndex = 0;
            this.lbCod.Text = "Código";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(31, 116);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(51, 15);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(31, 156);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(40, 15);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "Precio";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(31, 196);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lbDescripcion.TabIndex = 3;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(31, 236);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(36, 15);
            this.lbStock.TabIndex = 4;
            this.lbStock.Text = "Stock";
            // 
            // tbCodigo
            // 
            this.tbCodigo.AcceptsTab = true;
            this.tbCodigo.Location = new System.Drawing.Point(147, 76);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(54, 23);
            this.tbCodigo.TabIndex = 5;
            // 
            // tbNombre
            // 
            this.tbNombre.AcceptsTab = true;
            this.tbNombre.Location = new System.Drawing.Point(147, 116);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(211, 23);
            this.tbNombre.TabIndex = 6;
            // 
            // tbPrecio
            // 
            this.tbPrecio.AcceptsTab = true;
            this.tbPrecio.Location = new System.Drawing.Point(147, 156);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(54, 23);
            this.tbPrecio.TabIndex = 7;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.AcceptsTab = true;
            this.tbDescripcion.Location = new System.Drawing.Point(147, 196);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(211, 23);
            this.tbDescripcion.TabIndex = 8;
            // 
            // tbStock
            // 
            this.tbStock.AcceptsTab = true;
            this.tbStock.Location = new System.Drawing.Point(147, 236);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(54, 23);
            this.tbStock.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(179, 326);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.Location = new System.Drawing.Point(30, 28);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(252, 17);
            this.lbInfo.TabIndex = 15;
            this.lbInfo.Text = "Introduce los datos del nuevo producto";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 361);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCod);
            this.Name = "FormAdd";
            this.Text = "Añadir producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCod;
        private Label lbNombre;
        private Label lbPrecio;
        private Label lbDescripcion;
        private Label lbStock;
        private TextBox tbCodigo;
        private TextBox tbNombre;
        private TextBox tbPrecio;
        private TextBox tbDescripcion;
        private TextBox tbStock;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lbInfo;
    }
}