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
using ventas;
using ventas.Usuarios;

namespace Proyecto1
{
    public partial class MENU : MetroForm
    {
        public MENU(string nombre)
        {
            InitializeComponent();
            lblnombre.Text = nombre.ToString();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            Agregar_Producto a = new Agregar_Producto(lblnombre.Text);
            a.Show();

        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Vender v = new Vender(lblnombre.Text);
            v.Show();
        }

        private void btnrecetas_Click(object sender, EventArgs e)
        {
            Receta r = new Receta(lblnombre.Text);
            r.Show();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        { 
            Reportes r = new Reportes(lblnombre.Text);
            r.Show();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            crudusuario c = new crudusuario(lblnombre.Text);
            c.Show();
        }

        private void btntipousuario_Click(object sender, EventArgs e)
        {
            tipodeusuario u = new tipodeusuario(lblnombre.Text);
            u.Show();
        }

        private void btntipoproductos_Click(object sender, EventArgs e)
        {
            CrudProductos c = new CrudProductos(lblnombre.Text);
            c.Show();
        }
    }
}
