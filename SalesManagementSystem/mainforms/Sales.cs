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
    public partial class Sales : Form
    {
        string query;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45");
        DataTable dt = new DataTable();
        decimal total = 0 , Allamount=0;
        public Sales()
        {
            query = "select * FROM productlist_table";
            InitializeComponent();
            DisplayData(query);
            
        }
        private void DisplayData(string query)
        {

            conn.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            DataTable dt2 = new DataTable();
            adapt.Fill(dt2);
            dataGridView1.DataSource = dt2;
            foreach (DataRow dr in dt2.Rows)

            {
                int index = comboBox1.FindString(dr["Name"].ToString());
                if (index < 0)
                {
                    comboBox1.Items.Add(dr["Name"].ToString());
                }

            }
            conn.Close();

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.Beige;

            dt.Clear();
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductPrice", typeof(string));
            dt.Columns.Add("ProductQuantity", typeof(string));
            dt.Columns.Add("Totalprice", typeof(string));
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string price = "select * from productlist_table where Name = '" + comboBox1.Text + "'";

            conn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(price, conn);
            DataTable dt3 = new DataTable();
            adapt.Fill(dt3);

            foreach (DataRow dr in dt3.Rows)
            {
                textBox2.Text = dr["Price"].ToString();
            }
            conn.Close();
        }

         private void textBox3_Leave(object sender, EventArgs e)
        {

            
            try
            {
                
                total = Convert.ToDecimal(textBox2.Text) * Convert.ToDecimal(textBox3.Text);
                textBox4.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
         
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        { 

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty && comboBox1.Text != String.Empty)
            {
                int stock = 0;
                string price = "select * from productlist_table where Name = '" + comboBox1.Text + "'";

                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(price, conn);
                DataTable dt3 = new DataTable();
                adapt.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                {
                    stock = Convert.ToInt32(dr["Stock"].ToString());

                }
                if (Convert.ToInt32(textBox3.Text) > stock)
                {
                    MessageBox.Show("This much Value is not available");
                }
                else
                {

                    DataRow dr = dt.NewRow();

                    dr["ProductName"] = comboBox1.Text;
                    dr["ProductPrice"] = textBox2.Text;
                    dr["ProductQuantity"] = textBox3.Text;
                    dr["TotalPrice"] = textBox4.Text;


                    dt.Rows.Add(dr);
                    dataGridView1.DataSource = dt;

                    Allamount = Allamount + Convert.ToDecimal(dr["TotalPrice"].ToString());

                    totalPrice.Text = Convert.ToString(Allamount);


                    //insert into table
                  string  sql = "INSERT INTO sale (CustomerName,ProductName,Quantity,ProductPrice,Date) VALUES ('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" +dateTimePicker1.Text+ "')";

                    SqlCommand objSqlCommand = new SqlCommand(sql, conn);
                    objSqlCommand.ExecuteNonQuery();
                    //update stock
                    int qty=0;
                    qty = Convert.ToInt32(textBox3.Text);
                    sql = "update productlist_table set stock= stock-" + qty + " Where Name='" + comboBox1.Text+ "'";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();


                }
                conn.Close();
              }
            else
            {
                MessageBox.Show("Please Provide Detaile");
            }
            
        }

       
    }
}
