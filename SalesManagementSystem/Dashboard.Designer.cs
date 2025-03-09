namespace SalesManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.titlebar = new System.Windows.Forms.Panel();
            this.currenttitleicon = new FontAwesome.Sharp.IconPictureBox();
            this.currenttitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new FontAwesome.Sharp.IconButton();
            this.aboutbutton = new FontAwesome.Sharp.IconButton();
            this.viewproductbutton = new FontAwesome.Sharp.IconButton();
            this.exitbutton = new FontAwesome.Sharp.IconButton();
            this.productbutton = new FontAwesome.Sharp.IconButton();
            this.chngpassbutton = new FontAwesome.Sharp.IconButton();
            this.salesbutton = new FontAwesome.Sharp.IconButton();
            this.reportbutton = new FontAwesome.Sharp.IconButton();
            this.addstockbutton = new FontAwesome.Sharp.IconButton();
            this.homepannel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currenttitleicon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.homepannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.titlebar.Controls.Add(this.currenttitleicon);
            this.titlebar.Controls.Add(this.currenttitle);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(328, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(964, 120);
            this.titlebar.TabIndex = 5;
            // 
            // currenttitleicon
            // 
            this.currenttitleicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.currenttitleicon.ForeColor = System.Drawing.Color.Aqua;
            this.currenttitleicon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currenttitleicon.IconColor = System.Drawing.Color.Aqua;
            this.currenttitleicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currenttitleicon.IconSize = 43;
            this.currenttitleicon.Location = new System.Drawing.Point(337, 33);
            this.currenttitleicon.Margin = new System.Windows.Forms.Padding(0);
            this.currenttitleicon.Name = "currenttitleicon";
            this.currenttitleicon.Size = new System.Drawing.Size(45, 43);
            this.currenttitleicon.TabIndex = 5;
            this.currenttitleicon.TabStop = false;
            // 
            // currenttitle
            // 
            this.currenttitle.AutoSize = true;
            this.currenttitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currenttitle.ForeColor = System.Drawing.Color.MintCream;
            this.currenttitle.Location = new System.Drawing.Point(382, 33);
            this.currenttitle.Margin = new System.Windows.Forms.Padding(0);
            this.currenttitle.Name = "currenttitle";
            this.currenttitle.Size = new System.Drawing.Size(117, 40);
            this.currenttitle.TabIndex = 1;
            this.currenttitle.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(19, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 102);
            this.panel2.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.MintCream;
            this.name.Location = new System.Drawing.Point(69, 25);
            this.name.Margin = new System.Windows.Forms.Padding(0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 33);
            this.name.TabIndex = 2;
            this.name.Text = "AdminName";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Aqua;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Aqua;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 57;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 15);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(67, 57);
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.aboutbutton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.viewproductbutton);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Controls.Add(this.productbutton);
            this.panel1.Controls.Add(this.chngpassbutton);
            this.panel1.Controls.Add(this.salesbutton);
            this.panel1.Controls.Add(this.reportbutton);
            this.panel1.Controls.Add(this.addstockbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 586);
            this.panel1.TabIndex = 6;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Black;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.logout.IconColor = System.Drawing.Color.White;
            this.logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout.IconSize = 30;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(16, 374);
            this.logout.Margin = new System.Windows.Forms.Padding(0);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logout.Size = new System.Drawing.Size(309, 42);
            this.logout.TabIndex = 20;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // aboutbutton
            // 
            this.aboutbutton.BackColor = System.Drawing.Color.Black;
            this.aboutbutton.FlatAppearance.BorderSize = 0;
            this.aboutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbutton.ForeColor = System.Drawing.Color.White;
            this.aboutbutton.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.aboutbutton.IconColor = System.Drawing.Color.White;
            this.aboutbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.aboutbutton.IconSize = 30;
            this.aboutbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutbutton.Location = new System.Drawing.Point(16, 416);
            this.aboutbutton.Margin = new System.Windows.Forms.Padding(0);
            this.aboutbutton.Name = "aboutbutton";
            this.aboutbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.aboutbutton.Size = new System.Drawing.Size(309, 42);
            this.aboutbutton.TabIndex = 19;
            this.aboutbutton.Text = "About";
            this.aboutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutbutton.UseVisualStyleBackColor = false;
            this.aboutbutton.Click += new System.EventHandler(this.aboutbutton_Click_1);
            // 
            // viewproductbutton
            // 
            this.viewproductbutton.BackColor = System.Drawing.Color.Black;
            this.viewproductbutton.FlatAppearance.BorderSize = 0;
            this.viewproductbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewproductbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewproductbutton.ForeColor = System.Drawing.Color.White;
            this.viewproductbutton.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.viewproductbutton.IconColor = System.Drawing.Color.White;
            this.viewproductbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.viewproductbutton.IconSize = 30;
            this.viewproductbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewproductbutton.Location = new System.Drawing.Point(16, 174);
            this.viewproductbutton.Margin = new System.Windows.Forms.Padding(0);
            this.viewproductbutton.Name = "viewproductbutton";
            this.viewproductbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.viewproductbutton.Size = new System.Drawing.Size(309, 40);
            this.viewproductbutton.TabIndex = 12;
            this.viewproductbutton.Text = "View Products";
            this.viewproductbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewproductbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewproductbutton.UseVisualStyleBackColor = false;
            this.viewproductbutton.Click += new System.EventHandler(this.viewproductbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Black;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.exitbutton.IconColor = System.Drawing.Color.White;
            this.exitbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitbutton.IconSize = 30;
            this.exitbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitbutton.Location = new System.Drawing.Point(16, 458);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.exitbutton.Size = new System.Drawing.Size(309, 40);
            this.exitbutton.TabIndex = 18;
            this.exitbutton.Text = "Exit";
            this.exitbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // productbutton
            // 
            this.productbutton.BackColor = System.Drawing.Color.Black;
            this.productbutton.FlatAppearance.BorderSize = 0;
            this.productbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productbutton.ForeColor = System.Drawing.Color.White;
            this.productbutton.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.productbutton.IconColor = System.Drawing.Color.White;
            this.productbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productbutton.IconSize = 30;
            this.productbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productbutton.Location = new System.Drawing.Point(16, 134);
            this.productbutton.Margin = new System.Windows.Forms.Padding(0);
            this.productbutton.Name = "productbutton";
            this.productbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.productbutton.Size = new System.Drawing.Size(309, 40);
            this.productbutton.TabIndex = 13;
            this.productbutton.Text = "Product Management";
            this.productbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productbutton.UseVisualStyleBackColor = false;
            this.productbutton.Click += new System.EventHandler(this.productbutton_Click);
            // 
            // chngpassbutton
            // 
            this.chngpassbutton.BackColor = System.Drawing.Color.Black;
            this.chngpassbutton.FlatAppearance.BorderSize = 0;
            this.chngpassbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chngpassbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chngpassbutton.ForeColor = System.Drawing.Color.White;
            this.chngpassbutton.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.chngpassbutton.IconColor = System.Drawing.Color.White;
            this.chngpassbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.chngpassbutton.IconSize = 30;
            this.chngpassbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chngpassbutton.Location = new System.Drawing.Point(16, 334);
            this.chngpassbutton.Margin = new System.Windows.Forms.Padding(0);
            this.chngpassbutton.Name = "chngpassbutton";
            this.chngpassbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.chngpassbutton.Size = new System.Drawing.Size(309, 42);
            this.chngpassbutton.TabIndex = 17;
            this.chngpassbutton.Text = "Change Password";
            this.chngpassbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chngpassbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chngpassbutton.UseVisualStyleBackColor = false;
            this.chngpassbutton.Click += new System.EventHandler(this.chngpassbutton_Click);
            // 
            // salesbutton
            // 
            this.salesbutton.BackColor = System.Drawing.Color.Black;
            this.salesbutton.FlatAppearance.BorderSize = 0;
            this.salesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesbutton.ForeColor = System.Drawing.Color.White;
            this.salesbutton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingDollar;
            this.salesbutton.IconColor = System.Drawing.Color.White;
            this.salesbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salesbutton.IconSize = 30;
            this.salesbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesbutton.Location = new System.Drawing.Point(14, 214);
            this.salesbutton.Margin = new System.Windows.Forms.Padding(0);
            this.salesbutton.Name = "salesbutton";
            this.salesbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.salesbutton.Size = new System.Drawing.Size(311, 40);
            this.salesbutton.TabIndex = 14;
            this.salesbutton.Text = "Sales";
            this.salesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesbutton.UseVisualStyleBackColor = false;
            this.salesbutton.Click += new System.EventHandler(this.salesbutton_Click);
            // 
            // reportbutton
            // 
            this.reportbutton.BackColor = System.Drawing.Color.Black;
            this.reportbutton.FlatAppearance.BorderSize = 0;
            this.reportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbutton.ForeColor = System.Drawing.Color.White;
            this.reportbutton.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.reportbutton.IconColor = System.Drawing.Color.White;
            this.reportbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportbutton.IconSize = 30;
            this.reportbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportbutton.Location = new System.Drawing.Point(16, 294);
            this.reportbutton.Margin = new System.Windows.Forms.Padding(0);
            this.reportbutton.Name = "reportbutton";
            this.reportbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.reportbutton.Size = new System.Drawing.Size(309, 40);
            this.reportbutton.TabIndex = 16;
            this.reportbutton.Text = "Reports";
            this.reportbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportbutton.UseVisualStyleBackColor = false;
            this.reportbutton.Click += new System.EventHandler(this.reportbutton_Click);
            // 
            // addstockbutton
            // 
            this.addstockbutton.BackColor = System.Drawing.Color.Black;
            this.addstockbutton.FlatAppearance.BorderSize = 0;
            this.addstockbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstockbutton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstockbutton.ForeColor = System.Drawing.Color.White;
            this.addstockbutton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addstockbutton.IconColor = System.Drawing.Color.White;
            this.addstockbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addstockbutton.IconSize = 30;
            this.addstockbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstockbutton.Location = new System.Drawing.Point(16, 254);
            this.addstockbutton.Margin = new System.Windows.Forms.Padding(0);
            this.addstockbutton.Name = "addstockbutton";
            this.addstockbutton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addstockbutton.Size = new System.Drawing.Size(309, 40);
            this.addstockbutton.TabIndex = 15;
            this.addstockbutton.Text = "Add Stock";
            this.addstockbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addstockbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addstockbutton.UseVisualStyleBackColor = false;
            this.addstockbutton.Click += new System.EventHandler(this.addstockbutton_Click);
            // 
            // homepannel
            // 
            this.homepannel.BackColor = System.Drawing.Color.Black;
            this.homepannel.Controls.Add(this.pictureBox1);
            this.homepannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepannel.Location = new System.Drawing.Point(328, 120);
            this.homepannel.Name = "homepannel";
            this.homepannel.Size = new System.Drawing.Size(964, 466);
            this.homepannel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(964, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1292, 586);
            this.Controls.Add(this.homepannel);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currenttitleicon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.homepannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Label currenttitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox currenttitleicon;
        private FontAwesome.Sharp.IconButton viewproductbutton;
        private FontAwesome.Sharp.IconButton exitbutton;
        private FontAwesome.Sharp.IconButton productbutton;
        private FontAwesome.Sharp.IconButton chngpassbutton;
        private FontAwesome.Sharp.IconButton salesbutton;
        private FontAwesome.Sharp.IconButton reportbutton;
        private FontAwesome.Sharp.IconButton addstockbutton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel homepannel;
        private FontAwesome.Sharp.IconButton aboutbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton logout;
    }
}