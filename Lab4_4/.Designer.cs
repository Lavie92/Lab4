namespace Lab4_4
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
            this.ckbDisplayAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDelivery1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDelivery2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProductOrder = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbDisplayAll
            // 
            this.ckbDisplayAll.AutoSize = true;
            this.ckbDisplayAll.Location = new System.Drawing.Point(61, 38);
            this.ckbDisplayAll.Name = "ckbDisplayAll";
            this.ckbDisplayAll.Size = new System.Drawing.Size(126, 17);
            this.ckbDisplayAll.TabIndex = 0;
            this.ckbDisplayAll.Text = "Xem tất cả đơn hàng";
            this.ckbDisplayAll.UseVisualStyleBackColor = true;
            this.ckbDisplayAll.CheckedChanged += new System.EventHandler(this.ckbDisplayAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời Gian Giao Hàng";
            // 
            // dtpDelivery1
            // 
            this.dtpDelivery1.CustomFormat = "dd/MM/yyyy";
            this.dtpDelivery1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDelivery1.Location = new System.Drawing.Point(191, 75);
            this.dtpDelivery1.Name = "dtpDelivery1";
            this.dtpDelivery1.Size = new System.Drawing.Size(113, 20);
            this.dtpDelivery1.TabIndex = 2;
            this.dtpDelivery1.ValueChanged += new System.EventHandler(this.dtpDelivery1_ValueChanged);
            // 
            // dtpDelivery2
            // 
            this.dtpDelivery2.CustomFormat = "dd/MM/yyyy";
            this.dtpDelivery2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDelivery2.Location = new System.Drawing.Point(386, 75);
            this.dtpDelivery2.Name = "dtpDelivery2";
            this.dtpDelivery2.Size = new System.Drawing.Size(113, 20);
            this.dtpDelivery2.TabIndex = 2;
            this.dtpDelivery2.ValueChanged += new System.EventHandler(this.dtpDelivery2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "~~";
            // 
            // dgvProductOrder
            // 
            this.dgvProductOrder.AllowUserToAddRows = false;
            this.dgvProductOrder.AllowUserToDeleteRows = false;
            this.dgvProductOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.InvoiceNo,
            this.OrderDate,
            this.DeliveryDate,
            this.Total});
            this.dgvProductOrder.Location = new System.Drawing.Point(64, 137);
            this.dgvProductOrder.Name = "dgvProductOrder";
            this.dgvProductOrder.ReadOnly = true;
            this.dgvProductOrder.Size = new System.Drawing.Size(691, 291);
            this.dgvProductOrder.TabIndex = 3;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "STT";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "Số HĐ";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Ngày Đặt Hàng";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Ngày Giao Hàng";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Thành Tiền";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductOrder);
            this.Controls.Add(this.dtpDelivery2);
            this.Controls.Add(this.dtpDelivery1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbDisplayAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbDisplayAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDelivery1;
        private System.Windows.Forms.DateTimePicker dtpDelivery2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProductOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

