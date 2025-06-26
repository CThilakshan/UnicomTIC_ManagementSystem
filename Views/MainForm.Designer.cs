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
            this.UserDetails_label = new System.Windows.Forms.Label();
            this.Attendance_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logoutlabel = new System.Windows.Forms.Label();
            this.lbmark = new System.Windows.Forms.Label();
            this.lbexam = new System.Windows.Forms.Label();
            this.Course_label = new System.Windows.Forms.Label();
            this.lbtimetable = new System.Windows.Forms.Label();
            this.Staff_Label = new System.Windows.Forms.Label();
            this.lecturer_label = new System.Windows.Forms.Label();
            this.lbstudent = new System.Windows.Forms.Label();
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
            this.Leftpanel.Controls.Add(this.UserDetails_label);
            this.Leftpanel.Controls.Add(this.Attendance_label);
            this.Leftpanel.Controls.Add(this.panel1);
            this.Leftpanel.Controls.Add(this.Logoutlabel);
            this.Leftpanel.Controls.Add(this.lbmark);
            this.Leftpanel.Controls.Add(this.lbexam);
            this.Leftpanel.Controls.Add(this.Course_label);
            this.Leftpanel.Controls.Add(this.lbtimetable);
            this.Leftpanel.Controls.Add(this.Staff_Label);
            this.Leftpanel.Controls.Add(this.lecturer_label);
            this.Leftpanel.Controls.Add(this.lbstudent);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(171, 550);
            this.Leftpanel.TabIndex = 2;
            // 
            // UserDetails_label
            // 
            this.UserDetails_label.AutoSize = true;
            this.UserDetails_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDetails_label.Location = new System.Drawing.Point(25, 353);
            this.UserDetails_label.Name = "UserDetails_label";
            this.UserDetails_label.Size = new System.Drawing.Size(120, 25);
            this.UserDetails_label.TabIndex = 10;
            this.UserDetails_label.Text = "User Details";
            this.UserDetails_label.Click += new System.EventHandler(this.User_label_Click);
            // 
            // Attendance_label
            // 
            this.Attendance_label.AutoSize = true;
            this.Attendance_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance_label.ForeColor = System.Drawing.Color.Black;
            this.Attendance_label.Location = new System.Drawing.Point(25, 314);
            this.Attendance_label.Name = "Attendance_label";
            this.Attendance_label.Size = new System.Drawing.Size(108, 25);
            this.Attendance_label.TabIndex = 9;
            this.Attendance_label.Text = "Attendance";
            this.Attendance_label.Click += new System.EventHandler(this.Attendance_label_Click);
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
            this.lbmark.Location = new System.Drawing.Point(25, 119);
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
            this.lbexam.Location = new System.Drawing.Point(25, 80);
            this.lbexam.Name = "lbexam";
            this.lbexam.Size = new System.Drawing.Size(69, 25);
            this.lbexam.TabIndex = 5;
            this.lbexam.Text = "Exams";
            this.lbexam.Click += new System.EventHandler(this.lbexam_Click);
            // 
            // Course_label
            // 
            this.Course_label.AutoSize = true;
            this.Course_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_label.Location = new System.Drawing.Point(25, 275);
            this.Course_label.Name = "Course_label";
            this.Course_label.Size = new System.Drawing.Size(67, 25);
            this.Course_label.TabIndex = 4;
            this.Course_label.Text = "Course";
            this.Course_label.Click += new System.EventHandler(this.lbCourse_Click);
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
            // Staff_Label
            // 
            this.Staff_Label.AutoSize = true;
            this.Staff_Label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Label.Location = new System.Drawing.Point(25, 236);
            this.Staff_Label.Name = "Staff_Label";
            this.Staff_Label.Size = new System.Drawing.Size(65, 25);
            this.Staff_Label.TabIndex = 2;
            this.Staff_Label.Text = "Staffs";
            this.Staff_Label.Click += new System.EventHandler(this.lbstaff_Click);
            // 
            // lecturer_label
            // 
            this.lecturer_label.AutoSize = true;
            this.lecturer_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturer_label.Location = new System.Drawing.Point(25, 197);
            this.lecturer_label.Name = "lecturer_label";
            this.lecturer_label.Size = new System.Drawing.Size(90, 25);
            this.lecturer_label.TabIndex = 1;
            this.lecturer_label.Text = "Lecturers";
            this.lecturer_label.Click += new System.EventHandler(this.lblecturer_Click);
            // 
            // lbstudent
            // 
            this.lbstudent.AutoSize = true;
            this.lbstudent.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstudent.Location = new System.Drawing.Point(25, 158);
            this.lbstudent.Name = "lbstudent";
            this.lbstudent.Size = new System.Drawing.Size(87, 25);
            this.lbstudent.TabIndex = 0;
            this.lbstudent.Text = "Students";
            this.lbstudent.Click += new System.EventHandler(this.lbstudent_Click);
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
        private System.Windows.Forms.Label Course_label;
        private System.Windows.Forms.Label lbtimetable;
        private System.Windows.Forms.Label Staff_Label;
        private System.Windows.Forms.Label lecturer_label;
        private System.Windows.Forms.Label lbstudent;
        private System.Windows.Forms.Label Logoutlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Attendance_label;
        private System.Windows.Forms.Label UserDetails_label;
    }
}