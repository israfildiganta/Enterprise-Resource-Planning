using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Resource_Planning
{
    class Data_Access
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }
        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        //internal DataTable dt;

        public Data_Access()
        {
            this.Sqlcon = new SqlConnection("Data Source=DESKTOP-RO78UGJ;Initial Catalog=Diganta;Persist Security Info=True;User ID=sa;Password=farhana123*nusrat#");
            Sqlcon.Open();
        }
        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }
        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }
        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }
        public int ExecuteDMLQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
        public string genID(string s)
        {
            string q = "select * from Person where Role like '"+s+"' ORDER BY ID DESC ";
            DataSet dst = this.ExecuteQuery(q);
            if (dst.Tables[0].Rows.Count == 0)
            {
                int k = 0;
                string newId = "";
                if (s == "Production Manager") newId += "P-";
                else if (s == "Human Resource Manager") newId = "H-";
                else if (s == "Accountant") newId = "A-";
                string x = Convert.ToString(k);
                while (x.Length < 3)
                {
                    x = "0" + x;
                }
                newId = newId + x;
                return newId;
            }
            else
            {
                string p = dst.Tables[0].Rows[0][2].ToString();
                int k = Convert.ToInt32(p.Substring(2));
                string newId = p.Substring(0, 2);
                k++;
                string x = Convert.ToString(k);
                while (x.Length < 3)
                {
                    x = "0" + x;
                }
                newId = newId + x;
                return newId;
            }
        }
        public string genPID(string type)
        {
            string q = "select * from Product where type like '" + type + "' ORDER BY Product_id DESC ;";
            DataSet dst = this.ExecuteQuery(q);
            if (dst.Tables[0].Rows.Count == 0)
            {
                string x = "0";
                string newId;
                if (type == "Food") newId = "PF-";
                else if (type == "Electronics") newId = "PE-";
                else if (type == "Furniture") newId = "PT-";
                else
                {
                    newId = "PR-";
                }
                while (x.Length < 3)
                {
                    x = "0" + x;
                }
                newId = newId + x;
                return newId;
            }
            else
            {
                string p = dst.Tables[0].Rows[0][0].ToString();
                int k = Convert.ToInt32(p.Substring(3));
                string newId = p.Substring(0, 3);
                k++;
                string x = Convert.ToString(k);
                while (x.Length < 3)
                {
                    x = "0" + x;
                }
                newId = newId + x;
                return newId;
            }
        }
        public string genWID()
        {

            string q = "SELECT * FROM Ware ORDER BY Warehouse_id DESC; ";
            DataSet dst = this.ExecuteQuery(q);
            string p = dst.Tables[0].Rows[0][0].ToString();
            int k = Convert.ToInt32(p.Substring(3));
            string newId = p.Substring(0, 3);
            k++;
            string x = Convert.ToString(k);
            while (x.Length < 3)
            {
                x = "0" + x;
            }
            newId = newId + x;
            return newId;
        }
    }
}
