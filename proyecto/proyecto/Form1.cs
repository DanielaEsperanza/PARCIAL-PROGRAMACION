using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 otrafroma = new Form2();
            otrafroma.MdiParent = this;
            otrafroma.Show();
        }

        private void caluladoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 otrafroma = new Form3();
            otrafroma.MdiParent = this;
            otrafroma.Show();
        }

     

        private void lenguajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 otrafroma = new Form4();
            otrafroma.MdiParent = this;
            otrafroma.Show();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 otrafroma = new Form5();
            otrafroma.MdiParent = this;
            otrafroma.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ayudaParteIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 otrafroma = new Form6();
            otrafroma.MdiParent = this;
            otrafroma.Show();
        }

        private void ayudaParteLlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 otrafroma = new Form7();
            otrafroma.MdiParent = this;
            otrafroma.Show();
        }

        private void ayudaParteLllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 otrafroma = new Form8();
            otrafroma.MdiParent = this;
            otrafroma.Show();
        }
    }
}
