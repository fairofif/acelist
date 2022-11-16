namespace Acelist.boundary.popupform
{
    partial class NewBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBookNow = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdCust = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.labelRoomNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 95);
            this.panel1.TabIndex = 0;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRoomNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRoomNumber.Location = new System.Drawing.Point(141, 28);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(173, 38);
            this.labelRoomNumber.TabIndex = 0;
            this.labelRoomNumber.Text = "Room #XXX";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.buttonBookNow);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxIdCust);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 420);
            this.panel2.TabIndex = 1;
            // 
            // buttonBookNow
            // 
            this.buttonBookNow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBookNow.FlatAppearance.BorderSize = 0;
            this.buttonBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookNow.Location = new System.Drawing.Point(170, 241);
            this.buttonBookNow.Name = "buttonBookNow";
            this.buttonBookNow.Size = new System.Drawing.Size(112, 34);
            this.buttonBookNow.TabIndex = 5;
            this.buttonBookNow.Text = "Book Now";
            this.buttonBookNow.UseVisualStyleBackColor = false;
            this.buttonBookNow.Click += new System.EventHandler(this.buttonBookNow_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(169, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Checkout Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(178, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Customer";
            // 
            // textBoxIdCust
            // 
            this.textBoxIdCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIdCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.textBoxIdCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxIdCust.Location = new System.Drawing.Point(79, 88);
            this.textBoxIdCust.Name = "textBoxIdCust";
            this.textBoxIdCust.Size = new System.Drawing.Size(298, 31);
            this.textBoxIdCust.TabIndex = 0;
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NewBooking";
            this.Text = "New Booking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelRoomNumber;
        private Button buttonBookNow;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private TextBox textBoxIdCust;
    }
}