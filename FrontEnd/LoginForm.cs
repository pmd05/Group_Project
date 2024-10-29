using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatgpt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
private void btnLogin_Click(object sender, EventArgs e)
        {
        
            // Lấy thông tin email và mật khẩu từ các TextBox
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Kiểm tra đăng nhập (Giả lập)
            if (email == "customer@example.com" && password == "password123")
            {
                // Thông báo đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form chính sau khi đăng nhập thành công
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            
            else
            {
                // Thông báo nếu đăng nhập thất bại
                MessageBox.Show("Email hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); // Ẩn form đăng nhập
        }
        
    }
}
