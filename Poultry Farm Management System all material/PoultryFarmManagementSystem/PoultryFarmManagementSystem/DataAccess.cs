using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PoultryFarmManagementSystem
{
    class DataAccess
    {
        private string sql;
        private string Sql
        {
            get { return this.sql; }
            set { this.sql = value; }
        }
        private SqlConnection sqlcon;
        private SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        private SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        private SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }
        private DataSet ds;
        private DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-NI4ANO8;Initial Catalog=mytestdatabase;Persist Security Info=True;User ID=sa;Password=Dana1234");
            this.Sqlcon.Open();
        }
        public void QueryText(string query)
        {
            this.sqlcom = new SqlCommand(query, this.sqlcon);
        }
        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.sda = new SqlDataAdapter(sqlcom);
                this.Ds = new DataSet();
                this.sda.Fill(this.Ds);
                return this.Ds;

            }
            catch (Exception)
            {
                return null;
            }

        }
        public DataTable ExecuteQueryTable(string sql)
        {

            this.QueryText(sql);
            this.sda = new SqlDataAdapter(sqlcom);
            this.Ds = new DataSet();
            this.sda.Fill(this.Ds);
            return this.ds.Tables[0];
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.sqlcom.ExecuteNonQuery();
            return u;
        }

    }
}
