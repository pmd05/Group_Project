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
    public partial class Employee : Form
    {
        function fn = new function();
        String query;
        public Employee()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            getMaxId();
        }

        //=========
        public void getMaxId()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            { 
               Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();
            }
        }

        private void btnRegistation_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            { 
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;

                query = "insert into employee(ename, mobile, emailid, username, pass) values ('" + name + "', " + mobile + ", '" + email + "', '" + username + "', '" + pass + "')";
                fn.setData(query, "Đăng ký nhân viên thành công");


                clearAll();
                getMaxId();
            }
        }

        public void clearAll()
        { 
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.GetData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "Thông tin nhân viên đã được xóa");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }

        private void Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            User mForm = new User();
            mForm.Show();
            this.Hide();
        }
    }
}
