using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{
    // Excepción lanzada cuando algún formulario no es válido
    public class InvalidFormException : Exception
    {
        public InvalidFormException()
        {

        }
        public InvalidFormException(string msg): base(msg){

        }
        public InvalidFormException(string msg, Exception ex) : base(msg, ex)  
        {
            
        }
    }
}
