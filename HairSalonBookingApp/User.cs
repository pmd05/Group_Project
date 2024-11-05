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

namespace HairSalonBookingApp
{
    public partial class User : Form
    {
        bool SidebarExpand;
        bool homeCollapsed;
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public User()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;  
                    sidebarTimer.Stop();
                    sidebarTimer.Enabled = false; 
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    sidebarTimer.Stop();
                    Sidebar.Expand = false;
                }
            }
        }

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void HomeContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    SettingTimer.Stop();
                }
            }
            else
            {
                HomeContainer.Height -= 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    SettingTimer.Stop();
                }

            } 
        }

        private void button17_Click(object sender, EventArgs e)
            {
            SettingTimer.Start();
            }

        private void button16_Click_1(object sender, EventArgs e)
            {
            MainForm mForm = new MainForm();
            mForm.Show();
            this.Hide();
            }
        private void textBox2_TextChanged(object sender, EventArgs e)
            {
                string fullName = textBox2.Text.Trim(); 
                if (string.IsNullOrEmpty(fullName))
                    {
                    errorProvider1.SetError(textBox2, "Vui lòng nhập họ tên.");
                    }
                else
                    {
                        errorProvider1.SetError(textBox2, "");
                    }
            }
        private void textBox2_Leave(object sender, EventArgs e)
            {
                textBox2_TextChanged(sender, e);   
            }
        private void textBox1_TextChanged(object sender, EventArgs e)
            {
                string phone = textBox1.Text;
                if (!Regex.IsMatch(phone, @"^\d{10}$"))
                    {
                        errorProvider1.SetError(textBox1, "Số điện thoại không hợp lệ. Vui lòng nhập 10 số.");
                    }
                else
                    {
                        errorProvider1.SetError(textBox1, "");
                    }
            }
        private void textBox1_Leave(object sender, EventArgs e)
            {
                textBox1_TextChanged(sender, e); 
            }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Cắt tóc: Dịch vụ cắt tóc nam/nữ, tạo kiểu theo yêu cầu. Giá cả tùy thuộc vào độ dài và kiểu tóc.");
            }

        private void button6_Click(object sender, EventArgs e)
            {

            }

        private void button3_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Uốn tóc: Dịch vụ uốn tóc xoăn, uốn duỗi, phục hồi hư tổn.  Giá cả tùy thuộc vào độ dài và loại tóc.");
            }

        private void button4_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Nhuộm tóc: Dịch vụ nhuộm tóc với nhiều màu sắc đa dạng. Giá cả tùy thuộc vào độ dài và loại thuốc nhuộm.");
            }

        private void button5_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Dịch vụ gội đầu thư giãn, sử dụng dầu gội và dầu xả chất lượng cao. Giá cả cố định.");
            }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

        private void button14_Click(object sender, EventArgs e)
            {

            }

        private void button12_Click(object sender, EventArgs e)
            {

            }
    }
}
