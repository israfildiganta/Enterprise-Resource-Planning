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
    public partial class frmUpdateHR : Form
    {
        frmCEO X { get; set; }
        Data_Access Da{ get; set; }
        public frmUpdateHR()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public frmUpdateHR(frmCEO x):this()
        {
            this.X = x;
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtUpdateHRName.Text) || string.IsNullOrEmpty(this.txtUpdateHREmail.Text) ||
                String.IsNullOrEmpty(this.txtUpdateHRPassword.Text) || String.IsNullOrEmpty(this.txtUpdateHRConfirmPassword.Text) ||
                String.IsNullOrWhiteSpace(this.dtmUpdateHRDateOfBirth.Text) || (this.rbtnUpdateHRMale.Checked == false && this.rbtnUpdateHRFemale.Checked == false) || this.cmbUpdateHRBloodGroup.SelectedIndex == -1)
            {
                return false;
            }
            else
                return true;
        }
        private void btnUpdateHRSave_Click(object sender, EventArgs e)
        {
            if (this.txtUpdateHRPassword.Text.Equals(this.txtUpdateHRConfirmPassword.Text))
            {
                try
                {
                    if (!this.IsValidToSaveData())
                    {
                        MessageBox.Show("Invalid opration. Please fill up all the information");
                        return;
                    }
                    var query = "select * from Person where Email like '" + this.txtUpdateHREmail.Text + "';";
                    var ds = this.Da.ExecuteQuery(query);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        string gender = "";
                        if (this.rbtnUpdateHRMale.Checked) gender = "Male";
                        else gender = "Female";
                        //update
                        var sql = @"update Person
                                set Name = '" + this.txtUpdateHRName.Text + @"',
                                Email = '" + this.txtUpdateHREmail.Text + @"',
                                ID = '" + ds.Tables[0].Rows[0][2].ToString() + @"',
                                Password = '" + this.txtUpdateHRPassword.Text + @"',
                                DateOfBirth = '" + this.dtmUpdateHRDateOfBirth.Text + @"',
                                Salary = '" + ds.Tables[0].Rows[0][5].ToString() + @"',
                                Role = '" + ds.Tables[0].Rows[0][7].ToString()+ @"',
                                BloodGroup = '"+this.cmbUpdateHRBloodGroup.Text+ @"',
                                Gender = '" + gender + @"'
                                where Email like '" + this.txtUpdateHREmail.Text + "';";
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

        private void frmUpdateHR_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void btnUpdateHRBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void btnUpdateHRClear_Click(object sender, EventArgs e)
        {
            this.txtUpdateHRName.Text = "";
            this.txtUpdateHREmail.Text = "";
            this.txtUpdateHRPassword.Text = "";
            this.txtUpdateHRConfirmPassword.Text = "";
            this.dtmUpdateHRDateOfBirth.Text = "";
            this.rbtnUpdateHRFemale.Checked = false;
            this.rbtnUpdateHRMale.Checked = false;
            this.cmbUpdateHRBloodGroup.SelectedIndex = -1;
        }
    }
}
