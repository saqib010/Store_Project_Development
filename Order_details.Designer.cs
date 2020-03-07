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
            this.combosuppliername = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalesName = new System.Windows.Forms.Button();
            this.btnTotalSale = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_get_accounts = new System.Windows.Forms.Button();
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
            this.grid_ord_Detail.Size = new System.Drawing.Size(778, 282);
            this.grid_ord_Detail.TabIndex = 1;
            // 
            // Text_total_amount
            // 
            this.Text_total_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_total_amount.Location = new System.Drawing.Point(370, 330);
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
            this.label1.Location = new System.Drawing.Point(279, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Bill";
            // 
            // btn_ord_show_back
            // 
            this.btn_ord_show_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ord_show_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ord_show_back.Location = new System.Drawing.Point(10, 409);
            this.btn_ord_show_back.Name = "btn_ord_show_back";
            this.btn_ord_show_back.Size = new System.Drawing.Size(121, 48);
            this.btn_ord_show_back.TabIndex = 8;
            this.btn_ord_show_back.Text = "E&XIT";
            this.btn_ord_show_back.UseVisualStyleBackColor = false;
            this.btn_ord_show_back.Click += new System.EventHandler(this.btn_ord_show_back_Click);
            // 
            // Text_total_profit
            // 
            this.Text_total_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_total_profit.Location = new System.Drawing.Point(370, 376);
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
            this.label2.Location = new System.Drawing.Point(249, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Grand Profit";
            // 
            // combosuppliername
            // 
            this.combosuppliername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosuppliername.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combosuppliername.Location = new System.Drawing.Point(643, 304);
            this.combosuppliername.Name = "combosuppliername";
            this.combosuppliername.Size = new System.Drawing.Size(144, 26);
            this.combosuppliername.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Supplier name";
            // 
            // btnSalesName
            // 
            this.btnSalesName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesName.Location = new System.Drawing.Point(657, 344);
            this.btnSalesName.Name = "btnSalesName";
            this.btnSalesName.Size = new System.Drawing.Size(130, 33);
            this.btnSalesName.TabIndex = 13;
            this.btnSalesName.Text = "Product detail";
            this.btnSalesName.UseVisualStyleBackColor = false;
            this.btnSalesName.Click += new System.EventHandler(this.btnSalesName_Click);
            // 
            // btnTotalSale
            // 
            this.btnTotalSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSale.Location = new System.Drawing.Point(657, 383);
            this.btnTotalSale.Name = "btnTotalSale";
            this.btnTotalSale.Size = new System.Drawing.Size(130, 33);
            this.btnTotalSale.TabIndex = 14;
            this.btnTotalSale.Text = "Total Sale";
            this.btnTotalSale.UseVisualStyleBackColor = false;
            this.btnTotalSale.Click += new System.EventHandler(this.btnTotalSale_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Coral;
            this.label20.Location = new System.Drawing.Point(13, 302);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 19);
            this.label20.TabIndex = 84;
            this.label20.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(197, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 19);
            this.label4.TabIndex = 83;
            this.label4.Text = "To:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy:mm:dd";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(233, 304);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker3.TabIndex = 82;
            this.dateTimePicker3.Value = new System.DateTime(2020, 12, 22, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy:mm:dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 304);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 81;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 22, 0, 0, 0, 0);
            // 
            // btn_get_accounts
            // 
            this.btn_get_accounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_get_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_accounts.Location = new System.Drawing.Point(71, 337);
            this.btn_get_accounts.Name = "btn_get_accounts";
            this.btn_get_accounts.Size = new System.Drawing.Size(130, 33);
            this.btn_get_accounts.TabIndex = 85;
            this.btn_get_accounts.Text = "Net Sale";
            this.btn_get_accounts.UseVisualStyleBackColor = false;
            this.btn_get_accounts.Click += new System.EventHandler(this.btn_get_accounts_Click);
            // 
            // Order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(799, 469);
            this.Controls.Add(this.btn_get_accounts);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnTotalSale);
            this.Controls.Add(this.btnSalesName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combosuppliername);
            this.Controls.Add(this.Text_total_profit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ord_show_back);
            this.Controls.Add(this.Text_total_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_ord_Detail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ComboBox combosuppliername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalesName;
        private System.Windows.Forms.Button btnTotalSale;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_get_accounts;
    }
}