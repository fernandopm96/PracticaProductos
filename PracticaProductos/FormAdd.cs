using System.ComponentModel;

namespace PracticaProductos
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
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
        private bool ValidateForm()
        {
            bool valid = false;
            bool validCod = ValidateCod();
            bool validName = ValidateName();
            bool validPrice = ValidatePrice();  
            if(validCod && validName && validPrice)
            {
               valid = true;    
            }
            return valid;
        }

        /*    private void nupCodigo_Validated(object sender, EventArgs e)
     {
         errorAdd = new ErrorProvider();   
     }*/

    }
}
