namespace PoultryFarmManagementSystem
{
    partial class FormPriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPriceList));
            this.pnlImage = new System.Windows.Forms.Panel();
            this.btnFplBack = new System.Windows.Forms.Button();
            this.txtProductPriceFpl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFeedFpl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlImage.Location = new System.Drawing.Point(511, 35);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(415, 453);
            this.pnlImage.TabIndex = 0;
            // 
            // btnFplBack
            // 
            this.btnFplBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnFplBack.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFplBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFplBack.Location = new System.Drawing.Point(83, 416);
            this.btnFplBack.Name = "btnFplBack";
            this.btnFplBack.Size = new System.Drawing.Size(127, 40);
            this.btnFplBack.TabIndex = 7;
            this.btnFplBack.Text = "Back";
            this.btnFplBack.UseVisualStyleBackColor = false;
            this.btnFplBack.Click += new System.EventHandler(this.btnFplBack_Click);
            // 
            // txtProductPriceFpl
            // 
            this.txtProductPriceFpl.Enabled = false;
            this.txtProductPriceFpl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.txtProductPriceFpl.Location = new System.Drawing.Point(216, 248);
            this.txtProductPriceFpl.Name = "txtProductPriceFpl";
            this.txtProductPriceFpl.Size = new System.Drawing.Size(256, 32);
            this.txtProductPriceFpl.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Product Price:";
            // 
            // cmbFeedFpl
            // 
            this.cmbFeedFpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeedFpl.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFeedFpl.FormattingEnabled = true;
            this.cmbFeedFpl.Items.AddRange(new object[] {
            "Broyler Starter",
            "Broyler Grower",
            "Broyler Finisher",
            "Leyar Starter",
            "Leyar Grower",
            "Leyar Leyar",
            "Mash-1"});
            this.cmbFeedFpl.Location = new System.Drawing.Point(216, 183);
            this.cmbFeedFpl.Name = "cmbFeedFpl";
            this.cmbFeedFpl.Size = new System.Drawing.Size(256, 31);
            this.cmbFeedFpl.TabIndex = 19;
            this.cmbFeedFpl.SelectedIndexChanged += new System.EventHandler(this.cmbFeedFpl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Feed :";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Harlow Solid Italic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcome.Location = new System.Drawing.Point(45, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(415, 61);
            this.lblWelcome.TabIndex = 22;
            this.lblWelcome.Text = "Product Price List";
            // 
            // FormPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PoultryFarmManagementSystem.Properties.Resources.images__24_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 500);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtProductPriceFpl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFeedFpl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFplBack);
            this.Controls.Add(this.pnlImage);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPriceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPriceList";
            this.Load += new System.EventHandler(this.FormPriceList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Button btnFplBack;
        private System.Windows.Forms.TextBox txtProductPriceFpl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFeedFpl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
    }
}