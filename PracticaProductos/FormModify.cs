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
            UpdateProduct();
            if (NextProduct())
            {
                SetProduct(productos[position]);
            } else
            {
                formMain.SetProducts(productsModified);
                MessageBox.Show("Has moficado todos los artículos.");
                Close();
            }
        }
        private bool NextProduct()
        {
            bool nextElement = true;
            
            
            if(position <= productos.Count-1)
            {
                if(position == productos.Count-1)
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
                cbTipo.Text = producto.tipo.ToString();
                cbMarca.Text = producto.marca.ToString();
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
            if (cod == producto.Cod && nombre == producto.Nombre && precio == producto.Precio &&
                descripcion == producto.Descripcion && stock == producto.Stock && 
            tipo.ToString() == producto.tipo.ToString() && marca.ToString() == producto.marca.ToString())
            {
                MessageBox.Show("No has realizado ningún cambio.");
                productsModified.Add(producto);
            }
            else
            {
                MessageBox.Show("Has realizado algún cambio.");
                Producto modifiedProduct = new Producto(cod, nombre, precio, descripcion, stock, tipo, marca);
                productsModified.Add(modifiedProduct);
            }   
            
        }
    }
}
