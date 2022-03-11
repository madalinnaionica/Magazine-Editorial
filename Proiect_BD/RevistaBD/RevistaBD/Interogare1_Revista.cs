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
    public partial class Interogare1_Revista : Form
    {
        public Interogare1_Revista()
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
                    using(DataTable dt = new DataTable("Revista"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT R.Titlu_Revista, COUNT (A.ID_Articol) AS Numar_Articole FROM Revista R INNER JOIN Departament D ON R.ID_Revista = D.ID_Revista INNER JOIN Articol A ON A.ID_Departament = D.ID_Departament WHERE R.Titlu_Revista = @Revista GROUP BY R.Titlu_Revista ", cn))
                        {

                            cmd.Parameters.AddWithValue("Revista", textBox1.Text);
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Meniu main = new Meniu();
            main.Show();
        }
    }
}
