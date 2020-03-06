namespace Point_Of_Sale
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Product = new System.Windows.Forms.Button();
            this.Del_Product = new System.Windows.Forms.Button();
            this.Edit_Product = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.Load_Product = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Product_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.ComboBox();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileManagementToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileManagementToolStripMenuItem
            // 
            this.profileManagementToolStripMenuItem.Name = "profileManagementToolStripMenuItem";
            this.profileManagementToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.profileManagementToolStripMenuItem.Text = "Profile Management";
            this.profileManagementToolStripMenuItem.Click += new System.EventHandler(this.profileManagementToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Add_Product
            // 
            this.Add_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Add_Product.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.Add_Product.FlatAppearance.BorderSize = 0;
            this.Add_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Product.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product.ForeColor = System.Drawing.Color.White;
            this.Add_Product.Image = ((System.Drawing.Image)(resources.GetObject("Add_Product.Image")));
            this.Add_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Product.Location = new System.Drawing.Point(458, 249);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(146, 67);
            this.Add_Product.TabIndex = 5;
            this.Add_Product.Text = "        ADD";
            this.Add_Product.UseVisualStyleBackColor = false;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // Del_Product
            // 
            this.Del_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Del_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Del_Product.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Del_Product.ForeColor = System.Drawing.Color.White;
            this.Del_Product.Image = ((System.Drawing.Image)(resources.GetObject("Del_Product.Image")));
            this.Del_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del_Product.Location = new System.Drawing.Point(615, 249);
            this.Del_Product.Name = "Del_Product";
            this.Del_Product.Size = new System.Drawing.Size(146, 67);
            this.Del_Product.TabIndex = 8;
            this.Del_Product.Text = "DELETE";
            this.Del_Product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Del_Product.UseVisualStyleBackColor = false;
            this.Del_Product.Click += new System.EventHandler(this.Del_Product_Click);
            // 
            // Edit_Product
            // 
            this.Edit_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Edit_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_Product.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Product.ForeColor = System.Drawing.Color.White;
            this.Edit_Product.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Product.Image")));
            this.Edit_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Product.Location = new System.Drawing.Point(458, 338);
            this.Edit_Product.Name = "Edit_Product";
            this.Edit_Product.Size = new System.Drawing.Size(146, 67);
            this.Edit_Product.TabIndex = 6;
            this.Edit_Product.Text = "       EDIT";
            this.Edit_Product.UseVisualStyleBackColor = false;
            this.Edit_Product.Click += new System.EventHandler(this.Edit_Product_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(454, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(572, 47);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(156, 32);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // Load_Product
            // 
            this.Load_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Load_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Load_Product.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.Load_Product.ForeColor = System.Drawing.Color.White;
            this.Load_Product.Image = ((System.Drawing.Image)(resources.GetObject("Load_Product.Image")));
            this.Load_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Load_Product.Location = new System.Drawing.Point(615, 338);
            this.Load_Product.Name = "Load_Product";
            this.Load_Product.Size = new System.Drawing.Size(146, 67);
            this.Load_Product.TabIndex = 7;
            this.Load_Product.Text = "       LOAD";
            this.Load_Product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Load_Product.UseVisualStyleBackColor = false;
            this.Load_Product.Click += new System.EventHandler(this.Load_Product_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(421, 309);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(570, 149);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(156, 32);
            this.txt_Price.TabIndex = 3;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // txt_Product_Name
            // 
            this.txt_Product_Name.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product_Name.Location = new System.Drawing.Point(570, 96);
            this.txt_Product_Name.Multiline = true;
            this.txt_Product_Name.Name = "txt_Product_Name";
            this.txt_Product_Name.Size = new System.Drawing.Size(156, 32);
            this.txt_Product_Name.TabIndex = 2;
            this.txt_Product_Name.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(454, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product Name";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.txt_Quantity.Location = new System.Drawing.Point(570, 199);
            this.txt_Quantity.Multiline = true;
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(156, 32);
            this.txt_Quantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(454, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantity";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(182, 359);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(203, 32);
            this.search.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(391, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbox
            // 
            this.searchbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchbox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.FormattingEnabled = true;
            this.searchbox.Items.AddRange(new object[] {
            "Search by ID",
            "Search by Name"});
            this.searchbox.Location = new System.Drawing.Point(12, 362);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(164, 26);
            this.searchbox.TabIndex = 24;
            this.searchbox.SelectedIndexChanged += new System.EventHandler(this.searchbox_SelectedIndexChanged);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(779, 417);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.Add_Product);
            this.Controls.Add(this.Del_Product);
            this.Controls.Add(this.Edit_Product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Load_Product);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Product_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.Button Del_Product;
        private System.Windows.Forms.Button Edit_Product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button Load_Product;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Product_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox searchbox;
        private System.Windows.Forms.ToolStripMenuItem profileManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
    }
}