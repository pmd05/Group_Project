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
        function fn = new function();
        String query;

        bool SidebarExpand;
        bool homeCollapsed;
        bool adminCollapsed;
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
            query = "SELECT * FROM [booking] ";
            DataSet ds = fn.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
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
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    sidebarTimer.Stop();
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

        private void user_datlichbtn_Click(object sender, EventArgs e)
        {
            if (user_name.Text != "" && user_phone.Text != "" && user_date.Text != "" && user_dv.Text != "" && user_cs.Text != "" && user_stylist.Text != "")
            {
                String user = user_name.Text;
                Int64 phone = Int64.Parse(user_phone.Text);
                String date = user_date.Text;
                String dichvu = user_dv.Text;
                String coso = user_cs.Text;
                String stylist = user_stylist.Text;


                query = "insert into booking ( [user], phone, date, dichvu, coso, stylist) values ('" + user + "', " + phone + ", '" + date + "','" + dichvu + "', '" + coso + "', '" + stylist + "')";
                fn.setData(query, "Đã đặt hẹn");


                User_Load(this, null);
                clearAll();
            }
            else 
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            user_name.Clear();
            user_phone.Clear();
            user_date.ResetText();
            user_dv.SelectedIndex = -1;
            user_cs.SelectedIndex = -1;
            user_stylist.SelectedIndex = -1;


        }

        private void User_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void User_Enter(object sender, EventArgs e)
        {
            User_Load(this, null);
        }

        private void register_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminTimer_Tick(object sender, EventArgs e)
        {
            if (adminCollapsed)
            {
                AdminContainer.Height += 10;
                if (AdminContainer.Height == AdminContainer.MaximumSize.Height)
                {
                    adminCollapsed = false;
                    AdminTimer.Stop();
                }
            }
            else
            {
                AdminContainer.Height -= 10;
                if (AdminContainer.Height == AdminContainer.MinimumSize.Height)
                {
                   adminCollapsed =true;
                    AdminTimer.Stop();
                }
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            AdminTimer.Start();
        }

        private void button20_Click(object sender, EventArgs e)
        {
                Employee mForm = new Employee();
                mForm.Show();
                this.Hide();
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Appoinment mForm = new Appoinment();
            mForm.Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DataGridView1_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
