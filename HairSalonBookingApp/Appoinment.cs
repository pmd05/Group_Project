using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSalonBookingApp
{
    public partial class Appoinment : Form
    {
        function fn = new function();
        String query;
        public Appoinment()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            User mForm = new User();
            mForm.Show();
            this.Hide();
        }

        private void Appoinment_Load(object sender, EventArgs e)
        {
            query = "select booking.userid, booking.[user], booking.phone, booking.date, booking.dichvu, booking.coso, booking.stylist from booking where booked = 'NO'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView.DataSource = ds.Tables[0];
        }

        private void txtNAME_TextChanged(object sender, EventArgs e)
        {
            query = "select booking.userid, booking.[user], booking.phone, booking.date, booking.dichvu, booking.coso, booking.stylist from booking where [user] like '" + txtNAME.Text + "%' and booked = 'NO'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView.DataSource=ds.Tables[0];
        }

        int id;
        private void guna2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtFNAME.Text = guna2DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPHONE.Text = guna2DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtFNAME.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = "update booking set booked = 'YES'";
                    fn.setData(query, "Xác nhận thành công");
                    Appoinment_Load(this, null);
                    clearAll();
                }
            }
            else 
            { 
                MessageBox.Show("Không có khách hàng để lựa chọn", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        { 
            txtFNAME.Clear();
            txtNAME.Clear();
            txtPHONE.Clear();
        }

        private void Appoinment_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
