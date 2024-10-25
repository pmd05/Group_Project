namespace Chatgpt
{
    partial class RewardsForm
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
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(266, 117);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(190, 16);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "Hiển thị số điểm thưởng hiện tại";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(505, 114);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(100, 22);
            this.txtFeedback.TabIndex = 1;
            this.txtFeedback.Text = "Nhập phản hồi";
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Location = new System.Drawing.Point(356, 312);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitFeedback.TabIndex = 2;
            this.btnSubmitFeedback.Text = "Gửi phản hồi";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // RewardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblPoints);
            this.Name = "RewardsForm";
            this.Text = "RewardsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmitFeedback;
    }
}
