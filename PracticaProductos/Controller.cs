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

        public List<Producto> products2;

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
        public void AddProducts(List<Producto> productos)
        {
            productos.ForEach(p => products.Add(p));
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

        public void ModifyProducts(List<Producto> productsToModify, List<Producto> productsModified)
        {
            products.RemoveAll(p => productsToModify.Contains(p));
            productsModified.ForEach(p => products.Add(p));
            UpdateProducts();
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
            List<int> codigos = new List<int>();    

            reader.ReadLine();
            while (reader.Peek() >= 0)
            {
                // Reemplazamos las comillas por cadenas vacías y dividimos la línea separándola por los ';'
                linea = reader.ReadLine().Replace("\"", String.Empty);
                string[] campos = linea.Split(";");
                if (campos.Length < 7 || campos.Length > 9)
                {
                    throw new ImportCsvException("Error al importar el archivo csv.");
                }

                bool valid = true;
                if (campos[0] != "")
                {
                    try
                    { 
                        cod = Convert.ToInt32(campos[0]);
                    }
                    catch (FormatException)
                    {
                        throw new ImportCsvException("Error en el campo Código. Debes introducir un campo numérico entero.");
                    }
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
                    try
                    {
                        precio = Convert.ToDouble(campos[2]);
                    }
                    catch (FormatException)
                    {
                        throw new ImportCsvException("Error en el campo Precio. Debes introducir un campo numérico.");
                    }
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
                    try
                    {
                        stock = Convert.ToInt32(campos[4]);
                    }
                    catch (FormatException)
                    {
                        throw new ImportCsvException("Error en el campo Stock. Debes introducir un campo numérico entero.");
                    }
                    
                }
                else
                {
                    valid = false;
                }

                if (campos[5] != "")
                {
                    tipo = Tipo.Compacto;
                    try
                    {
                        tipo = (Tipo)Enum.Parse(typeof(Tipo), campos[5], true);
                    }
                    catch (ArgumentException)
                    {
                        DialogResult respuesta = MessageBox.Show("El tipo introducido no es válido. Se sustituirá por Compacto.\n¿Estás de acuerdo?", "Tipo no válido", MessageBoxButtons.YesNo);
                        if(respuesta != DialogResult.Yes)
                        {
                            MessageBox.Show("Importación cancelada.", "Importación cancelada.");
                            return;
                        }
                    }
                }
                else
                {
                    valid = false;
                }

                if (campos[6] != "")
                {
                    marca = Marca.Renault;
                    try
                    {
                        marca = (Marca)Enum.Parse(typeof(Marca), campos[5], true);
                    }
                    catch (ArgumentException)
                    {
                        DialogResult respuesta = MessageBox.Show("La marca introducida no es válida. Se sustituirá por Renault.\n¿Estás de acuerdo?", "Tipo no válido", MessageBoxButtons.YesNo);
                        if (respuesta != DialogResult.Yes)
                        {
                            MessageBox.Show("Importación cancelada.", "Importación cancelada.");
                            return;
                        }
                    }
                }
                else
                {
                    valid = false;
                }
                if (campos[7] != "")
                {
                    ruta = campos[7];
                    try
                    {
                        image = (Bitmap)Image.FromFile(ruta);
                    } catch(FileNotFoundException)
                    {
                        DialogResult respuesta = MessageBox.Show("La ruta introducida no corresponde a ninguna imagen. Se omitirá este campo.\n¿Estás de acuerdo?", "Tipo no válido", MessageBoxButtons.YesNo);
                        if (respuesta != DialogResult.Yes)
                        {
                            MessageBox.Show("Importación cancelada.", "Importación cancelada.");
                            return;
                        }
                    }
                }

                if (valid)
                {
                    Producto producto = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);

                    if (image != null)
                    {
                        producto.RutaImagen = ruta;
                        producto.Imagen = image;
                    }
                    if (importProducts.Count > 0)
                    {
                        if (codigos.Contains(cod))
                        {
                            string msg = $"El artículo con código {cod.ToString()} tiene un código que pertenece a otro artículo ya importado.\n" +
                                "Se sustituirá este campo por otro valor. ¿Estás de acuerdo?";
                            DialogResult result = MessageBox.Show(msg, "Código repetido", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                bool codValid = false;
                                for (int i = 1; !codValid; i++)
                                {
                                    if (!codigos.Contains(i))
                                    {
                                        producto.Cod = i;
                                        codValid = true;
                                    }
                                }
                                
                                MessageBox.Show($"El producto con código repetido se ha modificado.\nAhora su código es {producto.Cod}.", "Código modificado");
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    importProducts.Add(producto);
                    codigos.Add(producto.Cod);
                } else
                {
                    throw new ImportCsvException("Error al importar el archivo csv.\nAlguno de los campos obligatorios no tienen valor.");
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

        public bool ValidateCod(int cod)
        {
            bool valid = true; 
            if (cod <= 0 || !CodAvailable(cod))
            {
                valid = false;
            }
            return valid;
        }
        public bool ValidateName(string text)
        {
            bool valid = true;
            if(text == "")
            {
                valid = false;
            }
            return valid;
        }
        public bool ValidatePrice(double price)
        {
            bool valid = true;
            if(price <= 0)
            {
                valid =false;
            }
            return valid;
        }
        public bool ValidateTipo(string valor)
        {
            bool valid = true;
            try
            {
                Tipo tipo = (Tipo)Enum.Parse(typeof(Tipo), valor, true);
            }
            catch (ArgumentException)
            {
                valid=false;
            }
            return valid;
        }
        public bool ValidateMarca(string valor)
        {
            bool valid = true;
            try
            {
                Marca marca = (Marca)Enum.Parse(typeof(Marca), valor, true);
            }
            catch (ArgumentException)
            {
                valid = false;
            }
            return valid;
           
        }
        public bool CodAvailable(int cod)
        {
            bool codAvailable = true;
            products.ForEach(p =>
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
