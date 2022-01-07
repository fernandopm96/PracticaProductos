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
        private FormMain formMain = FormMain.GetInstance();
        public List<Producto> productos { get; set; } = new List<Producto>();

        public Controller()
        {
            productos = new List<Producto>();   
        }
        public void AddProduct(Producto producto)
        {
            productos.Add(producto);
            formMain.UpdateProducts();
            
        }
    }
}
