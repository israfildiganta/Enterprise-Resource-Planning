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
    public partial class Production_Manager_Apply_For_Leave : Form
    {
        frmProductionManager ProductionManager { get; set; }
        Data_Access Da { get; set; }
        public Production_Manager_Apply_For_Leave()
        {
            InitializeComponent();
            this.Da = new Data_Access();
        }
        public Production_Manager_Apply_For_Leave(frmProductionManager productionmanager):this()
        {
            this.ProductionManager = productionmanager;
        }

        private void btnProductionManagerApplyForLeaveApply_Click(object sender, EventArgs e)
        {
            try
            {
                var sql2 = "select * from LeaveRequests where ID like '" + this.ProductionManager.id + "' and Status like 'Pending';";
                var sql = @"insert into LeaveRequests values('" + this.ProductionManager.name + "','" + this.ProductionManager.id + "','" + "Production Manager" + "','" + this.dtpProductionManagerApplyForLeaveStartDate.Text + "','" + this.dtpProductionManagerApplyForLeaveEndDate.Text + "','" + "Pending')";
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

        private void Production_Manager_Apply_For_Leave_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            ProductionManager.Visible = true;
        }

        private void btnProductionManagerApplyForLeaveClear_Click(object sender, EventArgs e)
        {
            this.dtpProductionManagerApplyForLeaveEndDate.Text = "";
            this.dtpProductionManagerApplyForLeaveStartDate.Text = "";
        }
    }
}
