
namespace Enterprise_Resource_Planning
{
    partial class frmProductDelete
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
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.pnlProductDelete = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvProductDelete = new System.Windows.Forms.DataGridView();
            this.dgvProductDeleteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDeleteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDeleteCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDeleteWarehouseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDeleteManufacturedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDeleteType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProductDelete.Location = new System.Drawing.Point(990, 60);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(407, 123);
            this.btnProductDelete.TabIndex = 0;
            this.btnProductDelete.Text = "Product Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // pnlProductDelete
            // 
            this.pnlProductDelete.Controls.Add(this.btnShow);
            this.pnlProductDelete.Location = new System.Drawing.Point(7, -2);
            this.pnlProductDelete.Name = "pnlProductDelete";
            this.pnlProductDelete.Size = new System.Drawing.Size(794, 145);
            this.pnlProductDelete.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(289, 15);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(153, 51);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvProductDelete
            // 
            this.dgvProductDelete.AllowUserToAddRows = false;
            this.dgvProductDelete.AllowUserToDeleteRows = false;
            this.dgvProductDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductDeleteId,
            this.dgvProductDeleteName,
            this.dgvProductDeleteCost,
            this.dgvProductDeleteWarehouseId,
            this.dgvProductDeleteManufacturedate,
            this.dgvProductDeleteType});
            this.dgvProductDelete.Location = new System.Drawing.Point(12, 144);
            this.dgvProductDelete.Name = "dgvProductDelete";
            this.dgvProductDelete.ReadOnly = true;
            this.dgvProductDelete.RowHeadersWidth = 51;
            this.dgvProductDelete.RowTemplate.Height = 24;
            this.dgvProductDelete.Size = new System.Drawing.Size(789, 308);
            this.dgvProductDelete.TabIndex = 4;
            this.dgvProductDelete.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDelete_CellContentDoubleClick);
            // 
            // dgvProductDeleteId
            // 
            this.dgvProductDeleteId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductDeleteId.DataPropertyName = "Product_id";
            this.dgvProductDeleteId.HeaderText = "Product ID";
            this.dgvProductDeleteId.MinimumWidth = 6;
            this.dgvProductDeleteId.Name = "dgvProductDeleteId";
            this.dgvProductDeleteId.ReadOnly = true;
            // 
            // dgvProductDeleteName
            // 
            this.dgvProductDeleteName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductDeleteName.DataPropertyName = "Product_Name";
            this.dgvProductDeleteName.HeaderText = "Product Name";
            this.dgvProductDeleteName.MinimumWidth = 6;
            this.dgvProductDeleteName.Name = "dgvProductDeleteName";
            this.dgvProductDeleteName.ReadOnly = true;
            // 
            // dgvProductDeleteCost
            // 
            this.dgvProductDeleteCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductDeleteCost.DataPropertyName = "Product_Cost";
            this.dgvProductDeleteCost.HeaderText = "Product Cost";
            this.dgvProductDeleteCost.MinimumWidth = 6;
            this.dgvProductDeleteCost.Name = "dgvProductDeleteCost";
            this.dgvProductDeleteCost.ReadOnly = true;
            // 
            // dgvProductDeleteWarehouseId
            // 
            this.dgvProductDeleteWarehouseId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductDeleteWarehouseId.DataPropertyName = "Warehouse_name";
            this.dgvProductDeleteWarehouseId.HeaderText = "Warehouse ID";
            this.dgvProductDeleteWarehouseId.MinimumWidth = 6;
            this.dgvProductDeleteWarehouseId.Name = "dgvProductDeleteWarehouseId";
            this.dgvProductDeleteWarehouseId.ReadOnly = true;
            // 
            // dgvProductDeleteManufacturedate
            // 
            this.dgvProductDeleteManufacturedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductDeleteManufacturedate.DataPropertyName = "Manufacture_Date";
            this.dgvProductDeleteManufacturedate.HeaderText = "Manufacture Date";
            this.dgvProductDeleteManufacturedate.MinimumWidth = 6;
            this.dgvProductDeleteManufacturedate.Name = "dgvProductDeleteManufacturedate";
            this.dgvProductDeleteManufacturedate.ReadOnly = true;
            // 
            // dgvProductDeleteType
            // 
            this.dgvProductDeleteType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductDeleteType.DataPropertyName = "type";
            this.dgvProductDeleteType.HeaderText = "Product Type";
            this.dgvProductDeleteType.MinimumWidth = 6;
            this.dgvProductDeleteType.Name = "dgvProductDeleteType";
            this.dgvProductDeleteType.ReadOnly = true;
            // 
            // frmProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProductDelete);
            this.Controls.Add(this.pnlProductDelete);
            this.Controls.Add(this.btnProductDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmProductDelete";
            this.Text = "Product Delete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProductDelete_FormClosed);
            this.pnlProductDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Panel pnlProductDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvProductDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductDeleteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductDeleteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductDeleteCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductDeleteWarehouseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductDeleteManufacturedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductDeleteType;
    }
}