using FontAwesome.Sharp;
using SalesManagementSystem.mainforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class Dashboard : Form
    {
        private IconButton currentbtn;
        private Panel leftborderbtn;
        private Form currentchildform;


        public Dashboard()
        {
            InitializeComponent();
            leftborderbtn = new Panel();
            leftborderbtn.Size = new Size(7, 40);
            panel1.Controls.Add(leftborderbtn);
            //

            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
   
          
        //structs
        private struct rgbcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(172, 126, 241);
            public static Color color8 = Color.FromArgb(17, 156, 241);

        }
        private void restorebutton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.Black;
                currentbtn.ForeColor = Color.White;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.White;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
               
            }
        }
        private void activatebutton(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                restorebutton();
                //
                currentbtn = (IconButton)senderbtn;
                currentbtn.BackColor = Color.FromArgb(39, 41, 61);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftborderbtn.BackColor = color;
                leftborderbtn.Location = new Point(0, currentbtn.Location.Y);
                leftborderbtn.Visible = true;
                leftborderbtn.BringToFront();
                //current icon 
                currenttitleicon.IconChar = currentbtn.IconChar;
                currenttitleicon.IconColor = color;
                currenttitle.Text = currentbtn.Text;

            }
        }
        

        //childforms
        private void openchildform(Form childform)
        {
            if (titlebar != null)
            {
                //open only one form
                currentchildform = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                homepannel.Controls.Add(childform);
                childform.BringToFront();
                childform.Show();
                //all forms color change
                childform.BackColor = Color.FromArgb(39, 41, 61);
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            name.Text = login.user;
        }

        

        private void productbutton_Click(object sender, EventArgs e)
        {
            activatebutton(sender, rgbcolors.color1);
            openchildform(new product());
        }

        private void viewproductbutton_Click(object sender, EventArgs e)
        {
            activatebutton(sender, rgbcolors.color2);
            openchildform(new allproduct());
        }
        private void salesbutton_Click(object sender, EventArgs e)
        {
            activatebutton(sender, rgbcolors.color3);
            openchildform(new Sales());

        }

        private void addstockbutton_Click(object sender, EventArgs e)
        {
            activatebutton(sender, rgbcolors.color4);
            openchildform(new addstock());
        }

        private void reportbutton_Click(object sender, EventArgs e)
        {
            activatebutton(sender, rgbcolors.color5);
            openchildform(new report());
        }

        private void chngpassbutton_Click(object sender, EventArgs e)
        {
            activatebutton(sender, rgbcolors.color6);
            openchildform(new ChangePass());
        }

       private void aboutbutton_Click_1(object sender, EventArgs e)
        {
            activatebutton(sender, rgbcolors.color7);
            openchildform(new About());

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            activatebutton(sender, rgbcolors.color8);
            DialogResult res = MessageBox.Show("Are you want to exit ?","warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            switch(res)
            {
                case DialogResult.Yes: Application.Exit(); break;
                case DialogResult.No:  break;
            }
                
        }

        

        private void reset()
        {
            restorebutton();
            leftborderbtn.Visible = false;
            currenttitleicon.IconChar = IconChar.Home;
            currenttitleicon.IconColor = Color.Aqua;
            currenttitle.Text = "Home";
            homepannel.Controls.Clear();
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile(@"..\..\..\images\4.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(856, 466);
            homepannel.Controls.Add(pictureBox1);
        }
        private void add_pic()
        {
           
        }
        private void name_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login log = new login();
            DialogResult res = MessageBox.Show("Are you sure to logout ?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (res)
            {
                case DialogResult.Yes: this.Close(); log.Show(); break;
                case DialogResult.No:  break;
            }
            
            
        }
    }
}
