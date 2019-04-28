using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework;
using MetroFramework.Forms;
using Proyecto1;
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

namespace ventas
{
    public partial class Vender : MetroForm
    {
        sql s = new sql();
        List<double> _precio = new List<double>();
        List<string> _nombre = new List<string>();
        List<int> _cantidad = new List<int>();
        List<string> _listado = new List<string>();
        public Vender(string nombre)
        {
            InitializeComponent();            
            autocompletar();
            s.populate(cbproducto, "select * from productos where Existencia = 1", "Nombre");
            s.moneda(lblusd);
            Moneda();
            lblnombre.Text = nombre.ToString();
           
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                string val = string.Format("select * from productos where nombre = '{0}'",cbproducto.Text);
                if(cbproducto.Text == s.getdata(val, "nombre"))
                {
                    string query = string.Format("update productos set qty = '{0}' + qty where nombre = '{1}'", txtcantidad.Value, cbproducto.Text);
                    s.Exe(query);
                    listadoProductos.DataSource = null;
                    _cantidad.Add(int.Parse(txtcantidad.Value.ToString()));
                    _precio.Add(double.Parse(lblprecioU.Text));
                    _nombre.Add(cbproducto.Text);
                    _listado.Add(cbproducto.Text + "\t \t" + txtcantidad.Value.ToString() + "    X \t   " + (double.Parse(lblprecioU.Text)));
                    listadoProductos.DataSource = _listado;
                    lblprecio.Text = _precio.Sum().ToString();
                }
                else
                {
                    MessageBox.Show("Producto no valido");
                }
                        
            }
            catch
            {
                MessageBox.Show("Cantidad superada");
                string query = string.Format("select * from productos");
                s.Exe(query);
            }
        }
        public void Moneda()
        {
            if (USD.Checked == true)
            {
                lblprecio.Text = ( _precio.Sum()/ double.Parse(lblusd.Text)).ToString();
            }
           
        }
        public void autocompletar()
        {
            cbproducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbproducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            //    string cons = "Data Source=SETH\\SQLEXPRESS;Initial Catalog=tiendita; Integrated security=true;";
            string cons = "Server=tcp:itt.database.windows.net,1433;Initial Catalog=tiendita;Persist Security Info=False;User ID=Orlando;Password=Bejeweled2012;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            string query = "select * from productos";
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
                    coll.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            cbproducto.AutoCompleteCustomSource = coll;
        }

