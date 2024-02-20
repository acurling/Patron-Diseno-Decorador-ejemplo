using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp9
{
    abstract class ClsBebida
    {
        private string Descripcion { get; set; }

        public ClsBebida( string descripcion) 
        {
                Descripcion = "Bebida";
        }

        public virtual string GetDescripcion()
        {
            return this.Descripcion;
        }

        public abstract double precio();
    }
}
