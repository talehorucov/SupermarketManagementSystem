namespace MarketWinFormUI
{
    partial class AddCashRegisterUserControl
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
            this.btnCashAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCashRegisterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCashAdd
            // 
            this.btnCashAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCashAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCashAdd.Image = global::MarketWinFormUI.Properties.Resources.CashRegisterAdd;
            this.btnCashAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCashAdd.Location = new System.Drawing.Point(684, 396);
            this.btnCashAdd.Name = "btnCashAdd";
            this.btnCashAdd.Size = new System.Drawing.Size(120, 57);
            this.btnCashAdd.TabIndex = 15;
            this.btnCashAdd.Text = "Əlavə et";
            this.btnCashAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCashAdd.UseVisualStyleBackColor = true;
            this.btnCashAdd.Click += new System.EventHandler(this.btnCashAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(417, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "*Kassa:";
            // 
            // txtCashRegisterName
            // 
            this.txtCashRegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCashRegisterName.Location = new System.Drawing.Point(509, 180);
            this.txtCashRegisterName.MaxLength = 50;
            this.txtCashRegisterName.Name = "txtCashRegisterName";
            this.txtCashRegisterName.Size = new System.Drawing.Size(295, 31);
            this.txtCashRegisterName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(519, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kassa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(381, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Açıqlaması:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(509, 239);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(295, 125);
            this.txtDescription.TabIndex = 34;
            // 
            // AddCashRegisterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnCashAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCashRegisterName);
            this.Controls.Add(this.label1);
            this.Name = "AddCashRegisterUserControl";
            this.Size = new System.Drawing.Size(1218, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCashRegisterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
    }
}
