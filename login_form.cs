using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Grocery_Store_Management
{
    public partial class login_form : Form
    {
        hashCode hc = new hashCode();
        public login_form()
        {
            InitializeComponent();
        }
        string db_path = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=cloth sales;Data Source=CYBERSPACE";

        private void btn_login_Click(object sender, EventArgs e)
        { SqlConnection con = new SqlConnection(db_path);
        SqlCommand cmd = new SqlCommand("select * from reg_table where user_name=@user_name and password =@password", con);
        cmd.Parameters.AddWithValue("@user_name", txt_id.Text);  
            cmd.Parameters.AddWithValue("@password", hc.pass_hash( txt_password.Text));  
            SqlDataAdapter sda = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();  
            sda.Fill(dt);  
            //Connection open here   
            con.Open();  
            int i = cmd.ExecuteNonQuery();  
            con.Close();  
            if (dt.Rows.Count > 0) {  
                //MessageBox.Show("Successfully loged in");  
                ////after successful it will redirect  to next page .  
                sales_form sales = new sales_form();  
                sales.Show();  
            } else {  
                MessageBox.Show("Please enter Correct Username or Password");  
            }  
            ClearBoxes();
        
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            registration_form reg = new registration_form();
            reg.Show();
        }
        public void ClearBoxes()
        {
            txt_id.Clear();
            txt_password.Clear();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            
            
             
            
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
        } 

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget_password change_pass = new forget_password();
            change_pass.Show();
        
        }
    }
}
