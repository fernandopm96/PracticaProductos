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
    public partial class FormOrder : Form
    {
        Controller controller;
        List<Producto> productos, orderedProducts;
        public FormOrder()
        {
            controller = Controller.GetInstance();
            productos = controller.products;
            orderedProducts = new List<Producto>();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbCampos.Text != "Elige un campo")
            {
                OrderProducts();
                controller.SetOrderedProducts(orderedProducts);
            }
            else
            {
                MessageBox.Show("Elige un campo para ordenar. ");
            }
            Close();
        }

        private void OrderProducts()
        {
            switch (cbCampos.Text)
            {
                case "Código": OrderByCod(); break;
                case "Nombre": OrderByName(); break;
                case "Precio": OrderByPrice(); break;
                case "Stock": OrderByStock(); break;
                case "Tipo": OrderByType(); break;
                case "Marca": OrderByMarca(); break;
            }
        }
        private void OrderByCod()
        {
            if (rbAsc.Checked)
            {
                orderedProducts = productos.OrderBy(producto => producto.Cod).ToList<Producto>();
            }
            else
            {
                orderedProducts = productos.OrderByDescending(producto => producto.Cod).ToList<Producto>();
            }
            
        }
        private void OrderByName()
        {
            if (rbAsc.Checked)
            {
                orderedProducts = productos.OrderBy(producto => producto.Nombre).ToList<Producto>();
            }
            else
            {
                orderedProducts = productos.OrderByDescending(producto => producto.Nombre).ToList<Producto>();
            }
        }
        private void OrderByPrice()
        {
            if (rbAsc.Checked)
            {
                orderedProducts = productos.OrderBy(producto => producto.Precio).ToList<Producto>();
            }
            else
            {
                orderedProducts = productos.OrderByDescending(producto => producto.Precio).ToList<Producto>();
            }
        }
        private void OrderByStock()
        {
            if (rbAsc.Checked)
            {
                orderedProducts = productos.OrderBy(producto => producto.Stock).ToList<Producto>();
            }
            else
            {
                orderedProducts = productos.OrderByDescending(producto => producto.Stock).ToList<Producto>();
            }
        }
        private void OrderByType()
        {
            if (rbAsc.Checked)
            {
                orderedProducts = productos.OrderBy(producto => producto.Tipo.ToString()).ToList<Producto>();
            }
            else
            {
                orderedProducts = productos.OrderByDescending(producto => producto.Tipo.ToString()).ToList<Producto>();
            }
        }
        private void OrderByMarca()
        {
            if (rbAsc.Checked)
            {
                orderedProducts = productos.OrderBy(producto => producto.Marca.ToString()).ToList<Producto>();
            }
            else
            {
                orderedProducts = productos.OrderByDescending(producto => producto.Marca.ToString()).ToList<Producto>();
            }
        }
    }
}
