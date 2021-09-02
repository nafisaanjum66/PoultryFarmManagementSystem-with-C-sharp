using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PoultryFarmManagementSystem
{
    public partial class FormLogin : Form
    {
        private DataAccess da;
        private DataAccess Da
        {
            get{return this.da ;}
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
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.panelNewAccount.Visible = false;
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                this.Sql = "select * from projectlogin;";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                int count = 0;
                bool d = false;
                while (count < Ds.Tables[0].Rows.Count)
                {
                    if (this.txtId.Text == Ds.Tables[0].Rows[count][0].ToString() && this.txtPassword.Text == Ds.Tables[0].Rows[count][2].ToString())
                    {
                        //MessageBox.Show("Login approved for:" + Ds.Tables[0].Rows[count][1]);
                        Form2 f2 = new Form2(this.txtId.Text);
                        f2.Visible = true;
                        this.ClearLogin();
                        this.Visible = false;
                        
                        d = true;
                        break;
                    }
                    count++;
                }
                if (!d)
                {
                    MessageBox.Show("Cannot Login! Please enter correct info.");
                }
                //sqlcon.Close();
                
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error occured during Login"+exc.Message);
            }



        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearLogin();
        }

        public void ClearLogin() 
        {
            this.txtId.Text = "";
            this.txtPassword.Text = "";
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            FormPriceList fpl = new FormPriceList();
            fpl.Visible = true;
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            try
            {
                this.panelNewAccount.Visible = true;
                UserControlNewAccount ucna = new UserControlNewAccount("id");
                this.panelNewAccount.Controls.Add(ucna);
                ucna.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An Ecception occure during give type :" + exc.Message);
            }
        }

        
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.panelNewAccount.Visible=false;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
