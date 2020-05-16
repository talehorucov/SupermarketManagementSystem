using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.ORM.Facade;
using Market.ORM.Entity;
using Market.ORM;

namespace MarketWinFormUI
{
    public partial class AddEmployeeUserControl : UserControl
    {
        public AddEmployeeUserControl()
        {
            InitializeComponent();
        }
        EmployeesORM employeesORM = new EmployeesORM();
        AuthorityORM authorityORM = new AuthorityORM();
        private void EmployeeUserControl_Load(object sender, EventArgs e)
        {
            cmbAuthority.DataSource = authorityORM.Select();
            cmbAuthority.DisplayMember = "Vəzifə";
            cmbAuthority.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("İşçi əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if ((txtFirstname.Text != "" || txtLastname.Text != "" || txtUsername.Text != "" || txtPassword.Text != "") && mskdIdentityNo.Text.Length == 8)
                {
                    Employees employees = new Employees();
                    employees.Firstname = txtFirstname.Text;
                    employees.Lastname = txtLastname.Text;
                    employees.IdentityNo = mskdIdentityNo.Text;
                    employees.PhoneNo = mskdPhoneNo.Text;
                    employees.BirthDate = dtpBirthDate.Value;
                    employees.Salary = nudSalary.Value;
                    employees.AuthorityID = (int)cmbAuthority.SelectedValue;
                    employees.Username = txtUsername.Text;
                    employees.Pass = txtPassword.Text;
                    employees.Adress = txtAdress.Text;

                    employeesORM.SameAdd(employees);
                    if (employeesORM.status == true)
                    {
                        bool result = employeesORM.Insert(employees);
                        if (result)
                        {
                            MessageBox.Show("İşçi müvəffəqiyyətlə əlavə edildi !");
                            foreach (Control item in Controls)
                            {
                                if (item is TextBox)
                                {
                                    item.Text = "";
                                }
                                nudSalary.Value = 0;
                                mskdIdentityNo.Text = "";
                                mskdPhoneNo.Text = "";
                                cmbAuthority.Items.IndexOf(0);
                            }
                        }
                        else
                            MessageBox.Show("Xəta !!!");
                    }
                    else
                        MessageBox.Show("Bu istifadəçi adından artıq sistemdə var. Xahiş edirik başqa istifadəçi adı yazın!");
                }
                else if(mskdIdentityNo.Text.Length < 8)
                    MessageBox.Show("Şəxsiyyət vəsiqəsinin seriya nömrəsi 8-dən az ola bilməz !");
                else
                    MessageBox.Show("Xahiş edirik ulduzlanan xanaları doldurun !");
            }
        }
    }
}
