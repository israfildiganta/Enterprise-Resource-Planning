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
    public partial class frmAddingWarehouse : Form
    {
        private Data_Access Da { get; set; }
        public frmAddingWarehouse()
        {
            InitializeComponent();
            this.Da = new Data_Access();

            ///this.PopulateGridView();
            ///this.dgvView1.ClearSelection();
        }

        private void PopulateGridView(string sql = "select * from Ware;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvView1.AutoGenerateColumns = false;
            this.dgvView1.DataSource = ds.Tables[0];
        }

        private frmProductionManager F1 { set; get; }
        public frmAddingWarehouse(frmProductionManager ft) : this()
        {
            this.F1 = ft;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }

       

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(this.txtWarehouseName.Text.Length==0)
            {
                MessageBox.Show("Please Insert the Name");

            }
            else
            {
                string a = Da.genWID();
                
                var sql = "insert into Ware values ('"+a+"','"+this.txtWarehouseName.Text+"','"+this.txtWarehouseLocation.Text+"','"+this.txtWarehouseCapacity.Text+"','0');";
                var rowCount = this.Da.ExecuteDMLQuery(sql);
                if(rowCount==1)MessageBox.Show("Information Inserted");
                else MessageBox.Show("No opeartion occure");
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var sql = "select * from Ware;";
            this.PopulateGridView(sql);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Ware where Warehouse_name like '" + this.txtWarehouseName.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void dgvView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var sql = "select * from Ware where Warehouse_name like '" + this.txtWarehouseName.Text + "%';";
            this.PopulateGridView(sql);

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }

        private void frmAddingWarehouse_Load(object sender, EventArgs e)
        {

        }
    }
}
