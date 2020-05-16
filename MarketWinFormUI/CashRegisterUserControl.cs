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
    public partial class CashRegisterUserControl : UserControl
    {
        public CashRegisterUserControl()
        {
            InitializeComponent();
        }
        CashRegistersORM cashRegistersORM = new CashRegistersORM();
        private void CashRegisterUserControl_Load(object sender, EventArgs e)
        {
            dgvCashRegisters.DataSource = cashRegistersORM.Select();
            dgvCashRegisters.Columns["Id"].Visible = false;
        }

        private void dgvCashRegisters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCashName.Text = dgvCashRegisters.CurrentRow.Cells["Kassa adı"].Value.ToString();
            txtDescription.Text = dgvCashRegisters.CurrentRow.Cells["Açıqlama"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Kassa redaktə edilsin ?", "Redaktə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvCashRegisters.SelectedRows.Count == 1)
                    {
                        CashRegisters cashRegisters = new CashRegisters();
                        cashRegisters.Id = (int)dgvCashRegisters.CurrentRow.Cells["Id"].Value;
                        cashRegisters.Name = txtCashName.Text;
                        cashRegisters.Description = txtDescription.Text;

                        cashRegistersORM.SameUpdate(cashRegisters);
                        if (cashRegistersORM.status)
                        {
                            bool result = cashRegistersORM.Update(cashRegisters);
                            if (result)
                            {
                                MessageBox.Show("Kassa redaktə edildi !");
                                txtCashName.Text = "";
                                txtDescription.Text = "";
                                dgvCashRegisters.DataSource = cashRegistersORM.Select();
                            }
                        }
                        else
                            MessageBox.Show("Bu kassa adından artıq sistemdə var. Xahiş edirik başqa kassa adı yazın!");
                    }
                    else
                        MessageBox.Show("Xahiş edirik redaktə etmək istədiyiniz kassanı seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Kassa silinsin ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvCashRegisters.SelectedRows.Count == 1)
                    {
                        CashRegisters cashRegisters = new CashRegisters();
                        cashRegisters.Id = (int)dgvCashRegisters.CurrentRow.Cells["Id"].Value;
                        cashRegistersORM.Delete(cashRegisters);
                        dgvCashRegisters.DataSource = cashRegistersORM.Select();
                        txtCashName.Text = "";
                        txtDescription.Text = "";
                        MessageBox.Show("Kassa silindi !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik silmək istədiyiniz kassanı seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void dgvCashRegisters_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCashRegisters.ClearSelection();
        }
    }
}
