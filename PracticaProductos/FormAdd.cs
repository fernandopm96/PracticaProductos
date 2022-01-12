﻿using System.ComponentModel;

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
                var confirmResult = MessageBox.Show("Producto registrado correctamente.\n¿Quieres introducir más artículos?", "Añadir producto", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    Close();
                }
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
                if (!formMain.CodAvailable(Convert.ToInt32(nupCodigo.Value)))
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
            if (nupPrecio.Value == 0)
            {
                errorAdd.SetError(nupPrecio, "Debes introducir un precio mayor que 0.");
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
                errorAdd.SetError(tbDescripcion, "Debes introducir una descripción.");
                valid = false;
            }
            else
                errorAdd.SetError(tbDescripcion, "");
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
            } else
            {
                errorAdd.SetError(cbMarca, "");
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
            bool validTipo = ValidateTipo();
            bool validMarca = ValidateMarca();  
            if(validCod && validName && validPrice &&validDescription && validTipo && validMarca)
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
            Bitmap image = null;
            if(pictureBox.Image != null)
            {
                image = (Bitmap)pictureBox.Image;
            }
            Producto producto = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);
            if(image != null)
            {
                producto.Imagen = image;
            }
            formMain.AddProduct(producto);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageDialog = new OpenFileDialog();
            imageDialog.InitialDirectory = @"C:\";
            imageDialog.Title = "Selecciona una imagen.";
            imageDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if(imageDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(imageDialog.FileName);
            }
        }
    }
}
