using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.mainforms
{
    public partial class forgetPass : Form
    {
        public forgetPass()
        {
            InitializeComponent();
        }

        private void forget_Click(object sender, EventArgs e)
        {
            string ServerConnection = "Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45";
            SqlConnection conn = new SqlConnection(ServerConnection);
            conn.Open();
            string sql = "select * FROM login_table Where username='" + user_name.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader pass = cmd.ExecuteReader();
            if (pass.Read())
            {   
                   label3.Text= "Your Password is: " + pass.GetValue(2).ToString();
                    MessageBox.Show("Your Password is: " + pass.GetValue(2).ToString());
            }
            else
            {
                MessageBox.Show("User Name Not Found!!! ");

            }
            conn.Close();   
        }

        private void back_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Close();
            log.Show();
        }

        private void forgetPass_Load(object sender, EventArgs e)
        {

        }
    }
}
