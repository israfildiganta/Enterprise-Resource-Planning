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
    public partial class frmHR : Form
    {
        public frmLogin F1 { get; set; }
        public string name, id;
        Data_Access DataAccess { get; set; }
        public frmHR()
        {
            InitializeComponent();
            DataAccess = new Data_Access();
        }
        public frmHR(frmLogin f1,string s,string y) : this()
        {
            F1 = f1;
            this.lblHRName.Text = s;
            this.Visible = true;
            name = s;
            id = y;
        }
        private void HR_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }
        private void btnHRShow_Click(object sender, EventArgs e)
        {
            string Q = "select * from Person where Role not like 'Human Resource Manager' and Role not like 'CEO';";
            this.dgvHRShow.AutoGenerateColumns = false;
            this.dgvHRShow.DataSource = DataAccess.ExecuteQuery(Q).Tables[0];
        }
        private void txtSearchByRole_TextChanged(object sender, EventArgs e)
        {
            if (this.txtSearchByRole.Text.Length > 0)
            {
                string Q = "select * from Person where Role not like 'HR' and Role not like 'CEO' and Role like '" + this.txtSearchByRole.Text + "%';";
                this.dgvHRShow.AutoGenerateColumns = false;
                this.dgvHRShow.DataSource = DataAccess.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvHRShow.DataSource = "";
            }
        }

        private void txtHRSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (this.txtHRSearchByID.Text.Length > 0)
            {
                string Q = "select * from Person where ID not like 'H%' and ID not like 'C%' and ID like '" + this.txtHRSearchByID.Text + "%';";
                this.dgvHRShow.AutoGenerateColumns = false;
                this.dgvHRShow.DataSource = DataAccess.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvHRShow.DataSource ="";
            }
        }
        private void btnHRClear_Click(object sender, EventArgs e)
        {
            this.dgvHRShow.DataSource = "";
            this.txtHRSearchByID.Text = "";
            this.txtSearchByRole.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }
        private void btnHRAddEmployee_Click(object sender, EventArgs e)
        {
            frmRegister_Employee R1 = new frmRegister_Employee(this);
            this.Visible = false;
            R1.Visible = true;

        }

        private void txtHRSearchByEmail_TextChanged(object sender, EventArgs e)
        {
            if (this.txtHRSearchByEmail.Text.Length > 0)
            {
                string Q = "select * from Person where ID not like 'H%' and ID not like 'C%' and Email like '" + this.txtHRSearchByEmail.Text + "%';";
                this.dgvHRShow.AutoGenerateColumns = false;
                this.dgvHRShow.DataSource = DataAccess.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvHRShow.DataSource = "";
            }
        }

        private void txtHRSearchByBloodGroup_TextChanged(object sender, EventArgs e)
        {
            if (this.txtHRSearchByBloodGroup.Text.Length > 0)
            {
                string Q = "select * from Person where ID not like 'H%' and ID not like 'C%' and BloodGroup like '" + this.txtHRSearchByBloodGroup.Text + "%';";
                this.dgvHRShow.AutoGenerateColumns = false;
                this.dgvHRShow.DataSource = DataAccess.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvHRShow.DataSource = "";
            }
        }

        private void txtHRSearchByGender_TextChanged(object sender, EventArgs e)
        {
            if (this.txtHRSearchByGender.Text.Length > 0)
            {
                string Q = "select * from Person where ID not like 'H%' and ID not like 'C%' and Gender like '" + this.txtHRSearchByGender.Text + "%';";
                this.dgvHRShow.AutoGenerateColumns = false;
                this.dgvHRShow.DataSource = DataAccess.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvHRShow.DataSource = "";
            }
        }

        private void txtHRSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtHRSearchByName.Text.Length > 0)
            {
                string Q = "select * from Person where ID not like 'H%' and ID not like 'C%' and Name like '" + this.txtHRSearchByName.Text + "%';";
                this.dgvHRShow.AutoGenerateColumns = false;
                this.dgvHRShow.DataSource = DataAccess.ExecuteQuery(Q).Tables[0];
            }
            else
            {
                this.dgvHRShow.DataSource = "";
            }
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            frmUpdateEmployee R1 = new frmUpdateEmployee(this);
            this.Visible = false;
            R1.Visible = true;
        }
        private void dgvHRShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idd = dgvHRShow.Rows[e.RowIndex].Cells["dgvHRID"].FormattedValue.ToString();
                string q = "Delete Person Where ID Like '" + idd + "';";
                try
                {
                    if (DataAccess.ExecuteDMLQuery(q) == 1)
                    {
                        MessageBox.Show("Deleted Successfully");
                        string qq = "select * from Person where id not like 'C%' and id not like 'H%';";
                        this.dgvHRShow.AutoGenerateColumns = false;
                        this.dgvHRShow.DataSource = DataAccess.ExecuteQuery(qq).Tables[0];
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("An Error Has Occured, " + exc.Message);
                }
            }
        }

        private void btnHRShowGraph_Click(object sender, EventArgs e)
        {
            frmShowGraphChart X1 = new frmShowGraphChart(this);
            this.Visible = false;
            X1.Visible = true;
        }

        private void btnHRApproveLeaveRequest_Click(object sender, EventArgs e)
        {
            HR_Leave_Requests x = new HR_Leave_Requests(this);
            this.Visible = false;
            x.Visible = true;
        }

        private void btnHRApplyForLeave_Click(object sender, EventArgs e)
        {
            Human_Resource_Apply_For_Leave afl = new Human_Resource_Apply_For_Leave(this);
            this.Visible = false;
            afl.Visible = true;
        }

        private void btnHRLeaveRequestStatus_Click(object sender, EventArgs e)
        {
            HR_Leave_Request_Status X = new HR_Leave_Request_Status(this, id);
            this.Visible = false;
            X.Visible = true;
        }

        private void lblHRName_Click(object sender, EventArgs e)
        {

        }
    }
}
