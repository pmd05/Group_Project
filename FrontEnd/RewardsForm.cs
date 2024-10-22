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
    public partial class RewardsForm : Form
    {
        public RewardsForm()
        {
            InitializeComponent();
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            // Lấy nội dung phản hồi
            string feedback = txtFeedback.Text;

            // Giả lập gửi phản hồi
            MessageBox.Show("Phản hồi của bạn đã được ghi nhận!");

            // Tính toán điểm thưởng giả lập
            int points = 10; // Ví dụ: Thêm 10 điểm thưởng
            lblPoints.Text = $"Điểm thưởng của bạn: {points}";
        }
    }
}
