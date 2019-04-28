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
    class PorEntrada : ifiltro
    {
        public void filtrar(BunifuCustomDataGrid dgv, TextBox txt)
        {
            sql s = new sql();
            s.dgrid(dgv, "select * from Entrada");

            (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{0}%'", txt.Text);

        }
    }
}
