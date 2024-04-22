using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    //classe figlia di documento
    internal class DVD:Documento
    {
        //attributi
        private int durata;

        //metodi
        public int Durata
        {
            get { return durata; }
            set { durata = value; }
        }
    }
}
