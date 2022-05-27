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
    public partial class frmRegister_Employee : Form
    {
        private frmHR R1 { get; set; }
        Data_Access Da { get; set; }
        public frmRegister_Employee()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public frmRegister_Employee(frmHR x) : this()
        {
            R1 = x;
        }

        private void Register_Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            R1.Visible = true;
        }

        private void btnRegisterNewEmployeeClear_Click(object sender, EventArgs e)
        {
            this.txtRegisterNewEmployeeEmail.Text = "";
            this.txtRegisterNewEmployeeName.Text = "";
            this.txtRegisterNewEmployeePassword.Text = "";
            this.txtRegisterNewEmployeeConfirmPassword.Text = "";
            this.dtmRegisterNewEmployeeDateOfBirth.Value=DateTime.Today;
            this.cmbRegisterNewEmployeeRole.SelectedIndex = -1;
            this.cmbRegisterNewEmployeeBloodGroup.SelectedIndex = -1;
            this.rbtnRegisterNewEmployeeFemale.Checked = false;
            this.rbtnRegisterNewEmployeeMale.Checked = false;
        }
        private void btnRegisterNewEmployeeBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            R1.Visible = true;
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtRegisterNewEmployeeEmail.Text) || String.IsNullOrEmpty(this.txtRegisterNewEmployeeName.Text) ||
                String.IsNullOrEmpty(this.txtRegisterNewEmployeePassword.Text) || String.IsNullOrEmpty(this.txtRegisterNewEmployeeConfirmPassword.Text) ||
                String.IsNullOrEmpty(this.cmbRegisterNewEmployeeRole.Text) || String.IsNullOrWhiteSpace(this.dtmRegisterNewEmployeeDateOfBirth.Text) ||
                String.IsNullOrEmpty(this.cmbRegisterNewEmployeeBloodGroup.Text) ||(this.rbtnRegisterNewEmployeeFemale.Checked==false&&this.rbtnRegisterNewEmployeeMale.Checked==false))
            {
                return false;
            }
            else
                return true;
        }
        private void btnRegisterNewEmployeeSave_Click(object sender, EventArgs e)
        {
            if(this.txtRegisterNewEmployeePassword.Text.Equals(this.txtRegisterNewEmployeeConfirmPassword.Text))
            {
                try
                {
                    if (!this.IsValidToSaveData())
                    {
                        MessageBox.Show("Invalid opration. Please fill up all the information");
                        return;
                    }
                    var query = "select * from Person where ID = '" + this.txtRegisterNewEmployeeEmail.Text + "';";
                    var ds = this.Da.ExecuteQuery(query);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("User Already Exists.");
                    }
                    else
                    {
                        //insert
                        string role = this.cmbRegisterNewEmployeeRole.Text;
                        string id = Da.genID(role);
                        string Salary;
                        if (role == "Accountant") Salary = "60000";
                        else Salary = "60000";
                        string Gender;
                        if (this.rbtnRegisterNewEmployeeMale.Checked == true) Gender = "Male";
                        else Gender = "Female";
                        var sql = @"insert into Person values('" + this.txtRegisterNewEmployeeName.Text + "','" + this.txtRegisterNewEmployeeEmail.Text + "','"+id+"','" + this.txtRegisterNewEmployeePassword.Text + "','" + this.dtmRegisterNewEmployeeDateOfBirth.Text+ "','" +Salary+"','"+ Gender+"','"+ this.cmbRegisterNewEmployeeRole.Text+"','"+this.cmbRegisterNewEmployeeBloodGroup.Text +"');";
                        int count = this.Da.ExecuteDMLQuery(sql);
                        if (count == 1)
                            MessageBox.Show("Data insertion successfull");
                        else
                            MessageBox.Show("Data insertion failed");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured: " + exc.Message);
                }

            }
            else
            {
                MessageBox.Show("Passwords Didn't Match");
            }
        }

        private void frmRegister_Employee_Load(object sender, EventArgs e)
        {

        }

        private void txtRegisterNewEmployeeConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
