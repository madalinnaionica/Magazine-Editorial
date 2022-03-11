using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevistaBD
{
    public partial class Departament_Adaugare : Form
    {
        public Departament_Adaugare()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Meniu main = new Meniu();
            main.Show();
        }

        private void Departament_Adaugare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'revista_ProiectBDDataSet3.Departament' table. You can move, or remove it, as needed.
            this.departamentTableAdapter.Fill(this.revista_ProiectBDDataSet3.Departament);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            departamentBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            departamentBindingSource.EndEdit();
            departamentTableAdapter.Update(revista_ProiectBDDataSet3.Departament);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            departamentBindingSource.RemoveCurrent();
        }
    }
}
