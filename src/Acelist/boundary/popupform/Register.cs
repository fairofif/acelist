using Acelist.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelist.boundary.popupform
{
    public partial class Register : Form
    {
        public string id;
        public string username;
        public string password;
        public string name;
        public string phone;

        LoginUI loginform;

        private Receptionist receptionist = new Receptionist();
        public Register(LoginUI loginform)
        {
            InitializeComponent();
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword2.PasswordChar = '*';
            this.loginform = loginform;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxName.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxPassword2.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Please fill all columns, Sir.");
            }
            else
            {
                if (receptionist.isIdExist(textBoxID.Text))
                {
                    MessageBox.Show("ID is already exist, Sir.");
                }
                else
                {
                    if (receptionist.isUsernameExist(textBoxUsername.Text))
                    {
                        MessageBox.Show("Username is already exist, Sir.");
                    }
                    else
                    {
                        if (textBoxPassword.Text != textBoxPassword2.Text)
                        {
                            MessageBox.Show("Password doesn't match, Sir.");
                        }
                        else
                        {
                            this.id = textBoxID.Text;
                            this.name = textBoxName.Text;
                            this.phone = textBoxPhone.Text;
                            this.username = textBoxUsername.Text;
                            this.password = textBoxPassword.Text;
                            loginform.status = "register";
                            loginform.initialize();
                            MessageBox.Show("Please login to any one account to register this receptionist data.");
                            loginform.Show();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            loginform.Show();
        }
    }
}
