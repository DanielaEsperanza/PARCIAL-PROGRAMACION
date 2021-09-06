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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //comboBox1.Text = "";


            if (comboBox1.Text == "Kilogramos")
            {
                double Lb, Kg;

                Lb = System.Double.Parse(txtLb.Text);

                Kg = Lb * 0.4535;

                txtkg.Text = Kg.ToString() + "  Kilogramos ";
            }
            else if (comboBox1.Text == "Toneladas")
            {
                double Lb, tn;

                Lb = System.Double.Parse(txtLb.Text);

                tn = Lb * 0.000453592;

                txtkg.Text = tn.ToString()+ " Toneladas ";

            }

            else if (comboBox1.Text == "Gramos")
            {
                double Lb, gr;

                Lb = System.Double.Parse(txtLb.Text);

                gr = Lb * 453.592;

                txtkg.Text = gr.ToString() + " Gramos";

            }
            else if (comboBox1.Text == "Onza")
            {
                double Lb, on;

                Lb = System.Double.Parse(txtLb.Text);

                on = Lb * 16;

                txtkg.Text = on.ToString()+ " Onzas";

            }

        }
    }
}
