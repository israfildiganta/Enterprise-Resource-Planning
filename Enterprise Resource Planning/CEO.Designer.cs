
namespace Enterprise_Resource_Planning
{
    partial class frmCEO
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
            this.pnlCEO = new System.Windows.Forms.Panel();
            this.btnCEOShowAll = new System.Windows.Forms.Button();
            this.txtCEOSearchByGender = new System.Windows.Forms.TextBox();
            this.lblCEOSearchByGender = new System.Windows.Forms.Label();
            this.txtCEOSearchByEmail = new System.Windows.Forms.TextBox();
            this.lblCEOSearchByEmail = new System.Windows.Forms.Label();
            this.btnCEOUpdateHR = new System.Windows.Forms.Button();
            this.btnCEOClearDatabase = new System.Windows.Forms.Button();
            this.txtCEOSearchByBloodGroup = new System.Windows.Forms.TextBox();
            this.lblCEOSearchByBG = new System.Windows.Forms.Label();
            this.btnCEOApproveLeaveRequest = new System.Windows.Forms.Button();
            this.txtCeoSearch = new System.Windows.Forms.TextBox();
            this.lblSearchByID = new System.Windows.Forms.Label();
            this.btnShowHRDetails = new System.Windows.Forms.Button();
            this.btnShowProductManagerDetails = new System.Windows.Forms.Button();
            this.btnShowAccountantDetails = new System.Windows.Forms.Button();
            this.dgvCEOShowDetails = new System.Windows.Forms.DataGridView();
            this.dgvCEOName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEODateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCeoSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEOBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCEORole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCEONewHR = new System.Windows.Forms.Button();
            this.btnCeoLogout = new System.Windows.Forms.Button();
            this.lblCEOName = new System.Windows.Forms.Label();
            this.lblCEO = new System.Windows.Forms.Label();
            this.pnlCEO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCEOShowDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCEO
            // 
            this.pnlCEO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCEO.Controls.Add(this.btnCEOShowAll);
            this.pnlCEO.Controls.Add(this.txtCEOSearchByGender);
            this.pnlCEO.Controls.Add(this.lblCEOSearchByGender);
            this.pnlCEO.Controls.Add(this.txtCEOSearchByEmail);
            this.pnlCEO.Controls.Add(this.lblCEOSearchByEmail);
            this.pnlCEO.Controls.Add(this.btnCEOUpdateHR);
            this.pnlCEO.Controls.Add(this.btnCEOClearDatabase);
            this.pnlCEO.Controls.Add(this.txtCEOSearchByBloodGroup);
            this.pnlCEO.Controls.Add(this.lblCEOSearchByBG);
            this.pnlCEO.Controls.Add(this.btnCEOApproveLeaveRequest);
            this.pnlCEO.Controls.Add(this.txtCeoSearch);
            this.pnlCEO.Controls.Add(this.lblSearchByID);
            this.pnlCEO.Controls.Add(this.btnShowHRDetails);
            this.pnlCEO.Controls.Add(this.btnShowProductManagerDetails);
            this.pnlCEO.Controls.Add(this.btnShowAccountantDetails);
            this.pnlCEO.Controls.Add(this.dgvCEOShowDetails);
            this.pnlCEO.Controls.Add(this.btnCEONewHR);
            this.pnlCEO.Controls.Add(this.btnCeoLogout);
            this.pnlCEO.Controls.Add(this.lblCEOName);
            this.pnlCEO.Controls.Add(this.lblCEO);
            this.pnlCEO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCEO.Location = new System.Drawing.Point(0, 0);
            this.pnlCEO.Name = "pnlCEO";
            this.pnlCEO.Size = new System.Drawing.Size(1436, 545);
            this.pnlCEO.TabIndex = 0;
            // 
            // btnCEOShowAll
            // 
            this.btnCEOShowAll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCEOShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCEOShowAll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCEOShowAll.Location = new System.Drawing.Point(1141, 272);
            this.btnCEOShowAll.Name = "btnCEOShowAll";
            this.btnCEOShowAll.Size = new System.Drawing.Size(242, 36);
            this.btnCEOShowAll.TabIndex = 19;
            this.btnCEOShowAll.Text = "Show All";
            this.btnCEOShowAll.UseVisualStyleBackColor = false;
            this.btnCEOShowAll.Click += new System.EventHandler(this.btnCEOShowAll_Click);
            // 
            // txtCEOSearchByGender
            // 
            this.txtCEOSearchByGender.Location = new System.Drawing.Point(607, 332);
            this.txtCEOSearchByGender.Name = "txtCEOSearchByGender";
            this.txtCEOSearchByGender.Size = new System.Drawing.Size(174, 22);
            this.txtCEOSearchByGender.TabIndex = 18;
            this.txtCEOSearchByGender.TextChanged += new System.EventHandler(this.txtCEOSearchByGender_TextChanged);
            // 
            // lblCEOSearchByGender
            // 
            this.lblCEOSearchByGender.AutoSize = true;
            this.lblCEOSearchByGender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCEOSearchByGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCEOSearchByGender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCEOSearchByGender.Location = new System.Drawing.Point(384, 332);
            this.lblCEOSearchByGender.Name = "lblCEOSearchByGender";
            this.lblCEOSearchByGender.Size = new System.Drawing.Size(189, 25);
            this.lblCEOSearchByGender.TabIndex = 17;
            this.lblCEOSearchByGender.Text = "Search By Gender";
            // 
            // txtCEOSearchByEmail
            // 
            this.txtCEOSearchByEmail.Location = new System.Drawing.Point(606, 295);
            this.txtCEOSearchByEmail.Name = "txtCEOSearchByEmail";
            this.txtCEOSearchByEmail.Size = new System.Drawing.Size(174, 22);
            this.txtCEOSearchByEmail.TabIndex = 16;
            this.txtCEOSearchByEmail.TextChanged += new System.EventHandler(this.txtCEOSearchByEmail_TextChanged);
            // 
            // lblCEOSearchByEmail
            // 
            this.lblCEOSearchByEmail.AutoSize = true;
            this.lblCEOSearchByEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCEOSearchByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCEOSearchByEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCEOSearchByEmail.Location = new System.Drawing.Point(390, 294);
            this.lblCEOSearchByEmail.Name = "lblCEOSearchByEmail";
            this.lblCEOSearchByEmail.Size = new System.Drawing.Size(171, 25);
            this.lblCEOSearchByEmail.TabIndex = 15;
            this.lblCEOSearchByEmail.Text = "Search By Email";
            // 
            // btnCEOUpdateHR
            // 
            this.btnCEOUpdateHR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCEOUpdateHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCEOUpdateHR.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCEOUpdateHR.Location = new System.Drawing.Point(25, 114);
            this.btnCEOUpdateHR.Name = "btnCEOUpdateHR";
            this.btnCEOUpdateHR.Size = new System.Drawing.Size(330, 70);
            this.btnCEOUpdateHR.TabIndex = 14;
            this.btnCEOUpdateHR.Text = "Update Human Resource";
            this.btnCEOUpdateHR.UseVisualStyleBackColor = false;
            this.btnCEOUpdateHR.Click += new System.EventHandler(this.btnCEOUpdateHR_Click);
            // 
            // btnCEOClearDatabase
            // 
            this.btnCEOClearDatabase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCEOClearDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCEOClearDatabase.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCEOClearDatabase.Location = new System.Drawing.Point(1143, 318);
            this.btnCEOClearDatabase.Name = "btnCEOClearDatabase";
            this.btnCEOClearDatabase.Size = new System.Drawing.Size(242, 38);
            this.btnCEOClearDatabase.TabIndex = 13;
            this.btnCEOClearDatabase.Text = "Clear";
            this.btnCEOClearDatabase.UseVisualStyleBackColor = false;
            this.btnCEOClearDatabase.Click += new System.EventHandler(this.btnCEOClearDatabase_Click);
            // 
            // txtCEOSearchByBloodGroup
            // 
            this.txtCEOSearchByBloodGroup.Location = new System.Drawing.Point(210, 295);
            this.txtCEOSearchByBloodGroup.Name = "txtCEOSearchByBloodGroup";
            this.txtCEOSearchByBloodGroup.Size = new System.Drawing.Size(154, 22);
            this.txtCEOSearchByBloodGroup.TabIndex = 12;
            this.txtCEOSearchByBloodGroup.TextChanged += new System.EventHandler(this.txtCEOSearchByBloodGroup_TextChanged);
            // 
            // lblCEOSearchByBG
            // 
            this.lblCEOSearchByBG.AutoSize = true;
            this.lblCEOSearchByBG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCEOSearchByBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCEOSearchByBG.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCEOSearchByBG.Location = new System.Drawing.Point(29, 294);
            this.lblCEOSearchByBG.Name = "lblCEOSearchByBG";
            this.lblCEOSearchByBG.Size = new System.Drawing.Size(148, 25);
            this.lblCEOSearchByBG.TabIndex = 11;
            this.lblCEOSearchByBG.Text = "Search By BG";
            // 
            // btnCEOApproveLeaveRequest
            // 
            this.btnCEOApproveLeaveRequest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCEOApproveLeaveRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCEOApproveLeaveRequest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCEOApproveLeaveRequest.Location = new System.Drawing.Point(25, 206);
            this.btnCEOApproveLeaveRequest.Name = "btnCEOApproveLeaveRequest";
            this.btnCEOApproveLeaveRequest.Size = new System.Drawing.Size(330, 68);
            this.btnCEOApproveLeaveRequest.TabIndex = 10;
            this.btnCEOApproveLeaveRequest.Text = "Approve Leave Request";
            this.btnCEOApproveLeaveRequest.UseVisualStyleBackColor = false;
            this.btnCEOApproveLeaveRequest.Click += new System.EventHandler(this.btnCEOApproveLeaveRequest_Click);
            // 
            // txtCeoSearch
            // 
            this.txtCeoSearch.Location = new System.Drawing.Point(211, 329);
            this.txtCeoSearch.Name = "txtCeoSearch";
            this.txtCeoSearch.Size = new System.Drawing.Size(154, 22);
            this.txtCeoSearch.TabIndex = 9;
            this.txtCeoSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearchByID
            // 
            this.lblSearchByID.AutoSize = true;
            this.lblSearchByID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearchByID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSearchByID.Location = new System.Drawing.Point(28, 328);
            this.lblSearchByID.Name = "lblSearchByID";
            this.lblSearchByID.Size = new System.Drawing.Size(139, 25);
            this.lblSearchByID.TabIndex = 8;
            this.lblSearchByID.Text = "Search By ID";
            // 
            // btnShowHRDetails
            // 
            this.btnShowHRDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowHRDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnShowHRDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnShowHRDetails.Location = new System.Drawing.Point(1140, 70);
            this.btnShowHRDetails.Name = "btnShowHRDetails";
            this.btnShowHRDetails.Size = new System.Drawing.Size(242, 42);
            this.btnShowHRDetails.TabIndex = 7;
            this.btnShowHRDetails.Text = "Show HR Details";
            this.btnShowHRDetails.UseVisualStyleBackColor = false;
            this.btnShowHRDetails.Click += new System.EventHandler(this.btnShowHRDetails_Click);
            // 
            // btnShowProductManagerDetails
            // 
            this.btnShowProductManagerDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowProductManagerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowProductManagerDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnShowProductManagerDetails.Location = new System.Drawing.Point(1141, 124);
            this.btnShowProductManagerDetails.Name = "btnShowProductManagerDetails";
            this.btnShowProductManagerDetails.Size = new System.Drawing.Size(242, 70);
            this.btnShowProductManagerDetails.TabIndex = 6;
            this.btnShowProductManagerDetails.Text = "Show Production Manager Details";
            this.btnShowProductManagerDetails.UseVisualStyleBackColor = false;
            this.btnShowProductManagerDetails.Click += new System.EventHandler(this.btnShowProductManagerDetails_Click);
            // 
            // btnShowAccountantDetails
            // 
            this.btnShowAccountantDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAccountantDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnShowAccountantDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnShowAccountantDetails.Location = new System.Drawing.Point(1141, 200);
            this.btnShowAccountantDetails.Name = "btnShowAccountantDetails";
            this.btnShowAccountantDetails.Size = new System.Drawing.Size(242, 66);
            this.btnShowAccountantDetails.TabIndex = 5;
            this.btnShowAccountantDetails.Text = "Show Accountant Details";
            this.btnShowAccountantDetails.UseVisualStyleBackColor = false;
            this.btnShowAccountantDetails.Click += new System.EventHandler(this.btnShowAccountantDetails_Click);
            // 
            // dgvCEOShowDetails
            // 
            this.dgvCEOShowDetails.AllowUserToAddRows = false;
            this.dgvCEOShowDetails.AllowUserToDeleteRows = false;
            this.dgvCEOShowDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCEOShowDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCEOName,
            this.dgvCEOEmail,
            this.dgvCEOID,
            this.dgvCEODateOfBirth,
            this.dgvCEOGender,
            this.dgvCeoSalary,
            this.dgvCEOBloodGroup,
            this.dgvCEORole});
            this.dgvCEOShowDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCEOShowDetails.Location = new System.Drawing.Point(0, 371);
            this.dgvCEOShowDetails.Name = "dgvCEOShowDetails";
            this.dgvCEOShowDetails.ReadOnly = true;
            this.dgvCEOShowDetails.RowHeadersWidth = 51;
            this.dgvCEOShowDetails.RowTemplate.Height = 24;
            this.dgvCEOShowDetails.Size = new System.Drawing.Size(1436, 174);
            this.dgvCEOShowDetails.TabIndex = 4;
            this.dgvCEOShowDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCEOShowDetails_CellDoubleClick);
            // 
            // dgvCEOName
            // 
            this.dgvCEOName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOName.DataPropertyName = "Name";
            this.dgvCEOName.HeaderText = "Name";
            this.dgvCEOName.MinimumWidth = 6;
            this.dgvCEOName.Name = "dgvCEOName";
            this.dgvCEOName.ReadOnly = true;
            // 
            // dgvCEOEmail
            // 
            this.dgvCEOEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOEmail.DataPropertyName = "Email";
            this.dgvCEOEmail.HeaderText = "Email";
            this.dgvCEOEmail.MinimumWidth = 6;
            this.dgvCEOEmail.Name = "dgvCEOEmail";
            this.dgvCEOEmail.ReadOnly = true;
            // 
            // dgvCEOID
            // 
            this.dgvCEOID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOID.DataPropertyName = "ID";
            this.dgvCEOID.HeaderText = "ID";
            this.dgvCEOID.MinimumWidth = 6;
            this.dgvCEOID.Name = "dgvCEOID";
            this.dgvCEOID.ReadOnly = true;
            // 
            // dgvCEODateOfBirth
            // 
            this.dgvCEODateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEODateOfBirth.DataPropertyName = "DateOfBirth";
            this.dgvCEODateOfBirth.HeaderText = "Date Of Birth";
            this.dgvCEODateOfBirth.MinimumWidth = 6;
            this.dgvCEODateOfBirth.Name = "dgvCEODateOfBirth";
            this.dgvCEODateOfBirth.ReadOnly = true;
            // 
            // dgvCEOGender
            // 
            this.dgvCEOGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOGender.DataPropertyName = "Gender";
            this.dgvCEOGender.HeaderText = "Gender";
            this.dgvCEOGender.MinimumWidth = 6;
            this.dgvCEOGender.Name = "dgvCEOGender";
            this.dgvCEOGender.ReadOnly = true;
            // 
            // dgvCeoSalary
            // 
            this.dgvCeoSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCeoSalary.DataPropertyName = "Salary";
            this.dgvCeoSalary.HeaderText = "Salary";
            this.dgvCeoSalary.MinimumWidth = 6;
            this.dgvCeoSalary.Name = "dgvCeoSalary";
            this.dgvCeoSalary.ReadOnly = true;
            // 
            // dgvCEOBloodGroup
            // 
            this.dgvCEOBloodGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEOBloodGroup.DataPropertyName = "BloodGroup";
            this.dgvCEOBloodGroup.HeaderText = "Blood Group";
            this.dgvCEOBloodGroup.MinimumWidth = 6;
            this.dgvCEOBloodGroup.Name = "dgvCEOBloodGroup";
            this.dgvCEOBloodGroup.ReadOnly = true;
            // 
            // dgvCEORole
            // 
            this.dgvCEORole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCEORole.DataPropertyName = "Role";
            this.dgvCEORole.HeaderText = "Role";
            this.dgvCEORole.MinimumWidth = 6;
            this.dgvCEORole.Name = "dgvCEORole";
            this.dgvCEORole.ReadOnly = true;
            // 
            // btnCEONewHR
            // 
            this.btnCEONewHR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCEONewHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCEONewHR.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCEONewHR.Location = new System.Drawing.Point(25, 30);
            this.btnCEONewHR.Name = "btnCEONewHR";
            this.btnCEONewHR.Size = new System.Drawing.Size(330, 65);
            this.btnCEONewHR.TabIndex = 3;
            this.btnCEONewHR.Text = "New Human Resource";
            this.btnCEONewHR.UseVisualStyleBackColor = false;
            this.btnCEONewHR.Click += new System.EventHandler(this.btnCEONewHR_Click);
            // 
            // btnCeoLogout
            // 
            this.btnCeoLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCeoLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnCeoLogout.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCeoLogout.Location = new System.Drawing.Point(1139, 10);
            this.btnCeoLogout.Name = "btnCeoLogout";
            this.btnCeoLogout.Size = new System.Drawing.Size(242, 42);
            this.btnCeoLogout.TabIndex = 2;
            this.btnCeoLogout.Text = "Log Out";
            this.btnCeoLogout.UseVisualStyleBackColor = false;
            this.btnCeoLogout.Click += new System.EventHandler(this.btnCeoLogout_Click);
            // 
            // lblCEOName
            // 
            this.lblCEOName.AutoSize = true;
            this.lblCEOName.BackColor = System.Drawing.Color.Transparent;
            this.lblCEOName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblCEOName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCEOName.Location = new System.Drawing.Point(471, 88);
            this.lblCEOName.Name = "lblCEOName";
            this.lblCEOName.Size = new System.Drawing.Size(374, 38);
            this.lblCEOName.TabIndex = 1;
            this.lblCEOName.Text = "Chief Executive Officer";
            // 
            // lblCEO
            // 
            this.lblCEO.AutoSize = true;
            this.lblCEO.BackColor = System.Drawing.Color.Transparent;
            this.lblCEO.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblCEO.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCEO.Location = new System.Drawing.Point(471, 30);
            this.lblCEO.Name = "lblCEO";
            this.lblCEO.Size = new System.Drawing.Size(374, 38);
            this.lblCEO.TabIndex = 0;
            this.lblCEO.Text = "Chief Executive Officer";
            // 
            // frmCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 545);
            this.Controls.Add(this.pnlCEO);
            this.Name = "frmCEO";
            this.Text = "CEO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCEO_FormClosed);
            this.pnlCEO.ResumeLayout(false);
            this.pnlCEO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCEOShowDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCEO;
        private System.Windows.Forms.Label lblCEOName;
        private System.Windows.Forms.Label lblCEO;
        private System.Windows.Forms.Button btnCeoLogout;
        private System.Windows.Forms.DataGridView dgvCEOShowDetails;
        private System.Windows.Forms.Button btnCEONewHR;
        private System.Windows.Forms.Button btnShowHRDetails;
        private System.Windows.Forms.Button btnShowProductManagerDetails;
        private System.Windows.Forms.Button btnShowAccountantDetails;
        private System.Windows.Forms.TextBox txtCeoSearch;
        private System.Windows.Forms.Label lblSearchByID;
        private System.Windows.Forms.Button btnCEOApproveLeaveRequest;
        private System.Windows.Forms.TextBox txtCEOSearchByBloodGroup;
        private System.Windows.Forms.Label lblCEOSearchByBG;
        private System.Windows.Forms.Button btnCEOClearDatabase;
        private System.Windows.Forms.Button btnCEOUpdateHR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEODateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCeoSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEOBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCEORole;
        private System.Windows.Forms.TextBox txtCEOSearchByEmail;
        private System.Windows.Forms.Label lblCEOSearchByEmail;
        private System.Windows.Forms.TextBox txtCEOSearchByGender;
        private System.Windows.Forms.Label lblCEOSearchByGender;
        private System.Windows.Forms.Button btnCEOShowAll;
    }
}