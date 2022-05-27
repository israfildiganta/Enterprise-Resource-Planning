
namespace Enterprise_Resource_Planning
{
    partial class frmShowTransaction
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
            this.btnShowTransaction = new System.Windows.Forms.Button();
            this.dgvShowTransaction = new System.Windows.Forms.DataGridView();
            this.dgvShowTransactionProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShowTransactionProduct_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShowTransactionProductCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShowTransactionSelectPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShowTransactionManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowTransaction
            // 
            this.btnShowTransaction.Location = new System.Drawing.Point(312, 14);
            this.btnShowTransaction.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowTransaction.Name = "btnShowTransaction";
            this.btnShowTransaction.Size = new System.Drawing.Size(286, 42);
            this.btnShowTransaction.TabIndex = 0;
            this.btnShowTransaction.Text = "Show Transaction";
            this.btnShowTransaction.UseVisualStyleBackColor = true;
            this.btnShowTransaction.Click += new System.EventHandler(this.btnShowTransaction_Click);
            // 
            // dgvShowTransaction
            // 
            this.dgvShowTransaction.AllowUserToAddRows = false;
            this.dgvShowTransaction.AllowUserToDeleteRows = false;
            this.dgvShowTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvShowTransactionProductName,
            this.dgvShowTransactionProduct_id,
            this.dgvShowTransactionProductCost,
            this.dgvShowTransactionSelectPrice,
            this.dgvShowTransactionManagerName});
            this.dgvShowTransaction.Location = new System.Drawing.Point(12, 244);
            this.dgvShowTransaction.Name = "dgvShowTransaction";
            this.dgvShowTransaction.ReadOnly = true;
            this.dgvShowTransaction.RowHeadersWidth = 51;
            this.dgvShowTransaction.RowTemplate.Height = 24;
            this.dgvShowTransaction.Size = new System.Drawing.Size(958, 312);
            this.dgvShowTransaction.TabIndex = 1;
            this.dgvShowTransaction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowTransaction_CellDoubleClick);
            // 
            // dgvShowTransactionProductName
            // 
            this.dgvShowTransactionProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvShowTransactionProductName.DataPropertyName = "Product_name";
            this.dgvShowTransactionProductName.HeaderText = "Product Name";
            this.dgvShowTransactionProductName.MinimumWidth = 6;
            this.dgvShowTransactionProductName.Name = "dgvShowTransactionProductName";
            this.dgvShowTransactionProductName.ReadOnly = true;
            // 
            // dgvShowTransactionProduct_id
            // 
            this.dgvShowTransactionProduct_id.DataPropertyName = "Product_id";
            this.dgvShowTransactionProduct_id.HeaderText = "Product ID";
            this.dgvShowTransactionProduct_id.MinimumWidth = 6;
            this.dgvShowTransactionProduct_id.Name = "dgvShowTransactionProduct_id";
            this.dgvShowTransactionProduct_id.ReadOnly = true;
            this.dgvShowTransactionProduct_id.Width = 125;
            // 
            // dgvShowTransactionProductCost
            // 
            this.dgvShowTransactionProductCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvShowTransactionProductCost.DataPropertyName = "Product_Cost";
            this.dgvShowTransactionProductCost.HeaderText = "Product Cost";
            this.dgvShowTransactionProductCost.MinimumWidth = 6;
            this.dgvShowTransactionProductCost.Name = "dgvShowTransactionProductCost";
            this.dgvShowTransactionProductCost.ReadOnly = true;
            // 
            // dgvShowTransactionSelectPrice
            // 
            this.dgvShowTransactionSelectPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvShowTransactionSelectPrice.DataPropertyName = "Selling_price";
            this.dgvShowTransactionSelectPrice.HeaderText = "Selling Price";
            this.dgvShowTransactionSelectPrice.MinimumWidth = 6;
            this.dgvShowTransactionSelectPrice.Name = "dgvShowTransactionSelectPrice";
            this.dgvShowTransactionSelectPrice.ReadOnly = true;
            // 
            // dgvShowTransactionManagerName
            // 
            this.dgvShowTransactionManagerName.DataPropertyName = "Manager_Name";
            this.dgvShowTransactionManagerName.HeaderText = "Production Manager Name";
            this.dgvShowTransactionManagerName.MinimumWidth = 6;
            this.dgvShowTransactionManagerName.Name = "dgvShowTransactionManagerName";
            this.dgvShowTransactionManagerName.ReadOnly = true;
            this.dgvShowTransactionManagerName.Width = 125;
            // 
            // frmShowTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvShowTransaction);
            this.Controls.Add(this.btnShowTransaction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmShowTransaction";
            this.Text = "Show Transaction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Show_Transaction_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowTransaction;
        private System.Windows.Forms.DataGridView dgvShowTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShowTransactionProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShowTransactionProduct_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShowTransactionProductCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShowTransactionSelectPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShowTransactionManagerName;
    }
}