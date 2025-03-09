namespace SalesManagementSystem.mainforms
{
    partial class Adduser
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new ePOSOne.btnProduct.Button_WOC();
            this.back = new FontAwesome.Sharp.IconButton();
            this.usrname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.conpass = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(92, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(92, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(36, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Confirn Password";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Black;
            this.Add.BorderColor = System.Drawing.Color.Aqua;
            this.Add.ButtonColor = System.Drawing.Color.Black;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Black;
            this.Add.Location = new System.Drawing.Point(388, 248);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.OnHoverBorderColor = System.Drawing.Color.Aqua;
            this.Add.OnHoverButtonColor = System.Drawing.Color.Black;
            this.Add.OnHoverTextColor = System.Drawing.Color.MintCream;
            this.Add.Size = new System.Drawing.Size(95, 42);
            this.Add.TabIndex = 66;
            this.Add.Text = "ADD";
            this.Add.TextColor = System.Drawing.Color.Aqua;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            this.back.IconColor = System.Drawing.Color.Aqua;
            this.back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.back.IconSize = 30;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(150, 248);
            this.back.Margin = new System.Windows.Forms.Padding(0);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.back.Size = new System.Drawing.Size(131, 40);
            this.back.TabIndex = 67;
            this.back.Text = "Back";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // usrname
            // 
            this.usrname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.usrname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usrname.Location = new System.Drawing.Point(199, 60);
            this.usrname.Margin = new System.Windows.Forms.Padding(2);
            this.usrname.Multiline = true;
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(284, 27);
            this.usrname.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.textBox2.Location = new System.Drawing.Point(199, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 2);
            this.textBox2.TabIndex = 68;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pass.Location = new System.Drawing.Point(199, 119);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(284, 27);
            this.pass.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.textBox3.Location = new System.Drawing.Point(199, 145);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(284, 2);
            this.textBox3.TabIndex = 70;
            // 
            // conpass
            // 
            this.conpass.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.conpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.conpass.Location = new System.Drawing.Point(199, 182);
            this.conpass.Margin = new System.Windows.Forms.Padding(2);
            this.conpass.Multiline = true;
            this.conpass.Name = "conpass";
            this.conpass.PasswordChar = '*';
            this.conpass.Size = new System.Drawing.Size(284, 27);
            this.conpass.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.textBox5.Location = new System.Drawing.Point(199, 208);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(284, 2);
            this.textBox5.TabIndex = 72;
            // 
            // Adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(529, 335);
            this.Controls.Add(this.conpass);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Adduser";
            this.Text = "Adduser";
            this.Load += new System.EventHandler(this.Adduser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC Add;
        private FontAwesome.Sharp.IconButton back;
        private System.Windows.Forms.TextBox usrname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox conpass;
        private System.Windows.Forms.TextBox textBox5;
    }
}