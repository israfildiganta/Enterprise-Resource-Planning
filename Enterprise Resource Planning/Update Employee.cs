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
    public partial class frmUpdateEmployee : Form
    {
        Data_Access Da { get; set; }
        frmHR X { get; set; }
        public frmUpdateEmployee()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public frmUpdateEmployee(frmHR x):this()
        {
            X = x;
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtUpdateEmployeeEmail.Text) || String.IsNullOrEmpty(this.txtUpdateEmployeeName.Text) ||
                String.IsNullOrEmpty(this.txtUpdateEmployeePassword.Text) || String.IsNullOrEmpty(this.txtUpdateEmployeeConfirmPassword.Text) ||
                String.IsNullOrEmpty(this.cmbUpdateEmployeeRole.Text) || String.IsNullOrWhiteSpace(this.dtmUpdateEmployeeDateOfBirth.Text) ||
                String.IsNullOrEmpty(this.cmbUpdateEmployeeBloodGroup.Text) || (this.rbtnUpdateEmployeeFemale.Checked == false && this.rbtnUpdateEmployeeMale.Checked == false))
            {
                return false;
            }
            else
                return true;
        }
        private void btnUpdateEmployeeSave_Click(object sender, EventArgs e)
        {
            if (this.txtUpdateEmployeePassword.Text.Equals(this.txtUpdateEmployeeConfirmPassword.Text))
            {
                try
                {
                    if (!this.IsValidToSaveData())
                    {
                        MessageBox.Show("Invalid opration. Please fill up all the information");
                        return;
                    }
                    var query = "select * from Person where Email like '" + this.txtUpdateEmployeeEmail.Text + "';";
                    var ds = this.Da.ExecuteQuery(query);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        string salary = "";
                        string gender = "";
                        if (this.rbtnUpdateEmployeeMale.Checked) gender = "Male";
                        else gender = "Female";
                        if (this.cmbUpdateEmployeeRole.Text == "Production Manager") salary = "50000";
                        else salary = "60000";
                        //update
                        var sql = @"update Person
                                set Name = '" + this.txtUpdateEmployeeName.Text + @"',
                                Email = '" + this.txtUpdateEmployeeEmail.Text + @"',
                                ID = '" + ds.Tables[0].Rows[0][2].ToString() + @"',
                                Password = '" + this.txtUpdateEmployeePassword.Text + @"',
                                DateOfBirth = '" + this.dtmUpdateEmployeeDateOfBirth.Text + @"',
                                Salary = '" + salary + @"',
                                Role = '" + ds.Tables[0].Rows[0][7].ToString() + @"',
                                BloodGroup = '" + this.cmbUpdateEmployeeBloodGroup.Text + @"',
                                Gender = '" + gender + @"'
                                where Email like '" + this.txtUpdateEmployeeEmail.Text + "';";
                        int count = this.Da.ExecuteDMLQuery(sql);
                        if (count == 1)
                            MessageBox.Show("Data updated successfully");
                        else
                            MessageBox.Show("Data upgradation failed");
                    }
                    else
                    {
                        MessageBox.Show("User Doesn't Exist");
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

        private void btnUpdateEmployeeClear_Click(object sender, EventArgs e)
        {
            this.txtUpdateEmployeeEmail.Text = "";
            this.txtUpdateEmployeeName.Text = "";
            this.txtUpdateEmployeePassword.Text = "";
            this.txtUpdateEmployeeConfirmPassword.Text = "";
            this.dtmUpdateEmployeeDateOfBirth.Value = DateTime.Today;
            this.cmbUpdateEmployeeRole.SelectedIndex = -1;
            this.cmbUpdateEmployeeBloodGroup.SelectedIndex = -1;
            this.rbtnUpdateEmployeeFemale.Checked = false;
            this.rbtnUpdateEmployeeMale.Checked = false;
        }

        private void btnUpdateEmployeeBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void frmUpdateEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }
    }
}
