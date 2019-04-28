using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace ventas.filtros
{
    class Porinventario : ifiltro
    {
        public void filtrar(BunifuCustomDataGrid dgv,TextBox txt)
        {
            sql s = new sql();
            s.dgrid(dgv, "select v.nombre,c.Nombre as Medida,v.Porcion,v.precio,v.Cantidad from productos as v inner join Porcion as c on v.TipoPorcion = c.id ");
            (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[nombre] LIKE '%{0}%'", txt.Text);

        }
    }
}
