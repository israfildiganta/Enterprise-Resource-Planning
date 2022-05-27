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
    public partial class Accountant_Leave_Request_Status : Form
    {
        frmAccountant X { get; set; }
        Data_Access Da { get; set; }
        string id;
        public Accountant_Leave_Request_Status()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public Accountant_Leave_Request_Status(frmAccountant x,string a):this()
        {
            X = x;
            id = a;
        }
        private void btnAccountantLeaveRequestShow_Click(object sender, EventArgs e)
        {
            string s = "select * from LeaveRequests Where ID like'" + id + "';";
            dgvAccountantLeaveRequestStatusApprove.AutoGenerateColumns = false;
            dgvAccountantLeaveRequestStatusApprove.DataSource = Da.ExecuteQuery(s).Tables[0];
        }

        private void btnAccountantLeaveRequestStatusBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void Accountant_Leave_Request_Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }
    }
}
