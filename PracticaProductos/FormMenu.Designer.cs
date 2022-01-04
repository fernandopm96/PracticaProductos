namespace PracticaProductos
{
    partial class FormMenu
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAdd.Location = new System.Drawing.Point(181, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Añadir producto";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(23, 155);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(132, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modificar producto";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(23, 90);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(132, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Ver productos";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(181, 155);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Borrar producto";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(68, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(208, 19);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "¿Qué acción deseas realizar?";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 236);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Button btnModify;
        private Button btnList;
        private Button btnRemove;
        private Label lbTitle;
    }
}