using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
namespace ventas
{
    class sql
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter db;

        private void setcon()
        {
            //  con = new SqlConnection("Data Source=SETH\\SQLEXPRESS;Initial Catalog=tiendita; Integrated security=true;");
            con = new SqlConnection("Server=tcp:itt.database.windows.net,1433;Initial Catalog=tiendita;Persist Security Info=False;User ID=Orlando;Password=Bejeweled2012;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public void Exe(String query)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void dgrid(DataGridView dg, string query)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            db = new SqlDataAdapter(query, con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            dg.DataSource = dt;
            con.Close();
        }
        public void populate(ComboBox cb, string query, string type)
        {
            setcon();
            cb.Items.Clear();
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter db = new SqlDataAdapter(cmd);
            db.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cb.Items.Add(dr[type]).ToString();
            }
            con.Close();

        }
        public void pro(string type,string _getype)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from producto where nombre = '" + type + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                
               _getype =  dr["precio"].ToString();
          
            }
            con.Close();
        }

        public void descripcion(ComboBox cb,Label lblprecio)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from productos where nombre = '" + cb.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblprecio.Text = dr["precio"].ToString();
            }
            con.Close();
        }

        public void precio(ComboBox cb, Label lblprecio)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text; 
            cmd.CommandText = "select v.nombre,c.Nombre as Neto ,v.Porcion,v.precio from productos as v inner join Porcion as c on v.TipoPorcion = c.id where v.nombre = '"+cb.SelectedItem.ToString()+"'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblprecio.Text = dr["Porcion"].ToString()+" "+ dr["Neto"].ToString() ;
            }
            con.Close();
        }

        public void moneda(Label lblprecio)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TipoMoneda where Nombre = 'USD'";
            cmd.ExecuteNonQuery();
            //
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               lblprecio.Text = dr["moneda"].ToString();
            }
            con.Close();
        }




        public void f(DataGridView historial, string x, string y,string query)
        {
         SqlConnection   con = new SqlConnection("Server=tcp:itt.database.windows.net,1433;Initial Catalog=tiendita;Persist Security Info=False;User ID=Orlando;Password=Bejeweled2012;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            con.Open();
            cmd = con.CreateCommand();
            string cmdt = query;
            db = new SqlDataAdapter(cmdt, con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            historial.DataSource = dt;
            con.Close();
            DataView da = new DataView(dt, x, y, DataViewRowState.CurrentRows);
            historial.DataSource = da;
        }


        public void ExportDataTableToPdf(BunifuCustomDataGrid dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dgw.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var saveFilediloge = new SaveFileDialog();
            saveFilediloge.FileName = filename;
            saveFilediloge.DefaultExt = ".pdf";
            if (saveFilediloge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFilediloge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }
        public string getdata(string query,string dato)
        {
            setcon();
   //         con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;      
            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
        
            string userRole = string.Empty;
            while (reader.Read())
            {               
                userRole = reader[dato].ToString();

            }
            con.Close();
            return userRole;
        }


    }
}
