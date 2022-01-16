namespace PracticaProductos
{
    // Formulario para modificar uno o varios productos.
    public partial class FormModify : Form
    {
        Controller controller;
        static int position = 0;
        private List<Producto> productsToModify, productsModified;
        string ruta;

        public FormModify(List<Producto> productsToModify)
        {
            position = 0;   
            this.productsToModify = productsToModify;
            controller = Controller.GetInstance();
            productsModified = new List<Producto>();
            InitializeComponent();
            ShowProduct(productsToModify[position]);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (productsModified.Count > 0)
            {
                controller.ModifyProducts(productsModified, productsModified);
            }
            Close();
        }
        // Si los datos son válidos, el producto se modificará y se pasará al siguiente producto seleccionado.
        // En caso contrario, se especificará a través de un diálogo que datos son incorrectos. 
        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    UpdateProduct();
                    if (NextProduct())
                    {
                        ShowProduct(productsToModify[position]);
                    }
                    else
                    {
                        MessageBox.Show("Has moficado todos los artículos.");
                        Close();
                        controller.ModifyProducts(productsToModify, productsModified);
                        
                    }

                }
            }
            catch(InvalidFormException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        // Selección de imagen para el producto a modificar
        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.InitialDirectory = @"C:\";
            imageDialog.Title = "Selecciona una imagen.";
            imageDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (imageDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(imageDialog.FileName);
                ruta = @imageDialog.FileName;
            }
        }
        // Actualiza la posición de la lista para mostrar después el siguiente producto a modificar
        private bool NextProduct()
        {
            bool nextElement = true;
            if (position <= productsToModify.Count - 1)
            {
                if (position == productsToModify.Count - 1)
                {
                    nextElement = false;
                }
            }
            position++;
            return nextElement;
        }
        // Muestra los valores del producto a modificar
        private void ShowProduct(Producto producto)
        {
            if (producto != null)
            {
                nupCodigo.Value = Convert.ToDecimal(producto.Cod);
                tbNombre.Text = producto.Nombre;
                nupPrecio.Value = Convert.ToDecimal(producto.Precio);
                tbDescripcion.Text = producto.Descripcion;
                nupStock.Value = Convert.ToDecimal(producto.Stock);
                cbTipo.Text = producto.Tipo.ToString();
                cbMarca.Text = producto.Marca.ToString();
                if(producto.Imagen != null)
                {
                    pictureBox.Image = producto.Imagen;

                }
            }
        }

        // Actualiza las propiedades del producto una vez modificados los valores
        private void UpdateProduct()
        {

            Producto producto = productsToModify[position];
            int cod = Convert.ToInt32(nupCodigo.Value);
            string nombre = tbNombre.Text;
            double precio = Convert.ToDouble(nupPrecio.Value);
            string descripcion = tbDescripcion.Text;
            int stock = Convert.ToInt32(nupStock.Value);
            Tipo tipo = (Tipo)cbTipo.SelectedIndex;
            Marca marca = (Marca)cbMarca.SelectedIndex;
            Bitmap image;

            Producto modifiedProduct = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);

            image = (Bitmap)pictureBox.Image;
            modifiedProduct.Imagen = image;
            modifiedProduct.RutaImagen = ruta;

            productsModified.Add(modifiedProduct);
        }
       
        // VALIDACIONES
        // En todos los campos que tienen alguna condición se comprueba a través del controlador, que verifica los datos introducidos

        // Validación de nombre
        private void tbNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (controller.ValidateName(tbNombre.Text))
            {
                errorModify.SetError(tbNombre, "");
            }
            else
            {
                errorModify.SetError(tbNombre, "Nombre no válido.");
                e.Cancel = true;
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Nombre no válido.");
            }
        }
        // Validación de precio
        private void nupPrecio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (controller.ValidatePrice(Convert.ToDouble(nupPrecio.Value)))
            {
                errorModify.SetError(nupPrecio, "");
            }
            else
            {
                errorModify.SetError(nupPrecio, "Precio no válido.");
                e.Cancel = true;
                MessageBox.Show("El campo Precio debe ser mayor a 0.", "Precio no válido.");
            }
        }
        // Validación de tipo
        private void cbTipo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (controller.ValidateTipo(cbTipo.Text))
            {
                errorModify.SetError(cbTipo, "");
            }
            else
            {
                errorModify.SetError(cbTipo, "Tipo no válido.");
                e.Cancel = true;
                MessageBox.Show("Tipo no válido. Debes seleccionar una de las opciones del desplegable.", "Tipo no válido.");
            }
        }
        // Validación de marca
        private void cbMarca_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (controller.ValidateMarca(cbMarca.Text))
            {
                errorModify.SetError(cbMarca, "");
            }
            else
            {
                errorModify.SetError(cbMarca, "Marca no válida.");
                e.Cancel = true;
                MessageBox.Show("Marca no válida. Debes seleccionar una de las opciones del desplegable.", "Marca no válido.");
            }
        }
        // Validación de formulario
        private bool ValidateForm()
        {
            if (!controller.ValidateName(tbNombre.Text))
            {
                errorModify.SetError(tbNombre, "Nombre no válido.");
                throw new InvalidFormException("El campo Nombre no puede estar vacío.");
            }

            if (!controller.ValidatePrice(Convert.ToDouble(nupPrecio.Value)))
            {
                errorModify.SetError(nupPrecio, "Código no válido.");
                throw new InvalidFormException("El campo Precio debe ser mayor a 0.");
            }

            if (!controller.ValidateTipo(cbTipo.Text))
            {
                errorModify.SetError(cbTipo, "Tipo no válido.");
                throw new InvalidFormException("Tipo no válido. Debes seleccionar una de las opciones del desplegable.");
            }

            if (!controller.ValidateMarca(cbMarca.Text))
            {
                errorModify.SetError(cbMarca, "Marca no válida.");
                throw new InvalidFormException("Marca no válida. Debes seleccionar una de las opciones del desplegable.");
            }
            return true;
            
        }

        
    }
}
    