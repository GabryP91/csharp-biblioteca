using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    //classe figlia di documento
    internal class Libro:Documento
    {
        //attributi
        private int num_pag;

        //metodi
        public int Num_pag
        {
            get { return num_pag; }
            set { num_pag = value; }
        }
    }
}
