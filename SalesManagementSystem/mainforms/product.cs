using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
   

    public partial class product : Form
    {
       

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45");
  
        SqlCommand cmd;
       string sql;
       string sqlp= "select * FROM productlist_table";
        int ID = 0; 
        public product()
        {      
            InitializeComponent();
            DisplayData(sqlp);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void find_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != String.Empty && comboBox1.Text != String.Empty)
            {
                sql = "select * FROM productlist_table Where Name='" + textBox1.Text + "' and Category ='" + comboBox1.Text + "'";

            }
            else if (textBox1.Text == String.Empty || comboBox1.Text == String.Empty)
            {
                sql = "select * FROM productlist_table Where Name='" + textBox1.Text + "' or Category ='" + comboBox1.Text + "'";
            }

            DisplayData(sql);
             
        }
       
       
        private void product_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            
        }
       
      
             //Display Data in DataGridView  
            private void DisplayData(string query)
            {  //Clear Data
                   textBox1.Clear();
                   textBox2.Clear();
                   textBox3.Clear();
                   textBox4.Clear();
                   comboBox1.Items.Clear();
                   comboBox1.SelectedIndex = -1;
                   ID = 0;

            conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
                DataTable dt2 = new DataTable();
                adapt.Fill(dt2);
                dataGridView1.DataSource = dt2;
               
                foreach (DataRow dr in dt2.Rows)

                {    
                    int index = comboBox1.FindString(dr["Category"].ToString());
                    if (index < 0)
                    {
                        comboBox1.Items.Add(dr["Category"].ToString());
                    }

                }

                conn.Close();
            }
        private void delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete from productlist_table Where id=" + ID + "", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                comboBox1.Items.Clear();
                DisplayData(sqlp);
               
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty && comboBox1.Text != String.Empty)
            {
                sql = "update productlist_table set name ='" + textBox1.Text + "',price ='" + textBox3.Text + "',category ='" + comboBox1.Text + "',company ='" + textBox2.Text + "',stock= '" + textBox4.Text + "' Where id=" + ID + "";

                cmd = new SqlCommand(sql, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                DisplayData(sqlp);
               
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        //dataGridView1 RowHeaderMouseDoubleClick Event 
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
