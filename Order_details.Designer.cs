namespace Store
{
    partial class Order_details
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
            this.grid_ord_Detail = new System.Windows.Forms.DataGridView();
            this.Text_total_amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ord_show_back = new System.Windows.Forms.Button();
            this.Text_total_profit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ord_Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_ord_Detail
            // 
            this.grid_ord_Detail.AllowUserToAddRows = false;
            this.grid_ord_Detail.AllowUserToDeleteRows = false;
            this.grid_ord_Detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ord_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ord_Detail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_ord_Detail.Enabled = false;
            this.grid_ord_Detail.Location = new System.Drawing.Point(10, 12);
            this.grid_ord_Detail.Name = "grid_ord_Detail";
            this.grid_ord_Detail.ReadOnly = true;
            this.grid_ord_Detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ord_Detail.Size = new System.Drawing.Size(778, 314);
            this.grid_ord_Detail.TabIndex = 1;
            // 
            // Text_total_amount
            // 
            this.Text_total_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_total_amount.Location = new System.Drawing.Point(611, 347);
            this.Text_total_amount.Name = "Text_total_amount";
            this.Text_total_amount.ReadOnly = true;
            this.Text_total_amount.Size = new System.Drawing.Size(145, 26);
            this.Text_total_amount.TabIndex = 7;
            this.Text_total_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Amount";
            // 
            // btn_ord_show_back
            // 
            this.btn_ord_show_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ord_show_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ord_show_back.Location = new System.Drawing.Point(23, 345);
            this.btn_ord_show_back.Name = "btn_ord_show_back";
            this.btn_ord_show_back.Size = new System.Drawing.Size(108, 33);
            this.btn_ord_show_back.TabIndex = 8;
            this.btn_ord_show_back.Text = "E&XIT";
            this.btn_ord_show_back.UseVisualStyleBackColor = false;
            this.btn_ord_show_back.Click += new System.EventHandler(this.btn_ord_show_back_Click);
            // 
            // Text_total_profit
            // 
            this.Text_total_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_total_profit.Location = new System.Drawing.Point(318, 349);
            this.Text_total_profit.Name = "Text_total_profit";
            this.Text_total_profit.ReadOnly = true;
            this.Text_total_profit.Size = new System.Drawing.Size(145, 26);
            this.Text_total_profit.TabIndex = 10;
            this.Text_total_profit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Profit";
            // 
            // Order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(801, 395);
            this.Controls.Add(this.Text_total_profit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ord_show_back);
            this.Controls.Add(this.Text_total_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_ord_Detail);
            this.Name = "Order_details";
            this.Text = "Order_details";
            ((System.ComponentModel.ISupportInitialize)(this.grid_ord_Detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ord_Detail;
        private System.Windows.Forms.TextBox Text_total_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ord_show_back;
        private System.Windows.Forms.TextBox Text_total_profit;
        private System.Windows.Forms.Label label2;
    }
}