using MetroFramework.Forms;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.Usuarios;

namespace ventas
{
    public partial class crudusuario : MetroForm
    {
        public crudusuario(string nombre)
        {
            InitializeComponent();
         //   s.dgrid(dataGridView1, "select * from tipousuario");
            s.dgrid(dgvinfo, "select v.id,v.Nombre,v.ApellidoP,v.ApellidoM,v.Usuario,v.Password,c.Tipo as Rol from Usuario as v inner join Tipousuario as c on v.Tipousuario = c.id");
           s.populate(cbrol, "select * from tipousuario", "tipo");
            lblnombre.Text = nombre.ToString();
        }
        sql s = new sql();
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnagegar_Click(object sender, EventArgs e)
        {
       
        }

        private void dgvinfo_SelectionChanged(object sender, EventArgs e)
        {
           

        }

        private void dgvinfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgvinfo.CurrentRow.Cells[0].Value.ToString();

            txtnombre.Text = dgvinfo.CurrentRow.Cells[1].Value.ToString();
            txtAP.Text = dgvinfo.CurrentRow.Cells[2].Value.ToString();
            txtAM.Text = dgvinfo.CurrentRow.Cells[3].Value.ToString();
            txtusuario.Text = dgvinfo.CurrentRow.Cells[4].Value.ToString();
            txtcontrasena.Text = dgvinfo.CurrentRow.Cells[5].Value.ToString();
            cbrol.Text = dgvinfo.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                string ver = string.Format("select * from Usuario where id = '{0}'; if  @@ROWCOUNT = 1  begin RAISERROR ('Fields 3 cannot be null .',16,1); end", lblid.Text);
                s.Exe(ver);
                string add = string.Format("insert into Usuario values('{0}','{1}','{2}','{3}','{4}','{5}')", txtnombre.Text, txtAP.Text, txtAM.Text, txtusuario.Text, txtcontrasena.Text, (cbrol.SelectedIndex + 1));
                s.Exe(add);
                s.dgrid(dgvinfo, "select v.id,v.Nombre,v.ApellidoP,v.ApellidoM,v.Usuario,v.Password,c.Tipo as Rol from Usuario as v inner join Tipousuario as c on v.Tipousuario = c.id");
            }
            catch
            {
                MessageBox.Show("Usuario ya existe");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string upd = string.Format("update Usuario set Nombre = '{0}',ApellidoP = '{1}',ApellidoM = '{2}',Usuario='{3}',Password='{4}',Tipousuario='{5}' where id = '{6}'",txtnombre.Text,txtAP.Text,txtAM.Text,txtusuario.Text,txtcontrasena.Text,(cbrol.SelectedIndex+1),lblid.Text);
            s.Exe(upd);
            s.dgrid(dgvinfo, "select v.id,v.Nombre,v.ApellidoP,v.ApellidoM,v.Usuario,v.Password,c.Tipo as Rol from Usuario as v inner join Tipousuario as c on v.Tipousuario = c.id");

        }

        private void crudusuario_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string del = string.Format("delete from Usuario where id = '{0}'", lblid.Text);
            s.Exe(del);
            s.dgrid(dgvinfo, "select v.id,v.Nombre,v.ApellidoP,v.ApellidoM,v.Usuario,v.Password,c.Tipo as Rol from Usuario as v inner join Tipousuario as c on v.Tipousuario = c.id");

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            tipodeusuario t = new tipodeusuario();
            t.Show();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            MENU m = new MENU(lblnombre.Text);
            m.Show();
        }
    }
}
