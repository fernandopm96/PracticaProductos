namespace PracticaProductos
{
    public partial class FormModify : Form
    {
        Controller controller;
        static int position = 0;
        private List<Producto> productosToModify, productsModified;
        string ruta;

        Bitmap image;

        public FormModify(List<Producto> productsToModify)
        {
            this.productosToModify = productsToModify;
            controller = Controller.GetInstance();
            productsModified = new List<Producto>();
            InitializeComponent();
            ShowProduct(productosToModify[position]);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    UpdateProduct();
                    if (NextProduct())
                    {
                        ShowProduct(productosToModify[position]);
                    }
                    else
                    {
                        controller.UpdateProducts();
                        MessageBox.Show("Has moficado todos los artículos.");
                        controller.ModifyProducts(productsModified);
                        controller.UpdateProducts();
                        Close();
                    }

                }
            }
            catch(InvalidFormException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private bool NextProduct()
        {
            bool nextElement = true;
            if (position <= productosToModify.Count - 1)
            {
                if (position == productosToModify.Count - 1)
                {
                    nextElement = false;
                }
            }
            position++;
            return nextElement;
        }

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
                pictureBox.Image = producto.Imagen;
            }
        }
        

        private void tbNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateName();
        }
        private void nupPrecio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidatePrice();
        }
        private void tbDescripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateDescripcion();
        }

        private void cbTipo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateType();
        }

        private void cbMarca_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateMarca();
        }
       

        private bool ValidateName()
        {
            bool valid = true;
            if (tbNombre.Text == "")
            {
                errorModify.SetError(tbNombre, "No puedes dejar el nombre vacío.");
                throw new InvalidFormException("No puedes dejar el nombre vacío.");
                valid = false;
            }
            else
            {
                errorModify.SetError(tbNombre, "");
            }
            return valid;
        }
        

        private bool ValidatePrice()
        {
            bool valid = true;
            if (nupPrecio.Value == 0)
            {
                errorModify.SetError(nupPrecio, "Debes introducir un precio mayor que 0.");
                throw new InvalidFormException("Debes introducir un precio mayor que 0.");
            }
            else
            {
                errorModify.SetError(nupPrecio, "");
            }
            return valid;
        }

        private bool ValidateDescripcion()
        {
            bool valid = true;
            if (tbDescripcion.Text == "")
            {
                errorModify.SetError(tbDescripcion, "Debes introducir una descripción.");
                throw new InvalidFormException("Debes introducir una descripción.");
            }
            else
                errorModify.SetError(tbDescripcion, "");
            return valid;
        }

        private bool ValidateType()
        {
            List<string> tipos = new List<string> { "Compacto", "Deportivo", "Berlina", "Suv", "Todoterreno", "Monovolumen", "Biplaza", "Furgoneta"};
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
                errorModify.SetError(cbTipo, "Tipo no válido.");
                throw new InvalidFormException("El tipo no es válido.");
            }
            else
            {
                errorModify.SetError(cbMarca, "");
            }
            return valid;
        }
        private bool ValidateMarca()
        {
            List<string> marcas = new List<string> { "Renault", "Citroen", "Peugeot", "BMW", "Audi", "Mercedes", "Porsche", "Ferrari", "Ford", "Volkswagen", "Kia", "Honda", "Dacia" };
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
                errorModify.SetError(cbMarca, "Marca no válida.");
                throw new InvalidFormException("El tipo no es válido.");
            }
            else
            {
                errorModify.SetError(cbMarca, "");
            }
            return valid;
        }

        private bool ValidateForm()
        {
            bool valid = false;
            bool validName = ValidateName();
            bool validPrice = ValidatePrice();
            bool validDescription = ValidateDescripcion();
            bool validTipo = ValidateType();
            bool validMarca = ValidateMarca();
            if (validName && validPrice && validDescription && validTipo && validMarca)
            {
                valid = true;
            }
            return valid;
        }

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

        
        private void UpdateProduct()
        {

            Producto producto = productosToModify[position];
            int cod = Convert.ToInt32(nupCodigo.Value);
            string nombre = tbNombre.Text;
            double precio = Convert.ToDouble(nupPrecio.Value);
            string descripcion = tbDescripcion.Text;
            int stock = Convert.ToInt32(nupStock.Value);
            Tipo tipo = (Tipo)cbTipo.SelectedIndex;
            Marca marca = (Marca)cbMarca.SelectedIndex;
            Bitmap image = null;

            Producto modifiedProduct = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);
          
            image = (Bitmap)pictureBox.Image;
            modifiedProduct.Imagen = image;
            modifiedProduct.RutaImagen = ruta;

            productsModified.Add(modifiedProduct);
        }
    }
}
    