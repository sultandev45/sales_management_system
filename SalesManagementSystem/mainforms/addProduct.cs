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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45");
            string sql = "INSERT INTO productlist_table (name,price,category,company,stock) VALUES ('"+textBox1.Text+"','"+textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text+"')";
            conn.Open();
            SqlCommand objSqlCommand= new SqlCommand(sql,conn);
           objSqlCommand.ExecuteNonQuery();

            conn.Close();
        }
    }
}
