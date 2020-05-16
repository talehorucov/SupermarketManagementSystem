using System;
using System.Data;
using System.Windows.Forms;
using Market.ORM.Entity;
using Market.ORM.Facade;

namespace MarketWinFormUI
{
    public partial class SaleUserControl : UserControl
    {
        public SaleUserControl()
        {
            InitializeComponent();
        }
        ProductsORM productsORM = new ProductsORM();
        CashRegistersORM cashRegistersORM = new CashRegistersORM();

        decimal totalmoney;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal value = 0;
            try
            {
                Products products = new Products();
                products.BarcodeNo = txtBarcode.Text;
                DataTable table = productsORM.AddInCard(products, txtQuantity);

                if (table.Rows.Count != 0)
                {
                    btnCashPayment.Enabled = true;
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        DataRow dr = table.Rows[i];
                        listViewItem.Text = (lvwSales.Items.Count + 1).ToString();
                        listViewItem.SubItems.Add(dr["Barkod No"].ToString());
                        listViewItem.SubItems.Add(dr["Məhsulun adı"].ToString());
                        listViewItem.SubItems.Add(dr["Məhsulun qiyməti"].ToString());
                        listViewItem.SubItems.Add(txtQuantity.Text);
                        listViewItem.SubItems.Add(dr["Toplam məbləğ"].ToString());
                        listViewItem.Tag = dr["Id"];
                        value += Convert.ToDecimal(dr["Toplam məbləğ"]);
                        lvwSales.Items.Add(listViewItem);

                        totalmoney += value;
                        lblTotalMoney.Text = totalmoney.ToString();
                        txtBarcode.Text = "Barkod Nömrəsi";
                        txtQuantity.Text = "Miqdar";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xahiş edirik satmaq istədiyiniz məhsulu qeyd edin !");
            }
            
        }
        private void SaleUserControl_Load(object sender, EventArgs e)
        {
            cmbCashRegister.DataSource = cashRegistersORM.Select();
            cmbCashRegister.DisplayMember = "Kassa adı";
            cmbCashRegister.ValueMember = "Id";
            if (lvwSales.Items.Count == 0)
                btnCashPayment.Enabled = false;
        }

        private void btnCashPayment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Ödəniş təsdiq olunsun ?", "Ödəniş", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (txtRecievedMoney.Text != "")
                    {
                        if (txtChange.Text != "Qeyri-kafi məbləq" && Convert.ToDecimal(txtChange.Text) >= 0)
                        {
                            SalesORM salesORM = new SalesORM();
                            Sales sales = new Sales();
                            sales.EmployeeID = EmployeesORM.onlineUser.Id;
                            sales.CashRegisterID = (int)cmbCashRegister.SelectedValue;
                            sales.SaleDate = DateTime.Now;

                            int saleid = Convert.ToInt32(salesORM.InsertScalar(sales));
                            if (saleid > 0)
                            {
                                SaleDetailsORM saleDetailsORM = new SaleDetailsORM();
                                foreach (ListViewItem item in lvwSales.Items)
                                {
                                    SaleDetails saleDetails = new SaleDetails();
                                    saleDetails.SaleID = saleid;
                                    saleDetails.ProductID = (int)item.Tag;
                                    saleDetails.Quantity = Convert.ToDouble(item.SubItems[3].Text);
                                    saleDetails.UnitPrice = Convert.ToDecimal(item.SubItems[4].Text);
                                    saleDetails.TotalPrice = Convert.ToDecimal(item.SubItems[5].Text);

                                    saleDetailsORM.InsertScalar(saleDetails);
                                }
                                btnCashPayment.Enabled = false;
                                MessageBox.Show("Məhsullar satıldı !");

                                lvwSales.Items.Clear();
                                txtBarcode.Text = "Barkod Nömrəsi";
                                txtQuantity.Text = "Miqdar";
                                txtChange.Text = "";
                                txtRecievedMoney.Text = "";
                                lblTotalMoney.Text = "0";

                            }
                            else
                                MessageBox.Show("Xəta !!!");
                        }
                        else
                            MessageBox.Show("Kifayət qədər məbləq daxil edilməyib !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik ödəniləcək məbləği yazın !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }

        }

        private void txtRecievedMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtRecievedMoney.Text == "")
                {
                    txtChange.Text = "Məbləği qeyd edin";
                }
                else if (lvwSales.Items.Count == 0)
                {
                    txtRecievedMoney.Text = "";
                    MessageBox.Show("Satılacaq məhsulu seçin !");
                }
                else if (Convert.ToDecimal(txtRecievedMoney.Text) >= Convert.ToDecimal(lblTotalMoney.Text))
                {
                    txtChange.Text = (Convert.ToDecimal(txtRecievedMoney.Text) - Convert.ToDecimal(lblTotalMoney.Text)).ToString();
                }
                else
                {
                    txtChange.Text = "Qeyri-kafi məbləq";
                }
            }
            catch (Exception)
            {
                txtRecievedMoney.Text = "";
                MessageBox.Show("Xahiş edirik rəqəm yazın !");
            }
        }

        #region TxtEnterName
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
        #endregion

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Satış ləğv olunsun ?", "Ləğv et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                btnCashPayment.Enabled = false;
                if (lvwSales.Items.Count > 0)
                {
                    lvwSales.Items.Clear();
                    txtBarcode.Text = "Barkod Nömrəsi";
                    txtQuantity.Text = "Miqdar";
                    txtChange.Text = "";
                    txtRecievedMoney.Text = "";
                    lblTotalMoney.Text = "0";
                    totalmoney = 0;
                    MessageBox.Show("Satış əməliyyatı ləğv edildi !");
                }
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
