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
            this.Room_button = new System.Windows.Forms.Button();
            this.TTDelete_button = new System.Windows.Forms.Button();
            this.TTUpdate_button = new System.Windows.Forms.Button();
            this.TTInsert__button = new System.Windows.Forms.Button();
            this.TimeTableCenter_panel = new System.Windows.Forms.Panel();
            this.TTLecturer_comboBox = new System.Windows.Forms.ComboBox();
            this.LecturerName_label = new System.Windows.Forms.Label();
            this.TimeTabledataGridView = new System.Windows.Forms.DataGridView();
            this.TTRoomName_comboBox = new System.Windows.Forms.ComboBox();
            this.TTCourse_comboBox = new System.Windows.Forms.ComboBox();
            this.TTSubject_comboBox = new System.Windows.Forms.ComboBox();
            this.TTSolt_comboBox = new System.Windows.Forms.ComboBox();
            this.TTDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RoomName_label = new System.Windows.Forms.Label();
            this.CourseName_label = new System.Windows.Forms.Label();
            this.SubjectName_label = new System.Windows.Forms.Label();
            this.TimetableSlot_label = new System.Windows.Forms.Label();
            this.TimetableDate_label = new System.Windows.Forms.Label();
            this.student_header_pn.SuspendLayout();
            this.timetable_panel.SuspendLayout();
            this.TimeTableCenter_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTabledataGridView)).BeginInit();
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
            this.timetable_panel.Controls.Add(this.TTDelete_button);
            this.timetable_panel.Controls.Add(this.TTUpdate_button);
            this.timetable_panel.Controls.Add(this.TTInsert__button);
            this.timetable_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timetable_panel.Location = new System.Drawing.Point(0, 43);
            this.timetable_panel.Name = "timetable_panel";
            this.timetable_panel.Size = new System.Drawing.Size(730, 45);
            this.timetable_panel.TabIndex = 35;
            this.timetable_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.timetable_panel_Paint);
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
            // TTDelete_button
            // 
            this.TTDelete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTDelete_button.Location = new System.Drawing.Point(636, 7);
            this.TTDelete_button.Name = "TTDelete_button";
            this.TTDelete_button.Size = new System.Drawing.Size(75, 30);
            this.TTDelete_button.TabIndex = 17;
            this.TTDelete_button.Text = "Delete";
            this.TTDelete_button.UseVisualStyleBackColor = true;
            // 
            // TTUpdate_button
            // 
            this.TTUpdate_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTUpdate_button.Location = new System.Drawing.Point(468, 7);
            this.TTUpdate_button.Name = "TTUpdate_button";
            this.TTUpdate_button.Size = new System.Drawing.Size(75, 30);
            this.TTUpdate_button.TabIndex = 16;
            this.TTUpdate_button.Text = "Update";
            this.TTUpdate_button.UseVisualStyleBackColor = true;
            // 
            // TTInsert__button
            // 
            this.TTInsert__button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTInsert__button.Location = new System.Drawing.Point(300, 7);
            this.TTInsert__button.Name = "TTInsert__button";
            this.TTInsert__button.Size = new System.Drawing.Size(75, 30);
            this.TTInsert__button.TabIndex = 15;
            this.TTInsert__button.Text = "Insert";
            this.TTInsert__button.UseVisualStyleBackColor = true;
            this.TTInsert__button.Click += new System.EventHandler(this.CourseInsert_button_Click);
            // 
            // TimeTableCenter_panel
            // 
            this.TimeTableCenter_panel.Controls.Add(this.TTLecturer_comboBox);
            this.TimeTableCenter_panel.Controls.Add(this.LecturerName_label);
            this.TimeTableCenter_panel.Controls.Add(this.TimeTabledataGridView);
            this.TimeTableCenter_panel.Controls.Add(this.TTRoomName_comboBox);
            this.TimeTableCenter_panel.Controls.Add(this.TTCourse_comboBox);
            this.TimeTableCenter_panel.Controls.Add(this.TTSubject_comboBox);
            this.TimeTableCenter_panel.Controls.Add(this.TTSolt_comboBox);
            this.TimeTableCenter_panel.Controls.Add(this.TTDate_dateTimePicker);
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
            // TTLecturer_comboBox
            // 
            this.TTLecturer_comboBox.FormattingEnabled = true;
            this.TTLecturer_comboBox.Location = new System.Drawing.Point(271, 151);
            this.TTLecturer_comboBox.Name = "TTLecturer_comboBox";
            this.TTLecturer_comboBox.Size = new System.Drawing.Size(294, 21);
            this.TTLecturer_comboBox.TabIndex = 59;
            // 
            // LecturerName_label
            // 
            this.LecturerName_label.AutoSize = true;
            this.LecturerName_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerName_label.Location = new System.Drawing.Point(111, 146);
            this.LecturerName_label.Name = "LecturerName_label";
            this.LecturerName_label.Size = new System.Drawing.Size(136, 25);
            this.LecturerName_label.TabIndex = 58;
            this.LecturerName_label.Text = "Lecturer Name";
            // 
            // TimeTabledataGridView
            // 
            this.TimeTabledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeTabledataGridView.Location = new System.Drawing.Point(114, 256);
            this.TimeTabledataGridView.Name = "TimeTabledataGridView";
            this.TimeTabledataGridView.Size = new System.Drawing.Size(507, 150);
            this.TimeTabledataGridView.TabIndex = 57;
            // 
            // TTRoomName_comboBox
            // 
            this.TTRoomName_comboBox.FormattingEnabled = true;
            this.TTRoomName_comboBox.Location = new System.Drawing.Point(271, 186);
            this.TTRoomName_comboBox.Name = "TTRoomName_comboBox";
            this.TTRoomName_comboBox.Size = new System.Drawing.Size(294, 21);
            this.TTRoomName_comboBox.TabIndex = 56;
            // 
            // TTCourse_comboBox
            // 
            this.TTCourse_comboBox.FormattingEnabled = true;
            this.TTCourse_comboBox.Location = new System.Drawing.Point(269, 84);
            this.TTCourse_comboBox.Name = "TTCourse_comboBox";
            this.TTCourse_comboBox.Size = new System.Drawing.Size(294, 21);
            this.TTCourse_comboBox.TabIndex = 55;
            // 
            // TTSubject_comboBox
            // 
            this.TTSubject_comboBox.FormattingEnabled = true;
            this.TTSubject_comboBox.Location = new System.Drawing.Point(269, 115);
            this.TTSubject_comboBox.Name = "TTSubject_comboBox";
            this.TTSubject_comboBox.Size = new System.Drawing.Size(294, 21);
            this.TTSubject_comboBox.TabIndex = 54;
            // 
            // TTSolt_comboBox
            // 
            this.TTSolt_comboBox.FormattingEnabled = true;
            this.TTSolt_comboBox.Items.AddRange(new object[] {
            "8.00AM-10.00AM",
            "10.00AM-12.00AM",
            "01.00PM-03.00PM",
            "03.00PM-05.00PM"});
            this.TTSolt_comboBox.Location = new System.Drawing.Point(269, 52);
            this.TTSolt_comboBox.Name = "TTSolt_comboBox";
            this.TTSolt_comboBox.Size = new System.Drawing.Size(294, 21);
            this.TTSolt_comboBox.TabIndex = 53;
            // 
            // TTDate_dateTimePicker
            // 
            this.TTDate_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TTDate_dateTimePicker.Location = new System.Drawing.Point(269, 21);
            this.TTDate_dateTimePicker.Name = "TTDate_dateTimePicker";
            this.TTDate_dateTimePicker.Size = new System.Drawing.Size(294, 22);
            this.TTDate_dateTimePicker.TabIndex = 52;
            this.TTDate_dateTimePicker.Value = new System.DateTime(2025, 6, 24, 2, 47, 21, 0);
            // 
            // RoomName_label
            // 
            this.RoomName_label.AutoSize = true;
            this.RoomName_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomName_label.Location = new System.Drawing.Point(111, 181);
            this.RoomName_label.Name = "RoomName_label";
            this.RoomName_label.Size = new System.Drawing.Size(112, 25);
            this.RoomName_label.TabIndex = 51;
            this.RoomName_label.Text = "Room Name";
            // 
            // CourseName_label
            // 
            this.CourseName_label.AutoSize = true;
            this.CourseName_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName_label.Location = new System.Drawing.Point(109, 80);
            this.CourseName_label.Name = "CourseName_label";
            this.CourseName_label.Size = new System.Drawing.Size(121, 25);
            this.CourseName_label.TabIndex = 50;
            this.CourseName_label.Text = "Course Name";
            // 
            // SubjectName_label
            // 
            this.SubjectName_label.AutoSize = true;
            this.SubjectName_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectName_label.Location = new System.Drawing.Point(109, 110);
            this.SubjectName_label.Name = "SubjectName_label";
            this.SubjectName_label.Size = new System.Drawing.Size(128, 25);
            this.SubjectName_label.TabIndex = 49;
            this.SubjectName_label.Text = "Subject Name";
            // 
            // TimetableSlot_label
            // 
            this.TimetableSlot_label.AutoSize = true;
            this.TimetableSlot_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimetableSlot_label.Location = new System.Drawing.Point(109, 52);
            this.TimetableSlot_label.Name = "TimetableSlot_label";
            this.TimetableSlot_label.Size = new System.Drawing.Size(140, 25);
            this.TimetableSlot_label.TabIndex = 48;
            this.TimetableSlot_label.Text = "Timetable Slot ";
            // 
            // TimetableDate_label
            // 
            this.TimetableDate_label.AutoSize = true;
            this.TimetableDate_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimetableDate_label.Location = new System.Drawing.Point(109, 17);
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
            ((System.ComponentModel.ISupportInitialize)(this.TimeTabledataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Panel timetable_panel;
        private System.Windows.Forms.Button Room_button;
        private System.Windows.Forms.Button TTDelete_button;
        private System.Windows.Forms.Button TTUpdate_button;
        private System.Windows.Forms.Button TTInsert__button;
        private System.Windows.Forms.Panel TimeTableCenter_panel;
        private System.Windows.Forms.DataGridView TimeTabledataGridView;
        private System.Windows.Forms.ComboBox TTCourse_comboBox;
        private System.Windows.Forms.ComboBox TTSubject_comboBox;
        private System.Windows.Forms.ComboBox TTSolt_comboBox;
        private System.Windows.Forms.DateTimePicker TTDate_dateTimePicker;
        private System.Windows.Forms.Label CourseName_label;
        private System.Windows.Forms.Label SubjectName_label;
        private System.Windows.Forms.Label TimetableSlot_label;
        private System.Windows.Forms.Label TimetableDate_label;
        private System.Windows.Forms.ComboBox TTLecturer_comboBox;
        private System.Windows.Forms.Label LecturerName_label;
        private System.Windows.Forms.ComboBox TTRoomName_comboBox;
        private System.Windows.Forms.Label RoomName_label;
    }
}