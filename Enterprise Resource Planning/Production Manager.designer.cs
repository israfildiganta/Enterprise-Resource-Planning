
namespace Enterprise_Resource_Planning
{
    partial class frmProductionManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductInformation = new System.Windows.Forms.Button();
            this.btnAddingWarehouse = new System.Windows.Forms.Button();
            this.btnAddingProduct = new System.Windows.Forms.Button();
            this.btnShiftingWareHouse = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProductionManagerDeleteProduct = new System.Windows.Forms.Button();
            this.lblShowProductionMangerName = new System.Windows.Forms.Label();
            this.lblShowProductionManagerID = new System.Windows.Forms.Label();
            this.btnProductManagerApplyForLeave = new System.Windows.Forms.Button();
            this.btnProductionManagerLeaveRequestStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Production Manager";
            // 
            // btnProductInformation
            // 
            this.btnProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInformation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProductInformation.Location = new System.Drawing.Point(39, 82);
            this.btnProductInformation.Name = "btnProductInformation";
            this.btnProductInformation.Size = new System.Drawing.Size(339, 40);
            this.btnProductInformation.TabIndex = 1;
            this.btnProductInformation.Text = "Show Production List";
            this.btnProductInformation.UseVisualStyleBackColor = true;
            this.btnProductInformation.Click += new System.EventHandler(this.btnProductInformation_Click);
            // 
            // btnAddingWarehouse
            // 
            this.btnAddingWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddingWarehouse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddingWarehouse.Location = new System.Drawing.Point(39, 148);
            this.btnAddingWarehouse.Name = "btnAddingWarehouse";
            this.btnAddingWarehouse.Size = new System.Drawing.Size(339, 40);
            this.btnAddingWarehouse.TabIndex = 4;
            this.btnAddingWarehouse.Text = "Adding Warehouse";
            this.btnAddingWarehouse.UseVisualStyleBackColor = true;
            this.btnAddingWarehouse.Click += new System.EventHandler(this.btnAddingWarehouse_Click);
            // 
            // btnAddingProduct
            // 
            this.btnAddingProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddingProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddingProduct.Location = new System.Drawing.Point(39, 207);
            this.btnAddingProduct.Name = "btnAddingProduct";
            this.btnAddingProduct.Size = new System.Drawing.Size(339, 40);
            this.btnAddingProduct.TabIndex = 6;
            this.btnAddingProduct.Text = "Adding Product";
            this.btnAddingProduct.UseVisualStyleBackColor = true;
            this.btnAddingProduct.Click += new System.EventHandler(this.btnAddingProduct_Click);
            // 
            // btnShiftingWareHouse
            // 
            this.btnShiftingWareHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftingWareHouse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShiftingWareHouse.Location = new System.Drawing.Point(39, 326);
            this.btnShiftingWareHouse.Name = "btnShiftingWareHouse";
            this.btnShiftingWareHouse.Size = new System.Drawing.Size(339, 40);
            this.btnShiftingWareHouse.TabIndex = 7;
            this.btnShiftingWareHouse.Text = "Shifting Product";
            this.btnShiftingWareHouse.UseVisualStyleBackColor = true;
            this.btnShiftingWareHouse.Click += new System.EventHandler(this.btnShiftingWareHouse_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(795, 148);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(173, 40);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProductionManagerDeleteProduct
            // 
            this.btnProductionManagerDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductionManagerDeleteProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProductionManagerDeleteProduct.Location = new System.Drawing.Point(39, 264);
            this.btnProductionManagerDeleteProduct.Name = "btnProductionManagerDeleteProduct";
            this.btnProductionManagerDeleteProduct.Size = new System.Drawing.Size(339, 40);
            this.btnProductionManagerDeleteProduct.TabIndex = 11;
            this.btnProductionManagerDeleteProduct.Text = "Delete Product";
            this.btnProductionManagerDeleteProduct.UseVisualStyleBackColor = true;
            this.btnProductionManagerDeleteProduct.Click += new System.EventHandler(this.btnProductionManagerDeleteProduct_Click);
            // 
            // lblShowProductionMangerName
            // 
            this.lblShowProductionMangerName.AutoSize = true;
            this.lblShowProductionMangerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowProductionMangerName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblShowProductionMangerName.Location = new System.Drawing.Point(838, 30);
            this.lblShowProductionMangerName.Name = "lblShowProductionMangerName";
            this.lblShowProductionMangerName.Size = new System.Drawing.Size(85, 29);
            this.lblShowProductionMangerName.TabIndex = 12;
            this.lblShowProductionMangerName.Text = "label2";
            // 
            // lblShowProductionManagerID
            // 
            this.lblShowProductionManagerID.AutoSize = true;
            this.lblShowProductionManagerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowProductionManagerID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblShowProductionManagerID.Location = new System.Drawing.Point(838, 82);
            this.lblShowProductionManagerID.Name = "lblShowProductionManagerID";
            this.lblShowProductionManagerID.Size = new System.Drawing.Size(85, 29);
            this.lblShowProductionManagerID.TabIndex = 13;
            this.lblShowProductionManagerID.Text = "label2";
            // 
            // btnProductManagerApplyForLeave
            // 
            this.btnProductManagerApplyForLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagerApplyForLeave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProductManagerApplyForLeave.Location = new System.Drawing.Point(39, 387);
            this.btnProductManagerApplyForLeave.Name = "btnProductManagerApplyForLeave";
            this.btnProductManagerApplyForLeave.Size = new System.Drawing.Size(339, 40);
            this.btnProductManagerApplyForLeave.TabIndex = 14;
            this.btnProductManagerApplyForLeave.Text = "Apply For Leave";
            this.btnProductManagerApplyForLeave.UseVisualStyleBackColor = true;
            this.btnProductManagerApplyForLeave.Click += new System.EventHandler(this.btnProductManagerApplyForLeave_Click);
            // 
            // btnProductionManagerLeaveRequestStatus
            // 
            this.btnProductionManagerLeaveRequestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductionManagerLeaveRequestStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProductionManagerLeaveRequestStatus.Location = new System.Drawing.Point(39, 447);
            this.btnProductionManagerLeaveRequestStatus.Name = "btnProductionManagerLeaveRequestStatus";
            this.btnProductionManagerLeaveRequestStatus.Size = new System.Drawing.Size(339, 40);
            this.btnProductionManagerLeaveRequestStatus.TabIndex = 15;
            this.btnProductionManagerLeaveRequestStatus.Text = "Leave Request Status";
            this.btnProductionManagerLeaveRequestStatus.UseVisualStyleBackColor = true;
            this.btnProductionManagerLeaveRequestStatus.Click += new System.EventHandler(this.btnProductionManagerLeaveRequestStatus_Click);
            // 
            // frmProductionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1022, 519);
            this.Controls.Add(this.btnProductionManagerLeaveRequestStatus);
            this.Controls.Add(this.btnProductManagerApplyForLeave);
            this.Controls.Add(this.lblShowProductionManagerID);
            this.Controls.Add(this.lblShowProductionMangerName);
            this.Controls.Add(this.btnProductionManagerDeleteProduct);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnShiftingWareHouse);
            this.Controls.Add(this.btnAddingProduct);
            this.Controls.Add(this.btnAddingWarehouse);
            this.Controls.Add(this.btnProductInformation);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProductionManager";
            this.Text = "Production Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProductionManager_FormClosed);
            this.Load += new System.EventHandler(this.frmProductionMnager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductInformation;
        private System.Windows.Forms.Button btnAddingWarehouse;
        private System.Windows.Forms.Button btnAddingProduct;
        private System.Windows.Forms.Button btnShiftingWareHouse;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProductionManagerDeleteProduct;
        private System.Windows.Forms.Label lblShowProductionMangerName;
        private System.Windows.Forms.Label lblShowProductionManagerID;
        private System.Windows.Forms.Button btnProductManagerApplyForLeave;
        private System.Windows.Forms.Button btnProductionManagerLeaveRequestStatus;
    }
}

