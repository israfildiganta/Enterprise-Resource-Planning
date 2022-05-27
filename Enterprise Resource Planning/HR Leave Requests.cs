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
    public partial class HR_Leave_Requests : Form
    {
        Data_Access Da { get; set; }
        frmHR X { get; set; }
        public HR_Leave_Requests()
        {
            InitializeComponent();
            Da = new Data_Access();
            this.dgvHRLeaveRequest.AutoGenerateColumns = false;
            this.dgvHRLeaveRequest.DataSource = Da.ExecuteQueryTable("select * from LeaveRequests where Status like 'Pending' and Role not like 'H%' and Role not like 'C%';");
        }
        public HR_Leave_Requests(frmHR x):this()
        {
            X = x;
        }

        private void HR_Leave_Requests_Load(object sender, EventArgs e)
        {

        }

        private void btnHRLeaveRequestsBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }
        private void HR_Leave_Requests_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void dgvHRLeaveRequest_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.cmbHRLeaveRequestSelectDecision.SelectedIndex!=-1)
            {
                try
                {
                    string name = dgvHRLeaveRequest.Rows[e.RowIndex].Cells["dgvHRLeaveRequestsName"].FormattedValue.ToString();
                    string id = dgvHRLeaveRequest.Rows[e.RowIndex].Cells["dgvHRLeaveRequestsID"].FormattedValue.ToString();
                    string role = dgvHRLeaveRequest.Rows[e.RowIndex].Cells["dgvHRLeaveRequestsRole"].FormattedValue.ToString();
                    string startdate = dgvHRLeaveRequest.Rows[e.RowIndex].Cells["dgvHRLeaveRequestsStartDate"].FormattedValue.ToString();
                    string enddate = dgvHRLeaveRequest.Rows[e.RowIndex].Cells["dgvHRLeaveRequestsEndDate"].FormattedValue.ToString();
                    string status = cmbHRLeaveRequestSelectDecision.Text;
                    var sql = @"update LeaveRequests
                                set Name = '" + name + @"',
                                ID = '" + id + @"',
                                Role = '" + role + @"',
                                StartDate='" + startdate + @"',
                                EndDate='" + enddate + @"',
                                Status='" + status + @"'
                                where ID like '" + id + "' and Status like 'Pending';";

                    int count = this.Da.ExecuteDMLQuery(sql);
                    if (count==1)
                    {
                        MessageBox.Show("Updated Successfully");
                        this.dgvHRLeaveRequest.AutoGenerateColumns = false;
                        this.dgvHRLeaveRequest.DataSource = this.dgvHRLeaveRequest.DataSource = Da.ExecuteQueryTable("select * from LeaveRequests where Status like 'Pending' and Role not like 'H%' and Role not like 'C%';");
                    }
                    else
                    {
                        MessageBox.Show("There was a problem in Updateing");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("An Error Has Occured, " + exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select Your Decision");
            }
        }
    }
}
