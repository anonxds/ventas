using MetroFramework.Forms;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
       SqlConnection  con = new SqlConnection("Server=tcp:itt.database.windows.net,1433;Initial Catalog=tiendita;Persist Security Info=False;User ID=Orlando;Password=Bejeweled2012;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            string query = string.Format("select * from Usuario where Nombre = '{0}' and Password = '{1}'",txtusuario.Text,txtcontrasena.Text);
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            int count = 0;
            string userRole = string.Empty;
            while (reader.Read())
            {
                count = count + 1;
                userRole = reader["Tipousuario"].ToString();

            }
            if (count == 1)
            {
              
                this.Hide();
                switch (userRole)
                {
                    case "1":
                        MENU m = new MENU(txtusuario.Text);
                        m.Show();
                        break;
                    case "2":
                        Vender v = new Vender(txtusuario.Text);
                        v.Show();
                        break;
                }
            }
            

           
        }

        private void txtusuario_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
