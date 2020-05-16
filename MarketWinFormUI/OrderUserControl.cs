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
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
        }
        ProductsORM productsORM = new ProductsORM();
        SuppliersORM suppliersORM = new SuppliersORM();

        private void OrderUserControl1_Load(object sender, EventArgs e)
        {

            cmbProduct.DataSource = productsORM.Select();
            cmbProduct.DisplayMember = "Məhsulun adı";
            cmbProduct.ValueMember = "Id";

            cmbSupplier.DataSource = suppliersORM.Select();
            cmbSupplier.DisplayMember = "Ad";
            cmbSupplier.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Məhsul səbətə əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtQuantity.Text != "0" && txtQuantity.Text != "")
                {
                    OrdersORM ordersORM = new OrdersORM();
                    Products products = new Products();
                    products.Id = (int)cmbProduct.SelectedValue;
                    DataTable table = ordersORM.AddInCard(products, txtQuantity);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        DataRow dr = table.Rows[i];
                        listViewItem.Text = (lvwOrder.Items.Count + 1).ToString();
                        listViewItem.SubItems.Add(dr["Məhsulun adı"].ToString());
                        listViewItem.SubItems.Add(txtQuantity.Text);
                        listViewItem.SubItems.Add(dr["Məhsulun qiyməti"].ToString());
                        listViewItem.SubItems.Add(dr["Toplam məbləğ"].ToString());
                        listViewItem.Tag = dr["Id"];
                        lvwOrder.Items.Add(listViewItem);
                    }
                    txtQuantity.Text = "";
                }
                else
                    MessageBox.Show("Xahiş edirik 0-dan yuxarı ədəd daxil edin !");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Məhsul anbara əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (lvwOrder.Items.Count > 0)
                    {
                        OrdersORM ordersORM = new OrdersORM();
                        Orders orders = new Orders();
                        orders.EmployeeID = EmployeesORM.onlineUser.Id;
                        orders.SupplierID = (int)cmbSupplier.SelectedValue;
                        orders.Date = DateTime.Now;

                        int orderid = Convert.ToInt32(ordersORM.InsertScalar(orders));
                        if (orderid > 0)
                        {
                            OrderDetailsORM orderDetailsORM = new OrderDetailsORM();
                            foreach (ListViewItem item in lvwOrder.Items)
                            {
                                OrderDetails orderDetails = new OrderDetails();
                                orderDetails.OrderID = orderid;
                                orderDetails.ProductID = (int)item.Tag;
                                orderDetails.Quantity = Convert.ToDouble(item.SubItems[2].Text);
                                orderDetails.UnitPrice = Convert.ToDecimal(item.SubItems[3].Text);
                                orderDetails.TotalPrice = Convert.ToDecimal(item.SubItems[4].Text);

                                orderDetailsORM.InsertScalar(orderDetails);
                            }
                            MessageBox.Show("Məhsul anbara əlavə edildi !");

                            lvwOrder.Items.Clear();
                            txtQuantity.Text = "";
                        }
                        else
                            MessageBox.Show("Xəta !!!");
                    }
                    else
                        MessageBox.Show("Xahiş edirik sifariş etmək istədiyiniz məhsulları qeyd edin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Xahiş edirik rəqəm yazın");
                e.Handled = true;
            }
        }
    }
}
