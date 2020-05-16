namespace MarketWinFormUI
{
    partial class SaleUserControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRecievedMoney = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnCashPayment = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvwSales = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarcodeNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCashRegister = new System.Windows.Forms.ComboBox();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(20, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 1);
            this.panel2.TabIndex = 5;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcode.Location = new System.Drawing.Point(20, 38);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(202, 20);
            this.txtBarcode.TabIndex = 4;
            this.txtBarcode.Text = "Barkod Nömrəsi";
            this.txtBarcode.Enter += new System.EventHandler(this.txtBarcode_Enter);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            this.txtBarcode.Leave += new System.EventHandler(this.txtBarcode_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(445, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 1);
            this.panel1.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuantity.Location = new System.Drawing.Point(445, 38);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(202, 20);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.Text = "Miqdar";
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Location = new System.Drawing.Point(1068, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 1);
            this.panel4.TabIndex = 12;
            // 
            // txtRecievedMoney
            // 
            this.txtRecievedMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRecievedMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecievedMoney.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRecievedMoney.Location = new System.Drawing.Point(1123, 323);
            this.txtRecievedMoney.Name = "txtRecievedMoney";
            this.txtRecievedMoney.Size = new System.Drawing.Size(86, 16);
            this.txtRecievedMoney.TabIndex = 11;
            this.txtRecievedMoney.TextChanged += new System.EventHandler(this.txtRecievedMoney_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel5.Location = new System.Drawing.Point(1068, 390);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 1);
            this.panel5.TabIndex = 14;
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.Control;
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChange.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtChange.Location = new System.Drawing.Point(1068, 375);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(141, 16);
            this.txtChange.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1065, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Toplam Məbləğ:";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancelOrder.Image = global::MarketWinFormUI.Properties.Resources.CancelShoppingCart;
            this.btnCancelOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelOrder.Location = new System.Drawing.Point(1065, 588);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(147, 66);
            this.btnCancelOrder.TabIndex = 17;
            this.btnCancelOrder.Text = "Satışı ləğv et";
            this.btnCancelOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnCashPayment
            // 
            this.btnCashPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCashPayment.Image = global::MarketWinFormUI.Properties.Resources.CashPay;
            this.btnCashPayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCashPayment.Location = new System.Drawing.Point(1065, 516);
            this.btnCashPayment.Name = "btnCashPayment";
            this.btnCashPayment.Size = new System.Drawing.Size(147, 66);
            this.btnCashPayment.TabIndex = 18;
            this.btnCashPayment.Text = "Nəğd Ödəniş";
            this.btnCashPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCashPayment.UseVisualStyleBackColor = true;
            this.btnCashPayment.Click += new System.EventHandler(this.btnCashPayment_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(1068, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(141, 1);
            this.panel6.TabIndex = 15;
            // 
            // lvwSales
            // 
            this.lvwSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.BarcodeNo,
            this.ProductsName,
            this.UnitPrice,
            this.Quantity,
            this.TotalPrice});
            this.lvwSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvwSales.HideSelection = false;
            this.lvwSales.Location = new System.Drawing.Point(20, 75);
            this.lvwSales.Name = "lvwSales";
            this.lvwSales.Size = new System.Drawing.Size(1039, 579);
            this.lvwSales.TabIndex = 22;
            this.lvwSales.UseCompatibleStateImageBehavior = false;
            this.lvwSales.View = System.Windows.Forms.View.Details;
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
            this.TotalPrice.Text = "Toplam məbləğ";
            this.TotalPrice.Width = 152;
            // 
            // cmbCashRegister
            // 
            this.cmbCashRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCashRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCashRegister.FormattingEnabled = true;
            this.cmbCashRegister.Location = new System.Drawing.Point(1068, 75);
            this.cmbCashRegister.Name = "cmbCashRegister";
            this.cmbCashRegister.Size = new System.Drawing.Size(147, 24);
            this.cmbCashRegister.TabIndex = 23;
            this.cmbCashRegister.Tag = "";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalMoney.Location = new System.Drawing.Point(1178, 267);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(15, 16);
            this.lblTotalMoney.TabIndex = 24;
            this.lblTotalMoney.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1065, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Məbləğ:";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Image = global::MarketWinFormUI.Properties.Resources.AddToCart;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(920, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 58);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Səbətə əlavə et";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SaleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.cmbCashRegister);
            this.Controls.Add(this.lvwSales);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnCashPayment);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtRecievedMoney);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBarcode);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "SaleUserControl";
            this.Size = new System.Drawing.Size(1218, 661);
            this.Load += new System.EventHandler(this.SaleUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRecievedMoney;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnCashPayment;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwSales;
        private System.Windows.Forms.ComboBox cmbCashRegister;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader BarcodeNo;
        private System.Windows.Forms.ColumnHeader ProductsName;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.Label label2;
    }
}
