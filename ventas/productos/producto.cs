using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas.productos
{
   public abstract class producto
    {
        protected string descripcion = "Producto generico";
        public virtual string Descripcion()
        {
            return descripcion;
        }
        public abstract double precio();
   

    }
}
