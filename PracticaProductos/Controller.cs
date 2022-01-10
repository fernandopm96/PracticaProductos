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
       
      
    }
}
