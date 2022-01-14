using System.ComponentModel;
using System.Text;

namespace PracticaProductos
{
    public partial class FormMain : Form
    {
        public List<Producto> productos { set; get;  }
        public List<Producto> productosFiltrados { set; get; }

        Controller controller;
        static bool showingFilterProducts = false;
        List<int> codigos;
        public FormMain()
        {
            InitializeComponent();
            controller = Controller.GetInstance();
            controller.formMain = this;
            productos = new List<Producto>();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);   
            formAdd.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ProductsSelected())
            {
                List<Producto> productsToModify = ProductsToModify();
                FormModify formModify = new FormModify(productsToModify);
                formModify.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Selecciona los artículos que quieras modificar.");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {    
            if (ProductsSelected())
            {   
             //   RemoveProductsInDataGridView();
                RemoveProducts();
                MessageBox.Show("Artículos eliminados.");
            }
            else
            {
                MessageBox.Show("No hay artículos seleccionados.");
            }
           
        }

        public void UpdateProductsInView()
        {
            int i = 0;
            foreach (Producto product in productos)
            {
                DgvProductos.Rows.Add();
                DgvProductos.Rows[i].Cells[0].Value = product.Cod.ToString();
                DgvProductos.Rows[i].Cells[1].Value = product.Nombre.ToString();
                DgvProductos.Rows[i].Cells[2].Value = product.Precio.ToString();
                DgvProductos.Rows[i].Cells[3].Value = product.Descripcion.ToString();
                DgvProductos.Rows[i].Cells[4].Value = product.Stock.ToString();
                DgvProductos.Rows[i].Cells[5].Value = product.Tipo.ToString();
                DgvProductos.Rows[i].Cells[6].Value = product.Marca.ToString();
                DgvProductos.Rows[i].Cells[7].Value = product.Imagen;
                i++;    
            }
        }

        private void RemoveProducts()
        {
            List<Producto> productsToRemove = new List<Producto>();
            productos.ForEach(p =>
            {
                codigos.ForEach(c =>
                {
                    if(p.Cod == c)
                    {
                        productsToRemove.Add(p);
                    }
                });
            });
            controller.RemoveProducts(productsToRemove);
        //    productos.RemoveAll(p => productsToRemove.Contains(p));
        }
        private void RemoveProductsInDataGridView()
        {
            codigos.ForEach((c) =>
            {
                foreach (DataGridViewRow row in DgvProductos.Rows)
                {
                    if(Convert.ToInt32(row.Cells[0].Value) == c)
                    {
                        DgvProductos.Rows.Remove(row);
                    }
                }
            });
            
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if(productos.Count == 0)
            {
                MessageBox.Show("No hay artículos registrados.");
            }
            else
            {
                FormOrder formOrder = new FormOrder();
                formOrder.ShowDialog();
            }
        }
        public void AddProduct(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine(producto.ToString());
            ShowProducts(productos);
        }
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
                    DgvProductos.Rows[DgvProductos.Rows.Count - 2].Cells[7].Value = product.Imagen;
                }   
            }
        }

        private bool ProductsSelected()
        {
            bool selected = false;
            codigos = new List<int>();
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay ningún artículo.");
            } else
            {
                foreach (DataGridViewRow row in DgvProductos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[8].Value))
                    {
                        selected = true;
                        codigos.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                }
            }

            return selected;
        }
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
      
        public void SetProducts(List<Producto> productos)
        {
            this.productos = productos; 
            ShowProducts(productos);
        }
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
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay artículos registrados.");
            }
            else
            {
                if (showingFilterProducts)
                {
                    MessageBox.Show("Hay un filtro de búsqueda aplicado. Restaura los datos antes de aplicar un nuevo filtro.", "Establecer filtro");
                }
                else
                {
                    FormFilter formFilter = new FormFilter();
                    formFilter.ShowDialog();
                }
            }
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay artículos registrados.");
            }
            else
            {
                if (!showingFilterProducts)
                {
                    MessageBox.Show("No hay ningún filtro aplicado.", "Eliminar filtro");
                }
                else
                {
                    ShowProducts(productos);
                    showingFilterProducts = false;
                    MessageBox.Show("Filtro eliminado.");
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(productos.Count == 0)
            {
                MessageBox.Show("No hay artículos introducidos.");
            } else
            {
                controller.ExportToCsv();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ImportToCsv();
        }


        private void ImportToCsv()
        {
            importDialog.Filter = "Fichero CSV (*.csv)|*.csv";
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = importDialog.OpenFile();
                List<Producto> importProducts = new();
                List<string> tipos = new List<string> { "Compacto", "Deportivo", "Berlina", "Suv", "Todoterreno", "Monovolumen", "Biplaza", "Furgoneta" };
                List<string> marcas = new List<string> { "Renault", "Citroen", "Peugeot", "BMW", "Audi", "Mercedes", "Porsche", "Ferrari", "Ford", "Volkswagen", "Kia", "Honda", "Dacia" };

                int cod = -1, stock = -1;
                String linea = "", nombre = "", descripcion = "", ruta = "";
                double precio = -1;
                Tipo tipo = Tipo.Berlina;
                Marca marca = Marca.BMW;
                Bitmap image = null;
                
                StreamReader reader = new StreamReader(stream);
                controller.ImportToCsv(reader);
            }
        }
      

        public bool CodAvailable(int cod)
        {
            bool codAvailable = true;
            productos.ForEach(p =>
            {
                if (cod == p.Cod)
                {
                    codAvailable = false;
                }
            });
            return codAvailable;
        }

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
                MessageBox.Show("El artículo no tiene imagen.", "Imagen no disponible");
            }
            
        }
    }
}