﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clases.clsOpcion1 opcion1 = new clases.clsOpcion1();
            string miSaludo = opcion1.Saludar(txtsaludar.Text);
            MessageBox.Show(miSaludo);
        }
    }
}
