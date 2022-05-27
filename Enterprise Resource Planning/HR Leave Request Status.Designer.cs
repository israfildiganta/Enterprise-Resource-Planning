
namespace Enterprise_Resource_Planning
{
    partial class HR_Leave_Request_Status
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHRLeaveRequestStatusApprove = new System.Windows.Forms.DataGridView();
            this.btnHRLeaveRequestShow = new System.Windows.Forms.Button();
            this.btnHRLeaveRequestStatusBack = new System.Windows.Forms.Button();
            this.dgvHRLeaveRequestStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestStatusRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestStatusStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestStatusEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRLeaveRequestStatusApprove)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHRLeaveRequestStatusBack);
            this.panel1.Controls.Add(this.btnHRLeaveRequestShow);
            this.panel1.Controls.Add(this.dgvHRLeaveRequestStatusApprove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 544);
            this.panel1.TabIndex = 0;
            // 
            // dgvHRLeaveRequestStatusApprove
            // 
            this.dgvHRLeaveRequestStatusApprove.AllowUserToAddRows = false;
            this.dgvHRLeaveRequestStatusApprove.AllowUserToDeleteRows = false;
            this.dgvHRLeaveRequestStatusApprove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRLeaveRequestStatusApprove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvHRLeaveRequestStatusName,
            this.dgvHRLeaveRequestStatusID,
            this.dgvHRLeaveRequestStatusRole,
            this.dgvHRLeaveRequestStatusStartDate,
            this.dgvHRLeaveRequestStatusEndDate,
            this.dgvHRLeaveRequestStatus});
            this.dgvHRLeaveRequestStatusApprove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHRLeaveRequestStatusApprove.Location = new System.Drawing.Point(0, 231);
            this.dgvHRLeaveRequestStatusApprove.Name = "dgvHRLeaveRequestStatusApprove";
            this.dgvHRLeaveRequestStatusApprove.ReadOnly = true;
            this.dgvHRLeaveRequestStatusApprove.RowHeadersWidth = 51;
            this.dgvHRLeaveRequestStatusApprove.RowTemplate.Height = 24;
            this.dgvHRLeaveRequestStatusApprove.Size = new System.Drawing.Size(1025, 313);
            this.dgvHRLeaveRequestStatusApprove.TabIndex = 0;
            // 
            // btnHRLeaveRequestShow
            // 
            this.btnHRLeaveRequestShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRLeaveRequestShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHRLeaveRequestShow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRLeaveRequestShow.Location = new System.Drawing.Point(12, 170);
            this.btnHRLeaveRequestShow.Name = "btnHRLeaveRequestShow";
            this.btnHRLeaveRequestShow.Size = new System.Drawing.Size(99, 33);
            this.btnHRLeaveRequestShow.TabIndex = 2;
            this.btnHRLeaveRequestShow.Text = "Show All";
            this.btnHRLeaveRequestShow.UseVisualStyleBackColor = false;
            this.btnHRLeaveRequestShow.Click += new System.EventHandler(this.btnHRShow_Click);
            // 
            // btnHRLeaveRequestStatusBack
            // 
            this.btnHRLeaveRequestStatusBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRLeaveRequestStatusBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHRLeaveRequestStatusBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRLeaveRequestStatusBack.Location = new System.Drawing.Point(901, 31);
            this.btnHRLeaveRequestStatusBack.Name = "btnHRLeaveRequestStatusBack";
            this.btnHRLeaveRequestStatusBack.Size = new System.Drawing.Size(99, 33);
            this.btnHRLeaveRequestStatusBack.TabIndex = 3;
            this.btnHRLeaveRequestStatusBack.Text = "Back";
            this.btnHRLeaveRequestStatusBack.UseVisualStyleBackColor = false;
            this.btnHRLeaveRequestStatusBack.Click += new System.EventHandler(this.btnHRLeaveRequestStatusBack_Click);
            // 
            // dgvHRLeaveRequestStatusName
            // 
            this.dgvHRLeaveRequestStatusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestStatusName.DataPropertyName = "Name";
            this.dgvHRLeaveRequestStatusName.HeaderText = "Name";
            this.dgvHRLeaveRequestStatusName.MinimumWidth = 6;
            this.dgvHRLeaveRequestStatusName.Name = "dgvHRLeaveRequestStatusName";
            this.dgvHRLeaveRequestStatusName.ReadOnly = true;
            // 
            // dgvHRLeaveRequestStatusID
            // 
            this.dgvHRLeaveRequestStatusID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestStatusID.DataPropertyName = "ID";
            this.dgvHRLeaveRequestStatusID.HeaderText = "ID";
            this.dgvHRLeaveRequestStatusID.MinimumWidth = 6;
            this.dgvHRLeaveRequestStatusID.Name = "dgvHRLeaveRequestStatusID";
            this.dgvHRLeaveRequestStatusID.ReadOnly = true;
            // 
            // dgvHRLeaveRequestStatusRole
            // 
            this.dgvHRLeaveRequestStatusRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestStatusRole.DataPropertyName = "Role";
            this.dgvHRLeaveRequestStatusRole.HeaderText = "Role";
            this.dgvHRLeaveRequestStatusRole.MinimumWidth = 6;
            this.dgvHRLeaveRequestStatusRole.Name = "dgvHRLeaveRequestStatusRole";
            this.dgvHRLeaveRequestStatusRole.ReadOnly = true;
            // 
            // dgvHRLeaveRequestStatusStartDate
            // 
            this.dgvHRLeaveRequestStatusStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestStatusStartDate.DataPropertyName = "StartDate";
            this.dgvHRLeaveRequestStatusStartDate.HeaderText = "Start Date";
            this.dgvHRLeaveRequestStatusStartDate.MinimumWidth = 6;
            this.dgvHRLeaveRequestStatusStartDate.Name = "dgvHRLeaveRequestStatusStartDate";
            this.dgvHRLeaveRequestStatusStartDate.ReadOnly = true;
            // 
            // dgvHRLeaveRequestStatusEndDate
            // 
            this.dgvHRLeaveRequestStatusEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestStatusEndDate.DataPropertyName = "EndDate";
            this.dgvHRLeaveRequestStatusEndDate.HeaderText = "End Date";
            this.dgvHRLeaveRequestStatusEndDate.MinimumWidth = 6;
            this.dgvHRLeaveRequestStatusEndDate.Name = "dgvHRLeaveRequestStatusEndDate";
            this.dgvHRLeaveRequestStatusEndDate.ReadOnly = true;
            // 
            // dgvHRLeaveRequestStatus
            // 
            this.dgvHRLeaveRequestStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestStatus.DataPropertyName = "Status";
            this.dgvHRLeaveRequestStatus.HeaderText = "Status";
            this.dgvHRLeaveRequestStatus.MinimumWidth = 6;
            this.dgvHRLeaveRequestStatus.Name = "dgvHRLeaveRequestStatus";
            this.dgvHRLeaveRequestStatus.ReadOnly = true;
            // 
            // HR_Leave_Request_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 544);
            this.Controls.Add(this.panel1);
            this.Name = "HR_Leave_Request_Status";
            this.Text = "Leave_Request_Status";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Leave_Request_Status_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRLeaveRequestStatusApprove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHRLeaveRequestStatusApprove;
        private System.Windows.Forms.Button btnHRLeaveRequestShow;
        private System.Windows.Forms.Button btnHRLeaveRequestStatusBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestStatusRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestStatusStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestStatusEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestStatus;
    }
}