using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{
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
