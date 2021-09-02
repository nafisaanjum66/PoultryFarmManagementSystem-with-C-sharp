using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoultryFarmManagementSystem
{
    public partial class UserControlPriceList : UserControl
    {
        private int i = 1;
        public UserControlPriceList()
        {
            InitializeComponent();
        }

        private void UserControlPriceList_Load(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\Users\\HP\\source\\repos\\image feed\\1.png";
                this.pbFeed.Image = Image.FromFile(path);

                this.timerUCP.Start();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during UserControl Price List Load: " + exc.Message);
            }
        }

        
        private void timerUCP_Tick(object sender, EventArgs e)
        {
            try
            {
                this.progressBarUCP.Value += 20;
                if (this.progressBarUCP.Value >= 100)
                {
                    //this.timerUCP.Stop();
                    this.progressBarUCP.Value = 0;
                    i++;
                }
                if (i > 7)
                {
                    i = 1;
                }

                string path = "C:\\Users\\HP\\source\\repos\\image feed\\" + i + ".png";
                this.pbFeed.Image = Image.FromFile(path);
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Timer UCP tick: " + exc.Message);
            }
        }

        
    }
}
