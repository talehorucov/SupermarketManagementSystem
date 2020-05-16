namespace MarketWinFormUI
{
    partial class ReturnedProductsUserControl
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
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lvwReturns = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarcodeNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturnProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalMoney.Location = new System.Drawing.Point(1178, 267);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(15, 16);
            this.lblTotalMoney.TabIndex = 40;
            this.lblTotalMoney.Text = "0";
            // 
            // lvwReturns
            // 
            this.lvwReturns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.BarcodeNo,
            this.ProductsName,
            this.UnitPrice,
            this.Quantity,
            this.TotalPrice});
            this.lvwReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvwReturns.HideSelection = false;
            this.lvwReturns.Location = new System.Drawing.Point(20, 75);
            this.lvwReturns.Name = "lvwReturns";
            this.lvwReturns.Size = new System.Drawing.Size(1039, 579);
            this.lvwReturns.TabIndex = 38;
            this.lvwReturns.UseCompatibleStateImageBehavior = false;
            this.lvwReturns.View = System.Windows.Forms.View.Details;
            // 
            // Rank
            // 
            this.Rank.Text = "Sıra";
            this.Rank.Width = 91;
            // 
            // BarcodeNo
            // 
            this.BarcodeNo.Text = "Barkod No";
            this.BarcodeNo.Width = 170;
            // 
            // ProductsName
            // 
            this.ProductsName.Text = "Məhsulun adı";
            this.ProductsName.Width = 354;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Məhsulun qiyməti";
            this.UnitPrice.Width = 158;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Miqdar";
            this.Quantity.Width = 109;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Toplam məbləq";
            this.TotalPrice.Width = 152;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(1068, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(141, 1);
            this.panel6.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1065, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Toplam Məbləq:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(445, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 1);
            this.panel1.TabIndex = 28;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuantity.Location = new System.Drawing.Point(445, 38);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(202, 20);
            this.txtQuantity.TabIndex = 27;
            this.txtQuantity.Text = "Miqdar";
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(20, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 1);
            this.panel2.TabIndex = 26;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcode.Location = new System.Drawing.Point(20, 38);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(202, 20);
            this.txtBarcode.TabIndex = 25;
            this.txtBarcode.Text = "Barkod Nömrəsi";
            this.txtBarcode.Enter += new System.EventHandler(this.txtBarcode_Enter);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            this.txtBarcode.Leave += new System.EventHandler(this.txtBarcode_Leave);
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(1062, 75);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(147, 24);
            this.cmbSuppliers.TabIndex = 41;
            this.cmbSuppliers.Tag = "";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelOrder.Image = global::MarketWinFormUI.Properties.Resources.CancelOrder;
            this.btnCancelOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelOrder.Location = new System.Drawing.Point(1062, 588);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(147, 66);
            this.btnCancelOrder.TabIndex = 35;
            this.btnCancelOrder.Text = "İadəni ləğv et";
            this.btnCancelOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Image = global::MarketWinFormUI.Properties.Resources.AddToCart;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(920, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 58);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Səbətə əlavə et";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturnProducts
            // 
            this.btnReturnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturnProducts.Image = global::MarketWinFormUI.Properties.Resources.Return;
            this.btnReturnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturnProducts.Location = new System.Drawing.Point(1062, 516);
            this.btnReturnProducts.Name = "btnReturnProducts";
            this.btnReturnProducts.Size = new System.Drawing.Size(147, 66);
            this.btnReturnProducts.TabIndex = 36;
            this.btnReturnProducts.Text = "İadə et";
            this.btnReturnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnProducts.UseVisualStyleBackColor = true;
            this.btnReturnProducts.Click += new System.EventHandler(this.btnReturnProducts_Click);
            // 
            // ReturnedProductsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lvwReturns);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnReturnProducts);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBarcode);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ReturnedProductsUserControl";
            this.Size = new System.Drawing.Size(1218, 661);
            this.Load += new System.EventHandler(this.ReturnedProductsUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.ListView lvwReturns;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReturnProducts;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader BarcodeNo;
        private System.Windows.Forms.ColumnHeader ProductsName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader TotalPrice;
    }
}
