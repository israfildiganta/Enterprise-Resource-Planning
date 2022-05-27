
namespace Enterprise_Resource_Planning
{
    partial class frmShitfProduct
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
            this.btnShiftTo = new System.Windows.Forms.Button();
            this.pnlShiftProduct = new System.Windows.Forms.Panel();
            this.txtNewWarehouseId = new System.Windows.Forms.TextBox();
            this.lblNewWarehouseId = new System.Windows.Forms.Label();
            this.txtPresentWarehouse = new System.Windows.Forms.TextBox();
            this.lblPrsentWarehouseId = new System.Windows.Forms.Label();
            this.lblSelectProductId = new System.Windows.Forms.Label();
            this.txtSelectProductID = new System.Windows.Forms.TextBox();
            this.pnlShiftProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShiftTo
            // 
            this.btnShiftTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShiftTo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnShiftTo.Location = new System.Drawing.Point(168, 249);
            this.btnShiftTo.Name = "btnShiftTo";
            this.btnShiftTo.Size = new System.Drawing.Size(188, 44);
            this.btnShiftTo.TabIndex = 0;
            this.btnShiftTo.Text = "Shift To >>> ";
            this.btnShiftTo.UseVisualStyleBackColor = true;
            this.btnShiftTo.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pnlShiftProduct
            // 
            this.pnlShiftProduct.Controls.Add(this.txtNewWarehouseId);
            this.pnlShiftProduct.Controls.Add(this.lblNewWarehouseId);
            this.pnlShiftProduct.Controls.Add(this.txtPresentWarehouse);
            this.pnlShiftProduct.Controls.Add(this.lblPrsentWarehouseId);
            this.pnlShiftProduct.Controls.Add(this.lblSelectProductId);
            this.pnlShiftProduct.Controls.Add(this.txtSelectProductID);
            this.pnlShiftProduct.Controls.Add(this.btnShiftTo);
            this.pnlShiftProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShiftProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlShiftProduct.Name = "pnlShiftProduct";
            this.pnlShiftProduct.Size = new System.Drawing.Size(1024, 450);
            this.pnlShiftProduct.TabIndex = 1;
            // 
            // txtNewWarehouseId
            // 
            this.txtNewWarehouseId.Location = new System.Drawing.Point(319, 156);
            this.txtNewWarehouseId.Name = "txtNewWarehouseId";
            this.txtNewWarehouseId.Size = new System.Drawing.Size(178, 22);
            this.txtNewWarehouseId.TabIndex = 13;
            // 
            // lblNewWarehouseId
            // 
            this.lblNewWarehouseId.AutoSize = true;
            this.lblNewWarehouseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewWarehouseId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNewWarehouseId.Location = new System.Drawing.Point(33, 153);
            this.lblNewWarehouseId.Name = "lblNewWarehouseId";
            this.lblNewWarehouseId.Size = new System.Drawing.Size(198, 25);
            this.lblNewWarehouseId.TabIndex = 12;
            this.lblNewWarehouseId.Text = "New Warehouse ID";
            // 
            // txtPresentWarehouse
            // 
            this.txtPresentWarehouse.Location = new System.Drawing.Point(319, 104);
            this.txtPresentWarehouse.Name = "txtPresentWarehouse";
            this.txtPresentWarehouse.Size = new System.Drawing.Size(178, 22);
            this.txtPresentWarehouse.TabIndex = 6;
            // 
            // lblPrsentWarehouseId
            // 
            this.lblPrsentWarehouseId.AutoSize = true;
            this.lblPrsentWarehouseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrsentWarehouseId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrsentWarehouseId.Location = new System.Drawing.Point(33, 100);
            this.lblPrsentWarehouseId.Name = "lblPrsentWarehouseId";
            this.lblPrsentWarehouseId.Size = new System.Drawing.Size(230, 25);
            this.lblPrsentWarehouseId.TabIndex = 5;
            this.lblPrsentWarehouseId.Text = "Present Warehouse ID";
            // 
            // lblSelectProductId
            // 
            this.lblSelectProductId.AutoSize = true;
            this.lblSelectProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProductId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSelectProductId.Location = new System.Drawing.Point(33, 39);
            this.lblSelectProductId.Name = "lblSelectProductId";
            this.lblSelectProductId.Size = new System.Drawing.Size(180, 25);
            this.lblSelectProductId.TabIndex = 2;
            this.lblSelectProductId.Text = "Select Product ID";
            // 
            // txtSelectProductID
            // 
            this.txtSelectProductID.Location = new System.Drawing.Point(319, 43);
            this.txtSelectProductID.Name = "txtSelectProductID";
            this.txtSelectProductID.Size = new System.Drawing.Size(178, 22);
            this.txtSelectProductID.TabIndex = 1;
            // 
            // frmShitfProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.pnlShiftProduct);
            this.Name = "frmShitfProduct";
            this.Text = "Shift Product";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShitfProduct_FormClosed);
            this.Load += new System.EventHandler(this.frmShitfProduct_Load);
            this.pnlShiftProduct.ResumeLayout(false);
            this.pnlShiftProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShiftTo;
        private System.Windows.Forms.Panel pnlShiftProduct;
        private System.Windows.Forms.Label lblSelectProductId;
        private System.Windows.Forms.TextBox txtSelectProductID;
        private System.Windows.Forms.Label lblPrsentWarehouseId;
        private System.Windows.Forms.TextBox txtPresentWarehouse;
        private System.Windows.Forms.TextBox txtNewWarehouseId;
        private System.Windows.Forms.Label lblNewWarehouseId;
    }
}