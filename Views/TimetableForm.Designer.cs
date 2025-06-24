namespace Unicom_TIC_Management_System.View
{
    partial class TimetableForm
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
            this.User_label = new System.Windows.Forms.Label();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.timetable_panel = new System.Windows.Forms.Panel();
            this.CourseDelete_button = new System.Windows.Forms.Button();
            this.CourseUpdate_button = new System.Windows.Forms.Button();
            this.CourseInsert_button = new System.Windows.Forms.Button();
            this.Room_button = new System.Windows.Forms.Button();
            this.TimeTableCenter_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RoomName_label = new System.Windows.Forms.Label();
            this.CourseName_label = new System.Windows.Forms.Label();
            this.SubjectName_label = new System.Windows.Forms.Label();
            this.TimetableSlot_label = new System.Windows.Forms.Label();
            this.TimetableDate_label = new System.Windows.Forms.Label();
            this.student_header_pn.SuspendLayout();
            this.timetable_panel.SuspendLayout();
            this.TimeTableCenter_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.Location = new System.Drawing.Point(296, 9);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(89, 25);
            this.User_label.TabIndex = 0;
            this.User_label.Text = "TimeTable";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.User_label);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 34;
            // 
            // timetable_panel
            // 
            this.timetable_panel.Controls.Add(this.Room_button);
            this.timetable_panel.Controls.Add(this.CourseDelete_button);
            this.timetable_panel.Controls.Add(this.CourseUpdate_button);
            this.timetable_panel.Controls.Add(this.CourseInsert_button);
            this.timetable_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timetable_panel.Location = new System.Drawing.Point(0, 43);
            this.timetable_panel.Name = "timetable_panel";
            this.timetable_panel.Size = new System.Drawing.Size(730, 45);
            this.timetable_panel.TabIndex = 35;
            // 
            // CourseDelete_button
            // 
            this.CourseDelete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDelete_button.Location = new System.Drawing.Point(636, 7);
            this.CourseDelete_button.Name = "CourseDelete_button";
            this.CourseDelete_button.Size = new System.Drawing.Size(75, 30);
            this.CourseDelete_button.TabIndex = 17;
            this.CourseDelete_button.Text = "Delete";
            this.CourseDelete_button.UseVisualStyleBackColor = true;
            // 
            // CourseUpdate_button
            // 
            this.CourseUpdate_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseUpdate_button.Location = new System.Drawing.Point(468, 7);
            this.CourseUpdate_button.Name = "CourseUpdate_button";
            this.CourseUpdate_button.Size = new System.Drawing.Size(75, 30);
            this.CourseUpdate_button.TabIndex = 16;
            this.CourseUpdate_button.Text = "Update";
            this.CourseUpdate_button.UseVisualStyleBackColor = true;
            // 
            // CourseInsert_button
            // 
            this.CourseInsert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseInsert_button.Location = new System.Drawing.Point(300, 7);
            this.CourseInsert_button.Name = "CourseInsert_button";
            this.CourseInsert_button.Size = new System.Drawing.Size(75, 30);
            this.CourseInsert_button.TabIndex = 15;
            this.CourseInsert_button.Text = "Insert";
            this.CourseInsert_button.UseVisualStyleBackColor = true;
            // 
            // Room_button
            // 
            this.Room_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_button.Location = new System.Drawing.Point(12, 7);
            this.Room_button.Name = "Room_button";
            this.Room_button.Size = new System.Drawing.Size(134, 30);
            this.Room_button.TabIndex = 18;
            this.Room_button.Text = "Room Details";
            this.Room_button.UseVisualStyleBackColor = true;
            this.Room_button.Click += new System.EventHandler(this.Room_button_Click);
            // 
            // TimeTableCenter_panel
            // 
            this.TimeTableCenter_panel.Controls.Add(this.dataGridView1);
            this.TimeTableCenter_panel.Controls.Add(this.comboBox4);
            this.TimeTableCenter_panel.Controls.Add(this.comboBox3);
            this.TimeTableCenter_panel.Controls.Add(this.comboBox2);
            this.TimeTableCenter_panel.Controls.Add(this.comboBox1);
            this.TimeTableCenter_panel.Controls.Add(this.dateTimePicker);
            this.TimeTableCenter_panel.Controls.Add(this.RoomName_label);
            this.TimeTableCenter_panel.Controls.Add(this.CourseName_label);
            this.TimeTableCenter_panel.Controls.Add(this.SubjectName_label);
            this.TimeTableCenter_panel.Controls.Add(this.TimetableSlot_label);
            this.TimeTableCenter_panel.Controls.Add(this.TimetableDate_label);
            this.TimeTableCenter_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeTableCenter_panel.Location = new System.Drawing.Point(0, 88);
            this.TimeTableCenter_panel.Name = "TimeTableCenter_panel";
            this.TimeTableCenter_panel.Size = new System.Drawing.Size(730, 462);
            this.TimeTableCenter_panel.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 150);
            this.dataGridView1.TabIndex = 57;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(269, 201);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(294, 21);
            this.comboBox4.TabIndex = 56;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(269, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(294, 21);
            this.comboBox3.TabIndex = 55;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(269, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(294, 21);
            this.comboBox2.TabIndex = 54;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8.00AM-10.00AM",
            "10.00AM-12.00AM",
            "01.00PM-03.00PM",
            "03.00PM-05.00PM",
            "No Class"});
            this.comboBox1.Location = new System.Drawing.Point(269, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 21);
            this.comboBox1.TabIndex = 53;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(269, 60);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(294, 22);
            this.dateTimePicker.TabIndex = 52;
            this.dateTimePicker.Value = new System.DateTime(2025, 6, 24, 2, 47, 21, 0);
            // 
            // RoomName_label
            // 
            this.RoomName_label.AutoSize = true;
            this.RoomName_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomName_label.Location = new System.Drawing.Point(109, 196);
            this.RoomName_label.Name = "RoomName_label";
            this.RoomName_label.Size = new System.Drawing.Size(112, 25);
            this.RoomName_label.TabIndex = 51;
            this.RoomName_label.Text = "Room Name";
            // 
            // CourseName_label
            // 
            this.CourseName_label.AutoSize = true;
            this.CourseName_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName_label.Location = new System.Drawing.Point(109, 161);
            this.CourseName_label.Name = "CourseName_label";
            this.CourseName_label.Size = new System.Drawing.Size(121, 25);
            this.CourseName_label.TabIndex = 50;
            this.CourseName_label.Text = "Course Name";
            // 
            // SubjectName_label
            // 
            this.SubjectName_label.AutoSize = true;
            this.SubjectName_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectName_label.Location = new System.Drawing.Point(109, 126);
            this.SubjectName_label.Name = "SubjectName_label";
            this.SubjectName_label.Size = new System.Drawing.Size(128, 25);
            this.SubjectName_label.TabIndex = 49;
            this.SubjectName_label.Text = "Subject Name";
            // 
            // TimetableSlot_label
            // 
            this.TimetableSlot_label.AutoSize = true;
            this.TimetableSlot_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimetableSlot_label.Location = new System.Drawing.Point(109, 91);
            this.TimetableSlot_label.Name = "TimetableSlot_label";
            this.TimetableSlot_label.Size = new System.Drawing.Size(140, 25);
            this.TimetableSlot_label.TabIndex = 48;
            this.TimetableSlot_label.Text = "Timetable Slot ";
            // 
            // TimetableDate_label
            // 
            this.TimetableDate_label.AutoSize = true;
            this.TimetableDate_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimetableDate_label.Location = new System.Drawing.Point(109, 56);
            this.TimetableDate_label.Name = "TimetableDate_label";
            this.TimetableDate_label.Size = new System.Drawing.Size(142, 25);
            this.TimetableDate_label.TabIndex = 47;
            this.TimetableDate_label.Text = "Timetable Date";
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.TimeTableCenter_panel);
            this.Controls.Add(this.timetable_panel);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            this.timetable_panel.ResumeLayout(false);
            this.TimeTableCenter_panel.ResumeLayout(false);
            this.TimeTableCenter_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Panel timetable_panel;
        private System.Windows.Forms.Button Room_button;
        private System.Windows.Forms.Button CourseDelete_button;
        private System.Windows.Forms.Button CourseUpdate_button;
        private System.Windows.Forms.Button CourseInsert_button;
        private System.Windows.Forms.Panel TimeTableCenter_panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label RoomName_label;
        private System.Windows.Forms.Label CourseName_label;
        private System.Windows.Forms.Label SubjectName_label;
        private System.Windows.Forms.Label TimetableSlot_label;
        private System.Windows.Forms.Label TimetableDate_label;
    }
}