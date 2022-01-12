namespace PracticaProductos
{
    public partial class FormModify : Form
    {
        FormMain formMain;
        static int position = 0;
        private List<Producto> productos, productsModified;

        public FormModify(FormMain formMain, List<Producto> productos)
        {
            this.formMain = formMain;
            this.productos = productos;
            productsModified = new List<Producto>();
            InitializeComponent();
            SetProduct(productos[position]);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                UpdateProduct();
                if (NextProduct())
                {
                    SetProduct(productos[position]);
                }
                else
                {
                    formMain.SetProducts(productsModified);
                    MessageBox.Show("Has moficado todos los artículos.");
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Algún campo no es válido. ");
            }

        }
        private bool NextProduct()
        {
            bool nextElement = true;


            if (position <= productos.Count - 1)
            {
                if (position == productos.Count - 1)
                {
                    nextElement = false;
                }
            }
            position++;
            return nextElement;
        }

        private void SetProduct(Producto producto)
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
        private void UpdateProduct()
        {

            Producto producto = productos[position];
            int cod = Convert.ToInt32(nupCodigo.Value);
            string nombre = tbNombre.Text;
            double precio = Convert.ToDouble(nupPrecio.Value);
            string descripcion = tbDescripcion.Text;
            int stock = Convert.ToInt32(nupStock.Value);
            Tipo tipo = (Tipo)cbTipo.SelectedIndex;
            Marca marca = (Marca)cbMarca.SelectedIndex;
            Bitmap imagen = null;
            if(pictureBox.Image != null)
            {
                imagen = (Bitmap)pictureBox.Image;
            }
            if (cod == producto.Cod && nombre == producto.Nombre && precio == producto.Precio
                && descripcion == producto.Descripcion && stock == producto.Stock 
                && tipo.ToString() == producto.Tipo.ToString() 
                && marca.ToString() == producto.Marca.ToString()
                && pictureBox.Image == producto.Imagen)
            {
                productsModified.Add(producto);
            }
            else
            {
                Producto modifiedProduct = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);
                modifiedProduct.Imagen = imagen;
                productsModified.Add(modifiedProduct);
            }

        }

        private void nupCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateCod();
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
        private bool ValidateCod()
        {
            bool valid = true;
            if (nupCodigo.Value == 0)
            {
                errorModify.SetError(nupCodigo, "Debes introducir un código mayor que 0.");
                valid = false;
            }
            else
            {
                errorModify.SetError(nupCodigo, "");
                if (formMain.CodAvailable(Convert.ToInt32(nupCodigo.Value)))
                {
                    valid = false;
                    MessageBox.Show("El código introducido ya pertenece a algún artículo registrado.");
                }
            }
            return valid;
        }

        private bool ValidateName()
        {
            bool valid = true;
            if (tbNombre.Text == "")
            {
                errorModify.SetError(tbNombre, "No puedes dejar el nombre vacío.");
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
                valid = false;
            }
            else
            {
                errorModify.SetError(nupCodigo, "");
            }
            return valid;
        }

        private bool ValidateDescripcion()
        {
            bool valid = true;
            if (tbDescripcion.Text == "")
            {
                errorModify.SetError(tbDescripcion, "Debes introducir una descripción.");
                valid = false;
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
            }
            else
            {
                errorModify.SetError(cbMarca, "");
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
            }
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
            if (validCod && validName && validPrice &&validDescription && validTipo && validMarca)
            {
                valid = true;
            }
            return valid;
        }
    }
}
    