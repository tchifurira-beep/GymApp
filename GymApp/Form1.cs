using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newRegisterForm nm = new newRegisterForm();
            nm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newLoginForm nm = new newLoginForm();
            nm.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
