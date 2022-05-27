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
    public partial class frmShowGraphChart : Form
    {
        Data_Access Da { get; set; }
        frmHR HR { get; set; }
        public frmShowGraphChart()
        {
            InitializeComponent();
            this.Da = new Data_Access();
            chartGender.Titles.Add("Pie Chart For Gender");
            chartGender.Series["ShowGenderChart"].IsValueShownAsLabel = true;
            int count=Da.ExecuteQuery("select * from Person where Gender like 'Male' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartGender.Series["ShowGenderChart"].Points.AddXY("Male", Convert.ToString(count));
            count = Da.ExecuteQuery("select * from Person where Gender like 'Female' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartGender.Series["ShowGenderChart"].Points.AddXY("FeMale", Convert.ToString(count));


            chartBloodGroup.Titles.Add("Pie Chart For Blood Group");
            chartBloodGroup.Series["ShowBloodGroupChart"].IsValueShownAsLabel = true;
            count = Da.ExecuteQuery("select * from Person where BloodGroup like 'O+' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartBloodGroup.Series["ShowBloodGroupChart"].Points.AddXY("O+", Convert.ToString(count));

            count = Da.ExecuteQuery("select * from Person where BloodGroup like 'B+' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartBloodGroup.Series["ShowBloodGroupChart"].Points.AddXY("B+", Convert.ToString(count));

            count = Da.ExecuteQuery("select * from Person where BloodGroup like 'A+' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartBloodGroup.Series["ShowBloodGroupChart"].Points.AddXY("A+", Convert.ToString(count));

            count = Da.ExecuteQuery("select * from Person where BloodGroup like 'AB+' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartBloodGroup.Series["ShowBloodGroupChart"].Points.AddXY("AB+", Convert.ToString(count));


            count = Da.ExecuteQuery("select * from Person where BloodGroup like 'O-' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartBloodGroup.Series["ShowBloodGroupChart"].Points.AddXY("O-", Convert.ToString(count));


            count = Da.ExecuteQuery("select * from Person where BloodGroup like 'B-' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartBloodGroup.Series["ShowBloodGroupChart"].Points.AddXY("B-", Convert.ToString(count));


            count = Da.ExecuteQuery("select * from Person where BloodGroup like 'A-' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartBloodGroup.Series["ShowBloodGroupChart"].Points.AddXY("A-", Convert.ToString(count));


            count = Da.ExecuteQuery("select * from Person where BloodGroup like 'AB-' and Role not like 'C%' and Role not like 'H%';").Tables[0].Rows.Count;
            chartBloodGroup.Series["ShowBloodGroupChart"].Points.AddXY("AB-", Convert.ToString(count));

        }
        public frmShowGraphChart(frmHR hr):this()
        {
            this.HR = hr;
        }

        private void Gender_Chart_Load(object sender, EventArgs e)
        {

        }

        private void Gender_Chart_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.HR.Visible = true;
        }

        private void btnGenderChartBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.HR.Visible = true;
        }
    }
}
