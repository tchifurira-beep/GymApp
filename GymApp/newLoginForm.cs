using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
{
    public partial class newLoginForm : Form
    {
        public newLoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // declaration and inputing the information
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            // Checking whether the necessary details have been entered
            if (userName == "" || password == "")
            {
                MessageBox.Show(" Please enter all the details required", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            // Checking if the username and password are correct
            // then displaying whether the login was successful or not
            bool isLoginSuccessful = false;
            StreamReader Register = new StreamReader("C:\\Users\\Yoga\\Music\\my first project\\GymApp\\CoreGym2.txt");
            string line;
            string[] Login = new string[11];
            using (Register)
            {
                line = Register.ReadLine();
                while (line != null)
                {
                    string[]login = line.Split('|');
                    if (login[2] == userName && login[8] == password)
                    {
                        isLoginSuccessful = true;
                        break;
                    }
                    line = Register.ReadLine();

                }

            }
            if (isLoginSuccessful)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DashBoard DashBoard = new DashBoard();
                DashBoard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            // 
            ForgotPassword ForgotPassword = new ForgotPassword();
            ForgotPassword.Show();
            this.Hide();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            newRegisterForm NewRegisterForm = new newRegisterForm();
            NewRegisterForm.Show();
            this.Hide();

        }
    }
}
