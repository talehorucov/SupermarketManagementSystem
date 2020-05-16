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
    public partial class AuthorityUserControl : UserControl
    {
        public AuthorityUserControl()
        {
            InitializeComponent();
        }
        AuthorityORM authorityORM = new AuthorityORM();
        private void AuthorityUserControl_Load(object sender, EventArgs e)
        {
            dgvAuthority.DataSource = authorityORM.Select();
            dgvAuthority.Columns["Id"].Visible = false;
        }

        private void dgvAuthority_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtJobName.Text = dgvAuthority.CurrentRow.Cells["Vəzifə"].Value.ToString();
            txtDescription.Text = dgvAuthority.CurrentRow.Cells["Açıqlama"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Vəzifə redaktə edilsin ?", "Redaktə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvAuthority.SelectedRows.Count == 1)
                    {
                        Authority authority = new Authority();
                        authority.Id = (int)dgvAuthority.CurrentRow.Cells["Id"].Value;
                        authority.Job = txtJobName.Text;
                        authority.Description = txtDescription.Text;

                        authorityORM.SameUpdate(authority);
                        if (authorityORM.status)
                        {
                            bool result = authorityORM.Update(authority);
                            if (result)
                            {
                                txtDescription.Text = "";
                                txtJobName.Text = "";
                                dgvAuthority.DataSource = authorityORM.Select();
                                MessageBox.Show("Vəzifə redaktə edildi !");
                            }
                        }
                        else
                            MessageBox.Show("Bu vəzifədən artıq sistemdə var. Xahiş edirik başqa bir vəzifə yazın!");
                    }
                    else
                        MessageBox.Show("Xahiş edirik redaktə etmək istədiyiniz vəzifəni seçin !");
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
            dialogResult = MessageBox.Show("Vəzifə silinsin ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvAuthority.SelectedRows.Count == 1)
                    {
                        Authority authority = new Authority();
                        authority.Id = (int)dgvAuthority.CurrentRow.Cells["Id"].Value;
                        authorityORM.Delete(authority);
                        dgvAuthority.DataSource = authorityORM.Select();
                        txtDescription.Text = "";
                        txtJobName.Text = "";
                        MessageBox.Show("Vəzifə silindi !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik silmək istədiyiniz vəzifəni seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Authority authority = new Authority();
            authority.Job = txtSearch.Text;
            dgvAuthority.DataSource = authorityORM.Search(authority);
        }

        private void dgvAuthority_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAuthority.ClearSelection();
        }
    }
}
