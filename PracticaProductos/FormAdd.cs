using System;
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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Artículo registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Debes rellenar los campos obligatorios.");
            }
        }

        private void tbCodigo_Validating(object sender, CancelEventArgs e)
        {
            if(tbCodigo.Text == "")
            {
                e.Cancel = true;
                tbCodigo.Select(0, tbCodigo.TextLength);
                errorProviderAdd.SetError(tbCodigo, "Este campo es obligatorio");
            }
        }

        private void tbCodigo_Validated(object sender, EventArgs e)
        {
            errorProviderAdd.SetError(tbCodigo, "");
        }

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if(tbNombre.Text == "")
            { 
                e.Cancel = true;
                tbNombre.Select(0, tbNombre.TextLength);
                errorProviderAdd.SetError(tbNombre, "Este campo es obligatorio");
            }
        }
        private void tbNombre_Validated(object sender, EventArgs e)
        {
            errorProviderAdd.SetError(tbNombre, "");
        }

       
        private void nudPrecio_Validating(object sender, CancelEventArgs e)
        {
            if(nudPrecio.Value <= 0)
            {
                e.Cancel=true;
                errorProviderAdd.SetError(tbPrecio, "Debes introducir un número válido.");
            }
        }
        private void nudPrecio_Validated(object sender, EventArgs e)
        {
            errorProviderAdd.SetError(tbPrecio, "");
        }

    }
}
