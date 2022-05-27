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
    public partial class Human_Resource_Apply_For_Leave : Form
    {
        frmHR HR{ get; set; }
        Data_Access Da { get; set; }
        public Human_Resource_Apply_For_Leave()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public Human_Resource_Apply_For_Leave(frmHR hr) : this()
        {
            HR = hr;
        }

        private void btnHRApplyForLeaveApply_Click(object sender, EventArgs e)
        {
            try
            {
                var sql2 = "select * from LeaveRequests where ID like '" + this.HR.id + "' and Status like 'Pending';";
                var sql = @"insert into LeaveRequests values('" + this.HR.name + "','" + this.HR.id + "','" + "Human Resource Manager" + "','" + this.dtpHRApplyForLeaveStartDate.Text + "','" + this.dtpHRApplyForLeaveEndDate.Text + "','" + "Pending')";
                if(Da.ExecuteQuery(sql2).Tables[0].Rows.Count>0)
                {
                    MessageBox.Show("Already a request is pending");
                }
                else if (Da.ExecuteDMLQuery(sql) == 1)
                {
                    MessageBox.Show("Request Is Successfully Delivered");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Error Occured : " + exc.Message);
            }
        }
        private void btnHRApplyForLeaveBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HR.Visible = true;
        }

        private void Human_Resource_Apply_For_Leave_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            HR.Visible = true;
        }

        private void btnHRApplyForLeaveClear_Click(object sender, EventArgs e)
        {
            dtpHRApplyForLeaveStartDate.Value = DateTime.Now;
            dtpHRApplyForLeaveEndDate.Value = DateTime.Now;
        }

        private void dtpHRApplyForLeaveEndDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
