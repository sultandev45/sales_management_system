using FontAwesome.Sharp;
using System;
using System.Collections;
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
    public partial class addstock : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45");
        string sql;
        public addstock()
        {
            InitializeComponent();
            sql = "select * FROM productlist_table";
            DisplayData( sql);
        }

        private void DisplayData(string query)
        {

            conn.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            DataTable dt2 = new DataTable();
            adapt.Fill(dt2);
            addproductview.DataSource = dt2;
            conn.Close();
        }


            private void button_WOC2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty && textBox5.Text != String.Empty)
            { 
                
                conn.Open();
               sql = "INSERT INTO productlist_table (name,price,category,company,stock) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";

                SqlCommand objSqlCommand = new SqlCommand(sql, conn);
                int i= objSqlCommand.ExecuteNonQuery();
                conn.Close();
                if (i != 0) 
                {
                    sql   ="select * FROM productlist_table Where Name='" + textBox1.Text + "' and Price ='" + textBox2.Text + "' and Category ='" + textBox3.Text + "' and Company='" + textBox4.Text + "' and Stock='" + textBox5.Text + "'";

                     DisplayData(sql);
                }
                
            }

            else
            {
                MessageBox.Show("Please Provide Details!");
            }



        }

        private void addstock_Load(object sender, EventArgs e)
        {
            addproductview.DefaultCellStyle.Font = new Font("Tahoma", 12);
            addproductview.DefaultCellStyle.ForeColor = Color.Black;
            addproductview.DefaultCellStyle.BackColor = Color.Beige;
        }

       
    }
}
