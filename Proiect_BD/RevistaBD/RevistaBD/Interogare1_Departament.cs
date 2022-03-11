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
using System.Configuration;

namespace RevistaBD
{
    public partial class Interogare1_Departament : Form
    {
        public Interogare1_Departament()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Open();
                    using (DataTable dt = new DataTable("Departament"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT J.Nume, J.Prenume FROM Jurnalist J, (SELECT J2.ID_Jurnalist FROM Jurnalist J2 WHERE J2.Departament = @Departament ) AS J3 WHERE J.ID_Jurnalist = J3.ID_Jurnalist ", cn))
                        {

                            cmd.Parameters.AddWithValue("Departament", textBox1.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Meniu main = new Meniu();
            main.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                button1.PerformClick();
        }
    }
}
