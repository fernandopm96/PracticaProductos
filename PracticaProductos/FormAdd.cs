using System.ComponentModel;

namespace PracticaProductos
{
    public partial class FormAdd : Form
    {
        FormMain formMain;
        public FormAdd(FormMain formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                AddProduct();
                MessageBox.Show("Producto registrado correctamente.");
                Close();
            } else
            {
                MessageBox.Show("Algún campo no es válido. ");
            }
            
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
        private void nupStock_Validating(object sender, CancelEventArgs e)
        {
            ValidateStock();
        }
        private void cbTipo_Validating(object sender, CancelEventArgs e)
        {
            ValidateTipo();
        }
        private void cbMarca_Validating(object sender, CancelEventArgs e)
        {
            ValidateMarca();
        }

        private bool ValidateCod()
        {
            bool valid = true;
            if (nupCodigo.Value <= 0)
            {
                errorAdd.SetError(nupCodigo, "Debes introducir un código mayor que 0.");
                valid = false;
            }
            else
            {
                errorAdd.SetError(nupCodigo, "");
            }
            return valid;            
        }

        private bool ValidateName()
        {
            bool valid = true;
            if (tbNombre.Text == "")
            {
                errorAdd.SetError(tbNombre, "No puedes dejar el nombre vacío.");
                valid = false;
            }
            else
            {
                errorAdd.SetError(tbNombre, "");
            }
            return valid;
        }
        private bool ValidatePrice()
        {
            bool valid = true;
            if (nupPrecio.Value <= 0)
            {
                errorAdd.SetError(nupPrecio, "El precio debe ser mayor a 0.");
                valid = false;
            }
            else
            {
                errorAdd.SetError(nupPrecio, "");
            }
            return valid;
        }
        private bool ValidateDescripcion()
        {
            bool valid = true;
            if (tbDescripcion.Text == "")
            {
                valid = false;
            }
            return valid;
        }
        private bool ValidateStock()
        {
            bool valid = true;
            if(nupStock.Value < 0)
            {
                valid = false;   
            }
            return valid;
        }
        private bool ValidateTipo()
        {
            bool valid = true;
            if (cbTipo.Text == "")
            {
                valid =false;
            }
            return valid;
        }
        private bool ValidateMarca()
        {
            bool valid = true;
            if (cbMarca.Text == "")
            {
                valid = false;
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
            bool validStock = ValidateStock();
            bool validTipo = ValidateTipo();
            bool validMarca = ValidateMarca();  
            if(validCod && validName && validPrice && validDescription && validStock && validTipo && validMarca)
            {
               valid = true;    
            }
            return valid;
        }

        private void AddProduct()
        {
            int cod = (int)nupCodigo.Value;
            string nombre = tbNombre.Text;
            double precio = (double)nupPrecio.Value;
            string descripcion = tbDescripcion.Text;
            int stock = (int)nupStock.Value;    
            Tipo tipo = (Tipo)cbTipo.SelectedIndex;
            Marca marca = (Marca)cbMarca.SelectedIndex;
            Producto producto = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);
            MessageBox.Show(producto.ToString());
            formMain.AddProduct(producto);
        }

        
    }
}
