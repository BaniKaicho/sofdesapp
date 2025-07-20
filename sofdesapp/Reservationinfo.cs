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
    public partial class Reservationinfo : Form
    {
        public Reservationinfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus TUF\OneDrive\Documents\Slotdb.mdf"";Integrated Security=True;Connect Timeout=30");
        DateTime today;
        public void populate()
        {
            Con.Open();
            string MyQuery = "select * from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            if (reservationgridview != null)
            {
                reservationgridview.DataSource = ds.Tables[0];
            }
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }
        public void fillroomnum()
        {
            Con.Open();
            string roomstate = "Yes";
            SqlCommand cmd = new SqlCommand("select RoomID from Equipment_tbl where RoomFree = '" + roomstate + "' ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomID", typeof(int));
            dt.Load(rdr);
            if (roomnum != null)
            {
                roomnum.ValueMember = "RoomID";
                roomnum.DataSource = dt;
            }
            Con.Close();
        }
        public void fillusername()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select UserName from User_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UserName", typeof(string));
            dt.Load(rdr);
            if (username != null)
            {
                username.ValueMember = "UserName";
                username.DataSource = dt;
            }
            Con.Close();
        }
        public void updateroomstate()
        {
            if (roomnum.SelectedValue == null)
            {
                MessageBox.Show("No room selected to update.");
                return;
            }

            Con.Open();
            string newstate = "No";
            string myquery = "update Equipment_tbl set RoomFree = @newstate where RoomID = @roomid";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.Parameters.AddWithValue("@newstate", newstate);
            cmd.Parameters.AddWithValue("@roomid", roomnum.SelectedValue);
            cmd.ExecuteNonQuery();
            Con.Close();
            fillroomnum();
        }


        private void Reservationinfo_Load(object sender, EventArgs e)
        {
            today = DateTime.Today;
            fillroomnum();
            fillusername();
            timein.Format = DateTimePickerFormat.Time;
            timein.ShowUpDown = true;
            timeout.Format = DateTimePickerFormat.Time;
            timeout.ShowUpDown = true;
            populate();
            Datelbl.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        private void adminidtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(timein.Value, today);
            if (res < 0)

                MessageBox.Show("Time In cannot be in the past.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(timeout.Value, timein.Value);
            if (res < 0)

                MessageBox.Show("Time Out cannot be in the past.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }

            if (!int.TryParse(reservationidtb.Text, out int resid))
            {
                MessageBox.Show("Please enter a valid integer for Reservation Id.");
                Con.Close();
                return;
            }

            if (username.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid user.");
                Con.Close();
                return;
            }

            if (roomnum.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid room.");
                Con.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Reservation_tbl (Resid, [User], Room, DateIn, DateOut) VALUES (@id, @user, @room, @timein, @timeout)", Con);
            cmd.Parameters.AddWithValue("@id", resid);
            cmd.Parameters.AddWithValue("@user", username.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@room", roomnum.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@timein", timein.Value);
            cmd.Parameters.AddWithValue("@timeout", timeout.Value);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Added Successfully");
            Con.Close();
            updateroomstate();
            populate();

        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            if (reservationidtb.Text == "")
            {
                MessageBox.Show("Please enter a Reservation ID to delete.");
            }
            else
            {
                Con.Open();

                // Get the room number of the reservation to be deleted
                string getRoomQuery = "SELECT Room FROM Reservation_tbl WHERE Resid = @id";
                SqlCommand getRoomCmd = new SqlCommand(getRoomQuery, Con);
                getRoomCmd.Parameters.AddWithValue("@id", int.Parse(reservationidtb.Text));
                object roomIdObj = getRoomCmd.ExecuteScalar();

                if (roomIdObj != null)
                {
                    int roomId = Convert.ToInt32(roomIdObj);

                    // Delete the reservation
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Reservation_tbl WHERE Resid = @id", Con);
                    deleteCmd.Parameters.AddWithValue("@id", int.Parse(reservationidtb.Text));
                    deleteCmd.ExecuteNonQuery();

                    // Update the room back to available
                    SqlCommand updateRoomCmd = new SqlCommand("UPDATE Equipment_tbl SET RoomFree = 'Yes' WHERE RoomID = @roomid", Con);
                    updateRoomCmd.Parameters.AddWithValue("@roomid", roomId);
                    updateRoomCmd.ExecuteNonQuery();
                }

                Con.Close();
                populate();
                fillroomnum();
            }
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values (" + reservationidtb.Text + ", '" + username.SelectedValue.ToString() + ", '" + roomnum.SelectedValue.ToString() + ",'" + timein.Value + ",'" + timeout.Text + ")", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Added Successfully");
            Con.Close();
            populate();
        }

        private void username_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void reservationgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (reservationgridview.SelectedRows.Count > 0)
            {
                var selectedRow = reservationgridview.SelectedRows[0];
                if (selectedRow.Cells[0].Value != null)
                    reservationidtb.Text = selectedRow.Cells[0].Value.ToString();
                if (selectedRow.Cells[1].Value != null)
                    username.Text = selectedRow.Cells[1].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string MyQuery = "select * from Reservation_tbl where Resid = '" + reservationsearchtb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            reservationgridview.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void roomnum_SelectedIndexChanged(object sender, EventArgs e)
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


