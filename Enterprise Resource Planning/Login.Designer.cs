
namespace Enterprise_Resource_Planning
{
    partial class frmLogin
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
            this.pnlLoginERP = new System.Windows.Forms.Panel();
            this.pnlLoginERP2 = new System.Windows.Forms.Panel();
            this.btnERPLoginClear = new System.Windows.Forms.Button();
            this.btnERPLogin = new System.Windows.Forms.Button();
            this.lblERPLogin = new System.Windows.Forms.Label();
            this.lblERPLoginPassword = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblERPLoginUserID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlLoginERP.SuspendLayout();
            this.pnlLoginERP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginERP
            // 
            this.pnlLoginERP.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginERP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoginERP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginERP.Controls.Add(this.pnlLoginERP2);
            this.pnlLoginERP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginERP.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginERP.Name = "pnlLoginERP";
            this.pnlLoginERP.Size = new System.Drawing.Size(1139, 553);
            this.pnlLoginERP.TabIndex = 0;
            // 
            // pnlLoginERP2
            // 
            this.pnlLoginERP2.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoginERP2.Controls.Add(this.btnERPLoginClear);
            this.pnlLoginERP2.Controls.Add(this.btnERPLogin);
            this.pnlLoginERP2.Controls.Add(this.lblERPLogin);
            this.pnlLoginERP2.Controls.Add(this.lblERPLoginPassword);
            this.pnlLoginERP2.Controls.Add(this.txtUserId);
            this.pnlLoginERP2.Controls.Add(this.lblERPLoginUserID);
            this.pnlLoginERP2.Controls.Add(this.txtPassword);
            this.pnlLoginERP2.Location = new System.Drawing.Point(89, 133);
            this.pnlLoginERP2.Name = "pnlLoginERP2";
            this.pnlLoginERP2.Size = new System.Drawing.Size(461, 382);
            this.pnlLoginERP2.TabIndex = 5;
            // 
            // btnERPLoginClear
            // 
            this.btnERPLoginClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnERPLoginClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnERPLoginClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnERPLoginClear.Location = new System.Drawing.Point(241, 308);
            this.btnERPLoginClear.Name = "btnERPLoginClear";
            this.btnERPLoginClear.Size = new System.Drawing.Size(152, 37);
            this.btnERPLoginClear.TabIndex = 6;
            this.btnERPLoginClear.Text = "Clear";
            this.btnERPLoginClear.UseVisualStyleBackColor = false;
            this.btnERPLoginClear.Click += new System.EventHandler(this.btnERPLoginClear_Click);
            // 
            // btnERPLogin
            // 
            this.btnERPLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnERPLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnERPLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnERPLogin.Location = new System.Drawing.Point(51, 308);
            this.btnERPLogin.Name = "btnERPLogin";
            this.btnERPLogin.Size = new System.Drawing.Size(152, 37);
            this.btnERPLogin.TabIndex = 5;
            this.btnERPLogin.Text = "Log In";
            this.btnERPLogin.UseVisualStyleBackColor = false;
            this.btnERPLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblERPLogin
            // 
            this.lblERPLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblERPLogin.AutoSize = true;
            this.lblERPLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblERPLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblERPLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblERPLogin.Location = new System.Drawing.Point(154, 31);
            this.lblERPLogin.Name = "lblERPLogin";
            this.lblERPLogin.Size = new System.Drawing.Size(180, 69);
            this.lblERPLogin.TabIndex = 0;
            this.lblERPLogin.Text = "Login";
            this.lblERPLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblERPLoginPassword
            // 
            this.lblERPLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblERPLoginPassword.AutoSize = true;
            this.lblERPLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblERPLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblERPLoginPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblERPLoginPassword.Location = new System.Drawing.Point(52, 207);
            this.lblERPLoginPassword.Name = "lblERPLoginPassword";
            this.lblERPLoginPassword.Size = new System.Drawing.Size(175, 39);
            this.lblERPLoginPassword.TabIndex = 4;
            this.lblERPLoginPassword.Text = "Password";
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserId.Location = new System.Drawing.Point(51, 172);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(180, 22);
            this.txtUserId.TabIndex = 1;
            // 
            // lblERPLoginUserID
            // 
            this.lblERPLoginUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblERPLoginUserID.AutoSize = true;
            this.lblERPLoginUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblERPLoginUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblERPLoginUserID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblERPLoginUserID.Location = new System.Drawing.Point(52, 118);
            this.lblERPLoginUserID.Name = "lblERPLoginUserID";
            this.lblERPLoginUserID.Size = new System.Drawing.Size(140, 39);
            this.lblERPLoginUserID.TabIndex = 2;
            this.lblERPLoginUserID.Text = "User ID";
            this.lblERPLoginUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(52, 268);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 553);
            this.Controls.Add(this.pnlLoginERP);
            this.DoubleBuffered = true;
            this.Name = "frmLogin";
            this.Text = "Enterprise Resource Planning";
            this.pnlLoginERP.ResumeLayout(false);
            this.pnlLoginERP2.ResumeLayout(false);
            this.pnlLoginERP2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginERP;
        private System.Windows.Forms.Label lblERPLoginPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblERPLoginUserID;
        private System.Windows.Forms.Label lblERPLogin;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Panel pnlLoginERP2;
        private System.Windows.Forms.Button btnERPLogin;
        private System.Windows.Forms.Button btnERPLoginClear;
    }
}

