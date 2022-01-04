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
    public partial class FormModify : Form
    {
        public FormModify()
        {
            InitializeComponent();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if(btModificar.Text == "Buscar")
            {
                if (nupCodigo.Value <= 0)
                {
                    MessageBox.Show("Debes de introducir un valor válido.");
                }
                else
                {
                    btModificar.Text = "Modificar";
                    MessageBox.Show("Modifica los datos del artículo seleccionado.");
                }
            }

            else
            {
                MessageBox.Show("Artículo modificado.");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
