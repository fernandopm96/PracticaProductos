namespace PracticaProductos
{
    partial class FormOrder
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
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.rbDes = new System.Windows.Forms.RadioButton();
            this.cbCampos = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Location = new System.Drawing.Point(25, 23);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(87, 19);
            this.rbAsc.TabIndex = 0;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "Ascendente";
            this.rbAsc.UseVisualStyleBackColor = true;
            // 
            // rbDes
            // 
            this.rbDes.AutoSize = true;
            this.rbDes.Location = new System.Drawing.Point(129, 23);
            this.rbDes.Name = "rbDes";
            this.rbDes.Size = new System.Drawing.Size(93, 19);
            this.rbDes.TabIndex = 1;
            this.rbDes.TabStop = true;
            this.rbDes.Text = "Descendente";
            this.rbDes.UseVisualStyleBackColor = true;
            // 
            // cbCampos
            // 
            this.cbCampos.FormattingEnabled = true;
            this.cbCampos.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Precio",
            "Stock",
            "Tipo",
            "Marca"});
            this.cbCampos.Location = new System.Drawing.Point(25, 64);
            this.cbCampos.Name = "cbCampos";
            this.cbCampos.Size = new System.Drawing.Size(197, 23);
            this.cbCampos.TabIndex = 2;
            this.cbCampos.Text = "Elige un campo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(14, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 32);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(131, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(-2, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 58);
            this.panel1.TabIndex = 5;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(248, 188);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbCampos);
            this.Controls.Add(this.rbDes);
            this.Controls.Add(this.rbAsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenar";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbAsc;
        private RadioButton rbDes;
        private ComboBox cbCampos;
        private Button btnAceptar;
        private Button btnCancelar;
        private Panel panel1;
    }
}