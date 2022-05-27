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
    public partial class frmAccountant : Form
    {
        public frmAccountant()
        {
            InitializeComponent();
        }
        public string name, id;
        frmLogin X { get; set; }
        
        public frmAccountant(frmLogin X, string a, string b) : this()
        {
            this.X = X;
            this.lblShowAccountantName.Text = a;
            this.lblAccountantId.Text = b;
            name = a;
            id = b;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        

        private void frmAccountant_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;

        }

        private void btnShowTransaction_Click(object sender, EventArgs e)
        {
            frmShowTransaction fr = new frmShowTransaction(this);
            this.Visible = false;
            fr.Visible = true;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            frmCalculation fr = new frmCalculation(this);
            this.Visible = false;
            fr.Visible = true;

        }

        private void btnAccountantApplyForLeave_Click(object sender, EventArgs e)
        {
            Accountant_Apply_For_Leave X = new Accountant_Apply_For_Leave(this, name, id);
            this.Visible = false;
            X.Visible = true;
        }

        private void btnAccountantShowLeaveRequestStatus_Click(object sender, EventArgs e)
        {
            Accountant_Leave_Request_Status X = new Accountant_Leave_Request_Status(this, id);
            this.Visible = false;
            X.Visible = true;
        }

        private void lblAccountantId_Click(object sender, EventArgs e)
        {

        }
    }
}
