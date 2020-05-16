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
    public partial class AddCashRegisterUserControl : UserControl
    {
        public AddCashRegisterUserControl()
        {
            InitializeComponent();
        }

        CashRegistersORM cashRegistersORM = new CashRegistersORM();

        private void btnCashAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Kassa əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtCashRegisterName.Text != "")
                {
                    CashRegisters cashRegisters = new CashRegisters();
                    cashRegisters.Name = txtCashRegisterName.Text;
                    cashRegisters.Description = txtDescription.Text;

                    cashRegistersORM.SameAdd(cashRegisters);
                    if (cashRegistersORM.status == true)
                    {
                        bool result = cashRegistersORM.Insert(cashRegisters);

                        if (result)
                        {
                            MessageBox.Show("Kassa müvəffəqiyyətlə əlavə edildi !");
                        }
                        else
                            MessageBox.Show("Xəta !!!");
                    }
                    else
                        MessageBox.Show("Bu kassa adından artıq sistemdə var. Xahiş edirik başqa kassa adı yazın !");
                }
                else
                    MessageBox.Show("Xahiş edirik ulduzlanan xananı doldurun !");
            }
        }
    }
}
