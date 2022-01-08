using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{
    public class Controller
    {

        private static Controller controller = new Controller();
        private static FormMain formMain;
      /*  public BindingList<Producto> ListaProductos { get; set; } = new BindingList<Producto>();
        private BindingList<Producto> productos = new BindingList<Producto>();
        public BindingSource FuenteDatos { get; set; } = new BindingSource();*/

        public List<Producto> productos { get; set; }

        public static Controller GetInstance()
        {
            return controller;
        }
        private Controller()
        {
          //  formMain = FormMain.GetInstance();
            productos = new List<Producto>();
        }
        public void AddProduct(Producto producto)
        {
            productos.Add(producto);
            UpdateProducts();
        }
        public void UpdateProducts()
        {
            formMain.UpdateProducts();  
        }
    }
}
