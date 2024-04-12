﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] resultBuffer = new string[1];
            ProjectOne.Calendar.Main(resultBuffer);
            MessageBox.Show(resultBuffer[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectTwo.Form1 form1 = new ProjectTwo.Form1();
            form1.Show();
        }
    }
}
