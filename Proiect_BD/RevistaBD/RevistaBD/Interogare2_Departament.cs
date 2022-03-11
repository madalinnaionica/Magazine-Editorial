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
    public partial class Interogare2_Departament : Form
    {
        public Interogare2_Departament()
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
                        using (SqlCommand cmd = new SqlCommand("SELECT D.Nume_Departament, COUNT(A.ID_Articol) AS Numar_Articole FROM Departament D INNER JOIN Articol A ON D.ID_Departament = A.ID_Departament WHERE D.Nume_Departament = @Departament GROUP BY D.Nume_Departament", cn))
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
