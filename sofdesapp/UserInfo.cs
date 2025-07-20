using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace sofdesapp
{
    public partial class UserInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus TUF\OneDrive\Documents\Slotdb.mdf"";Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string MyQuery = "select * from User_tbl";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            usergridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "UPDATE User_tbl SET UserName = @UserName WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.Parameters.AddWithValue("@UserName", usernametb.Text);
            cmd.Parameters.AddWithValue("@UserId", int.Parse(useridtb.Text));
            int rowsAffected = cmd.ExecuteNonQuery();
            MessageBox.Show(rowsAffected > 0 ? "User Updated Successfully" : "No user found to update");
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "select * from User_tbl where UserName = '" + clientsearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            usergridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into User_tbl values (" + useridtb.Text + ", '" + usernametb.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Added Successfully");
            Con.Close();
            populate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void usergridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            useridtb.Text = usergridview.SelectedRows[0].Cells[0].Value.ToString();
            usernametb.Text = usergridview.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {


            Con.Open();
            string query = "delete from User_tbl where UserId = " + useridtb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Deleted Successfully");
            Con.Close();
            populate();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
    }
}
