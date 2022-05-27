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
    public partial class frmProductionManager : Form
    {
        Data_Access Da { get; set; }
        frmLogin X { get; set; }
        public string name, id;
        public frmProductionManager()
        {
            InitializeComponent();
        }
        public frmProductionManager(frmLogin X,string a,string b):this()
        {
            this.X = X;
            this.lblShowProductionMangerName.Text = a;
            this.lblShowProductionManagerID.Text= b;
            name = a;
            id = b;
        }
        private void btnProductInformation_Click(object sender, EventArgs e)
        {
            frmShowProductionList fh = new frmShowProductionList(this);
            this.Visible = false;
            fh.Visible = true;
        }

        private void btnAddingWarehouse_Click(object sender, EventArgs e)
        {
            frmAddingWarehouse fh = new frmAddingWarehouse(this);
            this.Visible = false;
            fh.Visible = true;
                

        }
        private void btnAddingProduct_Click(object sender, EventArgs e)
        {
            frmAddingProduct fh = new frmAddingProduct(this);
            this.Visible = false;
            fh.Visible = true;
        }

        private void btnShiftingWareHouse_Click(object sender, EventArgs e)
        {
            frmShitfProduct fh = new frmShitfProduct(this);
            this.Visible = false;
            fh.Visible = true;

        }


        private void frmProductionMnager_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void btnProductionManagerDeleteProduct_Click(object sender, EventArgs e)
        {
            frmProductDelete fh = new frmProductDelete(this, this.lblShowProductionMangerName.Text);
            this.Visible = false;
            fh.Visible = true;
        }

        private void frmProductionManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void btnProductionManagerLeaveRequestStatus_Click(object sender, EventArgs e)
        {
            Production_Manager_Leave_Request_Status x = new Production_Manager_Leave_Request_Status(this,id);
            this.Visible = false;
            x.Visible = true;
        }

        private void btnProductManagerApplyForLeave_Click(object sender, EventArgs e)
        {
            Production_Manager_Apply_For_Leave x = new Production_Manager_Apply_For_Leave(this);
            this.Visible = false;
            x.Visible = true;
        }
    }
}
