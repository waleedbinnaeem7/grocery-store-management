namespace Grocery_Store_Management
{
    partial class sales_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_tot_amount = new System.Windows.Forms.TextBox();
            this.txt_paid_amount = new System.Windows.Forms.TextBox();
            this.txt_balance_amount = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.com_product = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clothsalesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cloth_salesDataSet = new Grocery_Store_Management.cloth_salesDataSet();
            this.LBL_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothsalesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloth_salesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(48, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cloth Sales Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "#Invoice Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Amount ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Paid Amount ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Balance Amount";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(89, 227);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(174, 20);
            this.txt_quantity.TabIndex = 11;
            // 
            // txt_tot_amount
            // 
            this.txt_tot_amount.Location = new System.Drawing.Point(69, 319);
            this.txt_tot_amount.Name = "txt_tot_amount";
            this.txt_tot_amount.Size = new System.Drawing.Size(109, 20);
            this.txt_tot_amount.TabIndex = 12;
            // 
            // txt_paid_amount
            // 
            this.txt_paid_amount.Location = new System.Drawing.Point(218, 319);
            this.txt_paid_amount.Name = "txt_paid_amount";
            this.txt_paid_amount.Size = new System.Drawing.Size(110, 20);
            this.txt_paid_amount.TabIndex = 13;
            // 
            // txt_balance_amount
            // 
            this.txt_balance_amount.Location = new System.Drawing.Point(361, 319);
            this.txt_balance_amount.Name = "txt_balance_amount";
            this.txt_balance_amount.Size = new System.Drawing.Size(115, 20);
            this.txt_balance_amount.TabIndex = 14;
            this.txt_balance_amount.Text = "  ";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(75, 369);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 33);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(237, 369);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(73, 33);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(392, 369);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(73, 33);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(378, 68);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(191, 20);
            this.txt_id.TabIndex = 9;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(575, 65);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 24);
            this.btn_search.TabIndex = 18;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // com_product
            // 
            this.com_product.FormattingEnabled = true;
            this.com_product.Location = new System.Drawing.Point(89, 179);
            this.com_product.Name = "com_product";
            this.com_product.Size = new System.Drawing.Size(174, 21);
            this.com_product.TabIndex = 19;
            this.com_product.SelectedIndexChanged += new System.EventHandler(this.com_product_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(153, 427);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(217, 33);
            this.btn_reset.TabIndex = 21;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(671, 185);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clothsalesDataSetBindingSource
            // 
            this.clothsalesDataSetBindingSource.DataSource = this.cloth_salesDataSet;
            this.clothsalesDataSetBindingSource.Position = 0;
            // 
            // cloth_salesDataSet
            // 
            this.cloth_salesDataSet.DataSetName = "cloth_salesDataSet";
            this.cloth_salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LBL_ID
            // 
            this.LBL_ID.AutoSize = true;
            this.LBL_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ID.Location = new System.Drawing.Point(314, 34);
            this.LBL_ID.Name = "LBL_ID";
            this.LBL_ID.Size = new System.Drawing.Size(25, 13);
            this.LBL_ID.TabIndex = 23;
            this.LBL_ID.Text = "000";
            // 
            // sales_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 472);
            this.Controls.Add(this.LBL_ID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.com_product);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_balance_amount);
            this.Controls.Add(this.txt_paid_amount);
            this.Controls.Add(this.txt_tot_amount);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sales_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales form   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothsalesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloth_salesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_tot_amount;
        private System.Windows.Forms.TextBox txt_paid_amount;
        private System.Windows.Forms.TextBox txt_balance_amount;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox com_product;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clothsalesDataSetBindingSource;
        private cloth_salesDataSet cloth_salesDataSet;
        private System.Windows.Forms.Label LBL_ID;
    }
}

