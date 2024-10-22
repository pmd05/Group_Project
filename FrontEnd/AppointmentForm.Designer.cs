namespace Chatgpt
{
    partial class AppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbService = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cbStylist = new System.Windows.Forms.ComboBox();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(61, 137);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(188, 24);
            this.cbService.TabIndex = 0;
            this.cbService.Text = "Dịch vụ";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(293, 139);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(173, 22);
            this.dtpAppointmentDate.TabIndex = 1;
            // 
            // cbStylist
            // 
            this.cbStylist.FormattingEnabled = true;
            this.cbStylist.Location = new System.Drawing.Point(519, 137);
            this.cbStylist.Name = "cbStylist";
            this.cbStylist.Size = new System.Drawing.Size(121, 24);
            this.cbStylist.TabIndex = 2;
            this.cbStylist.Text = "Stylist";
            this.cbStylist.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(369, 292);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnBookAppointment.TabIndex = 3;
            this.btnBookAppointment.Text = "Đặt lịch";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.cbStylist);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.cbService);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cbStylist;
        private System.Windows.Forms.Button btnBookAppointment;
    }
}