using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Markup;
using SalesManagementSystem.mainforms;
using System.IO.Ports;

namespace SalesManagementSystem
{
    public partial class login : Form
    {
        public static string user;
        public login()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button_WOC1_Click(object sender, EventArgs e)
        {

            string ServerConnection = "Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45";
            SqlConnection conn = new SqlConnection(ServerConnection);
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                if (user_name.Text != string.Empty || password.Text != string.Empty)
                {
                    string sql = "select * FROM login_table Where username='" + user_name.Text + "' and password ='" + password.Text + "'";

                    SqlDataAdapter usrs= new SqlDataAdapter(sql, conn);
                    DataSet dt = new DataSet();
                    usrs.Fill(dt);

                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        Dashboard dashboard = new Dashboard();
                       dashboard.Name = user_name.Text;
                        user = user_name.Text;
                        this.Hide();
                        dashboard.Show();
                    }
                    else
                    {
                        password.Clear(); password.Focus();
                        MessageBox.Show("Invalid User Name Or Password");

                    }
                }
                else { MessageBox.Show("Please enter Your username & passsword.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else {
                MessageBox.Show("Cannot Connect to DataBase");
            }





        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {

            Adduser usr = new Adduser();
            this.Hide();
            usr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            forgetPass Pass = new forgetPass();
            this.Hide();
            Pass.Show();
        }
    }
}
