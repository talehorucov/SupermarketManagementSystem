using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketWinFormUI
{
    public partial class AddMenuUserControl : UserControl
    {
        public AddMenuUserControl()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            btnCategory.BackColor = Color.DarkRed;
            ChangeButtonColor(new Button[] { btnProduct, btnAuthority, btnCashRegister, btnEmployee, btnSupplier, btnUnitType });
            pnlMid.Controls.Clear();
            pnlMid.Controls.Add(new AddCategoryUserControl());
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {
            btnAuthority.BackColor = Color.DarkRed;
            ChangeButtonColor(new Button[] { btnCategory, btnProduct, btnCashRegister, btnEmployee, btnSupplier, btnUnitType });
            pnlMid.Controls.Clear();
            pnlMid.Controls.Add(new AddAuthorityUserControl());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            btnProduct.BackColor = Color.DarkRed;
            ChangeButtonColor(new Button[] { btnCategory, btnAuthority, btnCashRegister, btnEmployee, btnSupplier, btnUnitType });
            pnlMid.Controls.Clear();
            pnlMid.Controls.Add(new AddProductsUserControl());
        }

        private void btnUnitType_Click(object sender, EventArgs e)
        {
            btnUnitType.BackColor = Color.DarkRed;
            ChangeButtonColor(new Button[] { btnCategory, btnAuthority, btnCashRegister, btnEmployee, btnSupplier, btnProduct });
            pnlMid.Controls.Clear();
            pnlMid.Controls.Add(new AddUnitTypeUserControl());
        }

        private void btnCashRegister_Click(object sender, EventArgs e)
        {
            btnCashRegister.BackColor = Color.DarkRed;
            ChangeButtonColor(new Button[] { btnCategory, btnAuthority, btnProduct, btnEmployee, btnSupplier, btnUnitType });
            pnlMid.Controls.Clear();
            pnlMid.Controls.Add(new AddCashRegisterUserControl());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            btnEmployee.BackColor = Color.DarkRed;
            ChangeButtonColor(new Button[] { btnCategory, btnAuthority, btnCashRegister, btnProduct, btnSupplier, btnUnitType });
            pnlMid.Controls.Clear();
            pnlMid.Controls.Add(new AddEmployeeUserControl());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            btnSupplier.BackColor = Color.DarkRed;
            ChangeButtonColor(new Button[] { btnCategory, btnAuthority, btnCashRegister, btnEmployee, btnProduct, btnUnitType });
            pnlMid.Controls.Clear();
            pnlMid.Controls.Add(new AddSuppliersUserControl());
        }
        private void ChangeButtonColor(params Button[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                b[i].BackColor = Color.FromArgb(178, 8, 55);
            }
        }
    }
}
