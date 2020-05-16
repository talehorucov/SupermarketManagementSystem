using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.ORM.Entity;
using Market.ORM.Facade;

namespace MarketWinFormUI
{
    public partial class ReturnedProductsUserControl : UserControl
    {
        public ReturnedProductsUserControl()
        {
            InitializeComponent();
        }
        ProductsORM productsORM = new ProductsORM();

        decimal totalmoney;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal value = 0;
            try
            {
                Products products = new Products();
                products.BarcodeNo = txtBarcode.Text;
                DataTable table = productsORM.AddInCard(products, txtQuantity);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    DataRow dr = table.Rows[i];
                    listViewItem.Text = (lvwReturns.Items.Count + 1).ToString();
                    listViewItem.SubItems.Add(dr["Barkod No"].ToString());
                    listViewItem.SubItems.Add(dr["Məhsulun adı"].ToString());
                    listViewItem.SubItems.Add(dr["Məhsulun qiyməti"].ToString());
                    listViewItem.SubItems.Add(txtQuantity.Text);
                    listViewItem.SubItems.Add(dr["Toplam məbləğ"].ToString());
                    listViewItem.Tag = dr["Id"];
                    value += Convert.ToDecimal(dr["Toplam məbləğ"]);
                    lvwReturns.Items.Add(listViewItem);
                    totalmoney += value;
                    lblTotalMoney.Text = totalmoney.ToString();
                    txtBarcode.Text = "Barkod Nömrəsi";
                    txtQuantity.Text = "Miqdar";
                }
                btnReturnProducts.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Xahiş edirik iadə etmək istədiyiniz məhsulu qeyd edin !");
            }
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "Barkod Nömrəsi")
                txtBarcode.Text = "";
        }

        private void txtBarcode_Leave(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "")
                txtBarcode.Text = "Barkod Nömrəsi";
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "Miqdar")
                txtQuantity.Text = "";
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
                txtQuantity.Text = "Miqdar";
        }

        private void btnReturnProducts_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Məhsul iadə edilsin ?", "İadə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (lvwReturns.Items.Count > 0)
                    {
                        ReturnedProductsORM returnedProductsORM = new ReturnedProductsORM();
                        ReturnedProducts returnedProducts = new ReturnedProducts();
                        returnedProducts.EmployeeID = EmployeesORM.onlineUser.Id;
                        returnedProducts.ReturnDate = DateTime.Now;
                        returnedProducts.SupplierID = (int)cmbSuppliers.SelectedValue;

                        int returnid = Convert.ToInt32(returnedProductsORM.InsertScalar(returnedProducts));
                        if (returnid > 0)
                        {
                            ReturnDetailsORM returnDetailsORM = new ReturnDetailsORM();
                            foreach (ListViewItem item in lvwReturns.Items)
                            {
                                ReturnDetails returnDetails = new ReturnDetails();
                                returnDetails.ReturnID = returnid;
                                returnDetails.ProductID = (int)item.Tag;
                                returnDetails.Quantity = Convert.ToDouble(item.SubItems[3].Text);
                                returnDetails.UnitPrice = Convert.ToDecimal(item.SubItems[4].Text);
                                returnDetails.TotalPrice = Convert.ToDecimal(item.SubItems[5].Text);

                                returnDetailsORM.InsertScalar(returnDetails);
                            }
                            MessageBox.Show("Məhsullar iadə edildi");
                            btnReturnProducts.Enabled = true;
                            lvwReturns.Items.Clear();
                            txtBarcode.Text = "Barkod Nömrəsi";
                            txtQuantity.Text = "Miqdar";
                            lblTotalMoney.Text = "0";

                            btnReturnProducts.Enabled = false;
                        }
                        else
                            MessageBox.Show("Xəta !!!");
                    }
                    else
                        MessageBox.Show("Xahiş edirik iadə etmək istədiyiniz məhsulları qeyd edin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void ReturnedProductsUserControl_Load(object sender, EventArgs e)
        {
            SuppliersORM suppliersORM = new SuppliersORM();
            cmbSuppliers.DataSource = suppliersORM.Select();
            cmbSuppliers.DisplayMember = "Ad";
            cmbSuppliers.ValueMember = "Id";
            btnReturnProducts.Enabled = false;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("İadə ləğv edilsin ?", "Ləğv et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                lvwReturns.Items.Clear();
                txtBarcode.Text = "Barkod Nömrəsi";
                txtQuantity.Text = "Miqdar";
                lblTotalMoney.Text = "0";
                totalmoney = 0;
                MessageBox.Show("İadə ləğv edildi !");
                btnReturnProducts.Enabled = false;
            }
        }
    }
}
