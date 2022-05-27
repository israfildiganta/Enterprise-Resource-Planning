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
    public partial class Accountant_Apply_For_Leave : Form
    {
        Data_Access Da { get; set; }
        frmAccountant X { get; set; }
        public Accountant_Apply_For_Leave()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public Accountant_Apply_For_Leave(frmAccountant x,string a,string b):this()
        {
            X = x;
        }

        private void btnAccountantApplyForLeaveClear_Click(object sender, EventArgs e)
        {
            this.dtpAccountantApplyForLeaveEndDate.Text = "";
            this.dtpAccountantApplyForLeaveStartDate.Text = "";
        }

        private void Accountant_Apply_For_Leave_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void btnAccountantApplyForLeaveApply_Click(object sender, EventArgs e)
        {
            try
            {
                
                var sql2 = "select * from LeaveRequests where ID like '" + this.X.id + "' and Status like 'Pending';";
                var sql = @"insert into LeaveRequests values('" + this.X.name + "','" + this.X.id + "','" + "Accountant" + "','" + this.dtpAccountantApplyForLeaveStartDate.Text + "','" + this.dtpAccountantApplyForLeaveEndDate.Text + "','" + "Pending')";
                if (Da.ExecuteQuery(sql2).Tables[0].Rows.Count > 0)
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
    }
}
