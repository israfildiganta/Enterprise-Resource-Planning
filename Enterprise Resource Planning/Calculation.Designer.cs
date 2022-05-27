
namespace Enterprise_Resource_Planning
{
    partial class frmCalculation
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
            this.btnShowCalculation = new System.Windows.Forms.Button();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblShowExpense = new System.Windows.Forms.Label();
            this.lblShowincome = new System.Windows.Forms.Label();
            this.lblShowProfit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowCalculation
            // 
            this.btnShowCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCalculation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnShowCalculation.Location = new System.Drawing.Point(309, 54);
            this.btnShowCalculation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowCalculation.Name = "btnShowCalculation";
            this.btnShowCalculation.Size = new System.Drawing.Size(236, 70);
            this.btnShowCalculation.TabIndex = 0;
            this.btnShowCalculation.Text = "Show Calculation";
            this.btnShowCalculation.UseVisualStyleBackColor = true;
            this.btnShowCalculation.Click += new System.EventHandler(this.btnShowCalculation_Click);
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(49, 289);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(129, 38);
            this.lblIncome.TabIndex = 1;
            this.lblIncome.Text = "Income";
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(40, 199);
            this.lblExpense.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(152, 38);
            this.lblExpense.TabIndex = 2;
            this.lblExpense.Text = "Expense";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(59, 367);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(99, 38);
            this.lblProfit.TabIndex = 3;
            this.lblProfit.Text = "Profit";
            // 
            // lblShowExpense
            // 
            this.lblShowExpense.AutoSize = true;
            this.lblShowExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowExpense.Location = new System.Drawing.Point(395, 289);
            this.lblShowExpense.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowExpense.Name = "lblShowExpense";
            this.lblShowExpense.Size = new System.Drawing.Size(0, 38);
            this.lblShowExpense.TabIndex = 7;
            // 
            // lblShowincome
            // 
            this.lblShowincome.AutoSize = true;
            this.lblShowincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowincome.Location = new System.Drawing.Point(395, 218);
            this.lblShowincome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowincome.Name = "lblShowincome";
            this.lblShowincome.Size = new System.Drawing.Size(0, 38);
            this.lblShowincome.TabIndex = 8;
            // 
            // lblShowProfit
            // 
            this.lblShowProfit.AutoSize = true;
            this.lblShowProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowProfit.Location = new System.Drawing.Point(395, 367);
            this.lblShowProfit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShowProfit.Name = "lblShowProfit";
            this.lblShowProfit.Size = new System.Drawing.Size(0, 38);
            this.lblShowProfit.TabIndex = 9;
            // 
            // frmCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblShowProfit);
            this.Controls.Add(this.lblShowincome);
            this.Controls.Add(this.lblShowExpense);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblExpense);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.btnShowCalculation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCalculation";
            this.Text = "Calculation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCalculation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowCalculation;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblShowExpense;
        private System.Windows.Forms.Label lblShowincome;
        private System.Windows.Forms.Label lblShowProfit;
    }
}