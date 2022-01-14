using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{
    public class ImportCsvException: Exception
    {
        public ImportCsvException()
        {

        }
        public ImportCsvException(string msg) : base(msg)
        {

        }
        public ImportCsvException(string msg, Exception ex) : base(msg, ex)
        {

        }
    }
}
