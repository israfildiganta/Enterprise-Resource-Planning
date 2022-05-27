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
    public partial class frmAddingProduct : Form
    {
        private Data_Access Da { get; set; }
        public frmAddingProduct()
        {
            InitializeComponent();
            this.Da = new Data_Access();

           /// this.PopulateGridView();
           // this.dgvView1.ClearSelection();
        }

        private void PopulateGridView(string sql = "select * from Ware;")
        {
            var ds = this.Da.ExecuteQuery(sql);

           // this.dgvView1.AutoGenerateColumns = false;
            //this.dgvView1.DataSource = ds.Tables[0];
        }

        private frmProductionManager F1 { set; get; }
        public frmAddingProduct(frmProductionManager ft) : this()
        {
            this.F1 = ft;
        }

        private void Cost_Click(object sender, EventArgs e)
        {

        }
        
        bool isValidCost(string s)
        {
            if (s.Length == 0) return false;
            int idx = 0;
            while(idx<s.Length)
            {
                if(!(s[idx]>='0'&&s[idx]<='9'))
                {
                    return false;
                }
                idx++;
            }
            return true;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (isValidCost(this.txtCost.Text)  && isValidCost(this.txtProductSellingPrice.Text))
            {
                var sql1 = "select * from Ware where Warehouse_id like '" + txtWarehouseId.Text + "';";
                if (Da.ExecuteQuery(sql1).Tables[0].Rows.Count > 0)
                {
                    if (this.txtName.Text.Length == 0)
                    {
                        MessageBox.Show("Please Insert the Name");

                    }
                    else
                    {
                        int cnt = Convert.ToInt32(Da.ExecuteQuery(sql1).Tables[0].Rows[0][4].ToString());
                        int cnt2 = Convert.ToInt32(Da.ExecuteQuery(sql1).Tables[0].Rows[0][3].ToString());
                        if (cnt == cnt2)
                        {
                            MessageBox.Show("Capacity Full");
                        }
                        else
                        {
                            int cnt3 = Convert.ToInt32(Da.ExecuteQuery(sql1).Tables[0].Rows[0][4].ToString());
                            cnt3++;
                            string bb = Convert.ToString(cnt3);
                            string a = Da.genPID(cmbProductType.Text);
                            var sql = @"insert into Product values('" + a + "','" + this.txtName.Text + "','" + this.txtCost.Text + "','" + this.txtWarehouseId.Text + "','" + this.dtTime.Text + "','" + this.cmbProductType.Text + "','" + this.txtProductSellingPrice.Text + "');";
                            var rowCount = this.Da.ExecuteDMLQuery(sql);
                            
                            var sq = @"update Ware
                        set Warehouse_id = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][0].ToString() + @"',
                        Warehouse_name = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][1].ToString() + @"',
                        Location = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][2].ToString() + @"',
                        Capacity = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][3].ToString() +
                            @"', Quantity = '" + bb + @"'
                        where Warehouse_id like '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][0].ToString() + "';";
                            int count = this.Da.ExecuteDMLQuery(sq);


                            if (rowCount == 1) MessageBox.Show("Information Inserted");
                            else MessageBox.Show("No opeartion occure");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("There is no Warehouse");
                }
            }
            else
            {
                MessageBox.Show("Invalid Cost");
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F1.Visible=true;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }

        private void frmAddingProduct_Load(object sender, EventArgs e)
        {

        }
        private void frmAddingProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }
    }
}
