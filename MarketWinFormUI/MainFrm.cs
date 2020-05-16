using Market.ORM.Entity;
using Market.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketWinFormUI
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            btnX.Left += 473;
            btnMinimize.Left += 475;
            lblFirstname.Text = EmployeesORM.onlineUser.Firstname;
            lblLastname.Text = EmployeesORM.onlineUser.Lastname;
            lblFirstname.Left = pnlTop.Left - 122;
            lblLastname.Left = lblFirstname.Right + 5;
            pnlTop.Controls.Add(lblFirstname);
            pnlTop.Controls.Add(lblLastname);
            lblCopyRight.Left = pnlBottom.Left + 300;
            pnlBottom.Controls.Add(lblCopyRight);
            if (EmployeesORM.onlineUser.AuthorityID == 1 || EmployeesORM.onlineUser.AuthorityID == 2)
                pnlMiddle.Controls.Add(new SaleUserControl());
            else
                pnlMiddle.Controls.Clear();

            BtnStatistics();
        }
        #region btnStatistics
        private void BtnStatistics()
        {
            Button btn = new Button()
            {
                Text = "   Statistika",
                Name = "btnStatistics",
                Width = 130,
                Height = 46,
                Font = new Font("Microsoft Sans Serif", 9),
                BackColor = Color.FromArgb(41, 39, 40),
                ForeColor = Color.White,
                Image = imageList1.Images[0],
                ImageAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            pnlLeft.Controls.Add(btn);
            btn.Location = new Point(12, 506);

            btn.Click += btnStatistics_Click;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            pnlSlide.Height = 46;
            pnlSlide.Top = 506;
            pnlMiddle.Controls.Clear();
            pnlMiddle.Controls.Add(new StatisticsUserControl());
        }
        #endregion
        private void btnSale_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1 || EmployeesORM.onlineUser.AuthorityID == 2)
            {
                pnlSlide.Height = btnSale.Height;
                pnlSlide.Top = btnSale.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new SaleUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1)
            {
                pnlSlide.Height = btnAdd.Height;
                pnlSlide.Top = btnAdd.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new AddMenuUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1)
            {
                pnlSlide.Height = btnProduct.Height;
                pnlSlide.Top = btnProduct.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new ProductsUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1)
            {
                pnlSlide.Height = btnEmployee.Height;
                pnlSlide.Top = btnEmployee.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new EmployeeUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1)
            {
                pnlSlide.Height = btnSupplier.Height;
                pnlSlide.Top = btnSupplier.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new SuppliersUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1)
            {
                pnlSlide.Height = btnAuthority.Height;
                pnlSlide.Top = btnAuthority.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new AuthorityUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1)
            {
                pnlSlide.Height = btnCategory.Height;
                pnlSlide.Top = btnCategory.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new CategoriesUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnCashRegister_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1)
            {
                pnlSlide.Height = btnCashRegister.Height;
                pnlSlide.Top = btnCashRegister.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new CashRegisterUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnUnitType_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1)
            {
                pnlSlide.Height = btnUnitType.Height;
                pnlSlide.Top = btnUnitType.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new UnitTypeUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1 || EmployeesORM.onlineUser.AuthorityID == 3)
            {
                pnlSlide.Height = btnReturn.Height;
                pnlSlide.Top = btnReturn.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new ReturnedProductsUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (EmployeesORM.onlineUser.AuthorityID == 1 || EmployeesORM.onlineUser.AuthorityID == 3)
            {
                pnlSlide.Height = btnOrder.Height;
                pnlSlide.Top = btnOrder.Top;
                pnlMiddle.Controls.Clear();
                pnlMiddle.Controls.Add(new OrderUserControl());
            }
            else
            {
                MessageBox.Show("Bu səhifəyə keçid eliyə bilməzsiniz !");
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
