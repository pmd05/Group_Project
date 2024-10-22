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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string selectedService = cbService.SelectedItem.ToString();
            string selectedStylist = cbStylist.SelectedItem.ToString();
            DateTime appointmentDate = dtpAppointmentDate.Value;

            // Giả lập đặt lịch thành công
            MessageBox.Show($"Đặt lịch thành công với {selectedStylist} cho dịch vụ {selectedService} vào ngày {appointmentDate.ToShortDateString()}!");
        }
    }
}
