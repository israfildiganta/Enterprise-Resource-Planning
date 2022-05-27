
namespace Enterprise_Resource_Planning
{
    partial class CEO_Leave_Requests
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
            this.pnlCEOLeaveRequests = new System.Windows.Forms.Panel();
            this.lblCEOLeaveRequestsWelcome = new System.Windows.Forms.Label();
            this.btnCEOLeaveRequestsBack = new System.Windows.Forms.Button();
            this.lblCEOLeaveRequests = new System.Windows.Forms.Label();
            this.cmbCEOLeaveRequestSelectDecision = new System.Windows.Forms.ComboBox();
            this.dgvCEOLeaveRequest = new System.Windows.Forms.DataGridView();
            this.dgvCEOLeaveRequestsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOLeaveRequestsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOLeaveRequestsRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOLeaveRequestsStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOLeaveRequestsEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOLeaveRequestsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCEOLeaveRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCEOLeaveRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCEOLeaveRequests
            // 
            this.pnlCEOLeaveRequests.Controls.Add(this.lblCEOLeaveRequestsWelcome);
            this.pnlCEOLeaveRequests.Controls.Add(this.btnCEOLeaveRequestsBack);
            this.pnlCEOLeaveRequests.Controls.Add(this.lblCEOLeaveRequests);
            this.pnlCEOLeaveRequests.Controls.Add(this.cmbCEOLeaveRequestSelectDecision);
            this.pnlCEOLeaveRequests.Controls.Add(this.dgvCEOLeaveRequest);
            this.pnlCEOLeaveRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCEOLeaveRequests.Location = new System.Drawing.Point(0, 0);
            this.pnlCEOLeaveRequests.Name = "pnlCEOLeaveRequests";
            this.pnlCEOLeaveRequests.Size = new System.Drawing.Size(1328, 541);
            this.pnlCEOLeaveRequests.TabIndex = 2;
            // 
            // lblCEOLeaveRequestsWelcome
            // 
            this.lblCEOLeaveRequestsWelcome.AutoSize = true;
            this.lblCEOLeaveRequestsWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEOLeaveRequestsWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCEOLeaveRequestsWelcome.Location = new System.Drawing.Point(452, 28);
            this.lblCEOLeaveRequestsWelcome.Name = "lblCEOLeaveRequestsWelcome";
            this.lblCEOLeaveRequestsWelcome.Size = new System.Drawing.Size(234, 32);
            this.lblCEOLeaveRequestsWelcome.TabIndex = 4;
            this.lblCEOLeaveRequestsWelcome.Text = "Leave Requests";
            // 
            // btnCEOLeaveRequestsBack
            // 
            this.btnCEOLeaveRequestsBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCEOLeaveRequestsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCEOLeaveRequestsBack.ForeColor = System.Drawing.Color.Blue;
            this.btnCEOLeaveRequestsBack.Location = new System.Drawing.Point(1163, 28);
            this.btnCEOLeaveRequestsBack.Name = "btnCEOLeaveRequestsBack";
            this.btnCEOLeaveRequestsBack.Size = new System.Drawing.Size(126, 44);
            this.btnCEOLeaveRequestsBack.TabIndex = 3;
            this.btnCEOLeaveRequestsBack.Text = "Back";
            this.btnCEOLeaveRequestsBack.UseVisualStyleBackColor = false;
            this.btnCEOLeaveRequestsBack.Click += new System.EventHandler(this.btnCEOLeaveRequestsBack_Click);
            // 
            // lblCEOLeaveRequests
            // 
            this.lblCEOLeaveRequests.AutoSize = true;
            this.lblCEOLeaveRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEOLeaveRequests.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCEOLeaveRequests.Location = new System.Drawing.Point(12, 147);
            this.lblCEOLeaveRequests.Name = "lblCEOLeaveRequests";
            this.lblCEOLeaveRequests.Size = new System.Drawing.Size(258, 38);
            this.lblCEOLeaveRequests.TabIndex = 2;
            this.lblCEOLeaveRequests.Text = "Select Decision";
            // 
            // cmbCEOLeaveRequestSelectDecision
            // 
            this.cmbCEOLeaveRequestSelectDecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCEOLeaveRequestSelectDecision.FormattingEnabled = true;
            this.cmbCEOLeaveRequestSelectDecision.Items.AddRange(new object[] {
            "Approved",
            "Declined"});
            this.cmbCEOLeaveRequestSelectDecision.Location = new System.Drawing.Point(12, 207);
            this.cmbCEOLeaveRequestSelectDecision.Name = "cmbCEOLeaveRequestSelectDecision";
            this.cmbCEOLeaveRequestSelectDecision.Size = new System.Drawing.Size(371, 24);
            this.cmbCEOLeaveRequestSelectDecision.TabIndex = 1;
            // 
            // dgvCEOLeaveRequest
            // 
            this.dgvCEOLeaveRequest.AllowUserToAddRows = false;
            this.dgvCEOLeaveRequest.AllowUserToDeleteRows = false;
            this.dgvCEOLeaveRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCEOLeaveRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCEOLeaveRequestsName,
            this.dgvCEOLeaveRequestsID,
            this.dgvCEOLeaveRequestsRole,
            this.dgvCEOLeaveRequestsStartDate,
            this.dgvCEOLeaveRequestsEndDate,
            this.dgvCEOLeaveRequestsStatus});
            this.dgvCEOLeaveRequest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCEOLeaveRequest.Location = new System.Drawing.Point(0, 296);
            this.dgvCEOLeaveRequest.Name = "dgvCEOLeaveRequest";
            this.dgvCEOLeaveRequest.ReadOnly = true;
            this.dgvCEOLeaveRequest.RowHeadersWidth = 51;
            this.dgvCEOLeaveRequest.RowTemplate.Height = 24;
            this.dgvCEOLeaveRequest.Size = new System.Drawing.Size(1328, 245);
            this.dgvCEOLeaveRequest.TabIndex = 0;
            this.dgvCEOLeaveRequest.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCEOLeaveRequest_CellContentDoubleClick);
            // 
            // dgvCEOLeaveRequestsName
            // 
            this.dgvCEOLeaveRequestsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOLeaveRequestsName.DataPropertyName = "Name";
            this.dgvCEOLeaveRequestsName.HeaderText = "Name";
            this.dgvCEOLeaveRequestsName.MinimumWidth = 6;
            this.dgvCEOLeaveRequestsName.Name = "dgvCEOLeaveRequestsName";
            this.dgvCEOLeaveRequestsName.ReadOnly = true;
            // 
            // dgvCEOLeaveRequestsID
            // 
            this.dgvCEOLeaveRequestsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOLeaveRequestsID.DataPropertyName = "ID";
            this.dgvCEOLeaveRequestsID.HeaderText = "ID";
            this.dgvCEOLeaveRequestsID.MinimumWidth = 6;
            this.dgvCEOLeaveRequestsID.Name = "dgvCEOLeaveRequestsID";
            this.dgvCEOLeaveRequestsID.ReadOnly = true;
            // 
            // dgvCEOLeaveRequestsRole
            // 
            this.dgvCEOLeaveRequestsRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOLeaveRequestsRole.DataPropertyName = "Role";
            this.dgvCEOLeaveRequestsRole.HeaderText = "Role";
            this.dgvCEOLeaveRequestsRole.MinimumWidth = 6;
            this.dgvCEOLeaveRequestsRole.Name = "dgvCEOLeaveRequestsRole";
            this.dgvCEOLeaveRequestsRole.ReadOnly = true;
            // 
            // dgvCEOLeaveRequestsStartDate
            // 
            this.dgvCEOLeaveRequestsStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOLeaveRequestsStartDate.DataPropertyName = "StartDate";
            this.dgvCEOLeaveRequestsStartDate.HeaderText = "Start Date";
            this.dgvCEOLeaveRequestsStartDate.MinimumWidth = 6;
            this.dgvCEOLeaveRequestsStartDate.Name = "dgvCEOLeaveRequestsStartDate";
            this.dgvCEOLeaveRequestsStartDate.ReadOnly = true;
            // 
            // dgvCEOLeaveRequestsEndDate
            // 
            this.dgvCEOLeaveRequestsEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOLeaveRequestsEndDate.DataPropertyName = "EndDate";
            this.dgvCEOLeaveRequestsEndDate.HeaderText = "End Date";
            this.dgvCEOLeaveRequestsEndDate.MinimumWidth = 6;
            this.dgvCEOLeaveRequestsEndDate.Name = "dgvCEOLeaveRequestsEndDate";
            this.dgvCEOLeaveRequestsEndDate.ReadOnly = true;
            // 
            // dgvCEOLeaveRequestsStatus
            // 
            this.dgvCEOLeaveRequestsStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOLeaveRequestsStatus.DataPropertyName = "Status";
            this.dgvCEOLeaveRequestsStatus.HeaderText = "Status";
            this.dgvCEOLeaveRequestsStatus.MinimumWidth = 6;
            this.dgvCEOLeaveRequestsStatus.Name = "dgvCEOLeaveRequestsStatus";
            this.dgvCEOLeaveRequestsStatus.ReadOnly = true;
            // 
            // CEO_Leave_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 541);
            this.Controls.Add(this.pnlCEOLeaveRequests);
            this.Name = "CEO_Leave_Requests";
            this.Text = "CEO_Leave_Requests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CEO_Leave_Requests_FormClosed);
            this.pnlCEOLeaveRequests.ResumeLayout(false);
            this.pnlCEOLeaveRequests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCEOLeaveRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCEOLeaveRequests;
        private System.Windows.Forms.Label lblCEOLeaveRequestsWelcome;
        private System.Windows.Forms.Button btnCEOLeaveRequestsBack;
        private System.Windows.Forms.Label lblCEOLeaveRequests;
        private System.Windows.Forms.ComboBox cmbCEOLeaveRequestSelectDecision;
        private System.Windows.Forms.DataGridView dgvCEOLeaveRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOLeaveRequestsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOLeaveRequestsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOLeaveRequestsRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOLeaveRequestsStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOLeaveRequestsEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOLeaveRequestsStatus;
    }
}