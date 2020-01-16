namespace ProP_Restaurant
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
            this.btnEatIn = new System.Windows.Forms.Button();
            this.pnlOrderDetails = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblAmountOfProducts = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.pnMenuSelect = new System.Windows.Forms.Panel();
            this.pnlOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEatIn
            // 
            this.btnEatIn.Location = new System.Drawing.Point(446, 227);
            this.btnEatIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(206, 159);
            this.btnEatIn.TabIndex = 0;
            this.btnEatIn.Text = "Start Order";
            this.btnEatIn.UseVisualStyleBackColor = true;
            this.btnEatIn.Click += new System.EventHandler(this.btnEatIn_Click);
            // 
            // pnlOrderDetails
            // 
            this.pnlOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrderDetails.Controls.Add(this.lblTotalCost);
            this.pnlOrderDetails.Controls.Add(this.lblAmountOfProducts);
            this.pnlOrderDetails.Controls.Add(this.btnCancelOrder);
            this.pnlOrderDetails.Controls.Add(this.btnFinishOrder);
            this.pnlOrderDetails.Location = new System.Drawing.Point(11, 498);
            this.pnlOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrderDetails.Name = "pnlOrderDetails";
            this.pnlOrderDetails.Size = new System.Drawing.Size(1120, 149);
            this.pnlOrderDetails.TabIndex = 12;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(14, 37);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(120, 24);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Total cost: $0";
            // 
            // lblAmountOfProducts
            // 
            this.lblAmountOfProducts.AutoSize = true;
            this.lblAmountOfProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfProducts.Location = new System.Drawing.Point(13, 6);
            this.lblAmountOfProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountOfProducts.Name = "lblAmountOfProducts";
            this.lblAmountOfProducts.Size = new System.Drawing.Size(260, 24);
            this.lblAmountOfProducts.TabIndex = 2;
            this.lblAmountOfProducts.Text = "You have ordered 0 products.";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(179, 75);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(418, 64);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinishOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinishOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishOrder.ForeColor = System.Drawing.Color.White;
            this.btnFinishOrder.Location = new System.Drawing.Point(659, 75);
            this.btnFinishOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(418, 64);
            this.btnFinishOrder.TabIndex = 0;
            this.btnFinishOrder.Text = "Proceed Order";
            this.btnFinishOrder.UseVisualStyleBackColor = false;
            // 
            // pnMenuSelect
            // 
            this.pnMenuSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMenuSelect.Location = new System.Drawing.Point(11, 13);
            this.pnMenuSelect.Name = "pnMenuSelect";
            this.pnMenuSelect.Size = new System.Drawing.Size(1119, 480);
            this.pnMenuSelect.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 658);
            this.Controls.Add(this.pnlOrderDetails);
            this.Controls.Add(this.btnEatIn);
            this.Controls.Add(this.pnMenuSelect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOrderDetails.ResumeLayout(false);
            this.pnlOrderDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Panel pnlOrderDetails;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblAmountOfProducts;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Panel pnMenuSelect;
    }
}

