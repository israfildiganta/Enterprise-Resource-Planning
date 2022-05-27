using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Resource_Planning
{
    public partial class frmCEO : Form
    {
        Data_Access D1 { get; set; }
        frmLogin F1 { set; get; }
        public frmCEO()
        {
            InitializeComponent();
            D1 = new Data_Access();
        }
        public frmCEO(frmLogin f1,string s):this()
        {
            F1 = f1;
            this.lblCEOName.Text = s;
        }
        private void frmCEO_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }
        private void btnCeoLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }
        private void btnShowHRDetails_Click(object sender, EventArgs e)
        {
            string Q = "select * from Person where Role='Human Resource Manager';";
            this.dgvCEOShowDetails.AutoGenerateColumns = false;
            this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(Q).Tables[0];
        }
        private void btnShowProductManagerDetails_Click(object sender, EventArgs e)
        {
            string Q = "select * from Person where Role='Production Manager';";
            this.dgvCEOShowDetails.AutoGenerateColumns = false;
            this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(Q).Tables[0];
        }
        private void btnShowAccountantDetails_Click(object sender, EventArgs e)
        {
            string Q = "select * from Person where Role='Accountant';";
            this.dgvCEOShowDetails.AutoGenerateColumns = false;
            this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(Q).Tables[0];
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCeoSearch.Text.Length > 0)
            {
                string Q = "select * from Person where Role like '" + this.txtCeoSearch.Text + "%';";
                this.dgvCEOShowDetails.AutoGenerateColumns = false;
                this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvCEOShowDetails.DataSource = "";
            }
        }
        private void btnCEONewHR_Click(object sender, EventArgs e)
        {
            Register_HR x = new Register_HR(this);
            this.Visible = false;
            x.Visible = true;
        }

        private void txtCEOSearchByBloodGroup_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCEOSearchByBloodGroup.Text.Length > 0)
            {
                string Q = "select * from Person where BloodGroup like '" + this.txtCEOSearchByBloodGroup.Text + "%';";
                this.dgvCEOShowDetails.AutoGenerateColumns = false;
                this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvCEOShowDetails.DataSource = "";
            }
        }

        private void btnCEOClearDatabase_Click(object sender, EventArgs e)
        {
            this.dgvCEOShowDetails.DataSource = "";
            this.txtCeoSearch.Text = "";
            this.txtCEOSearchByBloodGroup.Text = "";
            this.txtCEOSearchByEmail.Text = "";
        }

        private void txtCEOSearchByEmail_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCEOSearchByEmail.Text.Length > 0)
            {
                string Q = "select * from Person where Email like '" + this.txtCEOSearchByEmail.Text + "%';";
                this.dgvCEOShowDetails.AutoGenerateColumns = false;
                this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvCEOShowDetails.DataSource = "";
            }
        }

        private void txtCEOSearchByGender_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCEOSearchByGender.Text.Length > 0)
            {
                string Q = "select * from Person where Gender like '" + this.txtCEOSearchByGender.Text + "%';";
                this.dgvCEOShowDetails.AutoGenerateColumns = false;
                this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvCEOShowDetails.DataSource = "";
            }
        }

        private void btnCEOUpdateHR_Click(object sender, EventArgs e)
        {
            frmUpdateHR X = new frmUpdateHR(this);
            this.Visible = false;
            X.Visible = true;
        }

        private void dgvCEOShowDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idd = dgvCEOShowDetails.Rows[e.RowIndex].Cells["dgvCEOID"].FormattedValue.ToString();
                string q = "Delete Person Where ID Like '" + idd + "';";
                try
                {
                    if (D1.ExecuteDMLQuery(q) == 1)
                    {
                        MessageBox.Show("Deleted Successfully");
                        string qq = "select * from Person where id not like 'C%';";
                        this.dgvCEOShowDetails.AutoGenerateColumns = false;
                        this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(qq).Tables[0];
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("An Error Has Occured, " + exc.Message);
                }
            }
        }

        private void btnCEOShowAll_Click(object sender, EventArgs e)
        {
            string Q = "select * from Person where Role not like 'C%';";
            this.dgvCEOShowDetails.AutoGenerateColumns = false;
            this.dgvCEOShowDetails.DataSource = D1.ExecuteQuery(Q).Tables[0];
        }

        private void btnCEOApproveLeaveRequest_Click(object sender, EventArgs e)
        {
            CEO_Leave_Requests p1 = new CEO_Leave_Requests(this);
            this.Visible = false;
            p1.Visible = true;
        }
    }
}
