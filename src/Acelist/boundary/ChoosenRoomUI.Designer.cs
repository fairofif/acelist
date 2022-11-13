namespace Acelist.boundary
{
    partial class ChoosenRoomUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelTotalBill = new System.Windows.Forms.Label();
            this.checkBoxCheckout = new System.Windows.Forms.CheckBox();
            this.checkBoxCheckin = new System.Windows.Forms.CheckBox();
            this.labelCheckout = new System.Windows.Forms.Label();
            this.labelCheckin = new System.Windows.Forms.Label();
            this.labelReceptionist = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.buttonBills = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNewBook = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelBook = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.labelTotalBill);
            this.panel1.Controls.Add(this.checkBoxCheckout);
            this.panel1.Controls.Add(this.checkBoxCheckin);
            this.panel1.Controls.Add(this.labelCheckout);
            this.panel1.Controls.Add(this.labelCheckin);
            this.panel1.Controls.Add(this.labelReceptionist);
            this.panel1.Controls.Add(this.labelCustomer);
            this.panel1.Controls.Add(this.buttonBills);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonNewBook);
            this.panel1.Controls.Add(this.buttonAddService);
            this.panel1.Controls.Add(this.labelRoom);
            this.panel1.Controls.Add(this.labelBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 227);
            this.panel1.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(87)))), ((int)(((byte)(36)))));
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefresh.Location = new System.Drawing.Point(960, 125);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(129, 34);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // labelTotalBill
            // 
            this.labelTotalBill.AutoSize = true;
            this.labelTotalBill.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotalBill.Location = new System.Drawing.Point(28, 175);
            this.labelTotalBill.Name = "labelTotalBill";
            this.labelTotalBill.Size = new System.Drawing.Size(345, 41);
            this.labelTotalBill.TabIndex = 12;
            this.labelTotalBill.Text = "Total Bills: Rp. 7000000";
            // 
            // checkBoxCheckout
            // 
            this.checkBoxCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCheckout.AutoSize = true;
            this.checkBoxCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxCheckout.Location = new System.Drawing.Point(667, 130);
            this.checkBoxCheckout.Name = "checkBoxCheckout";
            this.checkBoxCheckout.Size = new System.Drawing.Size(177, 29);
            this.checkBoxCheckout.TabIndex = 11;
            this.checkBoxCheckout.Text = "Already Checkout";
            this.checkBoxCheckout.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheckin
            // 
            this.checkBoxCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCheckin.AutoSize = true;
            this.checkBoxCheckin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxCheckin.Location = new System.Drawing.Point(667, 95);
            this.checkBoxCheckin.Name = "checkBoxCheckin";
            this.checkBoxCheckin.Size = new System.Drawing.Size(164, 29);
            this.checkBoxCheckin.TabIndex = 10;
            this.checkBoxCheckin.Text = "Already Checkin";
            this.checkBoxCheckin.UseVisualStyleBackColor = true;
            this.checkBoxCheckin.CheckedChanged += new System.EventHandler(this.checkBoxCheckin_CheckedChanged);
            // 
            // labelCheckout
            // 
            this.labelCheckout.AutoSize = true;
            this.labelCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCheckout.Location = new System.Drawing.Point(28, 139);
            this.labelCheckout.Name = "labelCheckout";
            this.labelCheckout.Size = new System.Drawing.Size(230, 25);
            this.labelCheckout.TabIndex = 9;
            this.labelCheckout.Text = "Checkout Date: 12/12/2022";
            // 
            // labelCheckin
            // 
            this.labelCheckin.AutoSize = true;
            this.labelCheckin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCheckin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCheckin.Location = new System.Drawing.Point(28, 114);
            this.labelCheckin.Name = "labelCheckin";
            this.labelCheckin.Size = new System.Drawing.Size(217, 25);
            this.labelCheckin.TabIndex = 8;
            this.labelCheckin.Text = "Checkin Date: 12/12/2022";
            // 
            // labelReceptionist
            // 
            this.labelReceptionist.AutoSize = true;
            this.labelReceptionist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReceptionist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelReceptionist.Location = new System.Drawing.Point(28, 89);
            this.labelReceptionist.Name = "labelReceptionist";
            this.labelReceptionist.Size = new System.Drawing.Size(164, 25);
            this.labelReceptionist.TabIndex = 7;
            this.labelReceptionist.Text = "Receptionist: Rofif";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCustomer.Location = new System.Drawing.Point(28, 66);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(142, 25);
            this.labelCustomer.TabIndex = 6;
            this.labelCustomer.Text = "Customer: Rofif";
            // 
            // buttonBills
            // 
            this.buttonBills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(87)))), ((int)(((byte)(36)))));
            this.buttonBills.FlatAppearance.BorderSize = 0;
            this.buttonBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBills.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBills.Location = new System.Drawing.Point(667, 175);
            this.buttonBills.Name = "buttonBills";
            this.buttonBills.Size = new System.Drawing.Size(129, 34);
            this.buttonBills.TabIndex = 5;
            this.buttonBills.Text = "Print Bills";
            this.buttonBills.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(28, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 38);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNewBook
            // 
            this.buttonNewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(87)))), ((int)(((byte)(36)))));
            this.buttonNewBook.FlatAppearance.BorderSize = 0;
            this.buttonNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNewBook.Location = new System.Drawing.Point(960, 175);
            this.buttonNewBook.Name = "buttonNewBook";
            this.buttonNewBook.Size = new System.Drawing.Size(129, 34);
            this.buttonNewBook.TabIndex = 3;
            this.buttonNewBook.Text = "New Book";
            this.buttonNewBook.UseVisualStyleBackColor = false;
            // 
            // buttonAddService
            // 
            this.buttonAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(87)))), ((int)(((byte)(36)))));
            this.buttonAddService.FlatAppearance.BorderSize = 0;
            this.buttonAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddService.Location = new System.Drawing.Point(813, 175);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(129, 34);
            this.buttonAddService.TabIndex = 2;
            this.buttonAddService.Text = "Add Service";
            this.buttonAddService.UseVisualStyleBackColor = false;
            // 
            // labelRoom
            // 
            this.labelRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoom.AutoSize = true;
            this.labelRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRoom.Location = new System.Drawing.Point(928, 50);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(177, 41);
            this.labelRoom.TabIndex = 1;
            this.labelRoom.Text = "Room #211";
            // 
            // labelBook
            // 
            this.labelBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBook.Location = new System.Drawing.Point(938, 9);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(167, 41);
            this.labelBook.TabIndex = 0;
            this.labelBook.Text = "Book #211";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 409);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnService,
            this.ColumnAmount,
            this.ColumnPrice,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(28, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id Order";
            this.ColumnId.MinimumWidth = 8;
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnService
            // 
            this.ColumnService.HeaderText = "Service";
            this.ColumnService.MinimumWidth = 8;
            this.ColumnService.Name = "ColumnService";
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Amount";
            this.ColumnAmount.MinimumWidth = 8;
            this.ColumnAmount.Name = "ColumnAmount";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Price";
            this.ColumnPrice.MinimumWidth = 8;
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(6)))), ((int)(((byte)(26)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ChoosenRoomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChoosenRoomUI";
            this.Text = "Choosen Room";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label labelRoom;
        private Label labelBook;
        private Button buttonAddService;
        private CheckBox checkBoxCheckout;
        private CheckBox checkBoxCheckin;
        private Label labelCheckout;
        private Label labelCheckin;
        private Label labelReceptionist;
        private Label labelCustomer;
        private Button buttonBills;
        private Button buttonBack;
        private Button buttonNewBook;
        private Label labelTotalBill;
        private Button buttonRefresh;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnService;
        private DataGridViewTextBoxColumn ColumnAmount;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewButtonColumn Delete;
    }
}