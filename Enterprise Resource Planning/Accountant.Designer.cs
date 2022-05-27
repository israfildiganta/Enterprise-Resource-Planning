
namespace Enterprise_Resource_Planning
{
    partial class frmAccountant
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblShowAccountantName = new System.Windows.Forms.Label();
            this.lblAccountantId = new System.Windows.Forms.Label();
            this.btnShowTransaction = new System.Windows.Forms.Button();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.btnAccountantApplyForLeave = new System.Windows.Forms.Button();
            this.btnAccountantShowLeaveRequestStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(815, 26);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 42);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblShowAccountantName
            // 
            this.lblShowAccountantName.AutoSize = true;
            this.lblShowAccountantName.Location = new System.Drawing.Point(810, 138);
            this.lblShowAccountantName.Name = "lblShowAccountantName";
            this.lblShowAccountantName.Size = new System.Drawing.Size(85, 29);
            this.lblShowAccountantName.TabIndex = 1;
            this.lblShowAccountantName.Text = "label1";
            // 
            // lblAccountantId
            // 
            this.lblAccountantId.AutoSize = true;
            this.lblAccountantId.Location = new System.Drawing.Point(810, 212);
            this.lblAccountantId.Name = "lblAccountantId";
            this.lblAccountantId.Size = new System.Drawing.Size(85, 29);
            this.lblAccountantId.TabIndex = 2;
            this.lblAccountantId.Text = "label1";
            this.lblAccountantId.Click += new System.EventHandler(this.lblAccountantId_Click);
            // 
            // btnShowTransaction
            // 
            this.btnShowTransaction.Location = new System.Drawing.Point(97, 128);
            this.btnShowTransaction.Name = "btnShowTransaction";
            this.btnShowTransaction.Size = new System.Drawing.Size(279, 49);
            this.btnShowTransaction.TabIndex = 3;
            this.btnShowTransaction.Text = "Show Transaction";
            this.btnShowTransaction.UseVisualStyleBackColor = true;
            this.btnShowTransaction.Click += new System.EventHandler(this.btnShowTransaction_Click);
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(97, 219);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(279, 49);
            this.btnCalculation.TabIndex = 4;
            this.btnCalculation.Text = "Calculation";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // btnAccountantApplyForLeave
            // 
            this.btnAccountantApplyForLeave.Location = new System.Drawing.Point(97, 305);
            this.btnAccountantApplyForLeave.Name = "btnAccountantApplyForLeave";
            this.btnAccountantApplyForLeave.Size = new System.Drawing.Size(279, 60);
            this.btnAccountantApplyForLeave.TabIndex = 5;
            this.btnAccountantApplyForLeave.Text = "Apply For Leave";
            this.btnAccountantApplyForLeave.UseVisualStyleBackColor = true;
            this.btnAccountantApplyForLeave.Click += new System.EventHandler(this.btnAccountantApplyForLeave_Click);
            // 
            // btnAccountantShowLeaveRequestStatus
            // 
            this.btnAccountantShowLeaveRequestStatus.Location = new System.Drawing.Point(97, 402);
            this.btnAccountantShowLeaveRequestStatus.Name = "btnAccountantShowLeaveRequestStatus";
            this.btnAccountantShowLeaveRequestStatus.Size = new System.Drawing.Size(279, 99);
            this.btnAccountantShowLeaveRequestStatus.TabIndex = 6;
            this.btnAccountantShowLeaveRequestStatus.Text = "Show Leave Request Status";
            this.btnAccountantShowLeaveRequestStatus.UseVisualStyleBackColor = true;
            this.btnAccountantShowLeaveRequestStatus.Click += new System.EventHandler(this.btnAccountantShowLeaveRequestStatus_Click);
            // 
            // frmAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnAccountantShowLeaveRequestStatus);
            this.Controls.Add(this.btnAccountantApplyForLeave);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.btnShowTransaction);
            this.Controls.Add(this.lblAccountantId);
            this.Controls.Add(this.lblShowAccountantName);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAccountant";
            this.Text = "Accountant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAccountant_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblShowAccountantName;
        private System.Windows.Forms.Label lblAccountantId;
        private System.Windows.Forms.Button btnShowTransaction;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Button btnAccountantApplyForLeave;
        private System.Windows.Forms.Button btnAccountantShowLeaveRequestStatus;
    }
}