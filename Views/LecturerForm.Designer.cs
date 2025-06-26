namespace Unicom_TIC_Management_System.View
{
    partial class LecturerForm
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
            this.Lecturer_dataGridView = new System.Windows.Forms.DataGridView();
            this.CourseName_comboBox = new System.Windows.Forms.ComboBox();
            this.StudnetCoursename_label = new System.Windows.Forms.Label();
            this.LecturerPhoneNo_textBox = new System.Windows.Forms.TextBox();
            this.LecturerEmail_textBox = new System.Windows.Forms.TextBox();
            this.StudentPhone_No_label = new System.Windows.Forms.Label();
            this.Student_Email_label = new System.Windows.Forms.Label();
            this.lecturerDelete_button = new System.Windows.Forms.Button();
            this.LecturerUpdate_button = new System.Windows.Forms.Button();
            this.LecturerInsert_button = new System.Windows.Forms.Button();
            this.LecturerFullname_textBox = new System.Windows.Forms.TextBox();
            this.student_menu_pn = new System.Windows.Forms.Panel();
            this.Student_Namelabel = new System.Windows.Forms.Label();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lecPasswordpanel = new System.Windows.Forms.Panel();
            this.Subject_comboBox = new System.Windows.Forms.ComboBox();
            this.LecturerUsername_textBox = new System.Windows.Forms.TextBox();
            this.LecturerPassword_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lecturer_dataGridView)).BeginInit();
            this.student_menu_pn.SuspendLayout();
            this.student_header_pn.SuspendLayout();
            this.lecPasswordpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lecturer_dataGridView
            // 
            this.Lecturer_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lecturer_dataGridView.Location = new System.Drawing.Point(82, 338);
            this.Lecturer_dataGridView.Name = "Lecturer_dataGridView";
            this.Lecturer_dataGridView.Size = new System.Drawing.Size(570, 195);
            this.Lecturer_dataGridView.TabIndex = 40;
            this.Lecturer_dataGridView.SelectionChanged += new System.EventHandler(this.Lecturer_dataGridView_SelectionChanged);
            // 
            // CourseName_comboBox
            // 
            this.CourseName_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName_comboBox.FormattingEnabled = true;
            this.CourseName_comboBox.Location = new System.Drawing.Point(281, 212);
            this.CourseName_comboBox.Name = "CourseName_comboBox";
            this.CourseName_comboBox.Size = new System.Drawing.Size(325, 21);
            this.CourseName_comboBox.TabIndex = 39;
            // 
            // StudnetCoursename_label
            // 
            this.StudnetCoursename_label.AutoSize = true;
            this.StudnetCoursename_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudnetCoursename_label.Location = new System.Drawing.Point(116, 213);
            this.StudnetCoursename_label.Name = "StudnetCoursename_label";
            this.StudnetCoursename_label.Size = new System.Drawing.Size(76, 15);
            this.StudnetCoursename_label.TabIndex = 38;
            this.StudnetCoursename_label.Text = "Course Name";
            // 
            // LecturerPhoneNo_textBox
            // 
            this.LecturerPhoneNo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerPhoneNo_textBox.Location = new System.Drawing.Point(281, 156);
            this.LecturerPhoneNo_textBox.Name = "LecturerPhoneNo_textBox";
            this.LecturerPhoneNo_textBox.Size = new System.Drawing.Size(325, 21);
            this.LecturerPhoneNo_textBox.TabIndex = 37;
            // 
            // LecturerEmail_textBox
            // 
            this.LecturerEmail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerEmail_textBox.Location = new System.Drawing.Point(281, 184);
            this.LecturerEmail_textBox.Name = "LecturerEmail_textBox";
            this.LecturerEmail_textBox.Size = new System.Drawing.Size(325, 21);
            this.LecturerEmail_textBox.TabIndex = 36;
            // 
            // StudentPhone_No_label
            // 
            this.StudentPhone_No_label.AutoSize = true;
            this.StudentPhone_No_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPhone_No_label.Location = new System.Drawing.Point(116, 157);
            this.StudentPhone_No_label.Name = "StudentPhone_No_label";
            this.StudentPhone_No_label.Size = new System.Drawing.Size(86, 15);
            this.StudentPhone_No_label.TabIndex = 34;
            this.StudentPhone_No_label.Text = "Phone Number";
            // 
            // Student_Email_label
            // 
            this.Student_Email_label.AutoSize = true;
            this.Student_Email_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Email_label.Location = new System.Drawing.Point(116, 185);
            this.Student_Email_label.Name = "Student_Email_label";
            this.Student_Email_label.Size = new System.Drawing.Size(85, 15);
            this.Student_Email_label.TabIndex = 33;
            this.Student_Email_label.Text = "Email Address";
            // 
            // lecturerDelete_button
            // 
            this.lecturerDelete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerDelete_button.Location = new System.Drawing.Point(500, 7);
            this.lecturerDelete_button.Name = "lecturerDelete_button";
            this.lecturerDelete_button.Size = new System.Drawing.Size(75, 30);
            this.lecturerDelete_button.TabIndex = 17;
            this.lecturerDelete_button.Text = "Delete";
            this.lecturerDelete_button.UseVisualStyleBackColor = true;
            this.lecturerDelete_button.Click += new System.EventHandler(this.lecturerDelete_button_Click);
            // 
            // LecturerUpdate_button
            // 
            this.LecturerUpdate_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerUpdate_button.Location = new System.Drawing.Point(391, 7);
            this.LecturerUpdate_button.Name = "LecturerUpdate_button";
            this.LecturerUpdate_button.Size = new System.Drawing.Size(75, 30);
            this.LecturerUpdate_button.TabIndex = 16;
            this.LecturerUpdate_button.Text = "Update";
            this.LecturerUpdate_button.UseVisualStyleBackColor = true;
            this.LecturerUpdate_button.Click += new System.EventHandler(this.LecturerUpdate_button_Click);
            // 
            // LecturerInsert_button
            // 
            this.LecturerInsert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerInsert_button.Location = new System.Drawing.Point(282, 7);
            this.LecturerInsert_button.Name = "LecturerInsert_button";
            this.LecturerInsert_button.Size = new System.Drawing.Size(75, 30);
            this.LecturerInsert_button.TabIndex = 15;
            this.LecturerInsert_button.Text = "Insert";
            this.LecturerInsert_button.UseVisualStyleBackColor = true;
            this.LecturerInsert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // LecturerFullname_textBox
            // 
            this.LecturerFullname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerFullname_textBox.Location = new System.Drawing.Point(281, 128);
            this.LecturerFullname_textBox.Name = "LecturerFullname_textBox";
            this.LecturerFullname_textBox.Size = new System.Drawing.Size(325, 21);
            this.LecturerFullname_textBox.TabIndex = 35;
            // 
            // student_menu_pn
            // 
            this.student_menu_pn.Controls.Add(this.lecturerDelete_button);
            this.student_menu_pn.Controls.Add(this.LecturerUpdate_button);
            this.student_menu_pn.Controls.Add(this.LecturerInsert_button);
            this.student_menu_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_menu_pn.Location = new System.Drawing.Point(0, 43);
            this.student_menu_pn.Name = "student_menu_pn";
            this.student_menu_pn.Size = new System.Drawing.Size(730, 45);
            this.student_menu_pn.TabIndex = 32;
            // 
            // Student_Namelabel
            // 
            this.Student_Namelabel.AutoSize = true;
            this.Student_Namelabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Namelabel.Location = new System.Drawing.Point(116, 129);
            this.Student_Namelabel.Name = "Student_Namelabel";
            this.Student_Namelabel.Size = new System.Drawing.Size(113, 15);
            this.Student_Namelabel.TabIndex = 31;
            this.Student_Namelabel.Text = "Lecturer FullName ";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.label1);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer  Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Subject Name";
            // 
            // lecPasswordpanel
            // 
            this.lecPasswordpanel.Controls.Add(this.LecturerUsername_textBox);
            this.lecPasswordpanel.Controls.Add(this.LecturerPassword_textBox);
            this.lecPasswordpanel.Controls.Add(this.label3);
            this.lecPasswordpanel.Controls.Add(this.label2);
            this.lecPasswordpanel.Location = new System.Drawing.Point(0, 263);
            this.lecPasswordpanel.Name = "lecPasswordpanel";
            this.lecPasswordpanel.Size = new System.Drawing.Size(730, 53);
            this.lecPasswordpanel.TabIndex = 47;
            // 
            // Subject_comboBox
            // 
            this.Subject_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_comboBox.FormattingEnabled = true;
            this.Subject_comboBox.Location = new System.Drawing.Point(281, 240);
            this.Subject_comboBox.Name = "Subject_comboBox";
            this.Subject_comboBox.Size = new System.Drawing.Size(325, 21);
            this.Subject_comboBox.TabIndex = 46;
            // 
            // LecturerUsername_textBox
            // 
            this.LecturerUsername_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerUsername_textBox.Location = new System.Drawing.Point(283, 2);
            this.LecturerUsername_textBox.Name = "LecturerUsername_textBox";
            this.LecturerUsername_textBox.Size = new System.Drawing.Size(325, 21);
            this.LecturerUsername_textBox.TabIndex = 52;
            // 
            // LecturerPassword_textBox
            // 
            this.LecturerPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerPassword_textBox.Location = new System.Drawing.Point(283, 30);
            this.LecturerPassword_textBox.Name = "LecturerPassword_textBox";
            this.LecturerPassword_textBox.Size = new System.Drawing.Size(325, 21);
            this.LecturerPassword_textBox.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Username";
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.lecPasswordpanel);
            this.Controls.Add(this.Subject_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lecturer_dataGridView);
            this.Controls.Add(this.CourseName_comboBox);
            this.Controls.Add(this.StudnetCoursename_label);
            this.Controls.Add(this.LecturerPhoneNo_textBox);
            this.Controls.Add(this.LecturerEmail_textBox);
            this.Controls.Add(this.StudentPhone_No_label);
            this.Controls.Add(this.Student_Email_label);
            this.Controls.Add(this.LecturerFullname_textBox);
            this.Controls.Add(this.student_menu_pn);
            this.Controls.Add(this.Student_Namelabel);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            ((System.ComponentModel.ISupportInitialize)(this.Lecturer_dataGridView)).EndInit();
            this.student_menu_pn.ResumeLayout(false);
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            this.lecPasswordpanel.ResumeLayout(false);
            this.lecPasswordpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Lecturer_dataGridView;
        private System.Windows.Forms.ComboBox CourseName_comboBox;
        private System.Windows.Forms.Label StudnetCoursename_label;
        private System.Windows.Forms.TextBox LecturerPhoneNo_textBox;
        private System.Windows.Forms.TextBox LecturerEmail_textBox;
        private System.Windows.Forms.Label StudentPhone_No_label;
        private System.Windows.Forms.Label Student_Email_label;
        private System.Windows.Forms.Button lecturerDelete_button;
        private System.Windows.Forms.Button LecturerUpdate_button;
        private System.Windows.Forms.Button LecturerInsert_button;
        private System.Windows.Forms.TextBox LecturerFullname_textBox;
        private System.Windows.Forms.Panel student_menu_pn;
        private System.Windows.Forms.Label Student_Namelabel;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel lecPasswordpanel;
        private System.Windows.Forms.TextBox LecturerUsername_textBox;
        private System.Windows.Forms.TextBox LecturerPassword_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Subject_comboBox;
    }
}