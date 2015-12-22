namespace MyApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.uxVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxProduct = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version:";
            // 
            // uxVersion
            // 
            this.uxVersion.AutoSize = true;
            this.uxVersion.ForeColor = System.Drawing.Color.OrangeRed;
            this.uxVersion.Location = new System.Drawing.Point(114, 45);
            this.uxVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxVersion.Name = "uxVersion";
            this.uxVersion.Size = new System.Drawing.Size(75, 24);
            this.uxVersion.TabIndex = 3;
            this.uxVersion.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product:";
            // 
            // uxProduct
            // 
            this.uxProduct.AutoSize = true;
            this.uxProduct.ForeColor = System.Drawing.Color.OrangeRed;
            this.uxProduct.Location = new System.Drawing.Point(114, 9);
            this.uxProduct.Name = "uxProduct";
            this.uxProduct.Size = new System.Drawing.Size(75, 24);
            this.uxProduct.TabIndex = 5;
            this.uxProduct.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Company:";
            // 
            // uxCompany
            // 
            this.uxCompany.AutoSize = true;
            this.uxCompany.ForeColor = System.Drawing.Color.OrangeRed;
            this.uxCompany.Location = new System.Drawing.Point(114, 85);
            this.uxCompany.Name = "uxCompany";
            this.uxCompany.Size = new System.Drawing.Size(91, 24);
            this.uxCompany.TabIndex = 7;
            this.uxCompany.Text = "Company";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.uxCompany);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxVersion);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "My App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uxProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label uxCompany;
    }
}

