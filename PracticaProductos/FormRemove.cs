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
    public partial class FormRemove : Form
    {
        public FormRemove()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(btEliminar.Text == "Buscar")
            {
                if (nupCodigo.Value <= 0)
                {
                    MessageBox.Show("Debes de introducir un valor válido.");
                }
                else
                {
                    btEliminar.Text = "Eliminar";
                }
            } 
            else
            {
                MessageBox.Show("Artículo eliminado.");
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
