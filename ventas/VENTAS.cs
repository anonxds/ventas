using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.productos;

namespace ventas
{
    public partial class VENTAS : Form
    {
        sql s = new sql();
        
        private SqlCommand cmd;
        private SqlDataAdapter db;      
        public VENTAS()
        {
            InitializeComponent();
            s.populate(comboBox1, "select * from producto", "nombre");
            autocompletar();   

        }
        

        List<string> _items = new List<string>();
        List<int> _precio = new List<int>();
        List<int> _cantidad = new List<int>();
        List<string> _nombre = new List<string>();
        SqlConnection con = new SqlConnection("Data Source=SETH\\SQLEXPRESS;Initial Catalog=productos; Integrated security=true;");


        public void autocompletar()
        {
            txtbuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtbuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string cons = "Data Source=SETH\\SQLEXPRESS;Initial Catalog=productos; Integrated security=true;";
            string query = "select * from producto";
            SqlConnection con = new SqlConnection(cons);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(1);
                    //  string stelefono = reader.GetString("telefono");
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ahhhh" + ex);
            }
            txtbuscar.AutoCompleteCustomSource = coll;
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from producto where nombre = '" + comboBox1.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                //
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {

                    _nombre.Add(dr["nombre"].ToString());
                    _cantidad.Add(int.Parse(txtcantidad.Text));
                    _items.Add(dr["nombre"].ToString() + "\t" + dr["descripcion"].ToString() + "\t" + int.Parse(txtcantidad.Text) * int.Parse(dr["precio"].ToString()));
                    _precio.Add(int.Parse(dr["precio"].ToString()) * int.Parse(txtcantidad.Text));
                }
                string query = string.Format("update producto set qty = '{0}' + qty where nombre = '{1}'", txtcantidad.Text, comboBox1.Text);
                precio.Text = "Precio: " + _precio.Sum().ToString();

                con.Close();
                listaproductos.DataSource = null;
                listaproductos.DataSource = _items;
                cbcarrito.DataSource = null;
                cbcarrito.DataSource = _items;
                s.Exe(query);
            }
            catch
            {
                MessageBox.Show("No hay esa cantidad");
            }
        }

        public void descripcion()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from producto where nombre = '" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                lbldescripcion.Text = dr["descripcion"].ToString();
          
            }
          
            con.Close();
           
        }
        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("select * from producto where inventario >= '{0}' and nombre = '{1}'; if @@ROWCOUNT = 0  begin RAISERROR ('Fields 3 cannot be null .',16, 1); end", txtcantidad.Text, comboBox1.Text);
                s.Exe(query);
            }
            catch(Exception ex)
            {
                txtcantidad.Text = "0";
                MessageBox.Show("No hay esa cantidad"+ex);
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            string query = string.Format("update producto set qty =  qty -'{0}' where nombre = '{1}'", _cantidad[listaproductos.SelectedIndex].ToString(), _nombre[listaproductos.SelectedIndex].ToString());
            s.Exe(query);
            _items.RemoveAt(cbcarrito.SelectedIndex);
            _precio.RemoveAt(cbcarrito.SelectedIndex);
            listaproductos.DataSource = null;
            listaproductos.DataSource = _items;
            cbcarrito.DataSource = null;
            cbcarrito.DataSource = _items;
            precio.Text = _precio.Sum().ToString();
        }

        private void listaproductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string query = string.Format("update producto set qty =  qty -'{0}' where nombre = '{1}'", _cantidad[listaproductos.SelectedIndex].ToString(), _nombre[listaproductos.SelectedIndex].ToString());
            s.Exe(query);
            _items.RemoveAt(cbcarrito.SelectedIndex);
            _precio.RemoveAt(cbcarrito.SelectedIndex);
            listaproductos.DataSource = null;
            listaproductos.DataSource = _items;
            cbcarrito.DataSource = null;
            cbcarrito.DataSource = _items;
            precio.Text = _precio.Sum().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            descripcion();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            //
            var saveFilediloge = new SaveFileDialog();
            saveFilediloge.FileName = "ticket";
            saveFilediloge.DefaultExt = ".pdf";
            if (saveFilediloge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFilediloge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(new Paragraph( txtcantidad.Text));
                    pdfdoc.Close();
                    stream.Close();
                }
            }
            //

            string query = string.Format("update producto set inventario = inventario - qty");
            s.Exe(query);
        }

        private void btntortillas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
    }
}
