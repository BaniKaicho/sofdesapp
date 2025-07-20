using Microsoft.Data.SqlClient; // Changed from System.Data.SqlClient to Microsoft.Data.SqlClient
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace sofdesapp
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus TUF\OneDrive\Documents\Slotdb.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(
                "select Count(*) from Admin_tbl where Adminname='" + usernametb.Text + "' and adminpassword='" + passwordtb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            Con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Slot_Click(object sender, EventArgs e)
        {

        }
    }
}
//             //