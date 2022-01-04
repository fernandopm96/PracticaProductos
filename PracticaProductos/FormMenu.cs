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
    public partial class FormMenu : Form
    {
        FormList formMain;
        FormAdd formAdd;
        FormRemove formRemove;
        FormModify formModify;

        public FormMenu()
        {
            InitializeComponent();
            formMain = new FormList();
            formMain.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if(formMain == null)
            {
                formMain = new FormList();
            }
            formMain.Visible = true;
            this.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(formAdd == null)
            {
                formAdd = new FormAdd();
            }
            formAdd.Visible = true;
            this.Visible = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if(formModify == null)
            {
                formModify = new FormModify();
            }
            formModify.Visible = true;
            this.Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(formRemove == null)
            {
                formRemove = new FormRemove();
            }
            formRemove.Visible = true;
            Visible = false;
        }
        public void setMainVisible()
        {
            formMain.Visible = !formMain.Visible;
        }
    }
}
