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
    public partial class frmCalculation : Form
    {
        private Data_Access Da { get; set; }
        public frmCalculation()
        {
            InitializeComponent();
            this.Da = new Data_Access();
        }
        frmAccountant X;
        public frmCalculation(frmAccountant X) : this()
        {
            this.X = X;
        }

        private void frmCalculation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;

        }

        private void btnShowCalculation_Click(object sender, EventArgs e)
        {
            string pai = "select * from Calculation where Calculation_id like 'CC-000';";
           // MessageBox.Show(pai);
            string aa = Da.ExecuteQuery(pai).Tables[0].Rows[0][1].ToString();
           // MessageBox.Show(aa);
            string bb = Da.ExecuteQuery(pai).Tables[0].Rows[0][2].ToString();
            string cc = Da.ExecuteQuery(pai).Tables[0].Rows[0][3].ToString();
            this.lblShowincome.Text = aa;
            this.lblShowExpense.Text = bb;
            this.lblShowProfit.Text = cc;
        }
    }
}
