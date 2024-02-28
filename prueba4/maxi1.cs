using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba4
{
    public class maxi1
    {
        public int codigo { set; get; }

        public string nom {  set; get; }

        public int cant {  set; get; }

        public double pre {  set; get; }

        public maxi1 () { }

        public maxi1 (int codigo, string nom, int cant, double pre)
        {
            this.codigo = codigo;
            this.nom = nom;
            this.cant = cant;
            this.pre = pre;
        }
    }
}
