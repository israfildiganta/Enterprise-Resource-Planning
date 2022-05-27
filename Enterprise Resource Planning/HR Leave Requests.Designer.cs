
namespace Enterprise_Resource_Planning
{
    partial class HR_Leave_Requests
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
            this.dgvHRLeaveRequest = new System.Windows.Forms.DataGridView();
            this.dgvHRLeaveRequestsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestsRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestsStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestsEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRLeaveRequestsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHRLeaveRequests = new System.Windows.Forms.Panel();
            this.lblHRLeaveRequestsWelcome = new System.Windows.Forms.Label();
            this.btnHRLeaveRequestsBack = new System.Windows.Forms.Button();
            this.lblHRLeaveRequests = new System.Windows.Forms.Label();
            this.cmbHRLeaveRequestSelectDecision = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRLeaveRequest)).BeginInit();
            this.pnlHRLeaveRequests.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHRLeaveRequest
            // 
            this.dgvHRLeaveRequest.AllowUserToAddRows = false;
            this.dgvHRLeaveRequest.AllowUserToDeleteRows = false;
            this.dgvHRLeaveRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRLeaveRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvHRLeaveRequestsName,
            this.dgvHRLeaveRequestsID,
            this.dgvHRLeaveRequestsRole,
            this.dgvHRLeaveRequestsStartDate,
            this.dgvHRLeaveRequestsEndDate,
            this.dgvHRLeaveRequestsStatus});
            this.dgvHRLeaveRequest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHRLeaveRequest.Location = new System.Drawing.Point(0, 295);
            this.dgvHRLeaveRequest.Name = "dgvHRLeaveRequest";
            this.dgvHRLeaveRequest.ReadOnly = true;
            this.dgvHRLeaveRequest.RowHeadersWidth = 51;
            this.dgvHRLeaveRequest.RowTemplate.Height = 24;
            this.dgvHRLeaveRequest.Size = new System.Drawing.Size(1333, 245);
            this.dgvHRLeaveRequest.TabIndex = 0;
            this.dgvHRLeaveRequest.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHRLeaveRequest_CellContentDoubleClick);
            // 
            // dgvHRLeaveRequestsName
            // 
            this.dgvHRLeaveRequestsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestsName.DataPropertyName = "Name";
            this.dgvHRLeaveRequestsName.HeaderText = "Name";
            this.dgvHRLeaveRequestsName.MinimumWidth = 6;
            this.dgvHRLeaveRequestsName.Name = "dgvHRLeaveRequestsName";
            this.dgvHRLeaveRequestsName.ReadOnly = true;
            // 
            // dgvHRLeaveRequestsID
            // 
            this.dgvHRLeaveRequestsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestsID.DataPropertyName = "ID";
            this.dgvHRLeaveRequestsID.HeaderText = "ID";
            this.dgvHRLeaveRequestsID.MinimumWidth = 6;
            this.dgvHRLeaveRequestsID.Name = "dgvHRLeaveRequestsID";
            this.dgvHRLeaveRequestsID.ReadOnly = true;
            // 
            // dgvHRLeaveRequestsRole
            // 
            this.dgvHRLeaveRequestsRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestsRole.DataPropertyName = "Role";
            this.dgvHRLeaveRequestsRole.HeaderText = "Role";
            this.dgvHRLeaveRequestsRole.MinimumWidth = 6;
            this.dgvHRLeaveRequestsRole.Name = "dgvHRLeaveRequestsRole";
            this.dgvHRLeaveRequestsRole.ReadOnly = true;
            // 
            // dgvHRLeaveRequestsStartDate
            // 
            this.dgvHRLeaveRequestsStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestsStartDate.DataPropertyName = "StartDate";
            this.dgvHRLeaveRequestsStartDate.HeaderText = "Start Date";
            this.dgvHRLeaveRequestsStartDate.MinimumWidth = 6;
            this.dgvHRLeaveRequestsStartDate.Name = "dgvHRLeaveRequestsStartDate";
            this.dgvHRLeaveRequestsStartDate.ReadOnly = true;
            // 
            // dgvHRLeaveRequestsEndDate
            // 
            this.dgvHRLeaveRequestsEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestsEndDate.DataPropertyName = "EndDate";
            this.dgvHRLeaveRequestsEndDate.HeaderText = "End Date";
            this.dgvHRLeaveRequestsEndDate.MinimumWidth = 6;
            this.dgvHRLeaveRequestsEndDate.Name = "dgvHRLeaveRequestsEndDate";
            this.dgvHRLeaveRequestsEndDate.ReadOnly = true;
            // 
            // dgvHRLeaveRequestsStatus
            // 
            this.dgvHRLeaveRequestsStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRLeaveRequestsStatus.DataPropertyName = "Status";
            this.dgvHRLeaveRequestsStatus.HeaderText = "Status";
            this.dgvHRLeaveRequestsStatus.MinimumWidth = 6;
            this.dgvHRLeaveRequestsStatus.Name = "dgvHRLeaveRequestsStatus";
            this.dgvHRLeaveRequestsStatus.ReadOnly = true;
            // 
            // pnlHRLeaveRequests
            // 
            this.pnlHRLeaveRequests.Controls.Add(this.lblHRLeaveRequestsWelcome);
            this.pnlHRLeaveRequests.Controls.Add(this.btnHRLeaveRequestsBack);
            this.pnlHRLeaveRequests.Controls.Add(this.lblHRLeaveRequests);
            this.pnlHRLeaveRequests.Controls.Add(this.cmbHRLeaveRequestSelectDecision);
            this.pnlHRLeaveRequests.Controls.Add(this.dgvHRLeaveRequest);
            this.pnlHRLeaveRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHRLeaveRequests.Location = new System.Drawing.Point(0, 0);
            this.pnlHRLeaveRequests.Name = "pnlHRLeaveRequests";
            this.pnlHRLeaveRequests.Size = new System.Drawing.Size(1333, 540);
            this.pnlHRLeaveRequests.TabIndex = 1;
            // 
            // lblHRLeaveRequestsWelcome
            // 
            this.lblHRLeaveRequestsWelcome.AutoSize = true;
            this.lblHRLeaveRequestsWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRLeaveRequestsWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHRLeaveRequestsWelcome.Location = new System.Drawing.Point(551, 28);
            this.lblHRLeaveRequestsWelcome.Name = "lblHRLeaveRequestsWelcome";
            this.lblHRLeaveRequestsWelcome.Size = new System.Drawing.Size(234, 32);
            this.lblHRLeaveRequestsWelcome.TabIndex = 4;
            this.lblHRLeaveRequestsWelcome.Text = "Leave Requests";
            // 
            // btnHRLeaveRequestsBack
            // 
            this.btnHRLeaveRequestsBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHRLeaveRequestsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRLeaveRequestsBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRLeaveRequestsBack.Location = new System.Drawing.Point(1163, 28);
            this.btnHRLeaveRequestsBack.Name = "btnHRLeaveRequestsBack";
            this.btnHRLeaveRequestsBack.Size = new System.Drawing.Size(126, 44);
            this.btnHRLeaveRequestsBack.TabIndex = 3;
            this.btnHRLeaveRequestsBack.Text = "Back";
            this.btnHRLeaveRequestsBack.UseVisualStyleBackColor = false;
            this.btnHRLeaveRequestsBack.Click += new System.EventHandler(this.btnHRLeaveRequestsBack_Click);
            // 
            // lblHRLeaveRequests
            // 
            this.lblHRLeaveRequests.AutoSize = true;
            this.lblHRLeaveRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRLeaveRequests.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHRLeaveRequests.Location = new System.Drawing.Point(12, 147);
            this.lblHRLeaveRequests.Name = "lblHRLeaveRequests";
            this.lblHRLeaveRequests.Size = new System.Drawing.Size(258, 38);
            this.lblHRLeaveRequests.TabIndex = 2;
            this.lblHRLeaveRequests.Text = "Select Decision";
            // 
            // cmbHRLeaveRequestSelectDecision
            // 
            this.cmbHRLeaveRequestSelectDecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHRLeaveRequestSelectDecision.FormattingEnabled = true;
            this.cmbHRLeaveRequestSelectDecision.Items.AddRange(new object[] {
            "Approved",
            "Declined"});
            this.cmbHRLeaveRequestSelectDecision.Location = new System.Drawing.Point(12, 201);
            this.cmbHRLeaveRequestSelectDecision.Name = "cmbHRLeaveRequestSelectDecision";
            this.cmbHRLeaveRequestSelectDecision.Size = new System.Drawing.Size(371, 24);
            this.cmbHRLeaveRequestSelectDecision.TabIndex = 1;
            // 
            // HR_Leave_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 540);
            this.Controls.Add(this.pnlHRLeaveRequests);
            this.Name = "HR_Leave_Requests";
            this.Text = "HR_Leave_Requests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HR_Leave_Requests_FormClosed);
            this.Load += new System.EventHandler(this.HR_Leave_Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRLeaveRequest)).EndInit();
            this.pnlHRLeaveRequests.ResumeLayout(false);
            this.pnlHRLeaveRequests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHRLeaveRequest;
        private System.Windows.Forms.Panel pnlHRLeaveRequests;
        private System.Windows.Forms.Label lblHRLeaveRequests;
        private System.Windows.Forms.ComboBox cmbHRLeaveRequestSelectDecision;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestsRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestsStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestsEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRLeaveRequestsStatus;
        private System.Windows.Forms.Button btnHRLeaveRequestsBack;
        private System.Windows.Forms.Label lblHRLeaveRequestsWelcome;
    }
}