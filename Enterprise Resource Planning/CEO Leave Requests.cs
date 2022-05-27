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
    public partial class CEO_Leave_Requests : Form
    {
        frmCEO X { get; set; }
        Data_Access Da { get; set; }
        public CEO_Leave_Requests()
        {
            InitializeComponent();
            Da = new Data_Access();
            this.dgvCEOLeaveRequest.AutoGenerateColumns = false;
            this.dgvCEOLeaveRequest.DataSource = Da.ExecuteQueryTable("select * from LeaveRequests where Status like 'Pending' and Role like 'H%';");
        }
        public CEO_Leave_Requests(frmCEO x):this()
        {
            X = x;
        }

        private void dgvCEOLeaveRequest_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.cmbCEOLeaveRequestSelectDecision.SelectedIndex != -1)
            {
                try
                {
                    string name = dgvCEOLeaveRequest.Rows[e.RowIndex].Cells["dgvCEOLeaveRequestsName"].FormattedValue.ToString();
                    string id = dgvCEOLeaveRequest.Rows[e.RowIndex].Cells["dgvCEOLeaveRequestsID"].FormattedValue.ToString();
                    string role = dgvCEOLeaveRequest.Rows[e.RowIndex].Cells["dgvCEOLeaveRequestsRole"].FormattedValue.ToString();
                    string startdate = dgvCEOLeaveRequest.Rows[e.RowIndex].Cells["dgvCEOLeaveRequestsStartDate"].FormattedValue.ToString();
                    string enddate = dgvCEOLeaveRequest.Rows[e.RowIndex].Cells["dgvCEOLeaveRequestsEndDate"].FormattedValue.ToString();
                    string status = cmbCEOLeaveRequestSelectDecision.Text;
                    var sql = @"update LeaveRequests
                                set Name = '" + name + @"',
                                ID = '" + id + @"',
                                Role = '" + role + @"',
                                StartDate='" + startdate + @"',
                                EndDate='" + enddate + @"',
                                Status='" + status + @"'
                                where ID like '" + id + "' and Status like 'Pending';";

                    int count = this.Da.ExecuteDMLQuery(sql);
                    if (count>0)
                    {
                        MessageBox.Show("Updated Successfully");
                        this.dgvCEOLeaveRequest.AutoGenerateColumns = false;
                        this.dgvCEOLeaveRequest.DataSource = Da.ExecuteQueryTable("select * from LeaveRequests where Status like 'Pending' and Role like 'H%';");
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

        private void CEO_Leave_Requests_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void btnCEOLeaveRequestsBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }
    }
}
