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
    public partial class UnitTypeUserControl : UserControl
    {
        public UnitTypeUserControl()
        {
            InitializeComponent();
        }
        UnitTypesORM unitTypesORM = new UnitTypesORM();
        private void UnitTypeUserControl_Load(object sender, EventArgs e)
        {
            dgvUnitTypes.DataSource = unitTypesORM.Select();
            dgvUnitTypes.Columns["Id"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Vahid Növü redaktə edilsin ?", "Redaktə et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvUnitTypes.SelectedRows.Count == 1)
                    {
                        UnitTypes unitTypes = new UnitTypes();
                        unitTypes.Id = (int)dgvUnitTypes.CurrentRow.Cells["Id"].Value;
                        unitTypes.Name = txtUnitName.Text;

                        unitTypesORM.SameAdd(unitTypes);
                        if (unitTypesORM.status)
                        {
                            bool result = unitTypesORM.Update(unitTypes);
                            if (result)
                            {
                                txtUnitName.Text = "";
                                dgvUnitTypes.DataSource = unitTypesORM.Select();
                                MessageBox.Show("Vahid Növü redaktə edildi !");
                            }
                        }
                        else
                            MessageBox.Show("Bu vahid növü artıq sistemdə var. Xahiş edirik başqa vahid növü yazın!");
                    }
                    else
                        MessageBox.Show("Xahiş edirik redaktə etmək istədiyiniz vahid növünü seçin !");

                }
                catch (Exception)
                {

                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Vahid Növü silinsin ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvUnitTypes.SelectedRows.Count == 1)
                    {
                        UnitTypes unitTypes = new UnitTypes();
                        unitTypes.Id = (int)dgvUnitTypes.CurrentRow.Cells["Id"].Value;
                        unitTypesORM.Delete(unitTypes);
                        dgvUnitTypes.DataSource = unitTypesORM.Select();
                        txtUnitName.Text = "";
                        MessageBox.Show("Vahid Növü silindi !");
                    }
                    else
                        MessageBox.Show("Xahiş edirik silmək istədiyiniz vahid növünü seçin !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xəta !!!");
                }
            }
        }

        private void dgvUnitTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUnitName.Text = dgvUnitTypes.CurrentRow.Cells["Vahid Növü"].Value.ToString();
        }

        private void dgvUnitTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUnitTypes.ClearSelection();
        }
    }
}
