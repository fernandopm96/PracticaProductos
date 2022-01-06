namespace PracticaProductos
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
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
    }
}