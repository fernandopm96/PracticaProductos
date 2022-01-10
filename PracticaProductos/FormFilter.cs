using System;
using System.Collections;
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
    public partial class FormFilter : Form
    {
        FormMain formMain;
        List<Producto> productos, productosFiltrados;
        Dictionary<string, string?> filterProducts = new Dictionary<string, string?>();
        public FormFilter(FormMain formMain, List<Producto> productos)
        {
            this.formMain = formMain;
            this.productos = productos;
            InitializeComponent();
            filterProducts.Add("Cod", null);
            filterProducts.Add("Nombre", null);
            filterProducts.Add("Precio", null);
            filterProducts.Add("Descripcion", null);
            filterProducts.Add("Stock", null);
            filterProducts.Add("Tipo", null);
            filterProducts.Add("Marca", null);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            Verify();
            SearchProducts();
            formMain.SetProducts(productosFiltrados);
        }

        
        private void cbCodigo_Changed(object sender, EventArgs e)
        {
            if (cbCodigo.Checked)
            {
                nupCodigo.Enabled = true;
            } else
            {
                nupCodigo.Enabled = false;  
            }
        }

        private void cbNombre_Changed(object sender, EventArgs e)
        {
            if (cbNombre.Checked)
            {
                tbNombre.Enabled = true;
            } else
            {
                tbNombre.Enabled = false;   
            }
        }

        private void cbPrecio_Changed(object sender, EventArgs e)
        {
            if (cbPrecio.Checked)
            {
                nupPrecio.Enabled = true;
            } else
            {
                nupPrecio.Enabled = false;
            }
        }

        private void cbDescripcion_Changed(object sender, EventArgs e)
        {
            if (cbDescripcion.Checked)
            {
                tbDescripcion.Enabled = true;
            } else
            {
                tbDescripcion.Enabled = false;  
            }
        }

        private void cbStock_Changed(object sender, EventArgs e)
        {
            if (cbStock.Checked)
            {
                nupStock.Enabled = true;
            }
            else
            {
                nupStock.Enabled = false;
            }
        }

        private void cbTipo_Changed(object sender, EventArgs e)
        {
            if (cbTipo.Checked)
            {
                comBoxTipo.Enabled = true;
            }
            else
            {
                comBoxTipo.Enabled = false;
            }
        }

        private void cbMarca_Changed(object sender, EventArgs e)
        {
            if (cbMarca.Checked)
            {
                comBoxMarca.Enabled = true;
            }
            else
            {
                comBoxMarca.Enabled = false;
            }
        }

        private void Verify()
        {
            if (nupCodigo.Enabled)
            {
                filterProducts["Cod"] = nupCodigo.Value.ToString();
            }
            if (tbNombre.Enabled)
            {
                filterProducts["Nombre"] = tbDescripcion.Text;
            }
            if (nupPrecio.Enabled)
            {
                filterProducts["Precio"] = nupPrecio.Value.ToString();

            }
            if (tbDescripcion.Enabled)
            {
                filterProducts["Descripcion"] = tbDescripcion.Text;
            }
            if (nupStock.Enabled)
            {
                filterProducts["Precio"] = nupStock.Value.ToString();
            }
            if (comBoxTipo.Enabled)
            {
                filterProducts["Tipo"] = comBoxTipo.Text;
            }
            if (comBoxMarca.Enabled)
            {
                filterProducts["Marca"] = comBoxMarca.Text;
            }
        }

        private void SearchProducts()
        {
            if (filterProducts["Cod"] != null)
                productosFiltrados = productos.Where(p => p.Cod.Equals(Convert.ToInt32(filterProducts["Cod"]))).ToList();
            if (filterProducts["Nombre"] != null)
                productosFiltrados = productos.Where(p => p.Nombre.Equals(filterProducts["Nombre"])).ToList();
            if (filterProducts["Precio"] != null)
                productosFiltrados = productos.Where(p => p.Precio.Equals(Convert.ToDouble(filterProducts["Precio"]))).ToList();
            if (filterProducts["Descripcion"] != null)
                productosFiltrados = productos.Where(p => p.Descripcion.Equals(filterProducts["Descripcion"])).ToList();
            if (filterProducts["Stock"] != null)
                productosFiltrados = productos.Where(p => p.Stock.Equals(Convert.ToInt32(filterProducts["Stock"]))).ToList();
            if (filterProducts["Tipo"] != null)
                productosFiltrados = productos.Where(p => p.tipo.ToString().Equals(filterProducts["Tipo"])).ToList();
            if (filterProducts["Marca"] != null)
                productosFiltrados = productos.Where(p => p.marca.ToString().Equals(filterProducts["Marca"])).ToList();
        }
    }
}
