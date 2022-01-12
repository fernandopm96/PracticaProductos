using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaProductos
{
    public partial class FormFilter : Form
    {

        Controller controller;
        List<Producto> productos, productosFiltrados;
        Dictionary<string, string?> filterProducts = new Dictionary<string, string?>();
        public FormFilter()
        {
            controller = Controller.GetInstance();
            this.productos = controller.products;
            productosFiltrados = new List<Producto>();
            InitializeComponent();
            filterProducts.Add("Cod", null);
            filterProducts.Add("Nombre", null);
            filterProducts.Add("Precio", null);
            filterProducts.Add("Descripcion", null);
            filterProducts.Add("Stock", null);
            filterProducts.Add("Tipo", null);
            filterProducts.Add("Marca", null);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (Verify())
            {
                SearchProducts();
                controller.SetFilterProducts(productosFiltrados);
                Close();
            } else
            {
                MessageBox.Show("Algún campo no es válido.");
            }
        }

        
        private void cbCodigo_Changed(object sender, EventArgs e)
        {
            if (cbCodigo.Checked)
            {
                nupCodigo.Enabled = true;
            } else
            {
                nupCodigo.Enabled = false;  
            }
        }

        private void cbNombre_Changed(object sender, EventArgs e)
        {
            if (cbNombre.Checked)
            {
                tbNombre.Enabled = true;
            } else
            {
                tbNombre.Enabled = false;   
            }
        }

        private void cbPrecio_Changed(object sender, EventArgs e)
        {
            if (cbPrecio.Checked)
            {
                nupPrecio.Enabled = true;
            } else
            {
                nupPrecio.Enabled = false;
            }
        }

        private void cbDescripcion_Changed(object sender, EventArgs e)
        {
            if (cbDescripcion.Checked)
            {
                tbDescripcion.Enabled = true;
            } else
            {
                tbDescripcion.Enabled = false;  
            }
        }

        private void cbStock_Changed(object sender, EventArgs e)
        {
            if (cbStock.Checked)
            {
                nupStock.Enabled = true;
            }
            else
            {
                nupStock.Enabled = false;
            }
        }

        private void cbTipo_Changed(object sender, EventArgs e)
        {
            if (cbTipo.Checked)
            {
                comBoxTipo.Enabled = true;
            }
            else
            {
                comBoxTipo.Enabled = false;
            }
        }

        private void cbMarca_Changed(object sender, EventArgs e)
        {
            if (cbMarca.Checked)
            {
                comBoxMarca.Enabled = true;
            }
            else
            {
                comBoxMarca.Enabled = false;
            }
        }

        private bool Verify()
        {
            bool cod, name, price, description, tipo, marca, valid;
            cod = name = price = description = tipo = marca = valid = false;
            if (nupCodigo.Enabled)
            {
                if(nupCodigo.Value == 0)
                {
                    errorFilter.SetError(nupCodigo, "Debes introducir un código mayor que 0.");
                    cod = false;
                } else
                {
                    cod = true;
                    errorFilter.SetError(nupCodigo, "");
                    filterProducts["Cod"] = nupCodigo.Value.ToString();
                }
            } 
            else
            {
                errorFilter.SetError(nupCodigo, "");
                filterProducts.Remove("Cod");
                cod = true;
            }
            if (tbNombre.Enabled)
            { 
                if(tbNombre.Text == "")
                {
                    errorFilter.SetError(tbNombre, "El nombre no puede estar vacío.");
                    name = false;
                } else
                {
                    name = true;
                    errorFilter.SetError(tbNombre, "");
                    filterProducts["Nombre"] = tbNombre.Text;
                }
            }
            else
            {
                errorFilter.SetError(tbNombre, "");
                filterProducts.Remove("Nombre");
                name = true;
            }
            if (nupPrecio.Enabled)
            {
                if (nupPrecio.Value == 0)
                {
                    errorFilter.SetError(nupPrecio, "Debes introducir un código mayor que 0.");
                    price = false;
                }
                else
                {
                    price = true;
                    errorFilter.SetError(nupPrecio, "");
                    filterProducts["Precio"] = nupPrecio.Value.ToString();
                }
            }
            else
            {
                errorFilter.SetError(nupPrecio, "");
                filterProducts.Remove("Precio");
                price = true;
            }
            if (tbDescripcion.Enabled)
            {
                if (tbDescripcion.Text == "")
                {
                    errorFilter.SetError(tbDescripcion, "La descripción no puede estar vacía.");
                    description = false;
                }
                else
                {
                    description = true;
                    errorFilter.SetError(tbDescripcion, "");
                    filterProducts["Descripcion"] = tbDescripcion.Text;
                }
            }
            else
            {
                errorFilter.SetError(tbDescripcion, "");
                filterProducts.Remove("Descripcion");
                description = true;
            }
            if (nupStock.Enabled)
            {
                filterProducts["Stock"] = nupStock.Value.ToString();
            }
            else
            {
                filterProducts.Remove("Stock");
            }
            if (comBoxTipo.Enabled)
            {
                List<string> tipos = new List<string> { "Compacto", "Deportivo", "Berlina", "Suv", "Todoterreno", "Monovolumen", "Biplaza", "Furgoneta" };
                tipo = false;
                foreach (string s in tipos)
                {
                    if (comBoxTipo.Text == s)
                    {
                        tipo = true;
                    }
                }
                if (!tipo)
                {
                    errorFilter.SetError(comBoxTipo, "Tipo no válido.");
                }
                else
                {
                    errorFilter.SetError(comBoxTipo, "");
                    filterProducts["Tipo"] = comBoxTipo.Text;
                }
                filterProducts["Tipo"] = comBoxTipo.Text;
            }
            else
            {
                errorFilter.SetError(comBoxTipo, "");
                filterProducts.Remove("Tipo");
                tipo = true;
            }
            if (comBoxMarca.Enabled)
            {
                List<string> marcas = new List<string> { "Renault", "Citroen", "Peugeot", "BMW", "Audi", "Mercedes", "Porsche", "Ferrari", "Ford", "Volkswagen", "Kia", "Honda", "Dacia" };
                marca = false;
                foreach (string s in marcas)
                {
                    if (comBoxMarca.Text == s)
                    {
                        marca = true;
                    }
                }
                if (!marca)
                {
                    errorFilter.SetError(comBoxMarca, "Marca no válida.");
                }
                else
                {
                    errorFilter.SetError(comBoxMarca, "");
                    filterProducts["Marca"] = comBoxMarca.Text;
                }
            }
            else
            {
                errorFilter.SetError(comBoxMarca, "");
                filterProducts.Remove("Marca");
                marca = true;
            }
            if(cod && name && description && price && tipo && marca)
            {
                valid = true;
            }
            return valid;
        }

        private void nupCodigo_Validating(object sender, CancelEventArgs e)
        {
            ValidateCod();
        }

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }
        private void nupPrecio_Validating(object sender, CancelEventArgs e)
        {
            ValidatePrice();
        }

        private void tbDescripcion_Validating(object sender, CancelEventArgs e)
        {
            ValidateDescripcion();
        }

        private void comBoxTipo_Validating(object sender, CancelEventArgs e)
        {
            ValidateType();
        }

        private void comBoxMarca_Validating(object sender, CancelEventArgs e)
        {
            ValidateMarca();
        }

       

        private void SearchProducts()
        {
            bool productoEncontrado = true;
            foreach(Producto p in productos)
            {
                productoEncontrado = true;
                foreach (string key in filterProducts.Keys)
                {
                    if(p.GetPropertyByName(key) != filterProducts[key])
                    {
                        productoEncontrado = false;
                        break;
                    }
                }
                if (productoEncontrado)
                {
                    productosFiltrados.Add(p);
                }
            }
        }
        private bool ValidateCod()
        {
            bool valid = true;
            if (nupCodigo.Value == 0)
            {
                errorFilter.SetError(nupCodigo, "Debes introducir un código mayor que 0.");
                valid = false;
            }
            else
            {
                errorFilter.SetError(nupCodigo, "");
            }
            return valid;
        }

        private bool ValidateName()
        {
            bool valid = true;
            if (tbNombre.Text == "")
            {
                errorFilter.SetError(tbNombre, "No puedes dejar el nombre vacío.");
                valid = false;
            }
            else
            {
                errorFilter.SetError(tbNombre, "");
            }
            return valid;
        }


        private bool ValidatePrice()
        {
            bool valid = true;
            if (nupPrecio.Value == 0)
            {
                errorFilter.SetError(nupPrecio, "Debes introducir un precio mayor que 0.");
                valid = false;
            }
            else
            {
                errorFilter.SetError(nupCodigo, "");
            }
            return valid;
        }

        private bool ValidateDescripcion()
        {
            bool valid = true;
            if (tbDescripcion.Text == "")
            {
                errorFilter.SetError(tbDescripcion, "Debes introducir una descripción.");
                valid = false;
            }
            else
                errorFilter.SetError(tbDescripcion, "");
            return valid;
        }

        private bool ValidateType()
        {
            List<string> tipos = new List<string> { "Television", "Lavadora", "Microondas", "Frigorifico", "Secadora", "Lavavajillas", "Horno", "AireAcondicionado", "Estufa" };
            bool valid = false;
            foreach (string s in tipos)
            {
                if (cbTipo.Text == s)
                {
                    valid = true;
                }
            }
            if (!valid)
            {
                errorFilter.SetError(cbTipo, "Tipo no válido.");
            }
            else
            {
                errorFilter.SetError(cbMarca, "");
            }
            return valid;
        }
        private bool ValidateMarca()
        {
            List<string> marcas = new List<string> { "Balay", "LG", "Bosch", "Siemens", "Secadora", "Samsung", "Zanussi", "Fagor", "Mitsubishi" };
            bool valid = false;
            foreach (string s in marcas)
            {
                if (cbMarca.Text == s)
                {
                    valid = true;
                }
            }
            if (!valid)
            {
                errorFilter.SetError(cbMarca, "Marca no válida.");
            }
            else
            {
                errorFilter.SetError(cbMarca, "");
            }
            return valid;
        }
        private bool ValidateForm()
        {
            bool valid = false;
            bool validCod = ValidateCod();
            bool validName = ValidateName();
            bool validPrice = ValidatePrice();
            bool validDescription = ValidateDescripcion();
            bool validTipo = ValidateType();
            bool validMarca = ValidateMarca();
            if (validCod && validName && validPrice && validDescription && validTipo && validMarca)
            {
                valid = true;
            }
            return valid;
        }
    }
}
