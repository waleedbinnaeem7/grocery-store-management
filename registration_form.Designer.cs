namespace Grocery_Store_Management
{
    partial class registration_form
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_country = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(131, 93);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(357, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(131, 130);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(357, 20);
            this.txt_email.TabIndex = 2;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(131, 293);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(357, 70);
            this.txt_address.TabIndex = 5;
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.Location = new System.Drawing.Point(130, 264);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(48, 17);
            this.rdo_male.TabIndex = 6;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Male";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.Location = new System.Drawing.Point(268, 264);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(59, 17);
            this.rdo_female.TabIndex = 7;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "Female";
            this.rdo_female.UseVisualStyleBackColor = true;
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.Location = new System.Drawing.Point(409, 392);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(79, 33);
            this.btn_sign_up.TabIndex = 8;
            this.btn_sign_up.Text = "Sign Up";
            this.btn_sign_up.UseVisualStyleBackColor = true;
            this.btn_sign_up.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Conutry:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmb_country
            // 
            this.cmb_country.FormattingEnabled = true;
            this.cmb_country.Location = new System.Drawing.Point(131, 197);
            this.cmb_country.Name = "cmb_country";
            this.cmb_country.Size = new System.Drawing.Size(357, 21);
            this.cmb_country.TabIndex = 16;
            this.cmb_country.SelectedIndexChanged += new System.EventHandler(this.cmb_country_SelectedIndexChanged);
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(131, 232);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(357, 21);
            this.cmb_city.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(176, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Registration Form";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Password:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(130, 163);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(357, 20);
            this.txt_pass.TabIndex = 19;
            // 
            // registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 466);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.cmb_country);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sign_up);
            this.Controls.Add(this.rdo_female);
            this.Controls.Add(this.rdo_male);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Name = "registration_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registration_form";
            this.Load += new System.EventHandler(this.registration_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.RadioButton rdo_female;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_country;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pass;
    }
}