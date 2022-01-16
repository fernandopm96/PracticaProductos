using System.ComponentModel;
using System.Text;

namespace PracticaProductos
{
    // Formulario principal
    public partial class FormMain : Form
    {
        public List<Producto> productos { set; get;  }
        public List<Producto> productosFiltrados { set; get; }

        Controller controller;
        static bool showingFilterProducts = false;
        List<int> codigos;
        // Al iniciar, recibe una instancia del controlador y a su vez, se asigna una instancia de �ste formulario al controlador.
        public FormMain()
        {
            InitializeComponent();
            controller = Controller.GetInstance();
            controller.formMain = this;
            productos = new List<Producto>();
        }
        // Muestra el formulario de a�adir producto
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();   
            formAdd.ShowDialog();
        }
        // Si hay alg�n producto seleccionado a trav�s del checkbox de la fila, se instancia un formulario para modificar todos los productos que tengan
        // el checkbox marcado.
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados.", "Sin productos");
                return;
            }
            if (ProductsSelected())
            {
                List<Producto> productsToModify = ProductsToModify();
                FormModify formModify = new FormModify(productsToModify);
                formModify.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("No hay productos seleccionados. \nSelecciona los productos que quieras modificar.", "Selecciona producto");
            }

        }
        // Llama al controlador pas�ndole como par�metro todos los elementos seleccionados en el DataGridView, para eliminarlos.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados.", "Sin productos");
                return;
            }
            if (ProductsSelected())
            {   
                controller.RemoveProducts(ProductsToModify());
                MessageBox.Show("Art�culos eliminados.", "Eliminar");
            }
            else
            {
                MessageBox.Show("No hay productos seleccionados. \nSelecciona los productos que quieras eliminar", "Selecciona producto");
            }
           
        }
        // Comprureba primero si hay productos registrados y despu�s, si hay alg�n filtro ya aplicado. Si lo hay, avisa al usuario. En caso contrario, instancia
        // un nuevo formulario de filtro
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados.", "Sin productos");
                return;
            }
            else
            {
                if (showingFilterProducts)
                {
                    DialogResult result = MessageBox.Show("Hay un filtro de b�squeda aplicado. �Quieres restablecer los datos?", "Restablecer filtro", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        ShowProducts(productos);
                        showingFilterProducts = false;
                        MessageBox.Show("Filtro eliminado.", "Eliminar filtro");
                    }
                }
                else
                {
                    FormFilter formFilter = new FormFilter();
                    formFilter.ShowDialog();
                }
            }
        }
        // Si hay productos registrados, se instancia un formulario para ordenarlos 
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos registrados.", "Sin productos");
            }
            else
            {
                FormOrder formOrder = new FormOrder();
                formOrder.ShowDialog();
            }
        }
        // Comprueba que haya productos registrados para poder exportar
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos introducidos.", "Sin productos");
            }
            else
            {
                controller.ExportToCsv();
            }
        }
        // Importar
        private void btnImportar_Click(object sender, EventArgs e)
        {
            ImportToCsv();
        }
        // M�todo que es llamado por el controlador cuando la lista de productos se modifica, para que actualizar el DataGridView
        public void UpdateProductsInView()
        {
            DgvProductos.Rows.Clear();
            foreach (Producto product in productos)
            {
                string[] fila = new string[7];
                fila[0] = product.Cod.ToString();
                fila[1] = product.Nombre.ToString();
                fila[2] = product.Precio.ToString();
                fila[3] = product.Descripcion.ToString();
                fila[4] = product.Stock.ToString();
                fila[5] = product.Tipo.ToString();
                fila[6] = product.Marca.ToString();
                DgvProductos.Rows.Add(fila);
                if (product.Imagen != null)
                {
                    DgvProductos.Rows[DgvProductos.Rows.Count - 1].Cells[7].Value = product.Imagen;
                }
                DgvProductos.Rows[DgvProductos.Rows.Count - 1].Cells[8].Value = false;

            }
        }
       
        // M�todo que muestra dependiendo de si hay filtro aplicado, los productos que correspondan seg�n el caso(todos o s�lo los que cumplan el filtro).
        public void ShowProducts(List<Producto> productos)
        {
            DgvProductos.Rows.Clear();
            foreach(Producto product in productos)
            {
                string[] fila = new string[7];
                fila[0] = product.Cod.ToString();
                fila[1] = product.Nombre.ToString();
                fila[2] = product.Precio.ToString();
                fila[3] = product.Descripcion.ToString();
                fila[4] = product.Stock.ToString();
                fila[5] = product.Tipo.ToString();
                fila[6] = product.Marca.ToString();
                
                DgvProductos.Rows.Add(fila);
                if (product.Imagen != null)
                {
                    DgvProductos.Rows[DgvProductos.Rows.Count - 1].Cells[7].Value = product.Imagen;
                }   
            }
        }
        // En base al valor del checkbox de cada fila, determina si hay alg�n producto seleccionado y, si lo hay, almacena sus c�digos para siguientes acciones.
        private bool ProductsSelected()
        {
            bool selected = false;
            codigos = new List<int>();
           
            foreach (DataGridViewRow row in DgvProductos.Rows)
            {
                if (Convert.ToBoolean(row.Cells[8].Value))
                {
                    selected = true;
                    codigos.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }

            return selected;
        }
        // Devuelve los productos cuyo c�digo pertenezca a la lista de c�digos seleccionados, devolviendo una lista con los productos seleccionados
        private List<Producto> ProductsToModify()
        {
            List<Producto> productsToModify = new List<Producto>();
            productos.ForEach(p =>
            {
                codigos.ForEach(c =>
                {
                    if(p.Cod == c)
                    {
                        productsToModify.Add(p);
                    }
                });
            });
            return productsToModify;
        }
        // Actualiza la lista de productos filtrados
        public void SetFilterProducts(List<Producto> filterProducts)
        {
            this.productosFiltrados = filterProducts;
            if (showingFilterProducts)
            {
                showingFilterProducts = false;
                ShowProducts(productos);
            }
            else
            {
                showingFilterProducts = true;
                ShowProducts(filterProducts);
            }
        }
        

        

        // A trav�s de un OpenFileDialog, crea un stream y un streamReader, para despu�s llamar al controlador que se encarga de la importaci�n.
        // Captura la posible excepci�n y muestra el mensaje de error correspondiente.
        private void ImportToCsv()
        {
            importDialog.Filter = "Fichero CSV (*.csv)|*.csv";
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = importDialog.OpenFile();             
                StreamReader reader = new StreamReader(stream);
                try
                {
                    controller.ImportToCsv(reader);
                } catch(ImportCsvException ex)
                {
                    MessageBox.Show(ex.Message, "Error al importar.");    
                }
            }
        }
        // Instancia un formulario de imagen, para mostrar la imagen del producto seleccionado en un formato m�s grande.
        public void show_image(object sender, DataGridViewCellEventArgs e)
        {
            FormImage image = new FormImage();
            int cod = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells[0].Value);
            string path = controller.GetPathByCod(cod);
            Bitmap bitmap = null;
            if(path != null)
            {
                bitmap = new Bitmap(new Bitmap(path), new Size(781, 559));
                image.PictureBox.Image = bitmap;
                image.ShowDialog();
            }
            else
            {
                MessageBox.Show("El art�culo no tiene imagen.", "Imagen no disponible");
            }
            
        }
        // Actualiza el valor del checkbox cuando se produce un click en cualquier parte de la fila
        private void check_column(object sender, DataGridViewCellEventArgs e)
        {
            if(productos.Count > 0)
            {
                bool check = (bool)DgvProductos.Rows[e.RowIndex].Cells[8].Value;
                check = !check;
                DgvProductos.Rows[e.RowIndex].Cells[8].Value = check;
            }
        }
    }
}