using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5951071080_NguyenQuangPhuoc_WF
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VJCSEGK\SQLEXPRESS;Initial Catalog=DemoCRUD_WF;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //ket noi Db
            GetStudensRecord();
        }
        private void GetStudensRecord()
        {
            //Truy van Db
            
            SqlCommand cmd = new SqlCommand("SELECT * from tbl_Student", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private bool IsValidData()
        {
            if(txb_Hoten.Text == string.Empty
                || txb_Ten.Text == string.Empty
                || txb_Address.Text == string.Empty
                || string.IsNullOrEmpty(txb_Sdt.Text)
                || string.IsNullOrEmpty(txb_SBD.Text))
            {
                MessageBox.Show("Có chỗ chưa nhập dữ liệu !! ",
                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SqlCommand cmd = new SqlCommand("Insert Into tbl_Student Values" +
                    "(@Name, @FatherName @RollNumber, @Address , @Mobile )", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txb_Hoten.Text);
                cmd.Parameters.AddWithValue("@FatherName", txb_Ten.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txb_SBD.Text);
                cmd.Parameters.AddWithValue("@Address", txb_Address.Text);
                cmd.Parameters.AddWithValue("@Mobile", txb_Sdt.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudensRecord();
            }
        }
        public int StudentID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            txb_Hoten.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txb_Ten.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txb_SBD.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txb_Address.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txb_Sdt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE  tbl_Student SET" +
                    "Name = @Name, FatherName = @FatherName," +
                    " RollNumber = @RollNumber, Adress= @Address," +
                    "Mobile = @Mobile Where StudentID =StudentID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txb_Hoten.Text);
                cmd.Parameters.AddWithValue("@FatherName", txb_Ten.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txb_SBD.Text);
                cmd.Parameters.AddWithValue("@Address", txb_Address.Text);
                cmd.Parameters.AddWithValue("@Mobile", txb_Sdt.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudensRecord();
                
            }
            else
            {
                MessageBox.Show("Cập nhật bị lỗi!!", "Lỗi!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("Delete From tbl_Student Where StudentID= @StudentID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@StudentID", this.StudentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStudensRecord();
            }
        }
    }
}
