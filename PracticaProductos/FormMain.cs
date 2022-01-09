using System.ComponentModel;

namespace PracticaProductos
{
    public partial class FormMain : Form
    {
        //private static Controller controller = Controller.GetInstance();
        private List<Producto> productos;
        List<int> codigos = new List<int>();
        public FormMain()
        {
            InitializeComponent();
            productos = new List<Producto>();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);   
            formAdd.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ProductsSelected())
            {
                FormModify formModify = new FormModify(this, ProductsToModify());
                formModify.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona los artículos que quieras modificar.");
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {    
            if (ProductsSelected())
            {   
                RemoveProductsInDataGridView();
                RemoveProducts();
                MessageBox.Show("Artículos eliminados.");
            }
            else
            {
                MessageBox.Show("No hay artículos seleccionados.");
            }
           
        }

        private void RemoveProducts()
        {
            List<Producto> productsToRemove = new List<Producto>();
            productos.ForEach(p =>
            {
                codigos.ForEach(c =>
                {
                    if(p.Cod == c)
                    {
                        productsToRemove.Add(p);
                    }
                });
            });
            productos.RemoveAll(p => productsToRemove.Contains(p));
        }
        private void RemoveProductsInDataGridView()
        {
            codigos.ForEach((c) =>
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if(Convert.ToInt32(row.Cells[0].Value) == c)
                    {
                        dgvProductos.Rows.Remove(row);
                    }
                }
            });
            
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }
        public void AddProduct(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine(producto.ToString());
            UpdateProducts();
        }
        public void UpdateProducts()
        {
            dgvProductos.Rows.Clear();
            foreach(Producto product in productos)
            {
                string[] fila = new string[7];
                fila[0] = product.Cod.ToString();
                fila[1] = product.Nombre.ToString();
                fila[2] = product.Precio.ToString();
                fila[3] = product.Descripcion.ToString();
                fila[4] = product.Stock.ToString();
                fila[5] = product.tipo.ToString();
                fila[6] = product.marca.ToString();
                dgvProductos.Rows.Add(fila);    
            }
        }

        private bool ProductsSelected()
        {
            bool selected = false;
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay ningún artículo.");
            } else
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[7].Value))
                    {
                        selected = true;
                        codigos.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                }
            }

            return selected;
        }
        private List<Producto> ProductsToModify()
        {
            List<Producto> productsToModify = new List<Producto>();
            productos.ForEach(p =>
            {
                codigos.ForEach(c =>
                {
                    if(p.Cod == c)
                    {
                        productsToModify.Add(p);
                    }
                });
            });
            return productsToModify;
        }
        public void SetProducts(List<Producto> productos)
        {
            this.productos = productos; 
            UpdateProducts();
        }
    }
}