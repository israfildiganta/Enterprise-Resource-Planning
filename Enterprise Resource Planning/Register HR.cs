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
    public partial class Register_HR : Form
    {
        frmCEO X { set; get; }
        Data_Access Da { get; set; }
        public Register_HR()
        {
            InitializeComponent();
            Da = new Data_Access();
        }
        public Register_HR(frmCEO x) : this()
        {
            X = x;
        }
        private void Register_HR_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterHRBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtRegisterHRName.Text) || string.IsNullOrEmpty(this.txtRegisterHREmail.Text)||
                String.IsNullOrEmpty(this.txtRegisterHRPassword.Text) || String.IsNullOrEmpty(this.txtRegisterHRConfirmPassword.Text) ||
                String.IsNullOrEmpty(this.lblCEORegisterHRRole.Text) || String.IsNullOrWhiteSpace(this.dtmRegisterHRDateOfBirth.Text) || (this.rbtnRegisterHRGenderMale.Checked==false && this.rbtnRegisterHRGenderFemale.Checked == false) || this.cmbRegisterHumanResourceBloodGroup.SelectedIndex==-1)
            {
                return false;
            }
            else
                return true;
        }
        private void btnRegisterHRSave_Click(object sender, EventArgs e)
        {
            if (this.txtRegisterHRPassword.Text.Equals(this.txtRegisterHRConfirmPassword.Text))
            {
                try
                {
                    if (!this.IsValidToSaveData())
                    {
                        MessageBox.Show("Invalid opration. Please fill up all the information");
                        return;
                    }
                    var query = "select * from Person where Email = '" + this.txtRegisterHREmail.Text + "';";
                    var ds = this.Da.ExecuteQuery(query);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        MessageBox.Show("User Already Exists with this Email");
                        
                        //update
                        /*
                        var sql = @"update Person
                                set Name = '" + this.txtRegisterHRName.Text + @"', 
                                Password = " + this.txtRegisterHRPassword.Text + @",
                                DateOfBirth = '" + this.dtmRegisterHRDateOfBirth.Text + @"',
                                Role = '" + this.lblCEORegisterHRRole.Text+ @"'
                                BloodGroup =  '"+this.lblRegisterHRBloodGroup.Text+@"'
                                where Email = '" + this.txtRegisterHREmail.Text + "';";
                        int count = this.Da.ExecuteDMLQuery(sql);
                        if (count == 1)
                            MessageBox.Show("Data updated successfully");
                        else
                            MessageBox.Show("Data upgradation failed");
                        */
                    }
                    else
                    {
                        //insert
                        string ID = Da.genID("Human Resource Manager");
                        string gender;
                        if (this.rbtnRegisterHRGenderMale.Checked) gender = "Male";
                        else gender = "Female";
                        var sql = @"insert into Person values('" + this.txtRegisterHRName.Text + "','" + this.txtRegisterHREmail.Text + "','"+ID+"','" + this.txtRegisterHRPassword.Text + "','" + this.dtmRegisterHRDateOfBirth.Text + "',75000,'" +gender+"','"+ this.lblCEORegisterHRRole.Text+"','"+this.cmbRegisterHumanResourceBloodGroup.Text + "');";
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
        private void Register_HR_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            X.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRegisterHRPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
