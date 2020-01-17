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
            this.labelStatusOfChecking = new System.Windows.Forms.Label();
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
            this.btn_assignToBracelet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbVisitorInfo.SuspendLayout();
            this.grEntrance.SuspendLayout();
            this.grExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Event Entrance";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Event Exit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(192, 341);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(121, 42);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan bracelet";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // buttonChangeAgeTypeOfTheTicket
            // 
            this.buttonChangeAgeTypeOfTheTicket.Location = new System.Drawing.Point(73, 95);
            this.buttonChangeAgeTypeOfTheTicket.Name = "buttonChangeAgeTypeOfTheTicket";
            this.buttonChangeAgeTypeOfTheTicket.Size = new System.Drawing.Size(185, 72);
            this.buttonChangeAgeTypeOfTheTicket.TabIndex = 4;
            this.buttonChangeAgeTypeOfTheTicket.Text = "Change ticket to underaged (visitor is under 18)";
            this.buttonChangeAgeTypeOfTheTicket.UseVisualStyleBackColor = true;
            this.buttonChangeAgeTypeOfTheTicket.Click += new System.EventHandler(this.buttonChangeTypeOfTheTicket_Click);
            // 
            // labelStatusOfChecking
            // 
            this.labelStatusOfChecking.AutoSize = true;
            this.labelStatusOfChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusOfChecking.Location = new System.Drawing.Point(369, 9);
            this.labelStatusOfChecking.Name = "labelStatusOfChecking";
            this.labelStatusOfChecking.Size = new System.Drawing.Size(85, 29);
            this.labelStatusOfChecking.TabIndex = 5;
            this.labelStatusOfChecking.Text = "label3";
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
            this.gbVisitorInfo.Location = new System.Drawing.Point(13, 140);
            this.gbVisitorInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbVisitorInfo.Name = "gbVisitorInfo";
            this.gbVisitorInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbVisitorInfo.Size = new System.Drawing.Size(300, 165);
            this.gbVisitorInfo.TabIndex = 14;
            this.gbVisitorInfo.TabStop = false;
            this.gbVisitorInfo.Text = "Event";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(115, 136);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(39, 17);
            this.lblage.TabIndex = 10;
            this.lblage.Text = "adult";
            // 
            // lblcredit
            // 
            this.lblcredit.AutoSize = true;
            this.lblcredit.Location = new System.Drawing.Point(115, 103);
            this.lblcredit.Name = "lblcredit";
            this.lblcredit.Size = new System.Drawing.Size(44, 17);
            this.lblcredit.TabIndex = 9;
            this.lblcredit.Text = "25.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "TicketType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Credit";
            // 
            // lblDoB
            // 
            this.lblDoB.Location = new System.Drawing.Point(115, 73);
            this.lblDoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(177, 16);
            this.lblDoB.TabIndex = 5;
            this.lblDoB.Text = "4.20.1969";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(123, 38);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(177, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Eftim4o";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // lblNoItems
            // 
            this.lblNoItems.BackColor = System.Drawing.Color.Linen;
            this.lblNoItems.ForeColor = System.Drawing.Color.Red;
            this.lblNoItems.Location = new System.Drawing.Point(28, 310);
            this.lblNoItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoItems.Name = "lblNoItems";
            this.lblNoItems.Size = new System.Drawing.Size(247, 16);
            this.lblNoItems.TabIndex = 6;
            this.lblNoItems.Text = "DOES NOT HAVE LOANED ITEM!";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 341);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(121, 42);
            this.btn.TabIndex = 16;
            this.btn.Text = "QR-code reader";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // grEntrance
            // 
            this.grEntrance.Controls.Add(this.btn_CheckIn);
            this.grEntrance.Controls.Add(this.buttonChangeAgeTypeOfTheTicket);
            this.grEntrance.Location = new System.Drawing.Point(331, 41);
            this.grEntrance.Name = "grEntrance";
            this.grEntrance.Size = new System.Drawing.Size(366, 188);
            this.grEntrance.TabIndex = 17;
            this.grEntrance.TabStop = false;
            this.grEntrance.Text = "Entrance";
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Location = new System.Drawing.Point(73, 34);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(185, 43);
            this.btn_CheckIn.TabIndex = 5;
            this.btn_CheckIn.Text = "Check-In Visitor";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            // 
            // grExit
            // 
            this.grExit.Controls.Add(this.button5);
            this.grExit.Location = new System.Drawing.Point(331, 243);
            this.grExit.Name = "grExit";
            this.grExit.Size = new System.Drawing.Size(366, 200);
            this.grExit.TabIndex = 18;
            this.grExit.TabStop = false;
            this.grExit.Text = "Exit";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 49);
            this.button5.TabIndex = 20;
            this.button5.Text = "Check out the visitor";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_assignToBracelet
            // 
            this.btn_assignToBracelet.Location = new System.Drawing.Point(101, 389);
            this.btn_assignToBracelet.Name = "btn_assignToBracelet";
            this.btn_assignToBracelet.Size = new System.Drawing.Size(123, 44);
            this.btn_assignToBracelet.TabIndex = 19;
            this.btn_assignToBracelet.Text = "Assign to bracelet";
            this.btn_assignToBracelet.UseVisualStyleBackColor = true;
            this.btn_assignToBracelet.Click += new System.EventHandler(this.btn_assignToBracelet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(703, 524);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_assignToBracelet);
            this.Controls.Add(this.grExit);
            this.Controls.Add(this.grEntrance);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblNoItems);
            this.Controls.Add(this.gbVisitorInfo);
            this.Controls.Add(this.labelStatusOfChecking);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label labelStatusOfChecking;
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
        private System.Windows.Forms.Button btn_assignToBracelet;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblcredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

