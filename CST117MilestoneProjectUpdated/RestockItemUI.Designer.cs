namespace CST117MilestoneProjectUpdated
{
    partial class RestockItemUI
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.RestockButton = new System.Windows.Forms.Button();
            this.ItemQuantityList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(172, 28);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(236, 35);
            this.txtQty.TabIndex = 1;
            // 
            // RestockButton
            // 
            this.RestockButton.Location = new System.Drawing.Point(455, 18);
            this.RestockButton.Name = "RestockButton";
            this.RestockButton.Size = new System.Drawing.Size(155, 55);
            this.RestockButton.TabIndex = 2;
            this.RestockButton.Text = "Restock Item";
            this.RestockButton.UseVisualStyleBackColor = true;
            this.RestockButton.Click += new System.EventHandler(this.RestockButton_Click);
            // 
            // ItemQuantityList
            // 
            this.ItemQuantityList.FormattingEnabled = true;
            this.ItemQuantityList.ItemHeight = 20;
            this.ItemQuantityList.Location = new System.Drawing.Point(45, 99);
            this.ItemQuantityList.Name = "ItemQuantityList";
            this.ItemQuantityList.Size = new System.Drawing.Size(565, 264);
            this.ItemQuantityList.TabIndex = 3;
            // 
            // RestockItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 408);
            this.Controls.Add(this.ItemQuantityList);
            this.Controls.Add(this.RestockButton);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label1);
            this.Name = "RestockItemUI";
            this.Text = "RestockItemUI";
            this.Load += new System.EventHandler(this.RestockItemUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button RestockButton;
        private System.Windows.Forms.ListBox ItemQuantityList;
    }
}