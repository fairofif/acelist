using Microsoft.VisualBasic.Logging;
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
    public partial class RoomAvailabilityUI : Form
    {
        private Form activeLevelFloorMapUI;

        public RoomAvailabilityUI()
        {
            InitializeComponent();
        }

        private void dropdownRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdownLevelFloor.Items.Clear();
            dropdownLevelFloor.Text = "Level Floor";
            if (dropdownRoomType.Text == "Minister")
            {               
                dropdownLevelFloor.Items.Add("1");
            }
            else if (dropdownRoomType.Text == "Emperor")
            { 
                dropdownLevelFloor.Items.Add("2");
                dropdownLevelFloor.Items.Add("3");
            }
            else if (dropdownRoomType.Text == "King")
            {
                dropdownLevelFloor.Items.Add("4");
            }
        }

        private void callLevelFloorUI(Form levelFloorUI, object sender)
        {
            if (activeLevelFloorMapUI != null)
            {
                activeLevelFloorMapUI.Close();
            }
            activeLevelFloorMapUI = levelFloorUI;
            levelFloorUI.TopLevel = false;
            levelFloorUI.FormBorderStyle = FormBorderStyle.None;
            levelFloorUI.Dock = DockStyle.Fill;
            this.panelAvailability.Controls.Add(levelFloorUI);
            this.panelAvailability.Tag = levelFloorUI;
            levelFloorUI.BringToFront();
            levelFloorUI.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (this.dropdownLevelFloor.Text == "1" || this.dropdownLevelFloor.Text == "2" || this.dropdownLevelFloor.Text == "3" || this.dropdownLevelFloor.Text == "4")
            {
                callLevelFloorUI(new LevelFloorMapUI(this.dropdownLevelFloor.Text), sender);
            }
        }
    }
}
