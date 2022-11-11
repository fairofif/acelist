using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acelist.boundary
{
    public partial class LevelFloorMapUI : Form
    {
        private Button[] arrButton = new Button[30];
        public LevelFloorMapUI(string floor)
        {
            InitializeComponent();
            setArrButton();
            setButtonText(this.arrButton, floor);
        }
    
        private void setButtonText(Button[] arrButton, string floor)
        {
            for (int i = 0; i < arrButton.Length; i++)
            {
                if (i < 9)
                {
                    arrButton[i].Text = floor + "0" + (i+1).ToString();
                }
                else
                {
                    arrButton[i].Text = floor + (i+1).ToString();
                }
                
            }
        }
        private void setArrButton()
        {
            this.arrButton[0] = button1;
            this.arrButton[1] = button2;
            this.arrButton[2] = button3;
            this.arrButton[3] = button4;
            this.arrButton[4] = button5;
            this.arrButton[5] = button6;
            this.arrButton[6] = button7;
            this.arrButton[7] = button8;
            this.arrButton[8] = button9;
            this.arrButton[9] = button10;
            this.arrButton[10] = button11;
            this.arrButton[11] = button12;
            this.arrButton[12] = button13;
            this.arrButton[13] = button14;
            this.arrButton[14] = button15;
            this.arrButton[15] = button16;
            this.arrButton[16] = button17;
            this.arrButton[17] = button18;
            this.arrButton[18] = button19;
            this.arrButton[19] = button20;
            this.arrButton[20] = button21;
            this.arrButton[21] = button22;
            this.arrButton[22] = button23;
            this.arrButton[23] = button24;
            this.arrButton[24] = button25;
            this.arrButton[25] = button26;
            this.arrButton[26] = button27;
            this.arrButton[27] = button28;
            this.arrButton[28] = button29;
            this.arrButton[29] = button30;
        }
    }
}
