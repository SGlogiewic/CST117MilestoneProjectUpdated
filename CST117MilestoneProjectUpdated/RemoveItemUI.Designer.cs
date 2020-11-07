namespace CST117MilestoneProjectUpdated
{
    partial class RemoveItemUI
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
            this.RemoveItemList = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveItemList
            // 
            this.RemoveItemList.FormattingEnabled = true;
            this.RemoveItemList.ItemHeight = 20;
            this.RemoveItemList.Location = new System.Drawing.Point(33, 29);
            this.RemoveItemList.Name = "RemoveItemList";
            this.RemoveItemList.Size = new System.Drawing.Size(467, 244);
            this.RemoveItemList.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(33, 280);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(467, 42);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove Item";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 352);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.RemoveItemList);
            this.Name = "RemoveItemUI";
            this.Text = "RemoveItemUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox RemoveItemList;
        private System.Windows.Forms.Button RemoveButton;
    }
}