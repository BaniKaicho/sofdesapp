using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Changed from System.Data.SqlClient to Microsoft.Data.SqlClient   

namespace sofdesapp
{
    public partial class AdminInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus TUF\OneDrive\Documents\Slotdb.mdf"";Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string MyQuery = "select * from Admin_tbl";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            admingridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        public AdminInfo()
        {
            InitializeComponent();
        }

        private void AdminInfo_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usergridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            adminidtb.Text = admingridview.SelectedRows[0].Cells[0].Value.ToString();
            adminnametb.Text = admingridview.SelectedRows[0].Cells[1].Value.ToString();
            passwordtb.Text = admingridview.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            string query = "delete from Admin_tbl where AdminID = " + adminidtb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Admin Deleted Successfully");
            Con.Close();
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into Admin_tbl values (@id, @name, @password)", Con);
            cmd.Parameters.AddWithValue("@id", adminidtb.Text);
            cmd.Parameters.AddWithValue("@name", adminnametb.Text);
            cmd.Parameters.AddWithValue("@password", passwordtb.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Admin Added Successfully");
            Con.Close();
            populate();
        }

        private void usernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void useridtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clientsearchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "select * from Admin_tbl where Adminname = '" + adminsearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            admingridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
    }
}
