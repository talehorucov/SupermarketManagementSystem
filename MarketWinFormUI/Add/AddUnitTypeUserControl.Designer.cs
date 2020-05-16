namespace MarketWinFormUI
{
    partial class AddUnitTypeUserControl
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
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnitAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnitAdd.Image = global::MarketWinFormUI.Properties.Resources.AddUnitTypes;
            this.btnUnitAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnitAdd.Location = new System.Drawing.Point(682, 272);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(120, 57);
            this.btnUnitAdd.TabIndex = 19;
            this.btnUnitAdd.Text = "Əlavə et";
            this.btnUnitAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnitAdd.UseVisualStyleBackColor = true;
            this.btnUnitAdd.Click += new System.EventHandler(this.btnUnitAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(364, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "*Vahid Növü:";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitName.Location = new System.Drawing.Point(507, 198);
            this.txtUnitName.MaxLength = 50;
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(295, 31);
            this.txtUnitName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(482, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 55);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vahid Növü";
            // 
            // AddUnitTypeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUnitAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.label3);
            this.Name = "AddUnitTypeUserControl";
            this.Size = new System.Drawing.Size(1218, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUnitAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label3;
    }
}
