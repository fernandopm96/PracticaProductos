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
    // Formulario para filtrar productos por uno o varios campos.
    public partial class FormFilter : Form
    {

        Controller controller;
        List<Producto> productos, productosFiltrados; 
        Dictionary<string, string?> filterProducts = new Dictionary<string, string?>(); 
        // El diccionario contendrá como clave el nombre de todos los campos por los que el usuario puede filtrar y, dependiendo de su elección, se introducirán
        // los valores correspondientes asociados a cada campo.
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
            if (ValidateForm())
            {
                SearchProducts();
                controller.SetFilterProducts(productosFiltrados);
                Close();
            } 
        }

        // Cuando el usuario selecciona un checkbox, se habilitará el elemento correspondiente para que el usuario ingrese los datos.
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
        // Verificación de formulario. Se comprueba que los campos cuyo checkbox esté habilitado contengan datos válidos para la búsqueda.
        // En caso afirmativo, se guarda en el diccionario como clave el nombre del campo seleccionado y como valor el introducido por el usuario.
        // Si algún dato no fuera correcto se muestra una ventana informando al usuario.
        private bool ValidateForm()
        {
            bool cod, name, price, tipo, marca, valid;
            valid = false;
            if(!nupCodigo.Enabled && !tbNombre.Enabled && !nupPrecio.Enabled && !tbDescripcion.Enabled && !nupStock.Enabled && !comBoxTipo.Enabled && !comBoxMarca.Enabled)
            { 
                MessageBox.Show("Debes seleccionar algún campo para filtrar.", "Selecciona campo");
                return valid;
            }
            if (nupCodigo.Enabled)
            {
                if(nupCodigo.Value == 0)
                {
                    errorFilter.SetError(nupCodigo, "Debes introducir un código mayor que 0.");
                    cod = false;
                    MessageBox.Show("Debes introducir un código mayor que 0.", "Código no válido.");
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
                    MessageBox.Show("El campo Nombre no puede estar vacío.", "Nombre no válido.");
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
                    errorFilter.SetError(nupPrecio, "Debes introducir un precio mayor que 0.");
                    price = false;
                    MessageBox.Show("El campo Precio debe ser mayor a 0.", "Precio no válido.");
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
                filterProducts["Descripcion"] = tbDescripcion.Text;   
            }
            else
            {
                filterProducts.Remove("Descripcion");
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
                if (controller.ValidateTipo(comBoxTipo.Text))
                {
                    tipo = true;
                    errorFilter.SetError(comBoxTipo, "");
                    filterProducts["Tipo"] = comBoxTipo.Text;
                } else
                {
                    tipo = false;
                    errorFilter.SetError(comBoxTipo, "Tipo no válido. Debes seleccionar una de las opciones del desplegable.");
                    MessageBox.Show("Tipo no válido. Debes seleccionar una de las opciones del desplegable.", "Tipo no válido.");
                }
              
            } else
            {
                errorFilter.SetError(comBoxTipo, "");
                filterProducts.Remove("Tipo");
                tipo = true;
            }
            if (comBoxMarca.Enabled)
            {
                if (controller.ValidateMarca(comBoxMarca.Text))
                {
                    marca = true;
                    errorFilter.SetError(comBoxMarca, "");
                    filterProducts["Marca"] = comBoxMarca.Text;
                }
                else
                {
                    marca = false;  
                    errorFilter.SetError(comBoxMarca, "Marca no válida. Debes seleccionar una de las opciones del desplegable.");
                    MessageBox.Show("Marca no válida. Debes seleccionar una de las opciones del desplegable.", "Marca no válida.");
                }

            }
            else
            {
                errorFilter.SetError(comBoxMarca, "");
                filterProducts.Remove("Marca");
                marca = true;
            }

            if(cod && name && price && tipo && marca)
            {
                valid = true;
            }
            return valid;
        }



        // Método encargado de buscar en la lista de productos los valores que el usuario ha introducido.
        // Se utiliza un objeto diccionario en el cual se guarda como clave el nombre de la propiedad(por ejemplo, "Cod") y como valor el ingresado por el 
        // usuario. Mediante un método de la clase Producto, el cuál devuelve el valor de una propiedad por su nombre, se verifican los datos y en caso de 
        // coincidencia, se añade a la lista de productos filtrados.
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
     
    }
}
