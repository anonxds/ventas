using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas.productos
{
    class leche : producto
    {
        int precios;
        sql s = new sql();
        public leche()
        {
            descripcion = "leche";
        }

        public override double precio()
        {

            s.pro("leche",precios.ToString());

            return precios;
        }
    }
}
