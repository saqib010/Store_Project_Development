namespace Store
{
    partial class FinalBill
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
            this.FinalBillPanel = new System.Windows.Forms.Panel();
            this.FinalBillGridView = new System.Windows.Forms.DataGridView();
            this.FinalBillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FinalBillPanel
            // 
            this.FinalBillPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FinalBillPanel.Controls.Add(this.FinalBillGridView);
            this.FinalBillPanel.Location = new System.Drawing.Point(154, 85);
            this.FinalBillPanel.Name = "FinalBillPanel";
            this.FinalBillPanel.Size = new System.Drawing.Size(265, 120);
            this.FinalBillPanel.TabIndex = 0;
            // 
            // FinalBillGridView
            // 
            this.FinalBillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinalBillGridView.Location = new System.Drawing.Point(25, 3);
            this.FinalBillGridView.Name = "FinalBillGridView";
            this.FinalBillGridView.Size = new System.Drawing.Size(220, 114);
            this.FinalBillGridView.TabIndex = 0;
            // 
            // FinalBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinalBillPanel);
            this.Name = "FinalBill";
            this.Text = "FinalBill";
            this.FinalBillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FinalBillGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FinalBillPanel;
        private System.Windows.Forms.DataGridView FinalBillGridView;
    }
}