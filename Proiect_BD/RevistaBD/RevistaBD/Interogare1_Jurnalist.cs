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
    public partial class Interogare1_Jurnalist : Form
    {
        public Interogare1_Jurnalist()
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
                    using (DataTable dt = new DataTable("Jurnalist"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select MONTH(A.Data) as Luna_Scriere, COUNT(A.ID_Articol) as Numar_ArticoleScrise from Articol A group by MONTH(A.Data) having COUNT(A.Data) >= (select top 1 count(A2.Data) from Articol A2 group by MONTH(A2.Data) order by count(A2.Data) DESC)", cn))
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
