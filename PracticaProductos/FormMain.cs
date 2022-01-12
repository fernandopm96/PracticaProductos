using System.ComponentModel;
using System.Text;

namespace PracticaProductos
{
    public partial class FormMain : Form
    {
        private List<Producto> productos, productosFiltrados;
        static bool showingFilterProducts = false;
        List<int> codigos = new List<int>();
        public FormMain()
        {
            InitializeComponent();
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
                productos.RemoveAll(p => productsToModify.Contains(p));
                FormModify formModify = new FormModify(this, productsToModify);
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
                RemoveProductsInDataGridView();
                RemoveProducts();
                MessageBox.Show("Artículos eliminados.");
            }
            else
            {
                MessageBox.Show("No hay artículos seleccionados.");
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
            productos.RemoveAll(p => productsToRemove.Contains(p));
        }
        private void RemoveProductsInDataGridView()
        {
            codigos.ForEach((c) =>
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if(Convert.ToInt32(row.Cells[0].Value) == c)
                    {
                        dgvProductos.Rows.Remove(row);
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
                FormOrder formOrder = new FormOrder(this, productos);
                formOrder.ShowDialog();
            }
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay artículos registrados.");
            }
            else
            {
                FormOrder formOrder = new FormOrder(this, productos);
                formOrder.ShowDialog();
            }        
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }
        public void AddProduct(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine(producto.ToString());
            ShowProducts(productos);
        }
        public void ShowProducts(List<Producto> productos)
        {
            dgvProductos.Rows.Clear();
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
                dgvProductos.Rows.Add(fila);
                if (product.Imagen != null)
                {
                    dgvProductos.Rows[dgvProductos.Rows.Count - 2].Cells[7].Value = product.Imagen;
                }   
            }
        }

        private bool ProductsSelected()
        {
            bool selected = false;
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay ningún artículo.");
            } else
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
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
        public void SetModifyProducts(List<Producto> modifiedProducts)
        {
            modifiedProducts.ForEach(p => productos.Add(p));
            ShowProducts(productos);
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
                    FormFilter formFilter = new FormFilter(this, productos);
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

                ExportToCsv();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ImportToCsv();
        }

        private void ExportToCsv()
        {
            SaveFileDialog exportDialog = new SaveFileDialog();
            exportDialog.Filter = "Fichero CSV (*.csv)|*.csv";
            exportDialog.FileName = "Datos_DataGridView";
            exportDialog.Title = "Exportar a CSV";
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                for (int i = 0; i < dgvProductos.Columns.Count; i++)
                {
                    if (i == dgvProductos.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            dgvProductos.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\";",
                            dgvProductos.Columns[i].HeaderText));
                    }
                }
                csvMemoria.AppendLine();

                for (int m = 0; m < dgvProductos.Rows.Count; m++)
                {
                    string path = GetPathByCod(Convert.ToInt32(dgvProductos.Rows[m].Cells[0].Value));
                    for (int n = 0; n < dgvProductos.Columns.Count; n++)
                    {
                        
                        if (n == dgvProductos.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"",
                                 dgvProductos.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            if (n == 7)
                            {
                                csvMemoria.Append(String.Format("\"{0}\";", path));

                            } else
                            {
                                csvMemoria.Append(String.Format("\"{0}\";",
                                    dgvProductos.Rows[m].Cells[n].Value));
                            }
                        }
                    }
                    csvMemoria.AppendLine();
                }
                System.IO.StreamWriter writer =
                    new System.IO.StreamWriter(exportDialog.FileName, false,
                       System.Text.Encoding.Default);
                writer.Write(csvMemoria.ToString());
                writer.Close();
            }
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
                reader.ReadLine();
                while (reader.Peek() >= 0)
                {
                    // Reemplazamos las comillas por cadenas vacías y dividimos la línea separándola por los ';'
                    linea = reader.ReadLine().Replace("\"", String.Empty);
                    string[] campos = linea.Split(";");

                    //Cada una de las partes se corresponde con uno de los argumentes de un producto
                    bool valid = true;
                    if(campos[0] != "")
                    {
                        cod = Convert.ToInt32(campos[0]);
                    } else
                    {
                        valid = false;  
                    }
                        
                    if(campos[1] != "")
                    {
                        nombre = campos[1];
                    } else
                    {
                        valid = false;
                    }
                    if(campos[2] != "")
                    {
                        precio = Convert.ToDouble(campos[2]);
                    } else
                    {
                        valid = false;
                    }
                    if(campos[3] != "")
                    {
                        descripcion = campos[3];
                    } else
                    {
                        valid = false;
                    }
                    if(campos[4] != "")
                    {
                        stock = Convert.ToInt32(campos[4]);
                    } else
                    {
                        valid = false;
                    }
                        
                    if(campos[5] != "")
                    {
                        tipo = (Tipo)Enum.Parse(typeof(Tipo), campos[5], true);
                    } else
                    {
                        valid = false;
                    }
                        
                    if(campos[6] != "")
                    {
                        marca = (Marca)Enum.Parse(typeof(Marca), campos[6], true);
                    } else
                    {
                        valid = false;
                    }
                    if(campos[7] != "")
                    {
                        ruta = campos[7];
                        
                        image = (Bitmap)Image.FromFile(ruta);
                    }
                         
                    if(valid)
                    {
                        Producto producto = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);
                        
                        if (image != null)
                        {
                            producto.RutaImagen = ruta;
                            producto.Imagen = image;
                        }
                        importProducts.Add(producto);
                    } 
                }
                reader.Close();
                stream.Close();
                SetProducts(importProducts);
                ShowProducts(importProducts);

                /*       imagen =
                           (partes[6].Equals(String.Empty)) ?
                           new Bitmap(Properties.Resources.placeholderProduct) { Tag = "placeholder" } : //Si no hay imagen guardada, asignamos el placeholder
                           new Bitmap(new MemoryStream(Convert.FromBase64String(partes[6]))); //Si la hay, convertimos el base 64 a un bitmap
                */


            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string GetPathByCod(int cod)
        {
            string path = "";
            productos.ForEach(p =>
            {
                if(p.Cod == cod)
                {
                    path = p.RutaImagen;
                }
            });
            return path;
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
    }
}