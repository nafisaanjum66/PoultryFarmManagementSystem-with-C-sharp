namespace PoultryFarmManagementSystem
{
    partial class UserControlPriceList
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
            this.components = new System.ComponentModel.Container();
            this.progressBarUCP = new System.Windows.Forms.ProgressBar();
            this.timerUCP = new System.Windows.Forms.Timer(this.components);
            this.pbFeed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarUCP
            // 
            this.progressBarUCP.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBarUCP.Location = new System.Drawing.Point(64, 375);
            this.progressBarUCP.Name = "progressBarUCP";
            this.progressBarUCP.Size = new System.Drawing.Size(269, 10);
            this.progressBarUCP.TabIndex = 28;
            // 
            // timerUCP
            // 
            this.timerUCP.Interval = 1000;
            this.timerUCP.Tick += new System.EventHandler(this.timerUCP_Tick);
            // 
            // pbFeed
            // 
            this.pbFeed.Location = new System.Drawing.Point(64, 36);
            this.pbFeed.Name = "pbFeed";
            this.pbFeed.Size = new System.Drawing.Size(269, 321);
            this.pbFeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFeed.TabIndex = 0;
            this.pbFeed.TabStop = false;
            // 
            // UserControlPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.progressBarUCP);
            this.Controls.Add(this.pbFeed);
            this.Name = "UserControlPriceList";
            this.Size = new System.Drawing.Size(415, 453);
            this.Load += new System.EventHandler(this.UserControlPriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFeed;
        private System.Windows.Forms.ProgressBar progressBarUCP;
        private System.Windows.Forms.Timer timerUCP;
    }
}
