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
    public partial class StatisticsUserControl : UserControl
    {
        public StatisticsUserControl()
        {
            InitializeComponent();
        }
        ProductsORM productsORM = new ProductsORM();
        EmployeesORM employeesORM = new EmployeesORM();
        SaleDetailsORM saleDetailsORM = new SaleDetailsORM();
        private void StatisticsUserControl_Load(object sender, EventArgs e)
        {
            lblProductNumber.Text = productsORM.ProductNumber();
            if (lblProductNumber.Text == "")
                lblProductNumber.Text = "0";
            lblEmployeeNumber.Text = employeesORM.EmployeesNumber();
            if (lblEmployeeNumber.Text == "")
                lblEmployeeNumber.Text = "0";
            lblStokNumber.Text = productsORM.TotalStockNumber();
            if (lblStokNumber.Text == "")
                lblStokNumber.Text = "0";
            lblExpensive.Text = productsORM.ExpensiveProduct();
            if (lblExpensive.Text == "")
                lblExpensive.Text = "Məhsul yoxdur";
            lblCheap.Text = productsORM.CheapProduct();
            if (lblCheap.Text == "")
                lblCheap.Text = "Məhsul yoxdur";
            lblBestSeller.Text = productsORM.BestSeller();
            if (lblBestSeller.Text == "")
                lblBestSeller.Text = "Məhsul yoxdur";
            lblLowOnStock.Text = productsORM.LowOnStock();
            if (lblLowOnStock.Text == "")
                lblLowOnStock.Text = "Məhsul yoxdur";
            lblTodaySales.Text = saleDetailsORM.TodaySales();
            if (lblTodaySales.Text == "")
                lblTodaySales.Text = "0";
            lblTodayEarn.Text = saleDetailsORM.TodayEarn();
            if (lblTodayEarn.Text == "")
                lblTodayEarn.Text = "0";
        }
    }
}
