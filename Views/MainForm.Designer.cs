namespace Unicom_TIC_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Centerpanel = new System.Windows.Forms.Panel();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logoutlabel = new System.Windows.Forms.Label();
            this.lbmark = new System.Windows.Forms.Label();
            this.lbexam = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbtimetable = new System.Windows.Forms.Label();
            this.lbstaff = new System.Windows.Forms.Label();
            this.lblecturer = new System.Windows.Forms.Label();
            this.lbstudent = new System.Windows.Forms.Label();
            this.Attendance_label = new System.Windows.Forms.Label();
            this.User_label = new System.Windows.Forms.Label();
            this.Leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Centerpanel
            // 
            this.Centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Centerpanel.Location = new System.Drawing.Point(171, 0);
            this.Centerpanel.Name = "Centerpanel";
            this.Centerpanel.Size = new System.Drawing.Size(729, 550);
            this.Centerpanel.TabIndex = 3;
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Leftpanel.Controls.Add(this.User_label);
            this.Leftpanel.Controls.Add(this.Attendance_label);
            this.Leftpanel.Controls.Add(this.panel1);
            this.Leftpanel.Controls.Add(this.Logoutlabel);
            this.Leftpanel.Controls.Add(this.lbmark);
            this.Leftpanel.Controls.Add(this.lbexam);
            this.Leftpanel.Controls.Add(this.lbCourse);
            this.Leftpanel.Controls.Add(this.lbtimetable);
            this.Leftpanel.Controls.Add(this.lbstaff);
            this.Leftpanel.Controls.Add(this.lblecturer);
            this.Leftpanel.Controls.Add(this.lbstudent);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(171, 550);
            this.Leftpanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 112);
            this.panel1.TabIndex = 8;
            // 
            // Logoutlabel
            // 
            this.Logoutlabel.AutoSize = true;
            this.Logoutlabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlabel.ForeColor = System.Drawing.Color.Maroon;
            this.Logoutlabel.Location = new System.Drawing.Point(34, 398);
            this.Logoutlabel.Name = "Logoutlabel";
            this.Logoutlabel.Size = new System.Drawing.Size(80, 25);
            this.Logoutlabel.TabIndex = 7;
            this.Logoutlabel.Text = "Logout";
            this.Logoutlabel.Click += new System.EventHandler(this.Logoutlabel_Click);
            // 
            // lbmark
            // 
            this.lbmark.AutoSize = true;
            this.lbmark.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmark.Location = new System.Drawing.Point(25, 107);
            this.lbmark.Name = "lbmark";
            this.lbmark.Size = new System.Drawing.Size(66, 25);
            this.lbmark.TabIndex = 6;
            this.lbmark.Text = "Marks";
            this.lbmark.Click += new System.EventHandler(this.lbmark_Click);
            // 
            // lbexam
            // 
            this.lbexam.AutoSize = true;
            this.lbexam.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbexam.Location = new System.Drawing.Point(25, 74);
            this.lbexam.Name = "lbexam";
            this.lbexam.Size = new System.Drawing.Size(69, 25);
            this.lbexam.TabIndex = 5;
            this.lbexam.Text = "Exams";
            this.lbexam.Click += new System.EventHandler(this.lbexam_Click);
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourse.Location = new System.Drawing.Point(25, 297);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(67, 25);
            this.lbCourse.TabIndex = 4;
            this.lbCourse.Text = "Course";
            this.lbCourse.Click += new System.EventHandler(this.lbCourse_Click);
            // 
            // lbtimetable
            // 
            this.lbtimetable.AutoSize = true;
            this.lbtimetable.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtimetable.Location = new System.Drawing.Point(25, 41);
            this.lbtimetable.Name = "lbtimetable";
            this.lbtimetable.Size = new System.Drawing.Size(104, 25);
            this.lbtimetable.TabIndex = 3;
            this.lbtimetable.Text = "Time Table";
            this.lbtimetable.Click += new System.EventHandler(this.lbtimetable_Click);
            // 
            // lbstaff
            // 
            this.lbstaff.AutoSize = true;
            this.lbstaff.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstaff.Location = new System.Drawing.Point(25, 236);
            this.lbstaff.Name = "lbstaff";
            this.lbstaff.Size = new System.Drawing.Size(65, 25);
            this.lbstaff.TabIndex = 2;
            this.lbstaff.Text = "Staffs";
            this.lbstaff.Click += new System.EventHandler(this.lbstaff_Click);
            // 
            // lblecturer
            // 
            this.lblecturer.AutoSize = true;
            this.lblecturer.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblecturer.Location = new System.Drawing.Point(25, 203);
            this.lblecturer.Name = "lblecturer";
            this.lblecturer.Size = new System.Drawing.Size(90, 25);
            this.lblecturer.TabIndex = 1;
            this.lblecturer.Text = "Lecturers";
            this.lblecturer.Click += new System.EventHandler(this.lblecturer_Click);
            // 
            // lbstudent
            // 
            this.lbstudent.AutoSize = true;
            this.lbstudent.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstudent.Location = new System.Drawing.Point(25, 170);
            this.lbstudent.Name = "lbstudent";
            this.lbstudent.Size = new System.Drawing.Size(87, 25);
            this.lbstudent.TabIndex = 0;
            this.lbstudent.Text = "Students";
            this.lbstudent.Click += new System.EventHandler(this.lbstudent_Click);
            // 
            // Attendance_label
            // 
            this.Attendance_label.AutoSize = true;
            this.Attendance_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance_label.ForeColor = System.Drawing.Color.Black;
            this.Attendance_label.Location = new System.Drawing.Point(25, 326);
            this.Attendance_label.Name = "Attendance_label";
            this.Attendance_label.Size = new System.Drawing.Size(108, 25);
            this.Attendance_label.TabIndex = 9;
            this.Attendance_label.Text = "Attendance";
            this.Attendance_label.Click += new System.EventHandler(this.Attendance_label_Click);
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.Location = new System.Drawing.Point(25, 355);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(120, 25);
            this.User_label.TabIndex = 10;
            this.User_label.Text = "User Details";
            this.User_label.Click += new System.EventHandler(this.User_label_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.Centerpanel);
            this.Controls.Add(this.Leftpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Centerpanel;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Label lbmark;
        private System.Windows.Forms.Label lbexam;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbtimetable;
        private System.Windows.Forms.Label lbstaff;
        private System.Windows.Forms.Label lblecturer;
        private System.Windows.Forms.Label lbstudent;
        private System.Windows.Forms.Label Logoutlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Attendance_label;
        private System.Windows.Forms.Label User_label;
    }
}