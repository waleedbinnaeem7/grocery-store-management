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
    public partial class forget_password : Form
    {
        public forget_password()
        {
            InitializeComponent();
        }

        public void ClearBoxes()
        {
            txt_email.Clear();
            txt_password.Clear();
        }


        string db_path = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=cloth sales;Data Source=CYBERSPACE";

        private void btn_login_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
        }


        private void btn_send_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn1 = new SqlConnection(db_path);
            conn1.Close();
            conn1.Open();
            SqlDataAdapter da = new SqlDataAdapter("select email_id from reg_table where email_id = '"+txt_email.Text+"'" ,  conn1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>0)
            {

                SqlCommand cmd = new SqlCommand("update reg_table set password= '" + txt_password.Text + "'    where email_id= '" + txt_email.Text + "' ", conn1);
                cmd.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show("Password Updated Successfully");
                sales_form sales = new sales_form();
                sales.Show();
                ClearBoxes();
            }
                    
            else
            {
                MessageBox.Show("Invalid email");
            }
            }
                 


            }



    }