using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.filtros;
using Bunifu.Framework.Lib;
namespace ventas
{
    public partial class Reportes : MetroForm
    {
        sql s = new sql();

        string[] filtros = new string[] {"Compras","Usuarios","Inventario","Entradas","Salidas" };
        public Reportes(string nombre)
        {
            InitializeComponent();
            op();
            lblnombre.Text = nombre.ToString();
               
        }
        public void op()
        {
            for (int i = 0; i < 5; i++)
            {
                cbinfo.Items.Add(filtros[i]);
            }
        }

        public void select()
        {
  
            ifiltro filtrar = null;
            switch (cbinfo.Text)
            {
                case "Entradas":
                    filtrar = new PorEntrada();
     
                    break;
                case "Salidas":
                    filtrar = new PorSalida();
                 break;
                case "Inventario":
                    filtrar = new Porinventario();
                    break;
                case "Usuarios":
                    filtrar = new Porusuario();
                    break;
                case "Compras":
                    filtrar = new Porticket();
                    break;
            }
            filtrar.filtrar(dgvinfo, textBox1);

        }

        private void cbinfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            select();
        }

        private void btnconfirar_Click(object sender, EventArgs e)
        {

          
        }

        private void dtantes_ValueChanged(object sender, EventArgs e)
        {
            date();         
          
        }
        public void date()
        {
            DataTable dt = (DataTable)dgvinfo.DataSource;
            DataView dv = new DataView();
            dv = dt.DefaultView;
            switch (cbinfo.Text)
            {
                case "Salidas":
                    dv.RowFilter = "Salida >= '" + dtantes.Value.Date + "' and  Salida <= '" + dtdespues.Value.Date + "'";
                    break;
                case "Entradas":
                    dv.RowFilter = "Entrada >= '" + dtantes.Value.Date + "' and  Entrada <= '" + dtdespues.Value.Date + "'";
                    break;
                case "Compras":
                    dv.RowFilter = "Fecha >= '" + dtantes.Value.Date + "' and  Fecha <= '" + dtdespues.Value.Date + "'";
                    break;
                default:
                    dtantes.Enabled = false;
                    dtdespues.Enabled = false;
                    throw new NotImplementedException();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            select();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void btngenerarpdf_Click(object sender, EventArgs e)
        {
            //  s.ExportDataTableToPdf(dgvinfo, "Reporte ");
            ExportDataTableToPdf(dgvinfo, "Reporte");
        }

        public void ExportDataTableToPdf(DataGridView dgw, string filename)
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

        private void dtdespues_ValueChanged(object sender, EventArgs e)
        {
            date();
        }
       

        private void btnsalir_Click(object sender, EventArgs e)
        {
            MENU m = new MENU(lblnombre.Text);
            m.Show();
        }
    }

}
