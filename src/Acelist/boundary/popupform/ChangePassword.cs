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
    public partial class ChangePassword : Form
    {

        private Receptionist receptionist = new Receptionist();

        private int idxUsernameUsed;

        public ChangePassword(int idxUsernameUsed)
        {
            InitializeComponent();
            this.idxUsernameUsed = idxUsernameUsed;
            this.textBoxConfirm.PasswordChar = '*';
            this.textBoxNew.PasswordChar = '*';
            this.textBoxOld.PasswordChar = '*';
        }

        private void buttonSubmitChange_Click(object sender, EventArgs e)
        {
            if (textBoxOld.Text == "" || textBoxNew.Text == ""  || textBoxConfirm.Text == "")
            {
                MessageBox.Show("Please fill the entire columns, Sir.");
            }
            else
            {
                if (textBoxOld.Text != receptionist.getArrPassword()[idxUsernameUsed])
                {
                    MessageBox.Show("The old Password is incorrect, Sir.");
                }
                else
                {
                    if (textBoxNew.Text != textBoxConfirm.Text)
                    {
                        MessageBox.Show("The new Password doesn't match");
                    }
                    else
                    {
                        receptionist.updatePassword(idxUsernameUsed, textBoxNew.Text);
                        MessageBox.Show("Password Updated");
                        this.Close();
                    }
                }
            }
        }
    }
}
