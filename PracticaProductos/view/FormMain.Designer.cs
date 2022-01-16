namespace PracticaProductos
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.menuToolArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconExport = new System.Windows.Forms.PictureBox();
            this.iconImport = new System.Windows.Forms.PictureBox();
            this.iconFilter = new System.Windows.Forms.PictureBox();
            this.iconOrder = new System.Windows.Forms.PictureBox();
            this.iconAdd = new System.Windows.Forms.PictureBox();
            this.iconRemove = new System.Windows.Forms.PictureBox();
            this.iconModify = new System.Windows.Forms.PictureBox();
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.msgAdd = new System.Windows.Forms.ToolTip(this.components);
            this.msgRemove = new System.Windows.Forms.ToolTip(this.components);
            this.msgModify = new System.Windows.Forms.ToolTip(this.components);
            this.msgOrdenar = new System.Windows.Forms.ToolTip(this.components);
            this.msgFiltrar = new System.Windows.Forms.ToolTip(this.components);
            this.msgImport = new System.Windows.Forms.ToolTip(this.components);
            this.msgExportar = new System.Windows.Forms.ToolTip(this.components);
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.menuSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconModify)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Descripcion,
            this.Stock,
            this.Tipo,
            this.Marca,
            this.Imagen,
            this.checkBox});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.Location = new System.Drawing.Point(0, 27);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 100;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1152, 693);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.check_column);
            this.dgvProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_image);
            // 
            // menuSuperior
            // 
            this.menuSuperior.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuSuperior.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolArchivo,
            this.productosMenuTool,
            this.accionesToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(1152, 24);
            this.menuSuperior.TabIndex = 4;
            this.menuSuperior.Text = "menuStrip1";
            // 
            // menuToolArchivo
            // 
            this.menuToolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.importarToolStripMenuItem});
            this.menuToolArchivo.Name = "menuToolArchivo";
            this.menuToolArchivo.Size = new System.Drawing.Size(63, 20);
            this.menuToolArchivo.Text = "Archivo";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // productosMenuTool
            // 
            this.productosMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.productosMenuTool.Name = "productosMenuTool";
            this.productosMenuTool.Size = new System.Drawing.Size(78, 20);
            this.productosMenuTool.Text = "Productos";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.añadirToolStripMenuItem.Text = "Añadir ";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarToolStripMenuItem,
            this.filtrarToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            this.ordenarToolStripMenuItem.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.filtrarToolStripMenuItem.Text = "Filtrar";
            this.filtrarToolStripMenuItem.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.iconExport);
            this.panel1.Controls.Add(this.iconImport);
            this.panel1.Controls.Add(this.iconFilter);
            this.panel1.Controls.Add(this.iconOrder);
            this.panel1.Controls.Add(this.iconAdd);
            this.panel1.Controls.Add(this.iconRemove);
            this.panel1.Controls.Add(this.iconModify);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 722);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 60);
            this.panel1.TabIndex = 9;
            // 
            // iconExport
            // 
            this.iconExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExport.Image = global::PracticaProductos.Properties.Resources.exportar;
            this.iconExport.Location = new System.Drawing.Point(1110, 15);
            this.iconExport.MaximumSize = new System.Drawing.Size(25, 25);
            this.iconExport.MinimumSize = new System.Drawing.Size(25, 25);
            this.iconExport.Name = "iconExport";
            this.iconExport.Size = new System.Drawing.Size(25, 25);
            this.iconExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconExport.TabIndex = 8;
            this.iconExport.TabStop = false;
            this.msgExportar.SetToolTip(this.iconExport, "Exportar");
            this.iconExport.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // iconImport
            // 
            this.iconImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconImport.Image = global::PracticaProductos.Properties.Resources.importar;
            this.iconImport.Location = new System.Drawing.Point(1055, 15);
            this.iconImport.MaximumSize = new System.Drawing.Size(25, 25);
            this.iconImport.MinimumSize = new System.Drawing.Size(25, 25);
            this.iconImport.Name = "iconImport";
            this.iconImport.Size = new System.Drawing.Size(25, 25);
            this.iconImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconImport.TabIndex = 7;
            this.iconImport.TabStop = false;
            this.msgImport.SetToolTip(this.iconImport, "Importar");
            this.iconImport.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // iconFilter
            // 
            this.iconFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFilter.Image = global::PracticaProductos.Properties.Resources.buscar;
            this.iconFilter.Location = new System.Drawing.Point(998, 15);
            this.iconFilter.MaximumSize = new System.Drawing.Size(25, 25);
            this.iconFilter.MinimumSize = new System.Drawing.Size(25, 25);
            this.iconFilter.Name = "iconFilter";
            this.iconFilter.Size = new System.Drawing.Size(25, 25);
            this.iconFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconFilter.TabIndex = 5;
            this.iconFilter.TabStop = false;
            this.msgFiltrar.SetToolTip(this.iconFilter, "Filtrar");
            this.iconFilter.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // iconOrder
            // 
            this.iconOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconOrder.Image = global::PracticaProductos.Properties.Resources.ordenar;
            this.iconOrder.Location = new System.Drawing.Point(940, 15);
            this.iconOrder.MaximumSize = new System.Drawing.Size(25, 25);
            this.iconOrder.MinimumSize = new System.Drawing.Size(25, 25);
            this.iconOrder.Name = "iconOrder";
            this.iconOrder.Size = new System.Drawing.Size(25, 25);
            this.iconOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconOrder.TabIndex = 4;
            this.iconOrder.TabStop = false;
            this.msgOrdenar.SetToolTip(this.iconOrder, "Ordenar");
            this.iconOrder.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // iconAdd
            // 
            this.iconAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconAdd.Image = global::PracticaProductos.Properties.Resources.anadir;
            this.iconAdd.Location = new System.Drawing.Point(762, 15);
            this.iconAdd.MaximumSize = new System.Drawing.Size(25, 25);
            this.iconAdd.MinimumSize = new System.Drawing.Size(25, 25);
            this.iconAdd.Name = "iconAdd";
            this.iconAdd.Size = new System.Drawing.Size(25, 25);
            this.iconAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconAdd.TabIndex = 3;
            this.iconAdd.TabStop = false;
            this.msgAdd.SetToolTip(this.iconAdd, "Añadir ");
            this.iconAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // iconRemove
            // 
            this.iconRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRemove.Image = global::PracticaProductos.Properties.Resources.eliminar;
            this.iconRemove.InitialImage = global::PracticaProductos.Properties.Resources.eliminar;
            this.iconRemove.Location = new System.Drawing.Point(820, 15);
            this.iconRemove.MaximumSize = new System.Drawing.Size(25, 25);
            this.iconRemove.MinimumSize = new System.Drawing.Size(25, 25);
            this.iconRemove.Name = "iconRemove";
            this.iconRemove.Size = new System.Drawing.Size(25, 25);
            this.iconRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconRemove.TabIndex = 2;
            this.iconRemove.TabStop = false;
            this.msgRemove.SetToolTip(this.iconRemove, "Eliminar");
            this.iconRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // iconModify
            // 
            this.iconModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconModify.Image = global::PracticaProductos.Properties.Resources.editar;
            this.iconModify.Location = new System.Drawing.Point(881, 15);
            this.iconModify.MaximumSize = new System.Drawing.Size(25, 25);
            this.iconModify.MinimumSize = new System.Drawing.Size(25, 25);
            this.iconModify.Name = "iconModify";
            this.iconModify.Size = new System.Drawing.Size(25, 25);
            this.iconModify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconModify.TabIndex = 0;
            this.iconModify.TabStop = false;
            this.msgModify.SetToolTip(this.iconModify, "Modificar");
            this.iconModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // importDialog
            // 
            this.importDialog.Title = "Importar CSV";
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.Name = "Foto";
            // 
            // msgAdd
            // 
            this.msgAdd.Tag = "Añadir";
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 101.0787F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 101.0787F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 101.0787F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 101.0787F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Stock
            // 
            this.Stock.FillWeight = 101.0787F;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tipo
            // 
            this.Tipo.FillWeight = 101.0787F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Marca
            // 
            this.Marca.FillWeight = 101.0787F;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Imagen
            // 
            this.Imagen.FillWeight = 101.0787F;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // checkBox
            // 
            this.checkBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.checkBox.FillWeight = 91.37056F;
            this.checkBox.HeaderText = "";
            this.checkBox.Name = "checkBox";
            this.checkBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkBox.Width = 20;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 781);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuSuperior);
            this.Controls.Add(this.dgvProductos);
            this.MainMenuStrip = this.menuSuperior;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconModify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuSuperior;
        private ToolStripMenuItem productosMenuTool;
        private ToolStripMenuItem añadirToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem menuToolArchivo;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem importarToolStripMenuItem;
        private Panel paProductos;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem ordenarToolStripMenuItem;
        private ToolStripMenuItem filtrarToolStripMenuItem;
        private Label lbPanel;
        private Panel panel1;
        private OpenFileDialog importDialog;
        private DataGridView dgvProductos;
        private DataGridViewImageColumn Foto;
        private PictureBox iconRemove;
        private PictureBox iconModify;
        private PictureBox iconFilter;
        private PictureBox iconOrder;
        private PictureBox iconAdd;
        private PictureBox iconExport;
        private PictureBox iconImport;
        private ToolTip msgAdd;
        private ToolTip msgRemove;
        private ToolTip msgModify;
        private ToolTip msgFiltrar;
        private ToolTip msgOrdenar;
        private ToolTip msgImport;
        private ToolTip msgExportar;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewImageColumn Imagen;
        private DataGridViewCheckBoxColumn checkBox;

        /*      private DataGridViewTextBoxColumn Codigo;
private DataGridViewTextBoxColumn Nombre;
private DataGridViewTextBoxColumn Precio;
private DataGridViewTextBoxColumn Descripcion;
private DataGridViewTextBoxColumn Stock;
private DataGridViewTextBoxColumn cbTipo;
private DataGridViewTextBoxColumn cMarca;
private DataGridViewImageColumn Imagen;
private DataGridViewCheckBoxColumn checkColumn;*/

        public DataGridView DgvProductos { get => dgvProductos; set => dgvProductos = value; }
    }
}