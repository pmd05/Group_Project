using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Chatgpt
{
    public partial class RegisterForm : Form
    {
        // Giả lập cơ sở dữ liệu với danh sách người dùng
        private static List<User> userList = new List<User>();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
               SqlConnection con = new SqlConnection("Data Source=PMD\\SQLEXPRESS;Initial Catalog=userRegister;Integrated Security=True");
       SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Register1]
      ([fullname]
      ,[email]
      ,[password]
      ,[username]
      ,[phone]
      ,[gender])
VALUES
      ('" + txtFullName.Text + "', '" + txtEmail.Text + "', '" + txtPassword + "', '" + txtUser.Text + "', '" + txtPhone.Text + "', '" + cmbGender.SelectedItem.ToString() + "')", con);
      con.Open();
       cmd.ExecuteNonQuery();
       con.Close();
            // Lấy thông tin từ các textbox
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Kiểm tra tính hợp lệ của thông tin
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            if (IsEmailExists(email))
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng chọn email khác.");
                return;
            }

            // Tạo người dùng mới
            User newUser = new User
            {
                FullName = fullName,
                Email = email,
                Password = password
            };

            // Thêm người dùng vào danh sách
            userList.Add(newUser);

            MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.");
            this.Close(); // Đóng form đăng ký
        }

        // Hàm kiểm tra xem email đã tồn tại hay chưa
        private bool IsEmailExists(string email)
        {
            foreach (var user in userList)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        // Lớp người dùng để lưu thông tin
        public class User
        {
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
              
        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

    }
}
