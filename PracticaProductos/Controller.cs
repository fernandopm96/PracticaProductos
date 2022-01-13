using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{
    public class Controller
    {

        private static Controller controller = new Controller();
        public FormMain formMain { set; get; }
        public List<Producto> products { get; set; }

        public static Controller GetInstance()
        {
            return controller;
        }
        public Controller()
        {
            products = new List<Producto>();
        }

        public void AddProduct(Producto producto)
        {
            products.Add(producto);
            UpdateProducts();
        }
        public void RemoveProducts(List<Producto> productsToRemove)
        {
            products.RemoveAll(p => productsToRemove.Contains(p));
            UpdateProducts();
        }
        

        public void SetOrderedProducts(List<Producto> orderedProducts)
        {
            products = orderedProducts;
            UpdateProducts();
        }

        public void ModifyProducts(List<Producto> productsModified)
        {
            foreach(Producto productModified in productsModified)
            {
                foreach (Producto producto in products)
                {
                    if(productModified.Cod == producto.Cod)
                    {
                        products.Remove(producto);
                        products.Add(productModified);
                    }
                }
            }   

        }

        public void UpdateProducts()
        {
            formMain.productos = products;
            formMain.UpdateProductsInView();
        }

        public void SetFilterProducts(List<Producto> productosFiltrados)
        {
            formMain.SetFilterProducts(productosFiltrados);
        }

        public void ExportToCsv()
        {
            SaveFileDialog exportDialog = new SaveFileDialog();
            exportDialog.Filter = "Fichero CSV (*.csv)|*.csv";
            exportDialog.FileName = "Datos_DataGridView";
            exportDialog.Title = "Exportar a CSV";
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvMemoria = new StringBuilder();

                for (int i = 0; i < formMain.DgvProductos.Columns.Count; i++)
                {
                    if (i == formMain.DgvProductos.Columns.Count - 1)
                    {
                        csvMemoria.Append(String.Format("\"{0}\"",
                            formMain.DgvProductos.Columns[i].HeaderText));
                    }
                    else
                    {
                        csvMemoria.Append(String.Format("\"{0}\";",
                            formMain.DgvProductos.Columns[i].HeaderText));
                    }
                }
                csvMemoria.AppendLine();

                for (int m = 0; m < formMain.DgvProductos.Rows.Count; m++)
                {
                    string path = GetPathByCod(Convert.ToInt32(formMain.DgvProductos.Rows[m].Cells[0].Value));
                    for (int n = 0; n < formMain.DgvProductos.Columns.Count; n++)
                    {

                        if (n == formMain.DgvProductos.Columns.Count - 1)
                        {
                            csvMemoria.Append(String.Format("\"{0}\"",
                                 formMain.DgvProductos.Rows[m].Cells[n].Value));
                        }
                        else
                        {
                            if (n == 7)
                            {
                                csvMemoria.Append(String.Format("\"{0}\";", path));

                            }
                            else
                            {
                                csvMemoria.Append(String.Format("\"{0}\";",
                                    formMain.DgvProductos.Rows[m].Cells[n].Value));
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
        public void ImportToCsv(StreamReader reader)
        {
            List<Producto> importProducts = new List<Producto>();
            string nombre = "", descripcion = "", ruta = "", linea = "";
            int cod = -1, stock = -1;
            double precio = -1;
            Tipo tipo = Tipo.Compacto;
            Marca marca = Marca.Ford;
            Bitmap image = null;

            reader.ReadLine();
            while (reader.Peek() >= 0)
            {
                // Reemplazamos las comillas por cadenas vacías y dividimos la línea separándola por los ';'
                linea = reader.ReadLine().Replace("\"", String.Empty);
                string[] campos = linea.Split(";");

                //Cada una de las partes se corresponde con uno de los argumentes de un producto
                bool valid = true;
                if (campos[0] != "")
                {
                    cod = Convert.ToInt32(campos[0]);
                }
                else
                {
                    valid = false;
                }

                if (campos[1] != "")
                {
                    nombre = campos[1];
                }
                else
                {
                    valid = false;
                }
                if (campos[2] != "")
                {
                    precio = Convert.ToDouble(campos[2]);
                }
                else
                {
                    valid = false;
                }
                if (campos[3] != "")
                {
                    descripcion = campos[3];
                }
                else
                {
                    valid = false;
                }
                if (campos[4] != "")
                {
                    stock = Convert.ToInt32(campos[4]);
                }
                else
                {
                    valid = false;
                }

                if (campos[5] != "")
                {
                    tipo = (Tipo)Enum.Parse(typeof(Tipo), campos[5], true);
                }
                else
                {
                    valid = false;
                }

                if (campos[6] != "")
                {
                    marca = (Marca)Enum.Parse(typeof(Marca), campos[6], true);
                }
                else
                {
                    valid = false;
                }
                if (campos[7] != "")
                {
                    ruta = campos[7];
                    image = (Bitmap)Image.FromFile(ruta);
                }

                if (valid)
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
            products = importProducts;
            UpdateProducts();

        }

        public string GetPathByCod(int cod)
        {
            string path = "";
            products.ForEach(p =>
            {
                if (p.Cod == cod)
                {
                    path = p.RutaImagen;
                }
            });
            return path;
        }
    }
}
