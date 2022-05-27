
namespace Enterprise_Resource_Planning
{
    partial class Accountant_Leave_Request_Status
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
            this.pnlAccountantLeaveRequestStatus = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountantLeaveRequestStatusBack = new System.Windows.Forms.Button();
            this.btnAccountantLeaveRequestShow = new System.Windows.Forms.Button();
            this.dgvAccountantLeaveRequestStatusApprove = new System.Windows.Forms.DataGridView();
            this.dgvAccountantLeaveRequestStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccountantLeaveRequestStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccountantLeaveRequestStatusRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccountantLeaveRequestStatusStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccountantLeaveRequestStatusEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccountantLeaveRequestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAccountantLeaveRequestStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountantLeaveRequestStatusApprove)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccountantLeaveRequestStatus
            // 
            this.pnlAccountantLeaveRequestStatus.Controls.Add(this.panel1);
            this.pnlAccountantLeaveRequestStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccountantLeaveRequestStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountantLeaveRequestStatus.Name = "pnlAccountantLeaveRequestStatus";
            this.pnlAccountantLeaveRequestStatus.Size = new System.Drawing.Size(1022, 553);
            this.pnlAccountantLeaveRequestStatus.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAccountantLeaveRequestStatusBack);
            this.panel1.Controls.Add(this.btnAccountantLeaveRequestShow);
            this.panel1.Controls.Add(this.dgvAccountantLeaveRequestStatusApprove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 553);
            this.panel1.TabIndex = 1;
            // 
            // btnAccountantLeaveRequestStatusBack
            // 
            this.btnAccountantLeaveRequestStatusBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountantLeaveRequestStatusBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAccountantLeaveRequestStatusBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAccountantLeaveRequestStatusBack.Location = new System.Drawing.Point(901, 31);
            this.btnAccountantLeaveRequestStatusBack.Name = "btnAccountantLeaveRequestStatusBack";
            this.btnAccountantLeaveRequestStatusBack.Size = new System.Drawing.Size(99, 33);
            this.btnAccountantLeaveRequestStatusBack.TabIndex = 3;
            this.btnAccountantLeaveRequestStatusBack.Text = "Back";
            this.btnAccountantLeaveRequestStatusBack.UseVisualStyleBackColor = false;
            this.btnAccountantLeaveRequestStatusBack.Click += new System.EventHandler(this.btnAccountantLeaveRequestStatusBack_Click);
            // 
            // btnAccountantLeaveRequestShow
            // 
            this.btnAccountantLeaveRequestShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccountantLeaveRequestShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAccountantLeaveRequestShow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAccountantLeaveRequestShow.Location = new System.Drawing.Point(12, 170);
            this.btnAccountantLeaveRequestShow.Name = "btnAccountantLeaveRequestShow";
            this.btnAccountantLeaveRequestShow.Size = new System.Drawing.Size(99, 33);
            this.btnAccountantLeaveRequestShow.TabIndex = 2;
            this.btnAccountantLeaveRequestShow.Text = "Show All";
            this.btnAccountantLeaveRequestShow.UseVisualStyleBackColor = false;
            this.btnAccountantLeaveRequestShow.Click += new System.EventHandler(this.btnAccountantLeaveRequestShow_Click);
            // 
            // dgvAccountantLeaveRequestStatusApprove
            // 
            this.dgvAccountantLeaveRequestStatusApprove.AllowUserToAddRows = false;
            this.dgvAccountantLeaveRequestStatusApprove.AllowUserToDeleteRows = false;
            this.dgvAccountantLeaveRequestStatusApprove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountantLeaveRequestStatusApprove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvAccountantLeaveRequestStatusName,
            this.dgvAccountantLeaveRequestStatusID,
            this.dgvAccountantLeaveRequestStatusRole,
            this.dgvAccountantLeaveRequestStatusStartDate,
            this.dgvAccountantLeaveRequestStatusEndDate,
            this.dgvAccountantLeaveRequestStatus});
            this.dgvAccountantLeaveRequestStatusApprove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccountantLeaveRequestStatusApprove.Location = new System.Drawing.Point(0, 240);
            this.dgvAccountantLeaveRequestStatusApprove.Name = "dgvAccountantLeaveRequestStatusApprove";
            this.dgvAccountantLeaveRequestStatusApprove.ReadOnly = true;
            this.dgvAccountantLeaveRequestStatusApprove.RowHeadersWidth = 51;
            this.dgvAccountantLeaveRequestStatusApprove.RowTemplate.Height = 24;
            this.dgvAccountantLeaveRequestStatusApprove.Size = new System.Drawing.Size(1022, 313);
            this.dgvAccountantLeaveRequestStatusApprove.TabIndex = 0;
            // 
            // dgvAccountantLeaveRequestStatusName
            // 
            this.dgvAccountantLeaveRequestStatusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAccountantLeaveRequestStatusName.DataPropertyName = "Name";
            this.dgvAccountantLeaveRequestStatusName.HeaderText = "Name";
            this.dgvAccountantLeaveRequestStatusName.MinimumWidth = 6;
            this.dgvAccountantLeaveRequestStatusName.Name = "dgvAccountantLeaveRequestStatusName";
            this.dgvAccountantLeaveRequestStatusName.ReadOnly = true;
            // 
            // dgvAccountantLeaveRequestStatusID
            // 
            this.dgvAccountantLeaveRequestStatusID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAccountantLeaveRequestStatusID.DataPropertyName = "ID";
            this.dgvAccountantLeaveRequestStatusID.HeaderText = "ID";
            this.dgvAccountantLeaveRequestStatusID.MinimumWidth = 6;
            this.dgvAccountantLeaveRequestStatusID.Name = "dgvAccountantLeaveRequestStatusID";
            this.dgvAccountantLeaveRequestStatusID.ReadOnly = true;
            // 
            // dgvAccountantLeaveRequestStatusRole
            // 
            this.dgvAccountantLeaveRequestStatusRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAccountantLeaveRequestStatusRole.DataPropertyName = "Role";
            this.dgvAccountantLeaveRequestStatusRole.HeaderText = "Role";
            this.dgvAccountantLeaveRequestStatusRole.MinimumWidth = 6;
            this.dgvAccountantLeaveRequestStatusRole.Name = "dgvAccountantLeaveRequestStatusRole";
            this.dgvAccountantLeaveRequestStatusRole.ReadOnly = true;
            // 
            // dgvAccountantLeaveRequestStatusStartDate
            // 
            this.dgvAccountantLeaveRequestStatusStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAccountantLeaveRequestStatusStartDate.DataPropertyName = "StartDate";
            this.dgvAccountantLeaveRequestStatusStartDate.HeaderText = "Start Date";
            this.dgvAccountantLeaveRequestStatusStartDate.MinimumWidth = 6;
            this.dgvAccountantLeaveRequestStatusStartDate.Name = "dgvAccountantLeaveRequestStatusStartDate";
            this.dgvAccountantLeaveRequestStatusStartDate.ReadOnly = true;
            // 
            // dgvAccountantLeaveRequestStatusEndDate
            // 
            this.dgvAccountantLeaveRequestStatusEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAccountantLeaveRequestStatusEndDate.DataPropertyName = "EndDate";
            this.dgvAccountantLeaveRequestStatusEndDate.HeaderText = "End Date";
            this.dgvAccountantLeaveRequestStatusEndDate.MinimumWidth = 6;
            this.dgvAccountantLeaveRequestStatusEndDate.Name = "dgvAccountantLeaveRequestStatusEndDate";
            this.dgvAccountantLeaveRequestStatusEndDate.ReadOnly = true;
            // 
            // dgvAccountantLeaveRequestStatus
            // 
            this.dgvAccountantLeaveRequestStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAccountantLeaveRequestStatus.DataPropertyName = "Status";
            this.dgvAccountantLeaveRequestStatus.HeaderText = "Status";
            this.dgvAccountantLeaveRequestStatus.MinimumWidth = 6;
            this.dgvAccountantLeaveRequestStatus.Name = "dgvAccountantLeaveRequestStatus";
            this.dgvAccountantLeaveRequestStatus.ReadOnly = true;
            // 
            // Accountant_Leave_Request_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 553);
            this.Controls.Add(this.pnlAccountantLeaveRequestStatus);
            this.Name = "Accountant_Leave_Request_Status";
            this.Text = "Accountant_Leave_Request_Status";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Accountant_Leave_Request_Status_FormClosed);
            this.pnlAccountantLeaveRequestStatus.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountantLeaveRequestStatusApprove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccountantLeaveRequestStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccountantLeaveRequestStatusBack;
        private System.Windows.Forms.Button btnAccountantLeaveRequestShow;
        private System.Windows.Forms.DataGridView dgvAccountantLeaveRequestStatusApprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAccountantLeaveRequestStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAccountantLeaveRequestStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAccountantLeaveRequestStatusRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAccountantLeaveRequestStatusStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAccountantLeaveRequestStatusEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAccountantLeaveRequestStatus;
    }
}