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
    public partial class frmShitfProduct : Form
    {
        private Data_Access Da { get; set; }
        public frmShitfProduct()
        {
            InitializeComponent();
            this.Da = new Data_Access();

            ///this.PopulateGridView();
            ///this.dgvView1.ClearSelection();
        }

        private void PopulateGridView(string sql = "select * from Ware;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            // this.dgvView1.AutoGenerateColumns = false;
            //this.dgvView1.DataSource = ds.Tables[0];
        }

        private frmProductionManager F1 { set; get; }
        public frmShitfProduct(frmProductionManager ft) : this()
        {
            this.F1 = ft;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            var sql1 = "select * from Ware where Warehouse_id like '" + txtPresentWarehouse.Text + "';";
            var sql2 = "select * from Ware where Warehouse_id like '" + txtNewWarehouseId.Text + "';";
            var sql3 = "select * from Product where Product_id like '" + txtSelectProductID.Text + "';";
            int coun1 = Da.ExecuteQuery(sql1).Tables[0].Rows.Count;
            int coun2 = Da.ExecuteQuery(sql2).Tables[0].Rows.Count;
            int coun3 = Da.ExecuteQuery(sql3).Tables[0].Rows.Count;
            if(coun1==0 || coun2==0 || coun3==0)
            {
                MessageBox.Show("Wrong Information");
            }
            else
            {

                int cnt = Convert.ToInt32(Da.ExecuteQuery(sql2).Tables[0].Rows[0][4].ToString());
                int cnt2 = Convert.ToInt32(Da.ExecuteQuery(sql2).Tables[0].Rows[0][3].ToString());

                string aa = Da.ExecuteQuery(sql1).Tables[0].Rows[0][0].ToString();
                string bb = Da.ExecuteQuery(sql3).Tables[0].Rows[0][3].ToString();
              //  MessageBox.Show(aa);
                //MessageBox.Show(bb);
                if (cnt==cnt2)
                {
                    MessageBox.Show("Capavity Full");
                }
                else if(aa.Equals(bb)==false)
                {
                    MessageBox.Show("Wrong Information");
                }
                else
                {
                 //   MessageBox.Show(bb);
                    int capa1= Convert.ToInt32(Da.ExecuteQuery(sql1).Tables[0].Rows[0][4].ToString());
                    int capa2= Convert.ToInt32(Da.ExecuteQuery(sql2).Tables[0].Rows[0][4].ToString());
                    capa1--;
                    capa2++;
                    string notun = Convert.ToString(capa2);
                    string pura = Convert.ToString(capa1);


                    var sq = @"update Ware
                            set Warehouse_id = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][0].ToString() + @"',
                            Warehouse_Name = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][1].ToString() + @"',
                            Location = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][2].ToString() + @"',
                            Capacity = '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][3].ToString() +
                    @"', Quantity = '" + pura + @"'
                            where Warehouse_id like '" + Da.ExecuteQuery(sql1).Tables[0].Rows[0][0].ToString() + "';";
                    int count = this.Da.ExecuteDMLQuery(sq);

                    

                    sq = @"update Ware
                            set Warehouse_id = '" + Da.ExecuteQuery(sql2).Tables[0].Rows[0][0].ToString() + @"',
                            Warehouse_Name = '" + Da.ExecuteQuery(sql2).Tables[0].Rows[0][1].ToString() + @"',
                            Location = '" + Da.ExecuteQuery(sql2).Tables[0].Rows[0][2].ToString() + @"',
                            Capacity = '" + Da.ExecuteQuery(sql2).Tables[0].Rows[0][3].ToString() +
                    @"', Quantity = '" + notun + @"'
                            where Warehouse_id like '" + Da.ExecuteQuery(sql2).Tables[0].Rows[0][0].ToString() + "';";
                     count = this.Da.ExecuteDMLQuery(sq);
                   

                    sq = @"update Product
                            set Product_id = '" + Da.ExecuteQuery(sql3).Tables[0].Rows[0][0].ToString() + @"',
                            Product_Name = '" + Da.ExecuteQuery(sql3).Tables[0].Rows[0][1].ToString() + @"',
                            Product_Cost = '" + Da.ExecuteQuery(sql3).Tables[0].Rows[0][2].ToString() + @"',
                           Warehouse_Name = '" + Da.ExecuteQuery(sql2).Tables[0].Rows[0][0].ToString() + @"',
                           Manufacture_Date = '" + Da.ExecuteQuery(sql3).Tables[0].Rows[0][4].ToString() + @"',
                           type = '" + Da.ExecuteQuery(sql3).Tables[0].Rows[0][5].ToString() + @"',
                           Selling_Price = '" + Da.ExecuteQuery(sql3).Tables[0].Rows[0][6].ToString() + @"'
                            where Product_id like '" + Da.ExecuteQuery(sql3).Tables[0].Rows[0][0].ToString() + "';";

                    count = this.Da.ExecuteDMLQuery(sq);

                    //MessageBox.Show("Diganta");

                    if (count == 1) MessageBox.Show("Information Inserted");
                    else MessageBox.Show("No opeartion occure");


                }
            }






        }

        private void frmShitfProduct_Load(object sender, EventArgs e)
        {

        }

        private void frmShitfProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }
    }
}