        private void cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            s.precio(cbproducto, lbldescripcion);
            s.descripcion(cbproducto, lblprecioU);
            s.descripcion(cbproducto, lblhidderprice);
        }

        private void Vender_Load(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {         
        }

        private void txtcantidad_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("select * from productos where Cantidad >= '{0}' and nombre = '{1}'; if @@ROWCOUNT = 0  begin RAISERROR ('Fields 3 cannot be null .',16, 1); end", txtcantidad.Value, cbproducto.Text);
                s.Exe(query);
            }
            catch (Exception ex)
            {
                txtcantidad.Value = 0;
                MessageBox.Show("No hay esa cantidad" + ex);
            }
            lblprecioU.Text = (double.Parse(txtcantidad.Value.ToString()) * double.Parse(lblhidderprice.Text)).ToString();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void listadoProductos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("update productos set qty =  qty -'{0}' where nombre = '{1}'", _cantidad[listadoProductos.SelectedIndex].ToString(), _nombre[listadoProductos.SelectedIndex].ToString());
                s.Exe(query);
                _precio.RemoveAt(listadoProductos.SelectedIndex);
                _nombre.RemoveAt(listadoProductos.SelectedIndex);
                _listado.RemoveAt(listadoProductos.SelectedIndex);
                _cantidad.RemoveAt(listadoProductos.SelectedIndex);
                listadoProductos.DataSource = null;
                listadoProductos.DataSource = _listado;
                lblprecio.Text = _precio.Sum().ToString();
            }
            catch
            {
                MessageBox.Show("No hay producto por quitar");
            }
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "El Total es de "+lblprecio.Text, "PAGAR?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < _nombre.Count; i++)
                {
                    string ins = string.Format("insert into Salida values ('{0}','{1}','{2}')", _nombre[i].ToString(), DateTime.Now.ToString("yyyy-MM-dd HH:mm"), lblnombre.Text);
                    s.Exe(ins);
                }
                string ver = string.Format("update productos set Existencia = 0 where Cantidad = 0");
                s.Exe(ver);
                string query = string.Format("update productos set Cantidad = (Cantidad - qty), qty = 0");
                s.Exe(query);
                string nombre = string.Format("select * from Usuario where Nombre = '{0}'", lblnombre.Text);
                string ticket = string.Format("insert into ticket values ('{0}','{1}','{2}','{3}')", string.Join(",", _nombre), lblprecio.Text, s.getdata(nombre, "id").ToString(), DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                s.Exe(ticket);
                 ExportDataTableToPdf("ticket");

            }
            else
            {

            }
        }

        public void ExportDataTableToPdf(string filename)
        {
            
            var saveFilediloge = new SaveFileDialog();
            saveFilediloge.FileName = filename;
            saveFilediloge.DefaultExt = ".pdf";
            if (saveFilediloge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFilediloge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A5, 10f, 10f, 10f, 0f);
                    PdfPTable titulo = new PdfPTable(1);
                    PdfPTable artiulos = new PdfPTable(3);
                    PdfPTable precio = new PdfPTable(1);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    titulo.AddCell(GetCell("LA TIENDITA DE LA ESQUINA " + "\n" + "Hora: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "  Atendido Por: " + lblnombre.Text + "\n XXXXXXXXXXXXXXXXXXXXXXXXXXXXX", PdfPCell.ALIGN_CENTER));

                    artiulos.AddCell(GetCell("Nombre \n" + string.Join("\n", _nombre), PdfPCell.ALIGN_LEFT));
                    artiulos.AddCell(GetCell("Cantidad \n" + string.Join("X \n ", _cantidad), PdfPCell.ALIGN_CENTER));
                    artiulos.AddCell(GetCell("Precio \n" + string.Join("\n ", _precio), PdfPCell.ALIGN_RIGHT));
                    precio.AddCell(GetCell("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX \n" + "Total = " + lblprecio.Text,Element.ALIGN_CENTER));
                    pdfdoc.Add(titulo);
                    pdfdoc.Add(artiulos);
                    pdfdoc.Add(precio);
              
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }
        //
        public PdfPCell GetCell(string text, int ali)
        {
            Phrase titulo = new Phrase();
            PdfPCell cell = new PdfPCell(new Phrase(text, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            cell.Padding = 0;
            cell.HorizontalAlignment = ali;
            cell.Border = PdfPCell.NO_BORDER;
            return cell;
        }
        //
        private void USD_CheckedChanged(object sender, EventArgs e)
        {
            Moneda();
        }

        private void mxn_CheckedChanged(object sender, EventArgs e)
        {
            if (mxn.Checked == true)
            {
                lblprecio.Text = (double.Parse(lblusd.Text) * double.Parse(lblprecio.Text)).ToString();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MENU m = new MENU(lblnombre.Text);
            m.Show();
        }

        private void txtcantidad_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string query = string.Format("select * from productos where Cantidad >= '{0}' and nombre = '{1}'; if @@ROWCOUNT = 0  begin RAISERROR ('Fields 3 cannot be null .',16, 1); end", txtcantidad.Value, cbproducto.Text);
                s.Exe(query);
            }
            catch (Exception ex)
            {
                txtcantidad.Value = 0;
                MessageBox.Show("No hay esa cantidad" + ex);
            }
            lblprecioU.Text = (double.Parse(txtcantidad.Value.ToString()) * double.Parse(lblhidderprice.Text)).ToString();
        }

        private void btnticket_Click(object sender, EventArgs e)
        {

        }
    }
}
