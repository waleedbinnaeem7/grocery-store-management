namespace Grocery_Store_Management
{
    partial class forget_password
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(116, 114);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(213, 20);
            this.txt_email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email id : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Enter Your Email Id";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(244, 222);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(82, 30);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Change";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Did you Forget your password?";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(122, 222);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(82, 30);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Back to login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password : ";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(116, 176);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(213, 20);
            this.txt_password.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type New Password";
            // 
            // forget_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 296);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Name = "forget_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forget_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
    }
} 