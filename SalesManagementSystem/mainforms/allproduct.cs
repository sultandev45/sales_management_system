using FontAwesome.Sharp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SalesManagementSystem
{
    public partial class allproduct : Form
    {
        string query;
       
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0R4M6QS;Initial Catalog=SalesDatabase;Persist Security Info=True;User ID=sa;Password=Sultan45");


        string queryp = "select * FROM productlist_table";
        public allproduct()
        {
           
            InitializeComponent();
            DisplayData(queryp);
        }
        private void DisplayData(string query)
        {

            conn.Open();
           
            SqlDataAdapter adapt = new SqlDataAdapter(query, conn); 
            DataTable dt2 = new DataTable();
            adapt.Fill(dt2);
           dataGridView1.DataSource= dt2; 
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
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            
            
            if (textBox1.Text != String.Empty && comboBox1.Text != String.Empty)
            {
                query = "select * FROM productlist_table Where Name='" + textBox1.Text + "' and Category ='" + comboBox1.Text + "'";

            }
            else if (textBox1.Text == String.Empty || comboBox1.Text == String.Empty)
            {
                query = "select * FROM productlist_table Where Name='" + textBox1.Text + "' or Category ='" + comboBox1.Text + "'";
            }

            DisplayData(query);
          
            

        }
       

        private void allproduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.Beige;


        }

        private void all_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
            DisplayData(queryp);
        }
    }
}
