
namespace Enterprise_Resource_Planning
{
    partial class frmShowProductionList
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
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.plnShowInfo = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblSearchWarehouse = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchId = new System.Windows.Forms.Label();
            this.txtWarehouseSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.dgvProductManagerProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductManagerSellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductManagerProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacture_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.plnShowInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductManagerProductName,
            this.dgvProductManagerSellingPrice,
            this.dgvProductManagerProductID,
            this.Product_Cost,
            this.Warehouse_Name,
            this.Manufacture_Date});
            this.dgvView.Location = new System.Drawing.Point(-1, 258);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersWidth = 51;
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(797, 188);
            this.dgvView.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(690, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 61);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // plnShowInfo
            // 
            this.plnShowInfo.Controls.Add(this.btnClear);
            this.plnShowInfo.Controls.Add(this.btnShow);
            this.plnShowInfo.Controls.Add(this.lblSearchWarehouse);
            this.plnShowInfo.Controls.Add(this.lblSearchName);
            this.plnShowInfo.Controls.Add(this.lblSearchId);
            this.plnShowInfo.Controls.Add(this.txtWarehouseSearch);
            this.plnShowInfo.Controls.Add(this.txtNameSearch);
            this.plnShowInfo.Controls.Add(this.txtIDSearch);
            this.plnShowInfo.Location = new System.Drawing.Point(12, 2);
            this.plnShowInfo.Name = "plnShowInfo";
            this.plnShowInfo.Size = new System.Drawing.Size(625, 250);
            this.plnShowInfo.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(347, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 43);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnShow.Location = new System.Drawing.Point(97, 163);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(161, 43);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblSearchWarehouse
            // 
            this.lblSearchWarehouse.AutoSize = true;
            this.lblSearchWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchWarehouse.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearchWarehouse.Location = new System.Drawing.Point(72, 113);
            this.lblSearchWarehouse.Name = "lblSearchWarehouse";
            this.lblSearchWarehouse.Size = new System.Drawing.Size(234, 29);
            this.lblSearchWarehouse.TabIndex = 15;
            this.lblSearchWarehouse.Text = "Search Warehouse";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearchName.Location = new System.Drawing.Point(72, 68);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(171, 29);
            this.lblSearchName.TabIndex = 14;
            this.lblSearchName.Text = "Search Name";
            // 
            // lblSearchId
            // 
            this.lblSearchId.AutoSize = true;
            this.lblSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearchId.Location = new System.Drawing.Point(72, 22);
            this.lblSearchId.Name = "lblSearchId";
            this.lblSearchId.Size = new System.Drawing.Size(127, 29);
            this.lblSearchId.TabIndex = 11;
            this.lblSearchId.Text = "Search ID";
            // 
            // txtWarehouseSearch
            // 
            this.txtWarehouseSearch.Location = new System.Drawing.Point(321, 120);
            this.txtWarehouseSearch.Name = "txtWarehouseSearch";
            this.txtWarehouseSearch.Size = new System.Drawing.Size(219, 22);
            this.txtWarehouseSearch.TabIndex = 10;
            this.txtWarehouseSearch.TextChanged += new System.EventHandler(this.txtWarehouseSearch_TextChanged);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(321, 75);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(219, 22);
            this.txtNameSearch.TabIndex = 9;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(321, 29);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(219, 22);
            this.txtIDSearch.TabIndex = 8;
            this.txtIDSearch.TextChanged += new System.EventHandler(this.txtIDSearch_TextChanged);
            // 
            // dgvProductManagerProductName
            // 
            this.dgvProductManagerProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductManagerProductName.DataPropertyName = "Product_Name";
            this.dgvProductManagerProductName.HeaderText = "Name";
            this.dgvProductManagerProductName.MinimumWidth = 6;
            this.dgvProductManagerProductName.Name = "dgvProductManagerProductName";
            this.dgvProductManagerProductName.ReadOnly = true;
            // 
            // dgvProductManagerSellingPrice
            // 
            this.dgvProductManagerSellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductManagerSellingPrice.DataPropertyName = "Selling_Price";
            this.dgvProductManagerSellingPrice.HeaderText = "Selling Price";
            this.dgvProductManagerSellingPrice.MinimumWidth = 6;
            this.dgvProductManagerSellingPrice.Name = "dgvProductManagerSellingPrice";
            this.dgvProductManagerSellingPrice.ReadOnly = true;
            // 
            // dgvProductManagerProductID
            // 
            this.dgvProductManagerProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductManagerProductID.DataPropertyName = "Product_id";
            this.dgvProductManagerProductID.HeaderText = "ID";
            this.dgvProductManagerProductID.MinimumWidth = 6;
            this.dgvProductManagerProductID.Name = "dgvProductManagerProductID";
            this.dgvProductManagerProductID.ReadOnly = true;
            // 
            // Product_Cost
            // 
            this.Product_Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product_Cost.DataPropertyName = "Product_Cost";
            this.Product_Cost.HeaderText = "Cost";
            this.Product_Cost.MinimumWidth = 6;
            this.Product_Cost.Name = "Product_Cost";
            this.Product_Cost.ReadOnly = true;
            // 
            // Warehouse_Name
            // 
            this.Warehouse_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Warehouse_Name.DataPropertyName = "WareHouse_name";
            this.Warehouse_Name.HeaderText = "Warehouse Name";
            this.Warehouse_Name.MinimumWidth = 6;
            this.Warehouse_Name.Name = "Warehouse_Name";
            this.Warehouse_Name.ReadOnly = true;
            // 
            // Manufacture_Date
            // 
            this.Manufacture_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manufacture_Date.DataPropertyName = "Manufacture_Date";
            this.Manufacture_Date.HeaderText = "Date";
            this.Manufacture_Date.MinimumWidth = 6;
            this.Manufacture_Date.Name = "Manufacture_Date";
            this.Manufacture_Date.ReadOnly = true;
            // 
            // frmShowProductionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plnShowInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvView);
            this.Name = "frmShowProductionList";
            this.Text = "Show Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShowProductionList_FormClosed);
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.plnShowInfo.ResumeLayout(false);
            this.plnShowInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel plnShowInfo;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblSearchWarehouse;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Label lblSearchId;
        private System.Windows.Forms.TextBox txtWarehouseSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductManagerProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductManagerSellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductManagerProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacture_Date;
    }
}