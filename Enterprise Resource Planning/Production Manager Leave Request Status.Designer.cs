
namespace Enterprise_Resource_Planning
{
    partial class Production_Manager_Leave_Request_Status
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProductionLeaveRequestStatusBack = new System.Windows.Forms.Button();
            this.btnProductionManagerLeaveRequestShow = new System.Windows.Forms.Button();
            this.dgvProductionManagerLeaveRequestStatusApprove = new System.Windows.Forms.DataGridView();
            this.dgvProductionManagerLeaveRequestStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductionManagerLeaveRequestStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductionManagerLeaveRequestStatusRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductionManagerLeaveRequestStatusStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductionManagerLeaveRequestStatusEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductionManagerLeaveRequestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionManagerLeaveRequestStatusApprove)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 570);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProductionLeaveRequestStatusBack);
            this.panel2.Controls.Add(this.btnProductionManagerLeaveRequestShow);
            this.panel2.Controls.Add(this.dgvProductionManagerLeaveRequestStatusApprove);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 570);
            this.panel2.TabIndex = 1;
            // 
            // btnProductionLeaveRequestStatusBack
            // 
            this.btnProductionLeaveRequestStatusBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductionLeaveRequestStatusBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnProductionLeaveRequestStatusBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProductionLeaveRequestStatusBack.Location = new System.Drawing.Point(901, 31);
            this.btnProductionLeaveRequestStatusBack.Name = "btnProductionLeaveRequestStatusBack";
            this.btnProductionLeaveRequestStatusBack.Size = new System.Drawing.Size(99, 33);
            this.btnProductionLeaveRequestStatusBack.TabIndex = 3;
            this.btnProductionLeaveRequestStatusBack.Text = "Back";
            this.btnProductionLeaveRequestStatusBack.UseVisualStyleBackColor = false;
            this.btnProductionLeaveRequestStatusBack.Click += new System.EventHandler(this.btnProductionLeaveRequestStatusBack_Click);
            // 
            // btnProductionManagerLeaveRequestShow
            // 
            this.btnProductionManagerLeaveRequestShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductionManagerLeaveRequestShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnProductionManagerLeaveRequestShow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProductionManagerLeaveRequestShow.Location = new System.Drawing.Point(12, 170);
            this.btnProductionManagerLeaveRequestShow.Name = "btnProductionManagerLeaveRequestShow";
            this.btnProductionManagerLeaveRequestShow.Size = new System.Drawing.Size(99, 33);
            this.btnProductionManagerLeaveRequestShow.TabIndex = 2;
            this.btnProductionManagerLeaveRequestShow.Text = "Show All";
            this.btnProductionManagerLeaveRequestShow.UseVisualStyleBackColor = false;
            this.btnProductionManagerLeaveRequestShow.Click += new System.EventHandler(this.btnProductionManagerLeaveRequestShow_Click);
            // 
            // dgvProductionManagerLeaveRequestStatusApprove
            // 
            this.dgvProductionManagerLeaveRequestStatusApprove.AllowUserToAddRows = false;
            this.dgvProductionManagerLeaveRequestStatusApprove.AllowUserToDeleteRows = false;
            this.dgvProductionManagerLeaveRequestStatusApprove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionManagerLeaveRequestStatusApprove.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductionManagerLeaveRequestStatusName,
            this.dgvProductionManagerLeaveRequestStatusID,
            this.dgvProductionManagerLeaveRequestStatusRole,
            this.dgvProductionManagerLeaveRequestStatusStartDate,
            this.dgvProductionManagerLeaveRequestStatusEndDate,
            this.dgvProductionManagerLeaveRequestStatus});
            this.dgvProductionManagerLeaveRequestStatusApprove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductionManagerLeaveRequestStatusApprove.Location = new System.Drawing.Point(0, 257);
            this.dgvProductionManagerLeaveRequestStatusApprove.Name = "dgvProductionManagerLeaveRequestStatusApprove";
            this.dgvProductionManagerLeaveRequestStatusApprove.ReadOnly = true;
            this.dgvProductionManagerLeaveRequestStatusApprove.RowHeadersWidth = 51;
            this.dgvProductionManagerLeaveRequestStatusApprove.RowTemplate.Height = 24;
            this.dgvProductionManagerLeaveRequestStatusApprove.Size = new System.Drawing.Size(1023, 313);
            this.dgvProductionManagerLeaveRequestStatusApprove.TabIndex = 0;
            // 
            // dgvProductionManagerLeaveRequestStatusName
            // 
            this.dgvProductionManagerLeaveRequestStatusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductionManagerLeaveRequestStatusName.DataPropertyName = "Name";
            this.dgvProductionManagerLeaveRequestStatusName.HeaderText = "Name";
            this.dgvProductionManagerLeaveRequestStatusName.MinimumWidth = 6;
            this.dgvProductionManagerLeaveRequestStatusName.Name = "dgvProductionManagerLeaveRequestStatusName";
            this.dgvProductionManagerLeaveRequestStatusName.ReadOnly = true;
            // 
            // dgvProductionManagerLeaveRequestStatusID
            // 
            this.dgvProductionManagerLeaveRequestStatusID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductionManagerLeaveRequestStatusID.DataPropertyName = "ID";
            this.dgvProductionManagerLeaveRequestStatusID.HeaderText = "ID";
            this.dgvProductionManagerLeaveRequestStatusID.MinimumWidth = 6;
            this.dgvProductionManagerLeaveRequestStatusID.Name = "dgvProductionManagerLeaveRequestStatusID";
            this.dgvProductionManagerLeaveRequestStatusID.ReadOnly = true;
            // 
            // dgvProductionManagerLeaveRequestStatusRole
            // 
            this.dgvProductionManagerLeaveRequestStatusRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductionManagerLeaveRequestStatusRole.DataPropertyName = "Role";
            this.dgvProductionManagerLeaveRequestStatusRole.HeaderText = "Role";
            this.dgvProductionManagerLeaveRequestStatusRole.MinimumWidth = 6;
            this.dgvProductionManagerLeaveRequestStatusRole.Name = "dgvProductionManagerLeaveRequestStatusRole";
            this.dgvProductionManagerLeaveRequestStatusRole.ReadOnly = true;
            // 
            // dgvProductionManagerLeaveRequestStatusStartDate
            // 
            this.dgvProductionManagerLeaveRequestStatusStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductionManagerLeaveRequestStatusStartDate.DataPropertyName = "StartDate";
            this.dgvProductionManagerLeaveRequestStatusStartDate.HeaderText = "Start Date";
            this.dgvProductionManagerLeaveRequestStatusStartDate.MinimumWidth = 6;
            this.dgvProductionManagerLeaveRequestStatusStartDate.Name = "dgvProductionManagerLeaveRequestStatusStartDate";
            this.dgvProductionManagerLeaveRequestStatusStartDate.ReadOnly = true;
            // 
            // dgvProductionManagerLeaveRequestStatusEndDate
            // 
            this.dgvProductionManagerLeaveRequestStatusEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductionManagerLeaveRequestStatusEndDate.DataPropertyName = "EndDate";
            this.dgvProductionManagerLeaveRequestStatusEndDate.HeaderText = "End Date";
            this.dgvProductionManagerLeaveRequestStatusEndDate.MinimumWidth = 6;
            this.dgvProductionManagerLeaveRequestStatusEndDate.Name = "dgvProductionManagerLeaveRequestStatusEndDate";
            this.dgvProductionManagerLeaveRequestStatusEndDate.ReadOnly = true;
            // 
            // dgvProductionManagerLeaveRequestStatus
            // 
            this.dgvProductionManagerLeaveRequestStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductionManagerLeaveRequestStatus.DataPropertyName = "Status";
            this.dgvProductionManagerLeaveRequestStatus.HeaderText = "Status";
            this.dgvProductionManagerLeaveRequestStatus.MinimumWidth = 6;
            this.dgvProductionManagerLeaveRequestStatus.Name = "dgvProductionManagerLeaveRequestStatus";
            this.dgvProductionManagerLeaveRequestStatus.ReadOnly = true;
            // 
            // Production_Manager_Leave_Request_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 570);
            this.Controls.Add(this.panel1);
            this.Name = "Production_Manager_Leave_Request_Status";
            this.Text = "Production_Manager_Leave_Request_Status";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Production_Manager_Leave_Request_Status_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionManagerLeaveRequestStatusApprove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProductionLeaveRequestStatusBack;
        private System.Windows.Forms.Button btnProductionManagerLeaveRequestShow;
        private System.Windows.Forms.DataGridView dgvProductionManagerLeaveRequestStatusApprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductionManagerLeaveRequestStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductionManagerLeaveRequestStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductionManagerLeaveRequestStatusRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductionManagerLeaveRequestStatusStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductionManagerLeaveRequestStatusEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductionManagerLeaveRequestStatus;
    }
}