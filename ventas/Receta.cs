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

namespace ventas
{
    public partial class Receta : MetroForm
    {
        sql db = new sql();
        public Receta(string nombre)
        {
            InitializeComponent();
            productos();
            lblnombre.Text = nombre.ToString();
        }
        List<int> _cantidad = new List<int>();
        List<string> _nombre = new List<string>();
        List<string> _listado = new List<string>();
        List<double> _precio = new List<double>();
        public void productos()
        {
            db.populate(cbingredientes,"select * from productos where Existencia = 1","nombre");
        }
      

        private void btnagregarI_Click(object sender, EventArgs e)
        {
            double p = double.Parse(txtcantidad.Text) * double.Parse(lblprecioP.Text);
            listado.DataSource = null;
            _precio.Add(p);
            _cantidad.Add(int.Parse(txtcantidad.Text));
            _nombre.Add(cbingredientes.Text);
            _listado.Add(cbingredientes.Text +"\t x"+txtcantidad.Text);
            listado.DataSource = _listado;
            string upd = string.Format("update productos set qty = '{0}' + qty where nombre = '{1}'",txtcantidad.Text,cbingredientes.Text);
            db.Exe(upd);
            lblprecio.Text = _precio.Sum().ToString();
        }

        private void listado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string upd = string.Format("update productos set qty =  qty - '{0}' where nombre = '{1}'", _cantidad[listado.SelectedIndex].ToString(), _nombre[listado.SelectedIndex].ToString());
                db.Exe(upd);
                _precio.RemoveAt(listado.SelectedIndex);
                _nombre.RemoveAt(listado.SelectedIndex);
                _cantidad.RemoveAt(listado.SelectedIndex);
                _listado.RemoveAt(listado.SelectedIndex);
                listado.DataSource = null;
                listado.DataSource = _listado;
                lblprecio.Text = _precio.Sum().ToString();
            }
            catch
            {
                MessageBox.Show("No hay elementos por quitar");
            }
        }

        private void btnconfirma_Click(object sender, EventArgs e)
        {
            try
            {
                string trans = string.Format("update productos set cantidad = cantidad - (qty * '{0}')", txtcantidadP.Text);
                db.Exe(trans);
                string ver = string.Format("update productos set Existencia = 0 where Cantidad = 0");
                db.Exe(ver);
                string rec = string.Format("insert into Recetas values ('{0}','{1}','{2}')", txtnombre.Text, string.Join(",", _nombre), txtprecio.Text);
                string pro = string.Format("insert into productos values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", txtnombre.Text, 5, txtporcion.Text, txtcantidad.Text, 0, txtprecio.Text,1);
                db.Exe(rec);
                db.Exe(pro);
                string ent = string.Format("insert into Entrada values ('{0}','{1}','{2}')", txtnombre.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "Receta creada");
                db.Exe(ent);
                MessageBox.Show("Se ingreso la receta");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrediente insuficientes "+ex);
            }
        }

        private void cbingredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.descripcion(cbingredientes, lblprecioP);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            _cantidad.Clear();
            _listado.Clear();
            _nombre.Clear();
            _precio.Clear();
            string clear = string.Format("update productos set qty = 0");
            db.Exe(clear);
            listado.DataSource = null;
            listado.DataSource = _listado;
            lblprecio.Text = _precio.Sum().ToString();

        }

        private void txtcantidad_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("select * from productos where cantidad >= '{0}' and nombre = '{1}'; if @@ROWCOUNT = 0  begin RAISERROR ('Fields 3 cannot be null .',16, 1); end", txtcantidad.Text, cbingredientes.Text);
                db.Exe(query);
            }
            catch (Exception ex)
            {
                txtcantidad.Text = "0";
                MessageBox.Show("No hay esa cantidad" + ex);
                
            }
        }
    }
}
