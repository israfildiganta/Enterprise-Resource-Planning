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
    public partial class frmProductDelete : Form
    {
        private Data_Access Da { get; set; }
        public frmProductDelete()
        {
            InitializeComponent();
            this.Da = new Data_Access();
            this.PopulateGridView();
            ///this.dgvProductDelete.ClearSelection();
        }
        private void PopulateGridView(string sql = "select * from Product;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvProductDelete.AutoGenerateColumns = false;
            this.dgvProductDelete.DataSource = ds.Tables[0];
        }
        private frmProductionManager F1 { set; get; }
        string tine;
        public frmProductDelete(frmProductionManager ft,string a) : this()
        {
            this.F1 = ft;
            this.tine = a;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sql = "select * from Product;";
            this.PopulateGridView(sql);

        }

        private void dgvProductDelete_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idd = dgvProductDelete.Rows[e.RowIndex].Cells["dgvProductDeleteId"].FormattedValue.ToString();
                string q = "Delete Product Where Product_id Like '" + idd + "';";
                try
                {
                    
                    string del = dgvProductDelete.Rows[e.RowIndex].Cells["dgvProductDeleteWarehouseId"].FormattedValue.ToString();
                    var sql1 = "select * from Ware where Warehouse_id like '" + del + "';";
                    var sqq2 = "select * from Product where Product_id Like '" + idd + "';";
                    string aaa=Da.ExecuteQuery(sqq2).Tables[0].Rows[0][1].ToString();
                    string bbb = Da.ExecuteQuery(sqq2).Tables[0].Rows[0][0].ToString();
                    string ccc = Da.ExecuteQuery(sqq2).Tables[0].Rows[0][2].ToString();
                    string ddd = Da.ExecuteQuery(sqq2).Tables[0].Rows[0][6].ToString();
                    string eee = tine;
                   // MessageBox.Show(tine);
                   
                    var sql4 = @"insert into Transactions values('"+ aaa + "','" + bbb + "','"+ ccc + "','"+ ddd + "','"+ eee + "');";
                    int cnt3 = Convert.ToInt32(Da.ExecuteQuery(sql1).Tables[0].Rows[0][4].ToString());
                    int ount = this.Da.ExecuteDMLQuery(sql4);

                    cnt3--;
                    if (Da.ExecuteDMLQuery(q) == 1)
                    {
                       // MessageBox.Show("Deleted Successfully");
                        //MessageBox.Show("KIng");
                        
                      
                        var sql = "select * from Product;";
                     //   var ount = this.Da.ExecuteDMLQuery(sql4);
                        this.PopulateGridView(sql);
                        string bb = Convert.ToString(cnt3);
                        var sq = @"update Ware
                        set Warehouse_id = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][0].ToString() + @"',
                        Warehouse_Name = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][1].ToString() + @"',
                        Location = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][2].ToString() + @"',
                        Capacity = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][3].ToString() +
                        @"', Quantity = '" + bb + @"'
                        where Warehouse_id like '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][0].ToString() + "';";
                        int count = this.Da.ExecuteDMLQuery(sq);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An Error Has Occured, " + exc.Message);
                }
            }
        }
        private void frmProductDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }
    }
}
