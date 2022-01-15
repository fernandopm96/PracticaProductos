using System.ComponentModel;

namespace PracticaProductos
{
    public partial class FormAdd : Form
    {
        FormMain formMain;
        Controller controller;
        string ruta;

        public FormAdd(FormMain formMain)
        {
            this.formMain = formMain;
            controller = Controller.GetInstance();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

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
        private void nupCodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (controller.ValidateCod(Convert.ToInt32(nupCodigo.Value)))
                    errorAdd.SetError(nupCodigo, "");
            } catch(InvalidFormException ex)
            {
                errorAdd.SetError(nupCodigo, ex.Message);
                MessageBox.Show(ex.Message, "Código no válido.");
                e.Cancel = true;
            }
        }
        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (controller.ValidateName(tbNombre.Text))
                    errorAdd.SetError(tbNombre, "");
            }
            catch (InvalidFormException ex)
            {
                errorAdd.SetError(tbNombre, ex.Message);
                MessageBox.Show(ex.Message, "Nombre no válido.");
                e.Cancel = true;
            }
        }
        private void nupPrecio_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (controller.ValidatePrice(Convert.ToDouble(nupPrecio.Value)))
                    errorAdd.SetError(nupPrecio, "");
            }
            catch (InvalidFormException ex)
            {
                errorAdd.SetError(nupPrecio, ex.Message);
                MessageBox.Show(ex.Message, "Precio no válido.");
                e.Cancel = true;
            }
        }
        private void cbTipo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (controller.ValidateTipo(cbTipo.Text))
                    errorAdd.SetError(cbTipo, "");
            }
            catch (InvalidFormException ex)
            {
                errorAdd.SetError(cbTipo, ex.Message);
                MessageBox.Show(ex.Message, "Tipo no válido.");
                e.Cancel = true;
            }
        }
        private void cbMarca_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (controller.ValidateMarca(cbMarca.Text))
                    errorAdd.SetError(cbMarca, "");
            }
            catch (InvalidFormException ex)
            {
                errorAdd.SetError(cbMarca, ex.Message);
                MessageBox.Show(ex.Message, "Marca no válida.");
                e.Cancel = true;
            }
        }
        private bool ValidateForm()
        {
            bool valid = false;
            bool validCod = controller.ValidateCod(Convert.ToInt32(nupCodigo.Value));
            bool validName = controller.ValidateName(tbNombre.Text);
            bool validPrice = controller.ValidatePrice(Convert.ToDouble(nupPrecio.Value));
            bool validTipo = controller.ValidateTipo(cbTipo.Text);
            bool validMarca = controller.ValidateMarca(cbMarca.Text);
            if (validCod && validName && validPrice && validTipo && validMarca)
            {
                valid = true;
            }
            return valid;
        }
        /*
        private bool ValidateCod()
        {
            bool valid = true;
            if (nupCodigo.Value <= 0)
            {
                
                throw new InvalidFormException("Debes introducir un código mayor que 0.");
            }   
            else
            {
                errorAdd.SetError(nupCodigo, "");
                if (!formMain.CodAvailable(Convert.ToInt32(nupCodigo.Value)))
                {
                    errorAdd.SetError(nupCodigo, "El código introducido ya pertenece a algún artículo registrado.");
                    throw new InvalidFormException("El código introducido ya pertenece a algún artículo registrado.");
                    
                }
            }
            return valid;            
        }

        private bool ValidateName()
        {
            bool valid = true;
            if (tbNombre.Text == "")
            {
                errorAdd.SetError(tbNombre, "No puedes dejar el nombre vacío.");
                throw new InvalidFormException("No puedes dejar el nombre vacío.");
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
            if (nupPrecio.Value == 0)
            {
                errorAdd.SetError(nupPrecio, "Debes introducir un precio mayor que 0.");
                throw new InvalidFormException("El precio no puede ser 0..");
            }
            else
            {
                errorAdd.SetError(nupPrecio, "");
            }
            return valid;
        }
       
        private bool ValidateTipo()
        {
            List<string> tipos = new List<string> { "Compacto", "Deportivo", "Berlina", "Suv", "Todoterreno", "Monovolumen", "Biplaza", "Furgoneta" };
            bool valid = false;
            foreach(string s in tipos)
            {
                if (cbTipo.Text == s)
                {
                    valid = true;
                }
            }
            if (!valid)
            {
                errorAdd.SetError(cbTipo, "Tipo no válido.");
                throw new InvalidFormException("Selecciona un tipo de vehículo válido.");         
            }
            else
            {
                errorAdd.SetError(cbTipo, "");
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
                errorAdd.SetError(cbMarca, "Marca no válida.");
                throw new InvalidFormException("Selecciona una marca de vehículo válido.");
            } else
            {
                errorAdd.SetError(cbMarca, "");
            }
            return valid;
        }*/


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
                image = (Bitmap)pictureBox.Image;
                producto.Imagen = image;
                producto.RutaImagen = ruta;
            } 
            controller.AddProduct(producto);
        }

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
