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
    public partial class Form2 : Form
    {
        private DataAccess da;
        private DataAccess Da
        {
            get { return this.da; }
            set { this.da = value; }
        }
        private DataSet ds;
        private DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        private DataTable Dt { get; set; }
        private string sql;
        private string Sql
        {
            get { return this.sql; }
            set { this.sql = value; }
        }
        public Form2()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public Form2(string idInfo)
        {
            try
            {
                InitializeComponent();
                this.Da = new DataAccess();
                this.lblOutputId.Text = idInfo;

                this.giveName();
                this.giveType();
                this.panelDeleteAccount.Visible = false;
                this.BtnPrivacy();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An Ecception occure during constructor loading :" + exc.Message);
            }

        }
        public void giveName()
        {
            try
            {
                this.Sql = @"select name from projectlogin where id='" + this.lblOutputId.Text + "';";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                string n = dt.Rows[0]["name"].ToString();
                //MessageBox.Show("name : " + n);
                this.lblOutputName.Text = n;

            }
            catch (Exception exc)
            {
                MessageBox.Show("An Ecception occure during give name :" + exc.Message);
            }

        }
        public void giveType()
        {
            try
            {
                this.Sql = @"select type from projectlogin where id='" + this.lblOutputId.Text + "';";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                string t = dt.Rows[0]["type"].ToString();
                this.lblOutputType.Text = t;

            }
            catch (Exception exc)
            {
                MessageBox.Show("An Ecception occure during give type :" + exc.Message);
            }

        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this.lblOutputId.Text);
            f3.Visible = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

       
        private void BtnUpdateProfile_Click_1(object sender, EventArgs e)
        {
            FormUpdateProfile up = new FormUpdateProfile(updateIdInfo: this.lblOutputId.Text);
            up.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.giveName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPriceList fpl = new FormPriceList();
            fpl.Visible = true;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            this.panelDeleteAccount.Visible = true;
            PopulateCustomerGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.panelDeleteAccount.Visible = false;
            this.ClearAll();
        }
        public void BtnPrivacy()
        {
            try
            {
                if (this.lblOutputId.Text.Contains("u"))
                {
                    this.btnDeleteAccount.Enabled = false;
                    this.btnDeleteAccount.Visible = false;
                    
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during btnPrivacy: " + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //string id = this.dgvMovie.CurrentRow.Cells[0].Value.ToString();
                //string title = this.dgvMovie.CurrentRow.Cells["title"].Value.ToString();
                //MessageBox.Show(title);

                this.Sql = @"delete from projectlogin where id='"+this.txtPanelDeleteId.Text+"';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show(" has been deleted properly");
                }
                else
                {
                    MessageBox.Show("Data deletation failed.");
                }

                //this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during delete " + exc.Message);
            }
        }
        public void PopulateCustomerGridView(string sql = "select * from projectlogin;")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);

                this.dgvCustomer.AutoGenerateColumns = false;
                this.dgvCustomer.DataSource = this.Ds.Tables[0];
                this.dgvCustomer.ClearSelection();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Populate grid view: " + exc.Message);
            }

        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtPanelDeleteId.Text = this.dgvCustomer.CurrentRow.Cells["id"].Value.ToString();
                this.txtPanelDeleteName.Text = this.dgvCustomer.CurrentRow.Cells["name"].Value.ToString();
                this.txtPanelDeletePassword.Text = this.dgvCustomer.CurrentRow.Cells["password"].Value.ToString();
                this.cmbDeleteType.Text = this.dgvCustomer.CurrentRow.Cells["type"].Value.ToString();
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during dgv product double click: " + exc.Message);
            }
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Sql = @"select * from projectlogin where id like '" + this.txtCustomerSearch.Text + "%';";
                this.PopulateCustomerGridView(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during auto search." + exc.Message);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void ClearAll()
        {
            try
            {
                this.cmbDeleteType.SelectedIndex = -1;
                this.txtPanelDeleteId.Clear();
                this.txtPanelDeleteName.Text = "";
                this.txtPanelDeletePassword.Clear();
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Clear All: " + exc.Message);
            }
        }
    }
}
