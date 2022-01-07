using System.ComponentModel;

namespace PracticaProductos
{
    public partial class FormMain : Form
    {
        private static FormMain formMain = new FormMain();
        private Controller controller = new Controller();
        public FormMain()
        {
            InitializeComponent();
        }
        public static FormMain GetInstance()
        {
            return formMain;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();   
            formAdd.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormModify formModify = new FormModify();
            formModify.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            FormRemove formRemove = new FormRemove();   
            formRemove.ShowDialog();
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
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
        }
        public void UpdateProducts()
        {
            List<Producto> productos = controller.productos;
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
    }
}