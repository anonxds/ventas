using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas.Usuarios
{
    public partial class tipodeusuario : MetroForm
    {
        sql s = new sql();

        public tipodeusuario()
        {
            InitializeComponent();
            s.dgrid(dgvinfo, "select id,tipo as Nombre from tipousuario");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string add = string.Format("insert into tipousuario values ('{0}')",txtnombre.Text);
            s.Exe(add);
            s.dgrid(dgvinfo, "select id,tipo as Nombre from tipousuario");

        }

        private void dgvinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgvinfo.CurrentRow.Cells[0].Value.ToString();

            txtpostnombre.Text = dgvinfo.CurrentRow.Cells[1].Value.ToString();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string del = string.Format("delete from tipousuario where tipo = '{0}'",txtpostnombre.Text);
            s.Exe(del);
            s.dgrid(dgvinfo, "select id,tipo as Nombre from tipousuario");

        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            string ups = string.Format("update tipousuario set tipo = '{0}' where id = '{1}'",txtpostnombre.Text,lblid.Text);
            s.Exe(ups);
            s.dgrid(dgvinfo, "select id,tipo as Nombre from tipousuario");

        }
    }
}
