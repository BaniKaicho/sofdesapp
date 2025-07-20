using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Changed from System.Data.SqlClient to Microsoft.Data.SqlClient   


namespace sofdesapp
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus TUF\OneDrive\Documents\Slotdb.mdf"";Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string MyQuery = "select * from Equipment_tbl";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            roomgridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void adminnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void admingridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (roomgridview.SelectedRows.Count > 0)
            {
                roomtb.Text = roomgridview.SelectedRows[0].Cells[0].Value.ToString();
                equipmentb.Text = roomgridview.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void adminsearchtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "select * from Equipment_tbl where Equipment = '" + roomsearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            roomgridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            string isfree;
            if (yesradio.Checked == true)

                isfree = "Yes";
            else
                isfree = "No";


            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into Equipment_tbl (RoomID, Equipment, RoomFree) values (@room, @equipment, @isfree)", Con);
            cmd.Parameters.AddWithValue("@room", roomtb.Text);
            cmd.Parameters.AddWithValue("@equipment", equipmentb.Text);
            cmd.Parameters.AddWithValue("@isfree", isfree);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room Added Successfully");
            Con.Close();
            populate();
        }

        private void deleteroombtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roomtb.Text))
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            Con.Open();
            string query = "DELETE FROM Equipment_tbl WHERE RoomID = @roomid";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@roomid", roomtb.Text);
            int rowsAffected = cmd.ExecuteNonQuery();
            Con.Close();

            if (rowsAffected > 0)
                MessageBox.Show("Room Deleted Successfully");
            else
                MessageBox.Show("No room found with the specified RoomID.");

            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
