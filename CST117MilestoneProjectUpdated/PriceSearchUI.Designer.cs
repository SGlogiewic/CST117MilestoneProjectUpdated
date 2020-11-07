namespace CST117MilestoneProjectUpdated
{
    partial class PriceSearchUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.PriceSearchButton = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.PriceSearchResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price:";
            // 
            // PriceSearchButton
            // 
            this.PriceSearchButton.Location = new System.Drawing.Point(464, 34);
            this.PriceSearchButton.Name = "PriceSearchButton";
            this.PriceSearchButton.Size = new System.Drawing.Size(147, 55);
            this.PriceSearchButton.TabIndex = 1;
            this.PriceSearchButton.Text = "Search by Price";
            this.PriceSearchButton.UseVisualStyleBackColor = true;
            this.PriceSearchButton.Click += new System.EventHandler(this.PriceSearchButton_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(182, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(234, 35);
            this.txtPrice.TabIndex = 2;
            // 
            // PriceSearchResults
            // 
            this.PriceSearchResults.FormattingEnabled = true;
            this.PriceSearchResults.ItemHeight = 20;
            this.PriceSearchResults.Location = new System.Drawing.Point(94, 128);
            this.PriceSearchResults.Name = "PriceSearchResults";
            this.PriceSearchResults.Size = new System.Drawing.Size(450, 264);
            this.PriceSearchResults.TabIndex = 3;
            // 
            // PriceSearchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.PriceSearchResults);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.PriceSearchButton);
            this.Controls.Add(this.label1);
            this.Name = "PriceSearchUI";
            this.Text = "PriceSearchUI";
            this.Load += new System.EventHandler(this.PriceSearchUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PriceSearchButton;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox PriceSearchResults;
    }
}