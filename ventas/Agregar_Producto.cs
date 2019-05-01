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

namespace ventas
{
    public partial class Agregar_Producto : MetroForm
    {
        sql s = new sql();
        public Agregar_Producto(string nombre)
        {
            InitializeComponent();
            porcion();
            lblnombre.Text = nombre.ToString();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                string pro = string.Format("insert into productos values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    txtproucto.Text, (cbTipo.SelectedIndex + 1), txtporcion.Text, txtcantidad.Text, 0, txtprecio.Text,1);
                s.Exe(pro);
                string ent = string.Format("insert into Entrada values ('{0}','{1}','{2}')",txtproucto.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm"),"Producto Agregado");
                s.Exe(ent);
                MessageBox.Show("Producto agregado Exitosamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error "+ex);
            }
        }
        public void porcion()
        {
            s.populate(cbTipo, "select * from Porcion", "Nombre");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MENU m = new MENU(lblnombre.Text);
            m.Show();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            CrudProductos c = new CrudProductos(lblnombre.Text);
            c.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Receta r = new Receta(lblnombre.Text);
            r.Show();
        }
    }
}
