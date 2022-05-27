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
    public partial class Production_Manager_Leave_Request_Status : Form
    {
        frmProductionManager X { get; set; }
        Data_Access Da { get; set; }
        string id;
        public Production_Manager_Leave_Request_Status()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public Production_Manager_Leave_Request_Status(frmProductionManager x,string a):this()
        {
            X = x;
            id = a;
        }

        private void btnProductionManagerLeaveRequestShow_Click(object sender, EventArgs e)
        {
            string q = "select * from LeaveRequests where ID like '" + id + "';";
            dgvProductionManagerLeaveRequestStatusApprove.AutoGenerateColumns = false;
            this.dgvProductionManagerLeaveRequestStatusApprove.DataSource = Da.ExecuteQuery(q).Tables[0];
        }

        private void btnProductionLeaveRequestStatusBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void Production_Manager_Leave_Request_Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }
    }
}
