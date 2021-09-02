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
    public partial class UserControlNewAccount : UserControl
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
        
        public UserControlNewAccount()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public UserControlNewAccount(string newId)
        {
            try
            {
                InitializeComponent();
                this.Da = new DataAccess();
                this.txtPanelId.Text = newId;
                this.GenerateNewAccountid();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Update " + exc.Message);
            }
        }

        private void UserControlNewAccount_Load(object sender, EventArgs e)
        {

        }
        public void GenerateNewAccountid()
        {
            try
            {
                this.Sql = @"select * from projectlogin order by id desc;";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                string id = dt.Rows[0]["id"].ToString();
                string[] str = id.Split('u');
                int number = Convert.ToInt32(str[1]);
                string newId = "u" + (++number).ToString("d3");

                this.txtPanelId.Text = newId;
                //MessageBox.Show(id);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Update " + exc.Message);
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.txtPanelName.Text==""|| this.txtPanelPassword.Text == "")
                {
                    MessageBox.Show("Please enter your name and password correctly...!");
                }
                else
                {
                    this.Sql = @"insert into projectlogin
                        values ('" + this.txtPanelId.Text + "','" + this.txtPanelName.Text + "','" + this.txtPanelPassword.Text + "','" + this.txtPanelType.Text + "');";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Account added properly");
                    }
                    else
                    {
                        MessageBox.Show("Account insertion failed.");
                    }
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Update " + exc.Message);
            }

        }
    }
}
