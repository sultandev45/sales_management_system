using SalesManagementSystem;
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

namespace SalesManagementSystem
{
    public partial class ChangePass : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45");

        SqlCommand cmd;
        string sql;
        public ChangePass()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                if ((textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty ) && (textBox2.Text==textBox3.Text))
                {
                     sql = "select * FROM login_table Where password ='" + textBox1.Text + "'";

                    SqlDataAdapter usrs = new SqlDataAdapter(sql, conn);
                    DataSet dt = new DataSet();
                    usrs.Fill(dt);

                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        sql = "update login_table set password ='" + textBox2.Text + "' Where password ='" + textBox1.Text + "'";

                        cmd = new SqlCommand(sql, conn);

                       
                        
                        
                      
                        DialogResult res = MessageBox.Show("Are you sure to change Password ?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        switch (res)
                        {
                            case DialogResult.Yes: cmd.ExecuteNonQuery(); MessageBox.Show("Password Updated Successfully"); break;
                            case DialogResult.No: MessageBox.Show(" Password Cannot be changed"); break;
                        }





                    }
                    else
                    {
                      
                        MessageBox.Show(" Password Not Matched");

                    }
                }
                else { MessageBox.Show("Please enter Your old passsword.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else
            {
                MessageBox.Show("Cannot Connect to DataBase");
            }

            conn.Close();
        }
    }
}
