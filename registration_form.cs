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
using System.Security.Cryptography;

namespace Grocery_Store_Management
{
    public partial class registration_form : Form
    {
        hashCode hc = new hashCode();
        public registration_form()
        {
            InitializeComponent();
        }

       
        string db_path = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=cloth sales;Data Source=CYBERSPACE";

       



        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void ClearBoxes()
        {
            txt_name.Text = "";
            txt_pass.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            cmb_country.ResetText();
            cmb_city.ResetText();
            rdo_female.Checked=false;
            rdo_male.Checked = false;

        }
        private void registration_form_Load(object sender, EventArgs e)
        {
            DataRow dr;
            SqlConnection conn = new SqlConnection(db_path);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from country_table", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // for show in comboBox
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Country--" };
            dt.Rows.InsertAt(dr, 0);

            cmb_country.ValueMember = "country_id";
            cmb_country.DisplayMember = "country";
            cmb_country.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)


        {
           
             {
            if (txt_name.Text == "" || txt_email.Text == "" || txt_pass.Text == "" || cmb_country.Text == "" || cmb_city.Text == "" || txt_address.Text == "" )
                MessageBox.Show("Please fill all data");
            else
            { 
                SqlConnection conn = new SqlConnection(db_path);
                conn.Close();
                conn.Open();

                string _gender = "";
                if (rdo_male.Checked == true) { _gender = "Male"; }
                if (rdo_female.Checked == true) { _gender = "Female"; }

                SqlCommand cmd = new SqlCommand("insert into reg_table(user_name,email_id,password,country,city,gender,address )" +
                " Values ('" + txt_name.Text + "' , '" + txt_email.Text + "','" + hc.pass_hash (txt_pass.Text) + "' ,'" + cmb_country.Text + "' ,'" + cmb_city.Text + "' , '" + _gender + "', '" + txt_address.Text + "')", conn);
                 
                 cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Congratulations! Signed UP Successfully");
                ClearBoxes();
                sales_form sales = new sales_form();
                sales.Show();  
               
            }
        }
    }

        private void cmb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
           
               if (cmb_country.SelectedValue.ToString() !=null )

               {
                   
               
            SqlConnection conn = new SqlConnection(db_path);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select 0 city_id, '--Select city--' city_name union all select city_id, city_name from city_table where country_id= " + cmb_country.SelectedValue, conn);
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            

            cmb_city.ValueMember = "city_id";
            cmb_city.DisplayMember = "city_name";
            cmb_city.DataSource = dt;
            conn.Close();

                }

            }
        
        }


    }
