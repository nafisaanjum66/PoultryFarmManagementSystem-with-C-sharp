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
    public partial class Form3 : Form
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
        
        public Form3()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        
        public Form3(string idInfo3)
        {
            try
            {
                InitializeComponent();
                this.Da = new DataAccess();
                this.txtPersonId.Text = idInfo3;

                this.GenerateProductId();
                this.Privacy();
                this.BtnPrivacy();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Constructor Loading " + exc.Message);
            }

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.txtPersonId.Text = "";
            this.ClearAll();
            
        }

       
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtProductPrice.Text == "" || this.txtTotalPrice.Text == ""|| this.cmbFeed.Text==""|| this.txtQuantity.Text=="")
                {
                    MessageBox.Show("Inter the information Correctly...!");
                }
                else
                {
                    string time = DateTime.Now.ToString("hh:mm:ss");

                    this.Sql = @"insert into productproject
                        values ('" + this.txtProductId.Text + "','" + this.txtPersonId.Text + "','" + this.cmbFeed.Text + "'," + this.txtQuantity.Text + ",'" + this.dtpProducts.Text + "'," + this.txtProductPrice.Text + "," + this.txtTotalPrice.Text + ",'" + time + "');";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Order confirmed.");
                    }
                    else
                    {
                        MessageBox.Show("Order confirmation failed.");
                    }

                    this.PopulateGridView();
                    this.ClearAll();

                    this.GenerateProductId();
                    this.Privacy();



                }

            }
            catch (Exception exc) 
            {
                MessageBox.Show("An error has occured during Confirmation " + exc.Message);
            }
        }
        //public void Fillup()
        //{
        //    pro.personid = this.txtPersonId.Text;
        //    pro.productid = this.txtProductId.Text;
        //    pro.feed = this.cmbFeed.Text;
        //    pro.quantity = Convert.ToInt32(this.txtQuantity.Text);
        //    pro.issuedate = this.dtpProducts.Text;
        //    pro.productprice = Convert.ToInt32(this.txtProductPrice.Text);
        //    pro.totalprice = Convert.ToInt32(this.txtTotalPrice.Text);
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        public void PopulateGridView(string sql = "select * from productproject;")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);

                this.dgvProduct.AutoGenerateColumns = false;
                this.dgvProduct.DataSource = this.Ds.Tables[0];
                this.dgvProduct.ClearSelection();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Populate grid view: " + exc.Message);
            }

        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.txtProductId.Text = this.dgvProduct.CurrentRow.Cells["productid"].Value.ToString();
                this.txtPersonId.Text = this.dgvProduct.CurrentRow.Cells["personid"].Value.ToString();
                this.cmbFeed.Text = this.dgvProduct.CurrentRow.Cells["feed"].Value.ToString();
                this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells["quantity"].Value.ToString();
                this.dtpProducts.Text = this.dgvProduct.CurrentRow.Cells["issuedate"].Value.ToString();
                this.txtProductPrice.Text = this.dgvProduct.CurrentRow.Cells["productprice"].Value.ToString();
                this.txtTotalPrice.Text = this.dgvProduct.CurrentRow.Cells["totalprice"].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during dgv product double click: " + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //string productid = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                string proid = this.dgvProduct.CurrentRow.Cells["productid"].Value.ToString();
                MessageBox.Show(proid);

                this.Sql = @"delete from productproject where productid='"+this.txtProductId.Text+"';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show(proid + " has been deleted properly");
                }
                else
                {
                    MessageBox.Show("Data deletation failed.");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during delete " + exc.Message);
            }


        }
        public void ClearAll()
        {
            try
            {
                //this.txtProductId.Clear();
                this.txtSearch.Clear();
                this.cmbFeed.SelectedIndex = -1;
                this.txtQuantity.Clear();
                this.dtpProducts.Text = "";
                this.txtProductPrice.Clear();
                this.txtTotalPrice.Clear();
                this.GenerateProductId();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Clear All: " + exc.Message);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtQuantity.Text == "" )
                {
                    this.txtQuantity.Clear();
                }
                else
                {
                    int quantity = Convert.ToInt32(this.txtQuantity.Text);

                    if (this.cmbFeed.SelectedIndex == 0 || this.cmbFeed.SelectedIndex == 1 || this.cmbFeed.SelectedIndex == 2)
                    {
                        this.txtProductPrice.Text = "2250";
                        int u = quantity * 2250;
                        this.txtTotalPrice.Text = u.ToString();
                    }
                    else if (this.cmbFeed.SelectedIndex == 3)
                    {
                        this.txtProductPrice.Text = "2000";
                        int u = quantity * 2000;
                        this.txtTotalPrice.Text = u.ToString();
                    }
                    else if (this.cmbFeed.SelectedIndex == 4)
                    {
                        this.txtProductPrice.Text = "1850";
                        int u = quantity * 1850;
                        this.txtTotalPrice.Text = u.ToString();
                    }
                    else if (this.cmbFeed.SelectedIndex == 5)
                    {
                        this.txtProductPrice.Text = "1650";
                        int u = quantity * 1650;
                        this.txtTotalPrice.Text = u.ToString();
                    }
                    else if (this.cmbFeed.SelectedIndex == 6)
                    {
                        this.txtProductPrice.Text = "1750";
                        int u = quantity * 1750;
                        this.txtTotalPrice.Text = u.ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Price Calculation with out button " + exc.Message);
            }
        }
                
        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.txtPersonId.Text.Contains("u"))
                {
                    this.Sql = @"select * from productproject where feed like '" + this.txtSearch.Text + "%'and personid='" + this.txtPersonId.Text + "';";
                    this.PopulateGridView(this.Sql);
                }
                else
                {
                    this.Sql = @"select * from productproject where feed like '" + this.txtSearch.Text + "%';";
                    this.PopulateGridView(this.Sql);

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during auto search." + exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void GenerateProductId()
        {
            try
            {
                this.Sql = @"select * from productproject order by productid desc;";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                string id = dt.Rows[0]["productid"].ToString();
                string[] str = id.Split('p');
                int number = Convert.ToInt32(str[1]);
                string newId = "p" + (++number).ToString("d3");

                this.txtProductId.Text = newId;
                //MessageBox.Show(id);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Generate product id: " + exc.Message);
            }

        }
        public void Privacy()
        {
            if (this.txtPersonId.Text.Contains("u"))
            {
                try
                {
                    this.Sql = @"select * from productproject where personid  like '" + this.txtPersonId.Text + "%';";
                    this.PopulateGridView(this.Sql);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured during Privacy:" + exc.Message);
                }
            }
            else
            {
                this.PopulateGridView();
            }
        }
        public void BtnPrivacy()
        {
            try
            {
                if (this.txtPersonId.Text.Contains("u"))
                {
                    this.btnRefresh.Enabled = false;
                    this.btnRefresh.Visible = false;
                    this.btnUpdate.Enabled = false;
                    this.btnUpdate.Visible = false;
                    this.btnDelete.Enabled = false;
                    this.btnDelete.Visible = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during btnPrivacy: " + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = @"select * from productproject where productid='" + this.txtProductId.Text + "';";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update productproject
                            set personid='" + this.txtPersonId.Text + @"',
                            feed='" + this.cmbFeed.Text + @"',
                            quantity=" + this.txtQuantity.Text + @",
                            issuedate='" + this.dtpProducts.Text + @"',
                            productprice=" + this.txtProductPrice.Text + @",
                            totalprice=" + this.txtTotalPrice.Text + @"
                            where productid='" + this.txtProductId.Text + "';";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data updated properly.");
                    }
                    else
                    {
                        MessageBox.Show("Data update failed.");
                    }

                    this.PopulateGridView();
                    this.ClearAll();


                }
                this.GenerateProductId();
                this.Privacy();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Update " + exc.Message);
            }
        }
    }
}
