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
    public partial class Interogare2_Revista : Form
    {
        public Interogare2_Revista()
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
                    using (DataTable dt = new DataTable("Revista"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT R.Titlu_Revista,(SELECT COUNT(*) FROM Departament D WHERE D.ID_Revista = R.ID_Revista) AS Revista_Departament FROM Revista R", cn))
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
