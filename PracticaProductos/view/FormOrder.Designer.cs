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
            this.SuspendLayout();
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAsc.Location = new System.Drawing.Point(25, 23);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(92, 20);
            this.rbAsc.TabIndex = 0;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "Ascendente";
            this.rbAsc.UseVisualStyleBackColor = true;
            // 
            // rbDes
            // 
            this.rbDes.AutoSize = true;
            this.rbDes.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDes.Location = new System.Drawing.Point(129, 23);
            this.rbDes.Name = "rbDes";
            this.rbDes.Size = new System.Drawing.Size(100, 20);
            this.rbDes.TabIndex = 1;
            this.rbDes.TabStop = true;
            this.rbDes.Text = "Descendente";
            this.rbDes.UseVisualStyleBackColor = true;
            // 
            // cbCampos
            // 
            this.cbCampos.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCampos.FormattingEnabled = true;
            this.cbCampos.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Precio",
            "Stock",
            "Tipo",
            "Marca"});
            this.cbCampos.Location = new System.Drawing.Point(25, 60);
            this.cbCampos.Name = "cbCampos";
            this.cbCampos.Size = new System.Drawing.Size(197, 24);
            this.cbCampos.TabIndex = 2;
            this.cbCampos.Text = "Elige un campo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(12, 144);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 32);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Ordenar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(136, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(248, 188);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbCampos);
            this.Controls.Add(this.rbDes);
            this.Controls.Add(this.rbAsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbAsc;
        private RadioButton rbDes;
        private ComboBox cbCampos;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}