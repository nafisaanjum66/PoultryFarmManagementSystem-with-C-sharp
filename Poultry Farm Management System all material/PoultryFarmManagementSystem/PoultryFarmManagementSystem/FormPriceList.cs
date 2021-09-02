using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoultryFarmManagementSystem
{
    public partial class FormPriceList : Form
    {
        public FormPriceList()
        {
            InitializeComponent();
        }

        private void FormPriceList_Load(object sender, EventArgs e)
        {
            try
            {
                UserControlPriceList ucp = new UserControlPriceList();
                this.pnlImage.Controls.Add(ucp);
                ucp.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Confirmation " + exc.Message);
            }
        }

        private void btnFplBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbFeedFpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbFeedFpl.SelectedIndex == 0 || this.cmbFeedFpl.SelectedIndex == 1 || this.cmbFeedFpl.SelectedIndex == 2)
                {
                    this.txtProductPriceFpl.Text = "2250";
                }
                else if (this.cmbFeedFpl.SelectedIndex == 3)
                {
                    this.txtProductPriceFpl.Text = "2000";
                }
                else if (this.cmbFeedFpl.SelectedIndex == 4)
                {
                    this.txtProductPriceFpl.Text = "1850";
                }
                else if (this.cmbFeedFpl.SelectedIndex == 5 || this.cmbFeedFpl.SelectedIndex == 6)
                {
                    this.txtProductPriceFpl.Text = "1750";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Confirmation " + exc.Message);
            }
        }
    }
}
