﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FormMain formMain = new FormMain();
            formMain.MdiParent = this;
            formMain.WindowState = FormWindowState.Maximized;
            formMain.MdiForm = this;
            formMain.Show();


        }
        
    }
}
