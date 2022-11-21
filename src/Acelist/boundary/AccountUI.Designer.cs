namespace Acelist.boundary
{
    partial class AccountUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ValueUsername = new System.Windows.Forms.Label();
            this.ValuePhone = new System.Windows.Forms.Label();
            this.ValueID = new System.Windows.Forms.Label();
            this.ValueName = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.buttonLogOut);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 488);
            this.panel2.TabIndex = 1;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogOut.Location = new System.Drawing.Point(58, 117);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(112, 34);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "Logout";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsername.Location = new System.Drawing.Point(52, 56);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(128, 32);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(230, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 488);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(51, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 376);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ValueUsername, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ValuePhone, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ValueID, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ValueName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonChange, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(172, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 376);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ValueUsername
            // 
            this.ValueUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueUsername.AutoSize = true;
            this.ValueUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValueUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ValueUsername.Location = new System.Drawing.Point(112, 250);
            this.ValueUsername.Name = "ValueUsername";
            this.ValueUsername.Size = new System.Drawing.Size(142, 25);
            this.ValueUsername.TabIndex = 7;
            this.ValueUsername.Text = "ValueUsername";
            this.ValueUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValuePhone
            // 
            this.ValuePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValuePhone.AutoSize = true;
            this.ValuePhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValuePhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ValuePhone.Location = new System.Drawing.Point(127, 175);
            this.ValuePhone.Name = "ValuePhone";
            this.ValuePhone.Size = new System.Drawing.Size(111, 25);
            this.ValuePhone.TabIndex = 6;
            this.ValuePhone.Text = "ValuePhone";
            this.ValuePhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueID
            // 
            this.ValueID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueID.AutoSize = true;
            this.ValueID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValueID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ValueID.Location = new System.Drawing.Point(145, 100);
            this.ValueID.Name = "ValueID";
            this.ValueID.Size = new System.Drawing.Size(76, 25);
            this.ValueID.TabIndex = 5;
            this.ValueID.Text = "ValueID";
            this.ValueID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueName
            // 
            this.ValueName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueName.AutoSize = true;
            this.ValueName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValueName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ValueName.Location = new System.Drawing.Point(129, 25);
            this.ValueName.Name = "ValueName";
            this.ValueName.Size = new System.Drawing.Size(107, 25);
            this.ValueName.TabIndex = 4;
            this.ValueName.Text = "ValueName";
            this.ValueName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChange.Location = new System.Drawing.Point(127, 321);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(112, 34);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(231)))), ((int)(((byte)(92)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 376);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AccountUI";
            this.Text = "Account";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label labelUsername;
        private Panel panel3;
        private Button buttonLogOut;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label ValueUsername;
        private Label ValuePhone;
        private Label ValueID;
        private Label ValueName;
        private Button buttonChange;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}