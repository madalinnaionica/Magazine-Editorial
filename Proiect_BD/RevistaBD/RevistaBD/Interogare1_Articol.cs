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
    public partial class Interogare1_Articol : Form
    {
        public Interogare1_Articol()
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
                        using (SqlCommand cmd = new SqlCommand("SELECT TOP 10 J.Nume, J.Prenume, J.Departament, A.Titlu_Articol, A.Prioritate, COUNT(A.ID_Articol) AS Prioritate_Articol FROM Jurnalist J INNER JOIN Articol A ON A.Titlu_Articol = J.Titlu_Articol GROUP BY J.Nume, J.Prenume, J.Departament, A.Titlu_Articol, A.Prioritate ORDER BY A.Prioritate ASC ", cn))
                        {
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
