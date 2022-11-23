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
    public partial class AccountUI : Form
    {
        private int idxUsernameUsed;
        private Receptionist receptionist = new Receptionist();
        private MainMenuUI mainmenuui;

        public AccountUI(int idxUsernameUsed, MainMenuUI mainmenuui)
        {
            InitializeComponent();
            this.idxUsernameUsed = idxUsernameUsed;
            this.mainmenuui = mainmenuui;
            initialize(idxUsernameUsed);
        }

        public void initialize(int idxUsernameUsed)
        {
            labelUsername.Text = receptionist.getArrUsername()[this.idxUsernameUsed];
            ValueID.Text = receptionist.getArrEmployeeId()[this.idxUsernameUsed];
            ValueName.Text = receptionist.getArrName()[this.idxUsernameUsed];
            ValuePhone.Text = receptionist.getArrPhoneNumber()[this.idxUsernameUsed];
            ValueUsername.Text = receptionist.getArrUsername()[this.idxUsernameUsed];
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("Sayonara, " + receptionist.getArrName()[idxUsernameUsed]);
                this.Close();
                this.mainmenuui.Close();
            }
                
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ChangePassword changeUI = new ChangePassword(idxUsernameUsed);
            changeUI.ShowDialog();
            receptionist.initialize();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ValueID_Click(object sender, EventArgs e)
        {

        }
    }
}
