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
    public partial class AddSuppliersUserControl : UserControl
    {
        public AddSuppliersUserControl()
        {
            InitializeComponent();
        }
        SuppliersORM suppliersORM = new SuppliersORM();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Təchizatçı əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtFirstname.Text != "" || txtLastname.Text != "" || txtCompanyName.Text != "")
                {
                    Suppliers suppliers = new Suppliers();
                    suppliers.Firstname = txtFirstname.Text;
                    suppliers.Lastname = txtLastname.Text;
                    suppliers.CompanyName = txtCompanyName.Text;
                    suppliers.PhoneNo = mskdPhoneNo.Text;
                    suppliers.Mail = txtMail.Text;
                    suppliers.Adress = txtAdress.Text;

                    bool result = suppliersORM.Insert(suppliers);
                    if (result)
                    {
                        MessageBox.Show("Təchizatçı müvəffəqiyyətlə əlavə edildi !");
                        foreach (Control item in Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }
                            mskdPhoneNo.Text = "";
                        }
                    }
                    else
                        MessageBox.Show("Xəta !!!");
                }
                else
                    MessageBox.Show("Xahiş edirik ulduzlanan xanaları doldurun!");
            }
        }
    }
}
