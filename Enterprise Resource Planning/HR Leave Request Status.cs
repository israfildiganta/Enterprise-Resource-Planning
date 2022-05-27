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
    public partial class HR_Leave_Request_Status : Form
    {
        frmHR X { get; set; }
        string id;
        Data_Access Da { get; set; }
        public HR_Leave_Request_Status()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public HR_Leave_Request_Status(frmHR x,string b):this()
        {
            X = x;
            id = b;
        }

        private void btnHRShow_Click(object sender, EventArgs e)
        {
            string q = "select * from LeaveRequests where ID like '"+id+"';";
            dgvHRLeaveRequestStatusApprove.AutoGenerateColumns = false;
            this.dgvHRLeaveRequestStatusApprove.DataSource = Da.ExecuteQuery(q).Tables[0];
        }

        private void btnHRLeaveRequestStatusBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void Leave_Request_Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }
    }
}
