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
    public partial class Adduser : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45");

        SqlCommand cmd;
        string query;
        public Adduser()
        {
            InitializeComponent();
        }

        private void Adduser_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            
           
            conn.Open();
             query = "select * FROM login_table Where username='" + usrname.Text + "'";
           cmd = new SqlCommand(query, conn);
            SqlDataReader data = cmd.ExecuteReader();

            if (usrname.Text != string.Empty || pass.Text != string.Empty || conpass.Text != string.Empty)
            {
                if (pass.Text == conpass.Text)
                {
                    
                   
                    if (data.Read())
                    {
                        data.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        data.Close();
                        cmd = new SqlCommand("insert into login_table values('"+usrname.Text+"','" +pass.Text+ "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Close();
            log.Show();
        }
    }
    
}
