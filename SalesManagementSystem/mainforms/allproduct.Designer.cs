namespace SalesManagementSystem
{
    partial class allproduct
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.salesDatabaseDataSet = new SalesManagementSystem.SalesDatabaseDataSet();
            this.salesDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet1 = new SalesManagementSystem.SalesDatabaseDataSet1();
            this.productlisttableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productlist_tableTableAdapter = new SalesManagementSystem.SalesDatabaseDataSet1TableAdapters.productlist_tableTableAdapter();
            this.all = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlisttableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(117, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 29);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button_WOC1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 101);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(298, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 38;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC1.BorderColor = System.Drawing.Color.Aqua;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.Black;
            this.button_WOC1.Location = new System.Drawing.Point(619, 10);
            this.button_WOC1.Margin = new System.Windows.Forms.Padding(2);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Aqua;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.MintCream;
            this.button_WOC1.Size = new System.Drawing.Size(90, 39);
            this.button_WOC1.TabIndex = 37;
            this.button_WOC1.Text = "Search";
            this.button_WOC1.TextColor = System.Drawing.Color.Aqua;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesDatabaseDataSetBindingSource
            // 
            this.salesDatabaseDataSetBindingSource.DataSource = this.salesDatabaseDataSet;
            this.salesDatabaseDataSetBindingSource.Position = 0;
            // 
            // salesDatabaseDataSet1
            // 
            this.salesDatabaseDataSet1.DataSetName = "SalesDatabaseDataSet1";
            this.salesDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productlisttableBindingSource
            // 
            this.productlisttableBindingSource.DataMember = "productlist_table";
            this.productlisttableBindingSource.DataSource = this.salesDatabaseDataSet1;
            // 
            // productlist_tableTableAdapter
            // 
            this.productlist_tableTableAdapter.ClearBeforeFill = true;
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.all.BorderColor = System.Drawing.Color.Aqua;
            this.all.ButtonColor = System.Drawing.Color.Black;
            this.all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all.ForeColor = System.Drawing.Color.Black;
            this.all.Location = new System.Drawing.Point(280, 118);
            this.all.Margin = new System.Windows.Forms.Padding(2);
            this.all.Name = "all";
            this.all.OnHoverBorderColor = System.Drawing.Color.Red;
            this.all.OnHoverButtonColor = System.Drawing.Color.Black;
            this.all.OnHoverTextColor = System.Drawing.Color.MintCream;
            this.all.Size = new System.Drawing.Size(205, 38);
            this.all.TabIndex = 39;
            this.all.Text = "ALL PRODUCTS";
            this.all.TextColor = System.Drawing.Color.Aqua;
            this.all.UseVisualStyleBackColor = false;
            this.all.Click += new System.EventHandler(this.all_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(611, 239);
            this.dataGridView1.TabIndex = 40;
            // 
            // allproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.all);
            this.Controls.Add(this.panel1);
            this.Name = "allproduct";
            this.Text = "allproduct";
            this.Load += new System.EventHandler(this.allproduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlisttableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource salesDatabaseDataSetBindingSource;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private SalesDatabaseDataSet1 salesDatabaseDataSet1;
        private System.Windows.Forms.BindingSource productlisttableBindingSource;
        private SalesDatabaseDataSet1TableAdapters.productlist_tableTableAdapter productlist_tableTableAdapter;
        private ePOSOne.btnProduct.Button_WOC all;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}