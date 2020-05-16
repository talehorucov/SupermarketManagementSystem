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
    public partial class AddCategoryUserControl : UserControl
    {
        public AddCategoryUserControl()
        {
            InitializeComponent();
        }
        CategoriesORM categoriesORM = new CategoriesORM();
        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Kateqoriya əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtCategoryName.Text != "")
                {
                    Categories categories = new Categories();
                    categories.Name = txtCategoryName.Text;

                    categoriesORM.SameAdd(categories);
                    if (categoriesORM.status == true)
                    {
                        bool result = categoriesORM.Insert(categories);

                        if (result)
                        {
                            MessageBox.Show("Kateqoriya müvəffəqiyyətlə əlavə edildi !");
                            txtCategoryName.Text = "";
                        }
                        else
                            MessageBox.Show("Xəta !!!");
                    }
                    else
                        MessageBox.Show("Bu kateqoriya adından artıq sistemdə var. Xahiş edirik başqa kateqoriya adı yazın!");
                }
                else
                    MessageBox.Show("Xahiş edirik ulduzlanan xananı doldurun !");
            }
        }
    }
}
