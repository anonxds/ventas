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
    class Porusuario : ifiltro
    {
        public void filtrar(BunifuCustomDataGrid dgv, TextBox txt)
        {
            sql s = new sql();
            s.dgrid(dgv, "select v.id,v.Nombre,v.ApellidoP as Apellido_Paterno ,v.ApellidoM as Apellido_Materno ,v.Usuario,v.Password as Contrasena ,c.Tipo from Usuario as v inner join Tipousuario as c on v.Tipousuario = c.id");
            (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre] LIKE '%{0}%'or [Apellido_Paterno] LIKE '%{1}%' ", txt.Text,txt.Text);

        }
    }
}
