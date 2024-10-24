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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        private void btnManageAppointments_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm manageAppointmentsForm = new ManageAppointmentsForm();
            manageAppointmentsForm.Show();
        }

        private void btnViewRewards_Click(object sender, EventArgs e)
        {
            RewardsForm rewardsForm = new RewardsForm();
            rewardsForm.Show();
        }
    }
}
