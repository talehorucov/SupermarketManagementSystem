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
    public partial class EmployeeUserControl : UserControl
    {
        public EmployeeUserControl()
        {
            InitializeComponent();
        }
        EmployeesORM employeesORM = new EmployeesORM();
        AuthorityORM authorityORM = new AuthorityORM();
        private void EmployeeUserControl_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = employeesORM.Select();
            dgvEmployees.Columns["Id"].Visible = false;

            cmbAuthority.DataSource = authorityORM.Select();
            cmbAuthority.DisplayMember = "Vəzifə";
            cmbAuthority.ValueMember = "Id";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("İşci redaktə edilsin ?", "Redaktə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvEmployees.SelectedRows.Count == 1)
                    {
                        Employees employees = new Employees();
                        employees.Id = (int)dgvEmployees.CurrentRow.Cells["Id"].Value;
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

                        employeesORM.SameUpdate(employees);
                        if (employeesORM.status)
                        {
                            bool result = employeesORM.Update(employees);
                            if (result)
                            {
                                dgvEmployees.DataSource = employeesORM.Select();
                                foreach (Control item in Controls)
                                {
                                    if (item is TextBox)
                                        item.Text = "";
                                    mskdIdentityNo.Text = "";
                                    mskdPhoneNo.Text = "";
                                    nudSalary.Value = 0;
                                }
                                MessageBox.Show("İşçi redaktə edildi !");
                            }
                        }
                        else
                            MessageBox.Show("Bu istifadəçi adından artıq sistemdə var. Xahiş edirik başqa istifadəçi adı yazın!");
                    }
                    else
                        MessageBox.Show("Xahiş edirik redaktə etmək istədiyiniz işçini seçin !");

                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtFirstname.Text = dgvEmployees.CurrentRow.Cells["Ad"].Value.ToString();
                txtLastname.Text = dgvEmployees.CurrentRow.Cells["Soyad"].Value.ToString();
                mskdIdentityNo.Text = dgvEmployees.CurrentRow.Cells["Ş/V nömrəsi"].Value.ToString();
                mskdPhoneNo.Text = dgvEmployees.CurrentRow.Cells["Mobil nömrə"].Value.ToString();
                dtpBirthDate.Value = (DateTime)dgvEmployees.CurrentRow.Cells["Doğum tarixi"].Value;
                nudSalary.Value = Convert.ToDecimal(dgvEmployees.CurrentRow.Cells["Məvacib"].Value);
                cmbAuthority.Text = dgvEmployees.CurrentRow.Cells["Vəzifə"].Value.ToString();
                txtUsername.Text = dgvEmployees.CurrentRow.Cells["İstifadəçi adı"].Value.ToString();
                txtPassword.Text = dgvEmployees.CurrentRow.Cells["Şifrə"].Value.ToString();
                txtAdress.Text = dgvEmployees.CurrentRow.Cells["Ünvan"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Mövcud olmayan istifadəçi !");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("İçşi  silinsin ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvEmployees.SelectedRows.Count == 1)
                    {
                        Employees employees = new Employees();
                        employees.Id = (int)dgvEmployees.CurrentRow.Cells["Id"].Value;
                        employeesORM.Delete(employees);
                        dgvEmployees.DataSource = employeesORM.Select();
                        foreach (Control item in Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                            mskdIdentityNo.Text = "";
                            mskdPhoneNo.Text = "";
                            nudSalary.Value = 0;
                        }
                        MessageBox.Show("İşçi silindi !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik silmək istədiyiniz işçini seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Firstname = txtSearch.Text;
            dgvEmployees.DataSource = employeesORM.Search(employees);
        }

        private void dgvEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEmployees.ClearSelection();
        }
    }
}
