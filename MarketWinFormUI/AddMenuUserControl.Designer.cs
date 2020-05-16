namespace MarketWinFormUI
{
    partial class AddMenuUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMid = new System.Windows.Forms.Panel();
            this.btnCashRegister = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnUnitType = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnAuthority = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMid.Location = new System.Drawing.Point(0, 162);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(1226, 512);
            this.pnlMid.TabIndex = 1;
            // 
            // btnCashRegister
            // 
            this.btnCashRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCashRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCashRegister.ForeColor = System.Drawing.Color.White;
            this.btnCashRegister.Image = global::MarketWinFormUI.Properties.Resources.FrmAddCash;
            this.btnCashRegister.Location = new System.Drawing.Point(1052, 10);
            this.btnCashRegister.Name = "btnCashRegister";
            this.btnCashRegister.Size = new System.Drawing.Size(159, 139);
            this.btnCashRegister.TabIndex = 7;
            this.btnCashRegister.Text = "Kassa";
            this.btnCashRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCashRegister.UseVisualStyleBackColor = false;
            this.btnCashRegister.Click += new System.EventHandler(this.btnCashRegister_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = global::MarketWinFormUI.Properties.Resources.FrmAddSupplier;
            this.btnSupplier.Location = new System.Drawing.Point(879, 10);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(159, 139);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "Təchizatçı";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::MarketWinFormUI.Properties.Resources.FrmAddEmployee;
            this.btnEmployee.Location = new System.Drawing.Point(533, 10);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(159, 139);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "İşçi";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnUnitType
            // 
            this.btnUnitType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnUnitType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitType.FlatAppearance.BorderSize = 0;
            this.btnUnitType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitType.ForeColor = System.Drawing.Color.White;
            this.btnUnitType.Image = global::MarketWinFormUI.Properties.Resources.FrmAddUnitType;
            this.btnUnitType.Location = new System.Drawing.Point(360, 10);
            this.btnUnitType.Name = "btnUnitType";
            this.btnUnitType.Size = new System.Drawing.Size(159, 139);
            this.btnUnitType.TabIndex = 6;
            this.btnUnitType.Text = "Vahid növü";
            this.btnUnitType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnitType.UseVisualStyleBackColor = false;
            this.btnUnitType.Click += new System.EventHandler(this.btnUnitType_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::MarketWinFormUI.Properties.Resources.FrmAddCategory;
            this.btnCategory.Location = new System.Drawing.Point(187, 10);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(159, 139);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Kateqoriya";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnAuthority
            // 
            this.btnAuthority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAuthority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthority.FlatAppearance.BorderSize = 0;
            this.btnAuthority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthority.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAuthority.ForeColor = System.Drawing.Color.White;
            this.btnAuthority.Image = global::MarketWinFormUI.Properties.Resources.FrmAddTitle;
            this.btnAuthority.Location = new System.Drawing.Point(706, 10);
            this.btnAuthority.Name = "btnAuthority";
            this.btnAuthority.Size = new System.Drawing.Size(159, 139);
            this.btnAuthority.TabIndex = 4;
            this.btnAuthority.Text = "Vəzifə";
            this.btnAuthority.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAuthority.UseVisualStyleBackColor = false;
            this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::MarketWinFormUI.Properties.Resources.FrmAddProduct;
            this.btnProduct.Location = new System.Drawing.Point(14, 10);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(159, 139);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Məhsul";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // AddMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnCashRegister);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnUnitType);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnAuthority);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.pnlMid);
            this.Name = "AddMenuUserControl";
            this.Size = new System.Drawing.Size(1226, 674);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnAuthority;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnUnitType;
        private System.Windows.Forms.Button btnCashRegister;
    }
}
