namespace PracticaProductos
{
    public partial class formMain : Form
    {
        FormAdd formAdd;
        FormModify formModify;
        FormRemove formRemove;
        public formMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(formAdd == null)
            {
                formAdd = new FormAdd();
            }   
            formAdd.Visible = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (formModify == null)
            {
                formModify = new FormModify();
            }
            formModify.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (formRemove == null)
            {
                formRemove = new FormRemove();
            }
            formRemove.Visible = true;

        }
    }
}