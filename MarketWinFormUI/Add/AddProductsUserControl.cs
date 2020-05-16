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
    public partial class AddProductsUserControl : UserControl
    {
        public AddProductsUserControl()
        {
            InitializeComponent();
        }
        ProductsORM productsORM = new ProductsORM();
        private void AddProductsUserControl_Load(object sender, EventArgs e)
        {
            CategoriesORM categoriesORM = new CategoriesORM();
            cmbCategories.DataSource = categoriesORM.Select();
            cmbCategories.DisplayMember = "Kateqoriya";
            cmbCategories.ValueMember = "Id";

            UnitTypesORM unitTypesORM = new UnitTypesORM();
            cmbUnitType.DataSource = unitTypesORM.Select();
            cmbUnitType.DisplayMember = "Vahid Növü";
            cmbUnitType.ValueMember = "Id";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Məhsul əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if ((txtBarcodeNo.Text != "" || txtProductName.Text != "") && nudPrice.Value != 0)
                {
                    Products products = new Products();
                    products.BarcodeNo = txtBarcodeNo.Text;
                    products.ProductName = txtProductName.Text;
                    products.Stock = Convert.ToDouble(nudStock.Value);
                    products.UnitPrice = nudPrice.Value;
                    products.UnitTypeID = (int)cmbUnitType.SelectedValue;
                    products.CategoryID = (int)cmbCategories.SelectedValue;

                    productsORM.SameAdd(products);
                    if (productsORM.status == true)
                    {
                        bool result = productsORM.Insert(products);
                        if (result)
                        {
                            MessageBox.Show("Məhsul müvəffəqiyyətlə əlavə edildi !");
                            foreach (Control item in Controls)
                            {
                                if (item is TextBox)
                                {
                                    item.Text = "";
                                }
                                nudPrice.Text = "0,00";
                                nudStock.Text = "0";
                            }
                        }
                        else
                            MessageBox.Show("Xəta !!!");
                }
                else
                    MessageBox.Show("Bu barkod nömrəsindən artıq sistemdə var. Xahiş edirik başqa barkod nömrəsi yazın !");
            }
                else if(nudPrice.Value == 0)
                    MessageBox.Show("Xahiş edirik məhsulun qiyətini qeyd edin !");
                else
                    MessageBox.Show("Xahiş edirik ulduzlanan xanaları doldurun !");
            }
        }
    }
}
