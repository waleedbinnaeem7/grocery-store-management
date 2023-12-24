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
    public partial class sales_form : Form
    {
        public sales_form()
        {
            InitializeComponent();
        }
         string db_path = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=cloth sales;Data Source=CYBERSPACE";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        {
            SqlConnection conn = new SqlConnection(db_path);
            SqlDataAdapter da = new SqlDataAdapter("select * from cloth_table where ID like '%"+txt_id.Text+"%' ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
        }
        }

       
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (com_product.Text == "" || txt_quantity.Text == "" || txt_tot_amount.Text == "" || txt_balance_amount.Text == "" || txt_balance_amount.Text == "")
                MessageBox.Show("Please fill all data");
            else
            {
                SqlConnection conn = new SqlConnection(db_path);
                conn.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into cloth_table(P_id,PRODUCT,QUANTITY,TOTAL_AMOUNT,PAID_AMOUNT,BALANCE )" +
                " Values ("+com_product.SelectedValue+",'" + com_product.Text + "' , '" + txt_quantity.Text + "','" + txt_tot_amount.Text + "' ,'" + txt_paid_amount.Text + "' ,'" + txt_balance_amount.Text + "')  select scope_identity()", conn);

              string new_id =   cmd.ExecuteScalar().ToString();
                conn.Close();
                MessageBox.Show("Record Inserted Successfully");
                BindAllRecord();
                ClearBoxes();
                Report r = new Report(new_id);
                r.Show();
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (com_product.Text == "" || txt_quantity.Text == "" || txt_tot_amount.Text == "" || txt_balance_amount.Text == "" || txt_balance_amount.Text == "")
                MessageBox.Show("Please fill all data");
            else
            {
                SqlConnection conn = new SqlConnection(db_path);
                conn.Close();
                conn.Open();

                SqlCommand cmd = new SqlCommand("update cloth_table set PRODUCT='" + com_product.Text + "',QUANTITY=" + txt_quantity.Text + "," +
                "   TOTAL_AMOUNT=" + txt_tot_amount.Text + ",PAID_AMOUNT=" + txt_paid_amount.Text + ",BALANCE=" + txt_balance_amount.Text + " where ID= " + txt_id.Text, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully");
                ClearBoxes();
            } 
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db_path);
            conn.Close();
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from cloth_table where ID=" + txt_id.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Deleted Successfully");
            ClearBoxes();
        }

        public void ClearBoxes()
        {
            txt_id.Clear();
            com_product.ResetText();
            txt_quantity.Clear();
            txt_tot_amount.Clear();
            txt_paid_amount.Clear();
            txt_balance_amount.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            com_product.ResetText();
            txt_quantity.Clear();
            txt_tot_amount.Clear();
            txt_paid_amount.Clear();
            txt_balance_amount.Clear();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            


            if (txt_id.Text == "")
            {
                MessageBox.Show("Please Input Invoice Id");

            }
            else
            {
                SqlConnection conn = new SqlConnection(db_path);

                SqlDataAdapter da = new SqlDataAdapter("select * from cloth_table where ID=" + txt_id.Text, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txt_id.Text = dt.Rows[0][0].ToString();
                     com_product.Text = dt.Rows[0][2].ToString();
                    txt_quantity.Text = dt.Rows[0][3].ToString();
                    txt_tot_amount.Text = dt.Rows[0][4].ToString();
                    txt_paid_amount.Text = dt.Rows[0][5].ToString();
                    txt_balance_amount.Text = dt.Rows[0][6].ToString();
                    com_product.SelectedValue = dt.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found..!");
                    ClearBoxes();
                }
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataRow dr;
            SqlConnection conn = new SqlConnection(db_path);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from cat_table", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            // for show in comboBox
            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Product--" };
            dt.Rows.InsertAt(dr, 0);

            com_product.ValueMember = "cat_id";
            com_product.DisplayMember = "cat_name";
            com_product.DataSource = dt;
            conn.Close();


            BindAllRecord();
        }

        public void BindAllRecord()
        {
            SqlConnection conn = new SqlConnection(db_path);
            SqlDataAdapter da = new SqlDataAdapter("select * from cloth_table", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
        }

        private void com_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                int rowindex = e.RowIndex;
                // DataGridViewRow row = this.dataGridView1.Rows[rowindex].Cells;

                txt_id.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            }
            if (e.RowIndex > -1)
            {
                int rowindex = e.RowIndex;
                // DataGridViewRow row = this.dataGridView1.Rows[rowindex].Cells;

                LBL_ID.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
              //  com_product.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                txt_quantity.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                txt_tot_amount.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                txt_paid_amount.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
                txt_balance_amount.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            }
               

        }

    }
}
