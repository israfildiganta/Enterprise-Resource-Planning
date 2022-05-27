using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Resource_Planning
{
    public partial class frmLogin : Form
    {
        Data_Access DataAccess { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            DataAccess = new Data_Access();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Q = "select * from Person where ID like '"+this.txtUserId.Text+"' and Password Like '"+this.txtPassword.Text+"';";
            if(DataAccess.ExecuteQueryTable(Q).Rows.Count==1)
            {
                if (DataAccess.ExecuteQueryTable(Q).Rows[0][7].ToString()=="CEO")
                {
                    frmCEO CEO = new frmCEO(this,DataAccess.ExecuteQueryTable(Q).Rows[0][0].ToString());
                    this.Visible = false;
                    CEO.Visible = true;
                    this.txtPassword.Text = "";
                    this.txtUserId.Text = "";
                }
                else if(DataAccess.ExecuteQueryTable(Q).Rows[0][7].ToString() == "Production Manager")
                {
                    frmProductionManager PM = new frmProductionManager(this, DataAccess.ExecuteQueryTable(Q).Rows[0][0].ToString(), DataAccess.ExecuteQueryTable(Q).Rows[0][2].ToString());
                    this.Visible = false;
                    PM.Visible = true;
                    this.txtPassword.Text = "";
                    this.txtUserId.Text = "";
                }
                else if(DataAccess.ExecuteQueryTable(Q).Rows[0][7].ToString() == "Human Resource Manager")
                {
                   frmHR Human_Resource = new frmHR(this, DataAccess.ExecuteQueryTable(Q).Rows[0][0].ToString(), DataAccess.ExecuteQueryTable(Q).Rows[0][2].ToString());
                   this.Visible = false;
                   Human_Resource.Visible = true;
                    this.txtPassword.Text = "";
                    this.txtUserId.Text = "";
                }
                else if(DataAccess.ExecuteQueryTable(Q).Rows[0][7].ToString() == "Accountant")
                {
                    frmAccountant ac = new frmAccountant(this, DataAccess.ExecuteQueryTable(Q).Rows[0][0].ToString(), DataAccess.ExecuteQueryTable(Q).Rows[0][2].ToString());
                    this.Visible = false;
                    ac.Visible = true;
                    this.txtPassword.Text = "";
                    this.txtUserId.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Invalid UserId or Password");
            }
        }

        private void btnERPLoginClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Text = "";
            this.txtPassword.Text = "";
        }
    }
}
