using System;
using System.Windows.Forms;
using Market.ORM.Facade;
using Market.ORM.Entity;

namespace MarketWinFormUI
{
    public partial class ProductsUserControl : UserControl
    {
        public ProductsUserControl()
        {
            InitializeComponent();
        }
        ProductsORM productsORM = new ProductsORM();
        CategoriesORM categoriesORM = new CategoriesORM();
        UnitTypesORM unitTypesORM = new UnitTypesORM();
        private void ProductsUserControl_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = productsORM.Select();
            dgvProducts.Columns["Id"].Visible = false;
            cmbCategories.DataSource = categoriesORM.Select();
            cmbCategories.DisplayMember = "Kateqoriya";
            cmbCategories.ValueMember = "Id";

            cmbUnitType.DataSource = unitTypesORM.Select();
            cmbUnitType.DisplayMember = "Vahid Növü";
            cmbUnitType.ValueMember = "Id";
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcodeNo.Text = dgvProducts.CurrentRow.Cells["Barkod No"].Value.ToString();
            txtProductName.Text = dgvProducts.CurrentRow.Cells["Məhsulun adı"].Value.ToString();
            nudPrice.Value = Convert.ToDecimal(dgvProducts.CurrentRow.Cells["Məhsulun qiyməti"].Value.ToString());
            nudStock.Value = Convert.ToDecimal(dgvProducts.CurrentRow.Cells["Anbardakı miqdar"].Value);
            cmbCategories.Text = dgvProducts.CurrentRow.Cells["Kateqoriya"].Value.ToString();
            cmbUnitType.Text = dgvProducts.CurrentRow.Cells["Vahid Növü"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Məhsul redaktə edilsin ?", "Redaktə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvProducts.SelectedRows.Count == 1)
                    {
                        Products products = new Products();
                        products.Id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
                        products.BarcodeNo = txtBarcodeNo.Text;
                        products.ProductName = txtProductName.Text;
                        products.UnitPrice = Convert.ToDecimal(nudPrice.Value);
                        products.Stock = Convert.ToDouble(nudStock.Value);
                        products.CategoryID = (int)cmbCategories.SelectedValue;
                        products.UnitTypeID = (int)cmbUnitType.SelectedValue;

                        productsORM.SameUpdate(products);
                        if (productsORM.status)
                        {
                            bool result = productsORM.Update(products);
                            if (result)
                            {
                                dgvProducts.DataSource = productsORM.Select();
                                foreach (Control item in Controls)
                                {
                                    if (item is TextBox)
                                        item.Text = "";
                                    nudStock.Value = 0;
                                }
                                MessageBox.Show("Məhsul redaktə edildi !");
                            }
                        }
                        else
                            MessageBox.Show("Bu barkod nömrəsi artıq sistemdə var. Xahiş edirik başqa barkod nömrəsi yazın!");
                    }
                    else
                        MessageBox.Show("Xahiş edirik redaktə etmək istədiyiniz məhsulu seçin !");
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
            dialogResult = MessageBox.Show("Məhsul silinlsin ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvProducts.SelectedRows.Count == 1)
                    {
                        Products products = new Products();
                        products.Id = (int)dgvProducts.CurrentRow.Cells["Id"].Value;
                        productsORM.Delete(products);
                        dgvProducts.DataSource = productsORM.Select();

                        foreach (Control item in Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                            nudStock.Value = 0;
                        }
                        MessageBox.Show("Məhsul silindi !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik silmək istədiyiniz məhsulu seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ProductName = txtSearch.Text;
            dgvProducts.DataSource = productsORM.Search(products);
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }
    }
}
