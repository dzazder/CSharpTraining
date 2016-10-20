using System;
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
    public partial class FormMain : Form
    {
        public Form MdiForm = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDesignPatterns formDesignPatterns = new FormDesignPatterns();
            formDesignPatterns.MdiParent = MdiForm;
            formDesignPatterns.WindowState = FormWindowState.Maximized;
            formDesignPatterns.Show();
        }
    }
}
