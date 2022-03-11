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
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simplaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare1_Revista main = new Interogare1_Revista();
            main.Show();
        }

        private void complexaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare2_Revista main = new Interogare2_Revista();
            main.Show();
        }

        private void simplaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare1_Articol main = new Interogare1_Articol();
            main.Show();
        }

        private void numarPaginiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare3_Revista main = new Interogare3_Revista();
            main.Show();
        }

        private void simplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare1_Departament main = new Interogare1_Departament();
            main.Show();
        }

        private void complexaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare2_Departament main = new Interogare2_Departament();
            main.Show();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Departament_Adaugare main = new Departament_Adaugare();
            main.Show();
        }

        private void simplaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare1_Jurnalist main = new Interogare1_Jurnalist();
            main.Show();
        }

        private void contorizareNumarArticoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare2_Jurnalist main = new Interogare2_Jurnalist();
            main.Show();
        }

        private void complexaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare2_Articol main = new Interogare2_Articol();
            main.Show();
        }

        private void jurnalistiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Interogare3_Articol main = new Interogare3_Articol();
            main.Show();
        }

        private void adaugareToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            Revista_Adaugare main = new Revista_Adaugare();
            main.Show();
        }
    }
}
