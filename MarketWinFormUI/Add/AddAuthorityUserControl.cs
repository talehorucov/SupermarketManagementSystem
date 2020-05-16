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
    public partial class AddAuthorityUserControl : UserControl
    {
        public AddAuthorityUserControl()
        {
            InitializeComponent();
        }
        AuthorityORM authorityORM = new AuthorityORM();
        private void btnJobAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Vəzifə əlavə edilsin ?", "Əlavə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtDescription.Text != "")
                {
                    Authority authority = new Authority();
                    authority.Job = txtJobName.Text;
                    authority.Description = txtDescription.Text;

                    authorityORM.SameAdd(authority);
                    if (authorityORM.status == true)
                    {
                        bool result = authorityORM.Insert(authority);

                        if (result)
                        {
                            MessageBox.Show("Vəzifə müvəffəqiyyətlə əlavə edildi !");
                            txtDescription.Text = "";
                            txtJobName.Text = "";
                        }
                        else
                            MessageBox.Show("Xəta !!!");
                    }
                    else
                        MessageBox.Show("Bu vəzifədən artıq sistemdə var. Xahiş edirik başqa vəzifə yazın !");
                }
                else
                    MessageBox.Show("Xahiş edirik ulduzlanan xananı doldurun !");
            }
        }
    }
}
