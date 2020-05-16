namespace MarketWinFormUI
{
    partial class AddAuthorityUserControl
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnJobAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(397, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Açıqlama:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(509, 239);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(295, 125);
            this.txtDescription.TabIndex = 32;
            // 
            // btnJobAdd
            // 
            this.btnJobAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJobAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJobAdd.Image = global::MarketWinFormUI.Properties.Resources.AddTitle;
            this.btnJobAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJobAdd.Location = new System.Drawing.Point(684, 396);
            this.btnJobAdd.Name = "btnJobAdd";
            this.btnJobAdd.Size = new System.Drawing.Size(120, 57);
            this.btnJobAdd.TabIndex = 28;
            this.btnJobAdd.Text = "Əlavə et";
            this.btnJobAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJobAdd.UseVisualStyleBackColor = true;
            this.btnJobAdd.Click += new System.EventHandler(this.btnJobAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(417, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "*Vəzifə:";
            // 
            // txtJobName
            // 
            this.txtJobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtJobName.Location = new System.Drawing.Point(509, 180);
            this.txtJobName.MaxLength = 50;
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(295, 31);
            this.txtJobName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(508, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 55);
            this.label6.TabIndex = 25;
            this.label6.Text = "Vəzifə";
            // 
            // AddAuthorityUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnJobAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.label6);
            this.Name = "AddAuthorityUserControl";
            this.Size = new System.Drawing.Size(1218, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnJobAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label6;
    }
}
