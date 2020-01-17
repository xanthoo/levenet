namespace EntranceLeavingApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnScan = new System.Windows.Forms.Button();
            this.buttonChangeAgeTypeOfTheTicket = new System.Windows.Forms.Button();
            this.gbVisitorInfo = new System.Windows.Forms.GroupBox();
            this.lblage = new System.Windows.Forms.Label();
            this.lblcredit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoItems = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.grEntrance = new System.Windows.Forms.GroupBox();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.grExit = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblTicketId = new System.Windows.Forms.Label();
            this.gbVisitorInfo.SuspendLayout();
            this.grEntrance.SuspendLayout();
            this.grExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 27);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Event Entrance";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 60);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Event Exit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(105, 277);
            this.btnScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(130, 34);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan and assign bracelet";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // buttonChangeAgeTypeOfTheTicket
            // 
            this.buttonChangeAgeTypeOfTheTicket.Location = new System.Drawing.Point(55, 77);
            this.buttonChangeAgeTypeOfTheTicket.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChangeAgeTypeOfTheTicket.Name = "buttonChangeAgeTypeOfTheTicket";
            this.buttonChangeAgeTypeOfTheTicket.Size = new System.Drawing.Size(139, 58);
            this.buttonChangeAgeTypeOfTheTicket.TabIndex = 4;
            this.buttonChangeAgeTypeOfTheTicket.Text = "Change ticket to underaged (visitor is under 18)";
            this.buttonChangeAgeTypeOfTheTicket.UseVisualStyleBackColor = true;
            this.buttonChangeAgeTypeOfTheTicket.Click += new System.EventHandler(this.buttonChangeTypeOfTheTicket_Click);
            // 
            // gbVisitorInfo
            // 
            this.gbVisitorInfo.Controls.Add(this.lblage);
            this.gbVisitorInfo.Controls.Add(this.lblcredit);
            this.gbVisitorInfo.Controls.Add(this.label4);
            this.gbVisitorInfo.Controls.Add(this.label2);
            this.gbVisitorInfo.Controls.Add(this.lblDoB);
            this.gbVisitorInfo.Controls.Add(this.lblName);
            this.gbVisitorInfo.Controls.Add(this.label1);
            this.gbVisitorInfo.Controls.Add(this.label3);
            this.gbVisitorInfo.Location = new System.Drawing.Point(10, 94);
            this.gbVisitorInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVisitorInfo.Name = "gbVisitorInfo";
            this.gbVisitorInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbVisitorInfo.Size = new System.Drawing.Size(225, 134);
            this.gbVisitorInfo.TabIndex = 14;
            this.gbVisitorInfo.TabStop = false;
            this.gbVisitorInfo.Text = "Event";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(86, 110);
            this.lblage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(30, 13);
            this.lblage.TabIndex = 10;
            this.lblage.Text = "adult";
            // 
            // lblcredit
            // 
            this.lblcredit.AutoSize = true;
            this.lblcredit.Location = new System.Drawing.Point(86, 84);
            this.lblcredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcredit.Name = "lblcredit";
            this.lblcredit.Size = new System.Drawing.Size(34, 13);
            this.lblcredit.TabIndex = 9;
            this.lblcredit.Text = "25.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TicketType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Credit";
            // 
            // lblDoB
            // 
            this.lblDoB.Location = new System.Drawing.Point(86, 59);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(133, 13);
            this.lblDoB.TabIndex = 5;
            this.lblDoB.Text = "4.20.1969";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(92, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Eftim4o";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // lblNoItems
            // 
            this.lblNoItems.BackColor = System.Drawing.Color.Linen;
            this.lblNoItems.ForeColor = System.Drawing.Color.Red;
            this.lblNoItems.Location = new System.Drawing.Point(26, 243);
            this.lblNoItems.Name = "lblNoItems";
            this.lblNoItems.Size = new System.Drawing.Size(185, 13);
            this.lblNoItems.TabIndex = 6;
            this.lblNoItems.Text = "DOES NOT HAVE LOANED ITEM!";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(9, 277);
            this.btn.Margin = new System.Windows.Forms.Padding(2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(91, 34);
            this.btn.TabIndex = 16;
            this.btn.Text = "QR-code reader";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // grEntrance
            // 
            this.grEntrance.Controls.Add(this.btn_CheckIn);
            this.grEntrance.Controls.Add(this.buttonChangeAgeTypeOfTheTicket);
            this.grEntrance.Location = new System.Drawing.Point(248, 33);
            this.grEntrance.Margin = new System.Windows.Forms.Padding(2);
            this.grEntrance.Name = "grEntrance";
            this.grEntrance.Padding = new System.Windows.Forms.Padding(2);
            this.grEntrance.Size = new System.Drawing.Size(274, 153);
            this.grEntrance.TabIndex = 17;
            this.grEntrance.TabStop = false;
            this.grEntrance.Text = "Entrance";
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Location = new System.Drawing.Point(55, 28);
            this.btn_CheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(139, 35);
            this.btn_CheckIn.TabIndex = 5;
            this.btn_CheckIn.Text = "Check-In Visitor";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // grExit
            // 
            this.grExit.Controls.Add(this.button5);
            this.grExit.Location = new System.Drawing.Point(248, 197);
            this.grExit.Margin = new System.Windows.Forms.Padding(2);
            this.grExit.Name = "grExit";
            this.grExit.Padding = new System.Windows.Forms.Padding(2);
            this.grExit.Size = new System.Drawing.Size(274, 162);
            this.grExit.TabIndex = 18;
            this.grExit.TabStop = false;
            this.grExit.Text = "Exit";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 61);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 40);
            this.button5.TabIndex = 20;
            this.button5.Text = "Check out the visitor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketId.Location = new System.Drawing.Point(57, 335);
            this.lblTicketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(91, 24);
            this.lblTicketId.TabIndex = 20;
            this.lblTicketId.Text = "Ticket ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(527, 388);
            this.Controls.Add(this.lblTicketId);
            this.Controls.Add(this.grExit);
            this.Controls.Add(this.grEntrance);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblNoItems);
            this.Controls.Add(this.gbVisitorInfo);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Event";
            this.gbVisitorInfo.ResumeLayout(false);
            this.gbVisitorInfo.PerformLayout();
            this.grEntrance.ResumeLayout(false);
            this.grExit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button buttonChangeAgeTypeOfTheTicket;
        private System.Windows.Forms.GroupBox gbVisitorInfo;
        private System.Windows.Forms.Label lblNoItems;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.GroupBox grEntrance;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.GroupBox grExit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblcredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTicketId;
    }
}

