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
    public partial class FormUpdateProfile : Form
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
        public FormUpdateProfile()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public FormUpdateProfile(string updateIdInfo)
        {
            try
            {
                InitializeComponent();
                this.Da = new DataAccess();
                this.txtUpdateId.Text = updateIdInfo;
            }
            
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Constructor Loading: " + exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtUpdateName.Text == "" || this.txtUpdatePassword.Text == "")
                {
                    MessageBox.Show("Please Enter Your All Information Correcgtly..!");
                }
                else
                {
                    this.Sql = @"update projectlogin
                        set name='" + this.txtUpdateName.Text + @"',
                        password='" + this.txtUpdatePassword.Text + @"'
                        where id='" + this.txtUpdateId.Text + "';";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data updated properly.");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Data update failed.");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Update: " + exc.Message);
            }

        }

        
    }
}
