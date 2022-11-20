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
    public partial class MainMenuUI : Form
    {
        private Button currentNavbar;
        private Random random;
        private int tempIndex;
        private Form activeUI;
        public int idxUsernameUsed;
        private Receptionist receptionist = new Receptionist();

        public MainMenuUI(int idxUsernameUsed)
        {
            InitializeComponent();
            random = new Random();
            this.idxUsernameUsed = idxUsernameUsed;
            MessageBox.Show("Welcome to Acelist "+receptionist.getArrName()[idxUsernameUsed]+ "!");
        }

        private Color gachaColorTheme()
        {
            int idx = random.Next(boundary.ColorTheme.ColorList.Count);

            // kalo pick colornya sama kaya sebelumnya jd gacha lagi
            while (tempIndex == idx)
            {
                idx = random.Next(boundary.ColorTheme.ColorList.Count);
            }
            tempIndex = idx;
            string color = boundary.ColorTheme.ColorList[idx];
            return ColorTranslator.FromHtml(color);
        }

        private void activateBtn(object sender)
        {
            if (sender != null)
            {
                if (currentNavbar != (Button)sender)
                {
                    disableBtn();
                    Color color = gachaColorTheme();
                    currentNavbar = (Button)sender;
                    currentNavbar.BackColor = color;
                    currentNavbar.ForeColor = Color.White;
                    currentNavbar.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    panelBar.BackColor = color;
                    panelMainMenu.BackColor = color;
                    NavbarButtonAccount.BackColor = color;
                    NavbarButtonAvailability.BackColor = color;
                    NavbarButtonBookHistory.BackColor = color;
                    NavbarButtonCustomer.BackColor = color;
                    NavbarButtonRooms.BackColor = color;
                    currentNavbar.BackColor = ColorTheme.ChangeColorBrightness(color, -0.3);
                    panelLogo.BackColor = color;
                    panelNavbar.BackColor = color;
                }
            }
        }

        private void disableBtn()
        {
            foreach (Control prevBtn in panelNavbar.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(33, 65, 86);
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void callUIToPanelMainMenu(Form choosenUI, object sender)
        {
            if(activeUI != null)
            {
                activeUI.Close();
            }
            activateBtn(sender);
            activeUI = choosenUI;
            choosenUI.TopLevel = false;
            choosenUI.FormBorderStyle = FormBorderStyle.None;
            choosenUI.Dock = DockStyle.Fill;
            this.panelMainMenu.Controls.Add(choosenUI);
            this.panelMainMenu.Tag = choosenUI;
            choosenUI.BringToFront();
            choosenUI.Show();
            textTitle.Text = choosenUI.Text;
        }

        private void NavbarButtonAvailability_Click(object sender, EventArgs e)
        {
            callUIToPanelMainMenu(new RoomAvailabilityUI(this.panelMainMenu, idxUsernameUsed), sender);
        }

        private void NavbarButtonBookHistory_Click(object sender, EventArgs e)
        {
            callUIToPanelMainMenu(new BookHistoryUI(), sender);
        }

        private void NavbarButtonRooms_Click(object sender, EventArgs e)
        {
            callUIToPanelMainMenu(new RoomSpecificationUI(), sender);
        }

        private void NavbarButtonCustomer_Click(object sender, EventArgs e)
        {
            callUIToPanelMainMenu(new CustomerUI(this.panelMainMenu), sender);
        }

        private void NavbarButtonAccount_Click(object sender, EventArgs e)
        {
            callUIToPanelMainMenu(new AccountUI(), sender);
        }
    }
}
