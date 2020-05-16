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

namespace MarketWinFormUI
{
    public partial class SuppliersUserControl : UserControl
    {
        public SuppliersUserControl()
        {
            InitializeComponent();
        }
        SuppliersORM suppliersORM = new SuppliersORM();
        private void SuppliersUserControl_Load(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource = suppliersORM.Select();
            dgvSuppliers.Columns["Id"].Visible = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Tədarikçi redaktə edilsin ?", "Redaktə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvSuppliers.SelectedRows.Count == 1)
                    {
                        Suppliers suppliers = new Suppliers();
                        suppliers.Id = (int)dgvSuppliers.CurrentRow.Cells["Id"].Value;
                        suppliers.Firstname = txtFirstname.Text;
                        suppliers.Lastname = txtLastname.Text;
                        suppliers.CompanyName = txtCompanyName.Text;
                        suppliers.PhoneNo = mskdPhoneNo.Text;
                        suppliers.Mail = txtMail.Text;
                        suppliers.Adress = txtAdress.Text;

                        suppliersORM.Update(suppliers);
                        dgvSuppliers.DataSource = suppliersORM.Select();
                        foreach (Control item in Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                            mskdPhoneNo.Text = "";
                        }
                        MessageBox.Show("Tədarikçi redaktə edildi !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik redaktə etmək istədiyiniz tədarikçini seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }
        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstname.Text = dgvSuppliers.CurrentRow.Cells["Ad"].Value.ToString();
            txtLastname.Text = dgvSuppliers.CurrentRow.Cells["Soyad"].Value.ToString();
            txtCompanyName.Text = dgvSuppliers.CurrentRow.Cells["Şirkət adı"].Value.ToString();
            mskdPhoneNo.Text = dgvSuppliers.CurrentRow.Cells["Mobil nömrə"].Value.ToString();
            txtMail.Text = dgvSuppliers.CurrentRow.Cells["E-Mail ünvanı"].Value.ToString();
            txtAdress.Text = dgvSuppliers.CurrentRow.Cells["Ünvan"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Tədarikçi silinsin ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvSuppliers.SelectedRows.Count == 1)
                    {
                        Suppliers suppliers = new Suppliers();
                        suppliers.Id = (int)dgvSuppliers.CurrentRow.Cells["Id"].Value;
                        suppliersORM.Delete(suppliers);
                        dgvSuppliers.DataSource = suppliersORM.Select();
                        foreach (Control item in Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                            mskdPhoneNo.Text = "";
                        }
                        MessageBox.Show("Tədarikçi silindi !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik silmək istədiyiniz tədarikçini seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Firstname = txtSearch.Text;
            dgvSuppliers.DataSource = suppliersORM.Search(suppliers);
        }

        private void dgvSuppliers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSuppliers.ClearSelection();
        }
    }
}
