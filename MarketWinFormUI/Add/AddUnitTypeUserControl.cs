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
    public partial class AddUnitTypeUserControl : UserControl
    {
        public AddUnitTypeUserControl()
        {
            InitializeComponent();
        }
        UnitTypesORM unitTypesORM = new UnitTypesORM(); 
        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Vahid növü əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtUnitName.Text != "")
                {
                    UnitTypes unitTypes = new UnitTypes();
                    unitTypes.Name = txtUnitName.Text;

                    unitTypesORM.SameAdd(unitTypes);
                    if (unitTypesORM.status == true)
                    {
                        bool result = unitTypesORM.Insert(unitTypes);
                        if (result)
                        {
                            txtUnitName.Text = "";
                            MessageBox.Show("Vahid Növü müvəffəqiyyətlə əlavə edildi !");
                        }
                        else
                            MessageBox.Show("Xəta !!!");
                    }
                    else
                        MessageBox.Show("Bu vahid növündən artıq sistemdə var. Xahiş edirik başqa vahid növü yazın!");
                }
                else
                    MessageBox.Show("Xahiş edirik ulduzlanan xananı doldurun!");
            }
        }
    }
}
