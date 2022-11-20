namespace Acelist.boundary
{
    partial class RoomAvailabilityUI
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dropdownLevelFloor = new System.Windows.Forms.ComboBox();
            this.dropdownRoomType = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelAvailability = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dropdownLevelFloor);
            this.panel1.Controls.Add(this.dropdownRoomType);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 81);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dropdownLevelFloor
            // 
            this.dropdownLevelFloor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dropdownLevelFloor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.dropdownLevelFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownLevelFloor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dropdownLevelFloor.FormattingEnabled = true;
            this.dropdownLevelFloor.Location = new System.Drawing.Point(273, 22);
            this.dropdownLevelFloor.Name = "dropdownLevelFloor";
            this.dropdownLevelFloor.Size = new System.Drawing.Size(149, 33);
            this.dropdownLevelFloor.TabIndex = 5;
            this.dropdownLevelFloor.Text = "Level Floor";
            // 
            // dropdownRoomType
            // 
            this.dropdownRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dropdownRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.dropdownRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownRoomType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dropdownRoomType.FormattingEnabled = true;
            this.dropdownRoomType.Items.AddRange(new object[] {
            "Minister",
            "Emperor",
            "King"});
            this.dropdownRoomType.Location = new System.Drawing.Point(107, 22);
            this.dropdownRoomType.Name = "dropdownRoomType";
            this.dropdownRoomType.Size = new System.Drawing.Size(149, 33);
            this.dropdownRoomType.TabIndex = 4;
            this.dropdownRoomType.Text = "Room Type";
            this.dropdownRoomType.SelectedIndexChanged += new System.EventHandler(this.dropdownRoomType_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(754, 22);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(91, 34);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelAvailability
            // 
            this.panelAvailability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAvailability.Location = new System.Drawing.Point(0, 81);
            this.panelAvailability.Name = "panelAvailability";
            this.panelAvailability.Size = new System.Drawing.Size(965, 463);
            this.panelAvailability.TabIndex = 1;
            // 
            // RoomAvailabilityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(965, 544);
            this.Controls.Add(this.panelAvailability);
            this.Controls.Add(this.panel1);
            this.Name = "RoomAvailabilityUI";
            this.Text = "Room Availability";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonRefresh;
        private ComboBox dropdownLevelFloor;
        private ComboBox dropdownRoomType;
        private DateTimePicker dateTimePicker1;
        private Panel panelAvailability;
    }
}