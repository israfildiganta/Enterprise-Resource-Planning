
namespace Enterprise_Resource_Planning
{
    partial class frmAddingProduct
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
            this.pnlAddingProduct = new System.Windows.Forms.Panel();
            this.txtProductSellingPrice = new System.Windows.Forms.TextBox();
            this.LblProductSellingPrice = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtWarehouseId = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWarehouseId = new System.Windows.Forms.Label();
            this.lblProductCost = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddingProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddingProduct
            // 
            this.pnlAddingProduct.Controls.Add(this.txtProductSellingPrice);
            this.pnlAddingProduct.Controls.Add(this.LblProductSellingPrice);
            this.pnlAddingProduct.Controls.Add(this.cmbProductType);
            this.pnlAddingProduct.Controls.Add(this.lblProductType);
            this.pnlAddingProduct.Controls.Add(this.btnInsert);
            this.pnlAddingProduct.Controls.Add(this.txtWarehouseId);
            this.pnlAddingProduct.Controls.Add(this.txtCost);
            this.pnlAddingProduct.Controls.Add(this.txtName);
            this.pnlAddingProduct.Controls.Add(this.dtTime);
            this.pnlAddingProduct.Controls.Add(this.lblDate);
            this.pnlAddingProduct.Controls.Add(this.lblWarehouseId);
            this.pnlAddingProduct.Controls.Add(this.lblProductCost);
            this.pnlAddingProduct.Controls.Add(this.lblProductName);
            this.pnlAddingProduct.Location = new System.Drawing.Point(2, 7);
            this.pnlAddingProduct.Name = "pnlAddingProduct";
            this.pnlAddingProduct.Size = new System.Drawing.Size(593, 540);
            this.pnlAddingProduct.TabIndex = 0;
            // 
            // txtProductSellingPrice
            // 
            this.txtProductSellingPrice.Location = new System.Drawing.Point(291, 148);
            this.txtProductSellingPrice.Name = "txtProductSellingPrice";
            this.txtProductSellingPrice.Size = new System.Drawing.Size(210, 22);
            this.txtProductSellingPrice.TabIndex = 17;
            // 
            // LblProductSellingPrice
            // 
            this.LblProductSellingPrice.AutoSize = true;
            this.LblProductSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductSellingPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblProductSellingPrice.Location = new System.Drawing.Point(20, 148);
            this.LblProductSellingPrice.Name = "LblProductSellingPrice";
            this.LblProductSellingPrice.Size = new System.Drawing.Size(163, 29);
            this.LblProductSellingPrice.TabIndex = 16;
            this.LblProductSellingPrice.Text = "Selling Price";
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "Food",
            "Furniture",
            "Raw Material",
            "Electronics"});
            this.cmbProductType.Location = new System.Drawing.Point(291, 307);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(210, 24);
            this.cmbProductType.TabIndex = 15;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProductType.Location = new System.Drawing.Point(20, 307);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(169, 29);
            this.lblProductType.TabIndex = 14;
            this.lblProductType.Text = "Product Type";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInsert.Location = new System.Drawing.Point(201, 363);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(137, 44);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtWarehouseId
            // 
            this.txtWarehouseId.Location = new System.Drawing.Point(291, 204);
            this.txtWarehouseId.Name = "txtWarehouseId";
            this.txtWarehouseId.Size = new System.Drawing.Size(210, 22);
            this.txtWarehouseId.TabIndex = 11;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(291, 94);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(210, 22);
            this.txtCost.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(291, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 22);
            this.txtName.TabIndex = 8;
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "yyyy-MM-dd";
            this.dtTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(291, 258);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(210, 22);
            this.dtTime.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDate.Location = new System.Drawing.Point(20, 258);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(216, 29);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Manufacture Date";
            // 
            // lblWarehouseId
            // 
            this.lblWarehouseId.AutoSize = true;
            this.lblWarehouseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWarehouseId.Location = new System.Drawing.Point(20, 204);
            this.lblWarehouseId.Name = "lblWarehouseId";
            this.lblWarehouseId.Size = new System.Drawing.Size(177, 29);
            this.lblWarehouseId.TabIndex = 4;
            this.lblWarehouseId.Text = "Warehouse ID";
            // 
            // lblProductCost
            // 
            this.lblProductCost.AutoSize = true;
            this.lblProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCost.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProductCost.Location = new System.Drawing.Point(20, 89);
            this.lblProductCost.Name = "lblProductCost";
            this.lblProductCost.Size = new System.Drawing.Size(163, 29);
            this.lblProductCost.TabIndex = 2;
            this.lblProductCost.Text = "Product Cost";
            this.lblProductCost.Click += new System.EventHandler(this.Cost_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProductName.Location = new System.Drawing.Point(20, 31);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(179, 29);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Location = new System.Drawing.Point(896, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 36);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // frmAddingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 559);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlAddingProduct);
            this.Name = "frmAddingProduct";
            this.Text = "Adding Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddingProduct_FormClosed);
            this.Load += new System.EventHandler(this.frmAddingProduct_Load);
            this.pnlAddingProduct.ResumeLayout(false);
            this.pnlAddingProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddingProduct;
        private System.Windows.Forms.Label lblProductCost;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtWarehouseId;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblWarehouseId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.TextBox txtProductSellingPrice;
        private System.Windows.Forms.Label LblProductSellingPrice;
    }
}