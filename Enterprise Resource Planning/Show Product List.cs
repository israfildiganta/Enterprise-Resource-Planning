using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Resource_Planning
{
    public partial class frmShowProductionList : Form
    {
        private Data_Access Da { get; set; }
        public frmShowProductionList()
        {
            InitializeComponent();
            this.Da = new Data_Access();

            ///this.PopulateGridView();
            ///this.dgvView.ClearSelection();
        }

        private void PopulateGridView(string sql = "select * from Product;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvView.AutoGenerateColumns = false;
            this.dgvView.DataSource = ds.Tables[0];
        }
       
        private frmProductionManager F1 { set; get; }
        public frmShowProductionList(frmProductionManager ft):this()
        {
            this.F1 = ft;
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F1.Show();
        }
       



        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            ///this.dgvView.ClearSelection();
        }

        private void txtIDSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Product where Product_id like '" + this.txtIDSearch.Text + "%';";
            this.PopulateGridView(sql);
            this.txtNameSearch.Text = "";
            this.txtWarehouseSearch.Text = "";
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Product where Product_Name like '" + this.txtNameSearch.Text + "%';";
            this.PopulateGridView(sql);
            this.txtIDSearch.Text = "";
            this.txtWarehouseSearch.Text = "";
        }

        private void txtWarehouseSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Product where WareHouse_name like '" + this.txtWarehouseSearch.Text + "%';";
            this.PopulateGridView(sql);
            this.txtIDSearch.Text = "";
            this.txtNameSearch.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtIDSearch.Text = "";
            this.txtNameSearch.Text = "";
            this.txtWarehouseSearch.Text = "";
            this.dgvView.DataSource="";
        }

       

        private void frmShowProductionList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            F1.Visible = true;
        }
    }
}
