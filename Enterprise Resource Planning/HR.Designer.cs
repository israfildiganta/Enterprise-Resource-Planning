
namespace Enterprise_Resource_Planning
{
    partial class frmHR
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
            this.btnHRApplyForLeave = new System.Windows.Forms.Button();
            this.btnHRShowGraph = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnHRApproveLeaveRequest = new System.Windows.Forms.Button();
            this.btnHRAddEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHRName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHRSearchByName = new System.Windows.Forms.TextBox();
            this.txtHRSearchByGender = new System.Windows.Forms.TextBox();
            this.lblHRSearchByName = new System.Windows.Forms.Label();
            this.lblHRSearchByGender = new System.Windows.Forms.Label();
            this.txtHRSearchByBloodGroup = new System.Windows.Forms.TextBox();
            this.txtHRSearchByEmail = new System.Windows.Forms.TextBox();
            this.lblSearchByBloodGroup = new System.Windows.Forms.Label();
            this.lblHRSearchByEmail = new System.Windows.Forms.Label();
            this.btnHRClear = new System.Windows.Forms.Button();
            this.txtHRSearchByID = new System.Windows.Forms.TextBox();
            this.lblHrSearchByID = new System.Windows.Forms.Label();
            this.txtSearchByRole = new System.Windows.Forms.TextBox();
            this.btnHRShow = new System.Windows.Forms.Button();
            this.lblSearchByRole = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvHRShow = new System.Windows.Forms.DataGridView();
            this.dgvHRName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHREmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHRRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHRLeaveRequestStatus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnHRLeaveRequestStatus);
            this.panel1.Controls.Add(this.btnHRApplyForLeave);
            this.panel1.Controls.Add(this.btnHRShowGraph);
            this.panel1.Controls.Add(this.btnUpdateEmployee);
            this.panel1.Controls.Add(this.btnHRApproveLeaveRequest);
            this.panel1.Controls.Add(this.btnHRAddEmployee);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblHRName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.dgvHRShow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 550);
            this.panel1.TabIndex = 0;
            // 
            // btnHRApplyForLeave
            // 
            this.btnHRApplyForLeave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRApplyForLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnHRApplyForLeave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRApplyForLeave.Location = new System.Drawing.Point(1046, 118);
            this.btnHRApplyForLeave.Name = "btnHRApplyForLeave";
            this.btnHRApplyForLeave.Size = new System.Drawing.Size(289, 56);
            this.btnHRApplyForLeave.TabIndex = 12;
            this.btnHRApplyForLeave.Text = "Apply For Leave";
            this.btnHRApplyForLeave.UseVisualStyleBackColor = false;
            this.btnHRApplyForLeave.Click += new System.EventHandler(this.btnHRApplyForLeave_Click);
            // 
            // btnHRShowGraph
            // 
            this.btnHRShowGraph.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRShowGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRShowGraph.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRShowGraph.Location = new System.Drawing.Point(24, 217);
            this.btnHRShowGraph.Name = "btnHRShowGraph";
            this.btnHRShowGraph.Size = new System.Drawing.Size(236, 43);
            this.btnHRShowGraph.TabIndex = 11;
            this.btnHRShowGraph.Text = "Show Graph";
            this.btnHRShowGraph.UseVisualStyleBackColor = false;
            this.btnHRShowGraph.Click += new System.EventHandler(this.btnHRShowGraph_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(24, 88);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(236, 60);
            this.btnUpdateEmployee.TabIndex = 10;
            this.btnUpdateEmployee.Text = "Update Employee Information";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnHRApproveLeaveRequest
            // 
            this.btnHRApproveLeaveRequest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRApproveLeaveRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRApproveLeaveRequest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRApproveLeaveRequest.Location = new System.Drawing.Point(24, 157);
            this.btnHRApproveLeaveRequest.Name = "btnHRApproveLeaveRequest";
            this.btnHRApproveLeaveRequest.Size = new System.Drawing.Size(236, 44);
            this.btnHRApproveLeaveRequest.TabIndex = 9;
            this.btnHRApproveLeaveRequest.Text = "Leave Requests";
            this.btnHRApproveLeaveRequest.UseVisualStyleBackColor = false;
            this.btnHRApproveLeaveRequest.Click += new System.EventHandler(this.btnHRApproveLeaveRequest_Click);
            // 
            // btnHRAddEmployee
            // 
            this.btnHRAddEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRAddEmployee.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRAddEmployee.Location = new System.Drawing.Point(24, 37);
            this.btnHRAddEmployee.Name = "btnHRAddEmployee";
            this.btnHRAddEmployee.Size = new System.Drawing.Size(236, 43);
            this.btnHRAddEmployee.TabIndex = 8;
            this.btnHRAddEmployee.Text = "New Employee";
            this.btnHRAddEmployee.UseVisualStyleBackColor = false;
            this.btnHRAddEmployee.Click += new System.EventHandler(this.btnHRAddEmployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.Location = new System.Drawing.Point(1148, 37);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 47);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblHRName
            // 
            this.lblHRName.AutoSize = true;
            this.lblHRName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHRName.Location = new System.Drawing.Point(572, 75);
            this.lblHRName.Name = "lblHRName";
            this.lblHRName.Size = new System.Drawing.Size(85, 29);
            this.lblHRName.TabIndex = 6;
            this.lblHRName.Text = "label1";
            this.lblHRName.Click += new System.EventHandler(this.lblHRName_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtHRSearchByName);
            this.panel2.Controls.Add(this.txtHRSearchByGender);
            this.panel2.Controls.Add(this.lblHRSearchByName);
            this.panel2.Controls.Add(this.lblHRSearchByGender);
            this.panel2.Controls.Add(this.txtHRSearchByBloodGroup);
            this.panel2.Controls.Add(this.txtHRSearchByEmail);
            this.panel2.Controls.Add(this.lblSearchByBloodGroup);
            this.panel2.Controls.Add(this.lblHRSearchByEmail);
            this.panel2.Controls.Add(this.btnHRClear);
            this.panel2.Controls.Add(this.txtHRSearchByID);
            this.panel2.Controls.Add(this.lblHrSearchByID);
            this.panel2.Controls.Add(this.txtSearchByRole);
            this.panel2.Controls.Add(this.btnHRShow);
            this.panel2.Controls.Add(this.lblSearchByRole);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 102);
            this.panel2.TabIndex = 5;
            // 
            // txtHRSearchByName
            // 
            this.txtHRSearchByName.Location = new System.Drawing.Point(1047, 49);
            this.txtHRSearchByName.Name = "txtHRSearchByName";
            this.txtHRSearchByName.Size = new System.Drawing.Size(161, 22);
            this.txtHRSearchByName.TabIndex = 16;
            this.txtHRSearchByName.TextChanged += new System.EventHandler(this.txtHRSearchByName_TextChanged);
            // 
            // txtHRSearchByGender
            // 
            this.txtHRSearchByGender.Location = new System.Drawing.Point(1046, 11);
            this.txtHRSearchByGender.Name = "txtHRSearchByGender";
            this.txtHRSearchByGender.Size = new System.Drawing.Size(161, 22);
            this.txtHRSearchByGender.TabIndex = 15;
            this.txtHRSearchByGender.TextChanged += new System.EventHandler(this.txtHRSearchByGender_TextChanged);
            // 
            // lblHRSearchByName
            // 
            this.lblHRSearchByName.AutoSize = true;
            this.lblHRSearchByName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHRSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHRSearchByName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHRSearchByName.Location = new System.Drawing.Point(830, 45);
            this.lblHRSearchByName.Name = "lblHRSearchByName";
            this.lblHRSearchByName.Size = new System.Drawing.Size(174, 25);
            this.lblHRSearchByName.TabIndex = 14;
            this.lblHRSearchByName.Text = "Search By Name";
            // 
            // lblHRSearchByGender
            // 
            this.lblHRSearchByGender.AutoSize = true;
            this.lblHRSearchByGender.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHRSearchByGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHRSearchByGender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHRSearchByGender.Location = new System.Drawing.Point(824, 13);
            this.lblHRSearchByGender.Name = "lblHRSearchByGender";
            this.lblHRSearchByGender.Size = new System.Drawing.Size(189, 25);
            this.lblHRSearchByGender.TabIndex = 13;
            this.lblHRSearchByGender.Text = "Search By Gender";
            // 
            // txtHRSearchByBloodGroup
            // 
            this.txtHRSearchByBloodGroup.Location = new System.Drawing.Point(643, 47);
            this.txtHRSearchByBloodGroup.Name = "txtHRSearchByBloodGroup";
            this.txtHRSearchByBloodGroup.Size = new System.Drawing.Size(161, 22);
            this.txtHRSearchByBloodGroup.TabIndex = 12;
            this.txtHRSearchByBloodGroup.TextChanged += new System.EventHandler(this.txtHRSearchByBloodGroup_TextChanged);
            // 
            // txtHRSearchByEmail
            // 
            this.txtHRSearchByEmail.Location = new System.Drawing.Point(642, 13);
            this.txtHRSearchByEmail.Name = "txtHRSearchByEmail";
            this.txtHRSearchByEmail.Size = new System.Drawing.Size(161, 22);
            this.txtHRSearchByEmail.TabIndex = 11;
            this.txtHRSearchByEmail.TextChanged += new System.EventHandler(this.txtHRSearchByEmail_TextChanged);
            // 
            // lblSearchByBloodGroup
            // 
            this.lblSearchByBloodGroup.AutoSize = true;
            this.lblSearchByBloodGroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchByBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearchByBloodGroup.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSearchByBloodGroup.Location = new System.Drawing.Point(376, 47);
            this.lblSearchByBloodGroup.Name = "lblSearchByBloodGroup";
            this.lblSearchByBloodGroup.Size = new System.Drawing.Size(238, 25);
            this.lblSearchByBloodGroup.TabIndex = 10;
            this.lblSearchByBloodGroup.Text = "Search By Blood Group";
            // 
            // lblHRSearchByEmail
            // 
            this.lblHRSearchByEmail.AutoSize = true;
            this.lblHRSearchByEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHRSearchByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHRSearchByEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHRSearchByEmail.Location = new System.Drawing.Point(376, 13);
            this.lblHRSearchByEmail.Name = "lblHRSearchByEmail";
            this.lblHRSearchByEmail.Size = new System.Drawing.Size(171, 25);
            this.lblHRSearchByEmail.TabIndex = 9;
            this.lblHRSearchByEmail.Text = "Search By Email";
            // 
            // btnHRClear
            // 
            this.btnHRClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHRClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRClear.Location = new System.Drawing.Point(1257, 50);
            this.btnHRClear.Name = "btnHRClear";
            this.btnHRClear.Size = new System.Drawing.Size(99, 32);
            this.btnHRClear.TabIndex = 8;
            this.btnHRClear.Text = "Clear All";
            this.btnHRClear.UseVisualStyleBackColor = false;
            this.btnHRClear.Click += new System.EventHandler(this.btnHRClear_Click);
            // 
            // txtHRSearchByID
            // 
            this.txtHRSearchByID.Location = new System.Drawing.Point(188, 47);
            this.txtHRSearchByID.Name = "txtHRSearchByID";
            this.txtHRSearchByID.Size = new System.Drawing.Size(161, 22);
            this.txtHRSearchByID.TabIndex = 7;
            this.txtHRSearchByID.TextChanged += new System.EventHandler(this.txtHRSearchByID_TextChanged);
            // 
            // lblHrSearchByID
            // 
            this.lblHrSearchByID.AutoSize = true;
            this.lblHrSearchByID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHrSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHrSearchByID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHrSearchByID.Location = new System.Drawing.Point(12, 47);
            this.lblHrSearchByID.Name = "lblHrSearchByID";
            this.lblHrSearchByID.Size = new System.Drawing.Size(139, 25);
            this.lblHrSearchByID.TabIndex = 6;
            this.lblHrSearchByID.Text = "Search By ID";
            // 
            // txtSearchByRole
            // 
            this.txtSearchByRole.Location = new System.Drawing.Point(189, 11);
            this.txtSearchByRole.Name = "txtSearchByRole";
            this.txtSearchByRole.Size = new System.Drawing.Size(161, 22);
            this.txtSearchByRole.TabIndex = 5;
            this.txtSearchByRole.TextChanged += new System.EventHandler(this.txtSearchByRole_TextChanged);
            // 
            // btnHRShow
            // 
            this.btnHRShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHRShow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRShow.Location = new System.Drawing.Point(1257, 11);
            this.btnHRShow.Name = "btnHRShow";
            this.btnHRShow.Size = new System.Drawing.Size(99, 33);
            this.btnHRShow.TabIndex = 1;
            this.btnHRShow.Text = "Show All";
            this.btnHRShow.UseVisualStyleBackColor = false;
            this.btnHRShow.Click += new System.EventHandler(this.btnHRShow_Click);
            // 
            // lblSearchByRole
            // 
            this.lblSearchByRole.AutoSize = true;
            this.lblSearchByRole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchByRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearchByRole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSearchByRole.Location = new System.Drawing.Point(10, 11);
            this.lblSearchByRole.Name = "lblSearchByRole";
            this.lblSearchByRole.Size = new System.Drawing.Size(161, 25);
            this.lblSearchByRole.TabIndex = 4;
            this.lblSearchByRole.Text = "Search By Role";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcome.Location = new System.Drawing.Point(492, 18);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(431, 38);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Human Resource Manager";
            // 
            // dgvHRShow
            // 
            this.dgvHRShow.AllowUserToAddRows = false;
            this.dgvHRShow.AllowUserToDeleteRows = false;
            this.dgvHRShow.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHRShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHRShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvHRName,
            this.dgvHREmail,
            this.dgvHRId,
            this.dgvHRDateOfBirth,
            this.dgvHRSalary,
            this.dgvHRGender,
            this.dgvHRBloodGroup,
            this.dgvHRRole});
            this.dgvHRShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHRShow.Location = new System.Drawing.Point(0, 414);
            this.dgvHRShow.Name = "dgvHRShow";
            this.dgvHRShow.ReadOnly = true;
            this.dgvHRShow.RowHeadersWidth = 51;
            this.dgvHRShow.RowTemplate.Height = 24;
            this.dgvHRShow.Size = new System.Drawing.Size(1368, 136);
            this.dgvHRShow.TabIndex = 0;
            this.dgvHRShow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHRShow_CellDoubleClick);
            // 
            // dgvHRName
            // 
            this.dgvHRName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRName.DataPropertyName = "Name";
            this.dgvHRName.HeaderText = "Name";
            this.dgvHRName.MinimumWidth = 6;
            this.dgvHRName.Name = "dgvHRName";
            this.dgvHRName.ReadOnly = true;
            // 
            // dgvHREmail
            // 
            this.dgvHREmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHREmail.DataPropertyName = "Email";
            this.dgvHREmail.HeaderText = "Email";
            this.dgvHREmail.MinimumWidth = 6;
            this.dgvHREmail.Name = "dgvHREmail";
            this.dgvHREmail.ReadOnly = true;
            // 
            // dgvHRId
            // 
            this.dgvHRId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRId.DataPropertyName = "ID";
            this.dgvHRId.HeaderText = "ID";
            this.dgvHRId.MinimumWidth = 6;
            this.dgvHRId.Name = "dgvHRId";
            this.dgvHRId.ReadOnly = true;
            // 
            // dgvHRDateOfBirth
            // 
            this.dgvHRDateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRDateOfBirth.DataPropertyName = "DateOfBirth";
            this.dgvHRDateOfBirth.HeaderText = "Date Of Birth";
            this.dgvHRDateOfBirth.MinimumWidth = 6;
            this.dgvHRDateOfBirth.Name = "dgvHRDateOfBirth";
            this.dgvHRDateOfBirth.ReadOnly = true;
            // 
            // dgvHRSalary
            // 
            this.dgvHRSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRSalary.DataPropertyName = "Salary";
            this.dgvHRSalary.HeaderText = "Salary";
            this.dgvHRSalary.MinimumWidth = 6;
            this.dgvHRSalary.Name = "dgvHRSalary";
            this.dgvHRSalary.ReadOnly = true;
            // 
            // dgvHRGender
            // 
            this.dgvHRGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRGender.DataPropertyName = "Gender";
            this.dgvHRGender.HeaderText = "Gender";
            this.dgvHRGender.MinimumWidth = 6;
            this.dgvHRGender.Name = "dgvHRGender";
            this.dgvHRGender.ReadOnly = true;
            // 
            // dgvHRBloodGroup
            // 
            this.dgvHRBloodGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRBloodGroup.DataPropertyName = "BloodGroup";
            this.dgvHRBloodGroup.HeaderText = "Blood Group";
            this.dgvHRBloodGroup.MinimumWidth = 6;
            this.dgvHRBloodGroup.Name = "dgvHRBloodGroup";
            this.dgvHRBloodGroup.ReadOnly = true;
            // 
            // dgvHRRole
            // 
            this.dgvHRRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvHRRole.DataPropertyName = "Role";
            this.dgvHRRole.HeaderText = "Role";
            this.dgvHRRole.MinimumWidth = 6;
            this.dgvHRRole.Name = "dgvHRRole";
            this.dgvHRRole.ReadOnly = true;
            // 
            // btnHRLeaveRequestStatus
            // 
            this.btnHRLeaveRequestStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHRLeaveRequestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnHRLeaveRequestStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHRLeaveRequestStatus.Location = new System.Drawing.Point(1046, 193);
            this.btnHRLeaveRequestStatus.Name = "btnHRLeaveRequestStatus";
            this.btnHRLeaveRequestStatus.Size = new System.Drawing.Size(289, 82);
            this.btnHRLeaveRequestStatus.TabIndex = 13;
            this.btnHRLeaveRequestStatus.Text = "Leave Request Status";
            this.btnHRLeaveRequestStatus.UseVisualStyleBackColor = false;
            this.btnHRLeaveRequestStatus.Click += new System.EventHandler(this.btnHRLeaveRequestStatus_Click);
            // 
            // frmHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 550);
            this.Controls.Add(this.panel1);
            this.Name = "frmHR";
            this.ShowIcon = false;
            this.Text = "Human Resource";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HR_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHRShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHRShow;
        private System.Windows.Forms.DataGridView dgvHRShow;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchByRole;
        private System.Windows.Forms.Label lblSearchByRole;
        private System.Windows.Forms.TextBox txtHRSearchByID;
        private System.Windows.Forms.Label lblHrSearchByID;
        private System.Windows.Forms.Button btnHRClear;
        private System.Windows.Forms.Label lblHRName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHRApproveLeaveRequest;
        private System.Windows.Forms.Button btnHRAddEmployee;
        private System.Windows.Forms.TextBox txtHRSearchByName;
        private System.Windows.Forms.TextBox txtHRSearchByGender;
        private System.Windows.Forms.Label lblHRSearchByName;
        private System.Windows.Forms.Label lblHRSearchByGender;
        private System.Windows.Forms.TextBox txtHRSearchByBloodGroup;
        private System.Windows.Forms.TextBox txtHRSearchByEmail;
        private System.Windows.Forms.Label lblSearchByBloodGroup;
        private System.Windows.Forms.Label lblHRSearchByEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHREmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHRRole;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnHRShowGraph;
        private System.Windows.Forms.Button btnHRApplyForLeave;
        private System.Windows.Forms.Button btnHRLeaveRequestStatus;
    }
}