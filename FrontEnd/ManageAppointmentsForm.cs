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
    public partial class ManageAppointmentsForm : Form
    {
        public ManageAppointmentsForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Giả lập từ chối lịch hẹn
            MessageBox.Show("Lịch hẹn đã bị từ chối.");

        }

        private void ManageAppointmentsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            // Giả lập duyệt lịch hẹn
            MessageBox.Show("Lịch hẹn đã được duyệt.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
