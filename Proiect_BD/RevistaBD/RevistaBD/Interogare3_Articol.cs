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
    public partial class Interogare3_Articol : Form
    {
        public Interogare3_Articol()
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
                    using (DataTable dt = new DataTable("Articol"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT J.Nume, J.Prenume, J.Departament, A.Titlu_Articol, A.Prioritate AS Prioritate_Articole FROM Articol A INNER JOIN Jurnalist J ON A.Titlu_Articol = J.Titlu_Articol WHERE A.Prioritate = @Prioritate GROUP BY J.Nume, J.Prenume, J.Departament, A.Titlu_Articol, A.Prioritate ", cn))
                        {
                            cmd.Parameters.AddWithValue("Prioritate", textBox1.Text);
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
    }
}
