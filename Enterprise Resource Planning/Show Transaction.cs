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
    public partial class frmShowTransaction : Form
    {
        public frmShowTransaction()
        {
            InitializeComponent();
            this.Da = new Data_Access();
        }
        frmAccountant X { set; get; }
        private Data_Access Da { get; set; }
        public frmShowTransaction(frmAccountant X):this()
        {
            this.X = X;
        }
        private void PopulateGridView(string sql = "select * from Transaction;")
        {
          //  MessageBox.Show("Bye");
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvShowTransaction.AutoGenerateColumns = false;
            this.dgvShowTransaction.DataSource = ds.Tables[0];
        }

        private void Show_Transaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;

        }

        private void btnShowTransaction_Click(object sender, EventArgs e)
        {
            var sq = "select * from Transactions;";
            this.PopulateGridView(sq);
        }

        private void dgvShowTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idd = dgvShowTransaction.Rows[e.RowIndex].Cells["dgvShowTransactionProduct_id"].FormattedValue.ToString();
                try
                {
                    string pp  = dgvShowTransaction.Rows[e.RowIndex].Cells["dgvShowTransactionProduct_id"].FormattedValue.ToString();
                    var sqq2 = "select * from Transactions where Product_id Like '" + pp + "';";
                    MessageBox.Show("Transaction successfully added to Calculation");
                    string aaa = Da.ExecuteQuery(sqq2).Tables[0].Rows[0][0].ToString();
                    string bbb = Da.ExecuteQuery(sqq2).Tables[0].Rows[0][1].ToString();
                    string ccc = Da.ExecuteQuery(sqq2).Tables[0].Rows[0][2].ToString();
                    string ddd = Da.ExecuteQuery(sqq2).Tables[0].Rows[0][3].ToString();
                    string eee = Da.ExecuteQuery(sqq2).Tables[0].Rows[0][4].ToString();
                    string q= "Delete Transactions Where Product_id Like '" + idd + "';";
                    int income = Convert.ToInt32(ccc);
                    int expense = Convert.ToInt32(ddd);
                    string pai = "select * from Calculation where Calculation_id like 'CC-000';";
                    int income2= Convert.ToInt32(Da.ExecuteQuery(pai).Tables[0].Rows[0][1].ToString());
                    int expense2 = Convert.ToInt32(Da.ExecuteQuery(pai).Tables[0].Rows[0][2].ToString());
                    income += income2;
                    expense += expense2;
                    if (Da.ExecuteDMLQuery(q) == 1)
                    {
                        MessageBox.Show("Transaction successfully added to Calculation");
                        var sq = "select * from Transactions;";
                        this.PopulateGridView(sq);

                        string notun = Convert.ToString(income);
                        string notun2= Convert.ToString(expense);
                        string notun3= Convert.ToString(expense-income);
                        var sw = "update Calculation set Calculation_id='CC-000',Income='" + notun + "',Expense='" + notun2 + "',Profit='" + notun3 + "';";
                        int count = this.Da.ExecuteDMLQuery(sw);

                    }
                  }
                catch (Exception exc)
                {
                    MessageBox.Show("An Error Has Occured, " + exc.Message);
                }
            }
        }
            
    }
}
