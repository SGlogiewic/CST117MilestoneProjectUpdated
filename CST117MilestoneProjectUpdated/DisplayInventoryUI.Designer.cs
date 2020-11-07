namespace CST117MilestoneProjectUpdated
{
    partial class DisplayInventoryUI
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
            this.DisplayInventoryList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DisplayInventoryList
            // 
            this.DisplayInventoryList.FormattingEnabled = true;
            this.DisplayInventoryList.ItemHeight = 20;
            this.DisplayInventoryList.Location = new System.Drawing.Point(32, 27);
            this.DisplayInventoryList.Name = "DisplayInventoryList";
            this.DisplayInventoryList.Size = new System.Drawing.Size(561, 324);
            this.DisplayInventoryList.TabIndex = 0;
            // 
            // DisplayInventoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 384);
            this.Controls.Add(this.DisplayInventoryList);
            this.Name = "DisplayInventoryUI";
            this.Text = "DisplayInventoryUI";
            this.Load += new System.EventHandler(this.DisplayInventoryUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayInventoryList;
    }
}