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
    public partial class CategoriesUserControl : UserControl
    {
        public CategoriesUserControl()
        {
            InitializeComponent();
        }
        CategoriesORM categoriesORM = new CategoriesORM();
        private void CategoriesUserControl_Load(object sender, EventArgs e)
        {
            dgvCategories.DataSource = categoriesORM.Select();
            dgvCategories.Columns["Id"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Kateqoriya silinsin ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvCategories.SelectedRows.Count == 1)
                    {
                        Categories categories = new Categories();
                        categories.Id = (int)dgvCategories.CurrentRow.Cells["Id"].Value;
                        categoriesORM.Delete(categories);
                        dgvCategories.DataSource = categoriesORM.Select();
                        txtCategoryName.Text = "";
                        MessageBox.Show("Kateqoriya silindi !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik silmək istədiyiniz kateqoriyanı seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryName.Text = dgvCategories.CurrentRow.Cells["Kateqoriya"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Kateqoriya redaktə edilsin ?", "Redaktə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvCategories.SelectedRows.Count == 1)
                    {
                        Categories categories = new Categories();
                        categories.Id = (int)dgvCategories.CurrentRow.Cells["Id"].Value;
                        categories.Name = txtCategoryName.Text;

                        categoriesORM.SameAdd(categories);
                        if (categoriesORM.status)
                        {
                            bool result = categoriesORM.Update(categories);
                            if (result)
                            {
                                txtCategoryName.Text = "";
                                dgvCategories.DataSource = categoriesORM.Select();
                                MessageBox.Show("Kateqoriya redakte edildi !");
                            }
                        }
                        else
                            MessageBox.Show("Bu kateqoriya adından artıq sistemdə var. Xahiş edirik başqa kateqoriya adı yazın!");
                    }
                    else
                        MessageBox.Show("Xahiş edirik redaktə etmək istədiyiniz kateqoriyanı seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void dgvCategories_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCategories.ClearSelection();
        }
    }
}
