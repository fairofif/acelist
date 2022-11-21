namespace Acelist.boundary.popupform
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOld = new System.Windows.Forms.TextBox();
            this.textBoxNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSubmitChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.buttonSubmitChange);
            this.panel1.Controls.Add(this.textBoxConfirm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNew);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxOld);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 420);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old Password";
            // 
            // textBoxOld
            // 
            this.textBoxOld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOld.Location = new System.Drawing.Point(54, 100);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.Size = new System.Drawing.Size(226, 31);
            this.textBoxOld.TabIndex = 1;
            // 
            // textBoxNew
            // 
            this.textBoxNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNew.Location = new System.Drawing.Point(54, 161);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.Size = new System.Drawing.Size(226, 31);
            this.textBoxNew.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxConfirm.Location = new System.Drawing.Point(54, 223);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(226, 31);
            this.textBoxConfirm.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(96, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // buttonSubmitChange
            // 
            this.buttonSubmitChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmitChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.buttonSubmitChange.FlatAppearance.BorderSize = 0;
            this.buttonSubmitChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitChange.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmitChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmitChange.Location = new System.Drawing.Point(111, 271);
            this.buttonSubmitChange.Name = "buttonSubmitChange";
            this.buttonSubmitChange.Size = new System.Drawing.Size(112, 34);
            this.buttonSubmitChange.TabIndex = 6;
            this.buttonSubmitChange.Text = "Change";
            this.buttonSubmitChange.UseVisualStyleBackColor = false;
            this.buttonSubmitChange.Click += new System.EventHandler(this.buttonSubmitChange_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 420);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonSubmitChange;
        private TextBox textBoxConfirm;
        private Label label3;
        private TextBox textBoxNew;
        private Label label2;
        private TextBox textBoxOld;
        private Label label1;
    }
}