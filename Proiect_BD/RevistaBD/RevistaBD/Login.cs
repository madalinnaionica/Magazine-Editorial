using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RevistaBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8SRLU01\SQLEXPRESS;Initial Catalog=Revista_ProiectBD;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Redactor where Username='" + textBox1.Text + "' and Parola ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Meniu ss = new Meniu();
                ss.Show();
            }

            else
            {
                MessageBox.Show("Eroare de autentificare. Verificati datele.");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)13)//enter
                    button1.PerformClick();
        }
    }
}
