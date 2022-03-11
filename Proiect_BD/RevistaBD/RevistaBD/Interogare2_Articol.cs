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
    public partial class Interogare2_Articol : Form
    {
        public Interogare2_Articol()
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
                        using (SqlCommand cmd = new SqlCommand("select top 10 A.Titlu_Articol, A.Numar_Pagini  from Articol A where A.Numar_Pagini >= ANY(select A2.Numar_Pagini from Articol A2 group by A2.Numar_Pagini) group by A.Titlu_Articol, A.Numar_Pagini order by A.Numar_Pagini DESC  ", cn))
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
