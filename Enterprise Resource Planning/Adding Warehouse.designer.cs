
namespace Enterprise_Resource_Planning
{
    partial class frmAddingWarehouse
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddingWarehouse = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtWarehouseCapacity = new System.Windows.Forms.TextBox();
            this.txtWarehouseLocation = new System.Windows.Forms.TextBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvView1 = new System.Windows.Forms.DataGridView();
            this.dgvProductManagerWarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductManagerQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductManagerWarehouseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductManagerLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductManagerCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAddingWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(704, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlAddingWarehouse
            // 
            this.pnlAddingWarehouse.Controls.Add(this.btnInsert);
            this.pnlAddingWarehouse.Controls.Add(this.txtWarehouseCapacity);
            this.pnlAddingWarehouse.Controls.Add(this.txtWarehouseLocation);
            this.pnlAddingWarehouse.Controls.Add(this.txtWarehouseName);
            this.pnlAddingWarehouse.Controls.Add(this.lblCapacity);
            this.pnlAddingWarehouse.Controls.Add(this.lblLocation);
            this.pnlAddingWarehouse.Controls.Add(this.lblName);
            this.pnlAddingWarehouse.Location = new System.Drawing.Point(12, 3);
            this.pnlAddingWarehouse.Name = "pnlAddingWarehouse";
            this.pnlAddingWarehouse.Size = new System.Drawing.Size(670, 238);
            this.pnlAddingWarehouse.TabIndex = 1;
            this.pnlAddingWarehouse.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(229, 175);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(104, 35);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtWarehouseCapacity
            // 
            this.txtWarehouseCapacity.Location = new System.Drawing.Point(229, 112);
            this.txtWarehouseCapacity.Name = "txtWarehouseCapacity";
            this.txtWarehouseCapacity.Size = new System.Drawing.Size(228, 22);
            this.txtWarehouseCapacity.TabIndex = 9;
            // 
            // txtWarehouseLocation
            // 
            this.txtWarehouseLocation.Location = new System.Drawing.Point(229, 71);
            this.txtWarehouseLocation.Name = "txtWarehouseLocation";
            this.txtWarehouseLocation.Size = new System.Drawing.Size(228, 22);
            this.txtWarehouseLocation.TabIndex = 7;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(229, 26);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(228, 22);
            this.txtWarehouseName.TabIndex = 5;
            this.txtWarehouseName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(3, 108);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(97, 25);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(6, 67);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(94, 25);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(185, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Warehouse Name";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(701, 72);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(94, 35);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvView1
            // 
            this.dgvView1.AllowUserToAddRows = false;
            this.dgvView1.AllowUserToDeleteRows = false;
            this.dgvView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductManagerWarehouseName,
            this.dgvProductManagerQuantity,
            this.dgvProductManagerWarehouseID,
            this.dgvProductManagerLocation,
            this.dgvProductManagerCapacity});
            this.dgvView1.Location = new System.Drawing.Point(12, 247);
            this.dgvView1.Name = "dgvView1";
            this.dgvView1.ReadOnly = true;
            this.dgvView1.RowHeadersWidth = 51;
            this.dgvView1.RowTemplate.Height = 24;
            this.dgvView1.Size = new System.Drawing.Size(790, 200);
            this.dgvView1.TabIndex = 3;
            this.dgvView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView1_CellDoubleClick);
            // 
            // dgvProductManagerWarehouseName
            // 
            this.dgvProductManagerWarehouseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductManagerWarehouseName.DataPropertyName = "Warehouse_Name";
            this.dgvProductManagerWarehouseName.HeaderText = "Name";
            this.dgvProductManagerWarehouseName.MinimumWidth = 6;
            this.dgvProductManagerWarehouseName.Name = "dgvProductManagerWarehouseName";
            this.dgvProductManagerWarehouseName.ReadOnly = true;
            // 
            // dgvProductManagerQuantity
            // 
            this.dgvProductManagerQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductManagerQuantity.DataPropertyName = "Quantity";
            this.dgvProductManagerQuantity.HeaderText = "Quantity";
            this.dgvProductManagerQuantity.MinimumWidth = 6;
            this.dgvProductManagerQuantity.Name = "dgvProductManagerQuantity";
            this.dgvProductManagerQuantity.ReadOnly = true;
            // 
            // dgvProductManagerWarehouseID
            // 
            this.dgvProductManagerWarehouseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductManagerWarehouseID.DataPropertyName = "Warehouse_id";
            this.dgvProductManagerWarehouseID.HeaderText = "ID";
            this.dgvProductManagerWarehouseID.MinimumWidth = 6;
            this.dgvProductManagerWarehouseID.Name = "dgvProductManagerWarehouseID";
            this.dgvProductManagerWarehouseID.ReadOnly = true;
            // 
            // dgvProductManagerLocation
            // 
            this.dgvProductManagerLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductManagerLocation.DataPropertyName = "Location";
            this.dgvProductManagerLocation.HeaderText = "Location";
            this.dgvProductManagerLocation.MinimumWidth = 6;
            this.dgvProductManagerLocation.Name = "dgvProductManagerLocation";
            this.dgvProductManagerLocation.ReadOnly = true;
            // 
            // dgvProductManagerCapacity
            // 
            this.dgvProductManagerCapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductManagerCapacity.DataPropertyName = "Capacity";
            this.dgvProductManagerCapacity.HeaderText = "Capacity";
            this.dgvProductManagerCapacity.MinimumWidth = 6;
            this.dgvProductManagerCapacity.Name = "dgvProductManagerCapacity";
            this.dgvProductManagerCapacity.ReadOnly = true;
            // 
            // frmAddingWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvView1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pnlAddingWarehouse);
            this.Controls.Add(this.btnBack);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "frmAddingWarehouse";
            this.Text = "Adding Warehouse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.frmAddingWarehouse_Load);
            this.pnlAddingWarehouse.ResumeLayout(false);
            this.pnlAddingWarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlAddingWarehouse;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtWarehouseCapacity;
        private System.Windows.Forms.TextBox txtWarehouseLocation;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductManagerWarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductManagerQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductManagerWarehouseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductManagerLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductManagerCapacity;
    }
}