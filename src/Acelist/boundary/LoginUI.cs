using Acelist.boundary.popupform;
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

namespace Acelist.boundary
{
    public partial class LoginUI : Form
    {
        private Receptionist receptionist = new Receptionist();

        public string status;
        public bool loginGranteed;
        public int idxUsernameUsed;
        public Register register;
        public LoginUI(string status)
        {
            InitializeComponent();
            this.status = status;
            this.textBoxPassword.PasswordChar = '*';
            initialize();
        }

        public void initialize()
        {
            this.textBoxPassword.Text = "";
            this.textBoxUsername.Text = "";
            if (this.status == "register")
            {
                this.labelRegister.Enabled = false;
                this.labelRegister.Hide();
            }
            else
            {
                this.labelRegister.Enabled = true;
                this.labelRegister.Show();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                loginGranteed = false;
                MessageBox.Show("Please fill all the columns, Sir.");
            }
            else
            {
                if (receptionist.isUsernameExist(textBoxUsername.Text))
                {
                    if (receptionist.checkLogin(textBoxUsername.Text, textBoxPassword.Text))
                    {
                        loginGranteed = true;
                    }
                    else
                    {
                        loginGranteed = false;
                        MessageBox.Show("Incorrect Password.");
                    }
                }
                else
                {
                    loginGranteed = false;
                    MessageBox.Show("Username doesn't exist, please register.");
                }
            }
            if (loginGranteed == true && this.status == "login")
            {
                this.idxUsernameUsed = receptionist.idxUsername(textBoxUsername.Text);
                this.Close();
            }
            else if (loginGranteed == true && this.status == "register")
            {
                receptionist.addAccount(register.id, register.username, register.password, register.name, register.phone);
                MessageBox.Show("New Account Registered, Sir.");
                this.status = "login";
                loginGranteed = false;
                initialize();
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            this.status = "register";
            initialize();
            this.Hide();
            register = new Register(this);
            register.ShowDialog();
        }
    }
}
