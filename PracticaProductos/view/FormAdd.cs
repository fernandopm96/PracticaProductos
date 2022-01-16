using System.ComponentModel;

namespace PracticaProductos
{
    // Formulario para añadir un nuevo producto.
    public partial class FormAdd : Form
    {
        Controller controller;
        string ruta;

        public FormAdd()
        {
            controller = Controller.GetInstance();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Si el formulario es válido, se llama a AddProduct que crea un nuevo objeto y se llama al controlador para que lo registre. 
        // En caso contrario, se muestra una ventana indicando que campo o campos no son válidos.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    AddProduct();
                    var confirmResult = MessageBox.Show("Producto registrado correctamente.\n¿Quieres introducir más artículos?", "Añadir producto", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            catch (InvalidFormException ex)
            {
                MessageBox.Show(ex.Message, "Formulario inválido.");
            }    
        }
        // Validaciones
        // En todos los campos requeridos obligatoriamente(cod, nombre, precio, marca y tipo) se llama al controlador para verificar los datos.
        // Si no son correctos, se establece un error en el campo correspondiente a través de ErrorProvider y se muestra el mensaje de error.
        private void nupCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (controller.ValidateCod(Convert.ToInt32(nupCodigo.Value)))
            {
                errorAdd.SetError(nupCodigo, "");
            } else
            {
                errorAdd.SetError(nupCodigo, "Código no válido.");
                e.Cancel = true;
                if(!controller.CodAvailable(Convert.ToInt32(nupCodigo.Value)))
                    MessageBox.Show("El código introducido ya pertenece a otro artículo.", "Código no válido.");
                else 
                    MessageBox.Show("El código debe ser mayor a 0.","Código no válido");
            }
            
        }
        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (controller.ValidateName(tbNombre.Text))
            {
                errorAdd.SetError(tbNombre, "");
            } else
            {
                errorAdd.SetError(tbNombre, "Nombre no válido.");
                e.Cancel = true;
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Nombre no válido.");
            }
           
        }
        private void nupPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (controller.ValidatePrice(Convert.ToDouble(nupPrecio.Value)))
            {
                errorAdd.SetError(nupPrecio, "");
            }
            else
            {
                errorAdd.SetError(nupPrecio, "Precio no válido.");
                e.Cancel = true;
                MessageBox.Show("El campo Precio debe ser mayor a 0.", "Precio no válido.");
            }
        }
        private void cbTipo_Validating(object sender, CancelEventArgs e)
        {
            if (controller.ValidateTipo(cbTipo.Text))
            {
                errorAdd.SetError(cbTipo, "");
            }
            else
            {
                errorAdd.SetError(cbTipo, "Tipo no válido.");
                e.Cancel = true;
                MessageBox.Show("Tipo no válido. Debes seleccionar una de las opciones del desplegable.", "Tipo no válido.");
            }
        }
        private void cbMarca_Validating(object sender, CancelEventArgs e)
        {
            if (controller.ValidateMarca(cbMarca.Text))
            {
                errorAdd.SetError(cbMarca, "");
            }
            else
            {
                errorAdd.SetError(cbMarca, "Marca no válida.");
                e.Cancel = true;
                MessageBox.Show("Marca no válida. Debes seleccionar una de las opciones del desplegable.", "Marca no válido.");
            }
        }
        // Validación de formulario. Cuando el usuario pulsa Aceptar, se verifican todos los campos y si alguno no es válido, se lanza la excepción con el 
        // mensaje correspondiente.
        private bool ValidateForm()
        {
            if (!controller.ValidateCod(Convert.ToInt32(nupCodigo.Value)))
            {
                errorAdd.SetError(nupCodigo, "Código no válido.");
                if (!controller.CodAvailable(Convert.ToInt32(nupCodigo.Value)))
                    throw new InvalidFormException("Ese código ya pertenece a algún artículo.");
                throw new InvalidFormException("Debes introducir un código mayor que 0.");
            }
                
            if (!controller.ValidateName(tbNombre.Text))
            {
                errorAdd.SetError(tbNombre, "Nombre no válido.");
                throw new InvalidFormException("El campo Nombre no puede estar vacío.");
            }
                
            if (!controller.ValidatePrice(Convert.ToDouble(nupPrecio.Value)))
            {
                errorAdd.SetError(nupPrecio, "Código no válido.");
                throw new InvalidFormException("El campo Precio debe ser mayor a 0.");
            }
                
            if (!controller.ValidateTipo(cbTipo.Text))
            {
                errorAdd.SetError(cbTipo, "Tipo no válido.");
                throw new InvalidFormException("Tipo no válido. Debes seleccionar una de las opciones del desplegable.");
            }
                
            if (!controller.ValidateMarca(cbMarca.Text))
            {
                errorAdd.SetError(cbMarca, "Marca no válida.");
                throw new InvalidFormException("Marca no válida. Debes seleccionar una de las opciones del desplegable.");
            }
             
            return true;
        }
        // Si todo es correcto, se crea un nuevo objeto y a través del controlador se registra.
        private void AddProduct()
        {
            int cod = (int)nupCodigo.Value;
            string nombre = tbNombre.Text;
            double precio = (double)nupPrecio.Value;
            string descripcion = tbDescripcion.Text;
            int stock = (int)nupStock.Value;    
            Tipo tipo = (Tipo)cbTipo.SelectedIndex;
            Marca marca = (Marca)cbMarca.SelectedIndex;
            Bitmap image = new Bitmap(new Bitmap(pictureBox.Image), new Size(75,75));
            Producto producto = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);
            if(ruta != null)
            {
                producto.RutaImagen = ruta;
            }
            producto.Imagen = image;
             
            controller.AddProduct(producto);
        }
        // Muestra un diálogo de archivo para que el usuario seleccione una foto
        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.InitialDirectory = @"C:\";
            imageDialog.Title = "Selecciona una imagen.";
            imageDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if(imageDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(new Bitmap(imageDialog.FileName), new Size(75,75));
                ruta = @imageDialog.FileName;
                
            }
        }
    }
}
