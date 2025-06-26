namespace Unicom_TIC_Management_System.View
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.Student_Namelabel = new System.Windows.Forms.Label();
            this.student_menu_pn = new System.Windows.Forms.Panel();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.StudentInsert_button = new System.Windows.Forms.Button();
            this.Student_Email_label = new System.Windows.Forms.Label();
            this.StudentPhone_No_label = new System.Windows.Forms.Label();
            this.StudentFullname_textBox = new System.Windows.Forms.TextBox();
            this.StudentEmail_textBox = new System.Windows.Forms.TextBox();
            this.StudentPhoneNo_textBox = new System.Windows.Forms.TextBox();
            this.StudnetCoursename_label = new System.Windows.Forms.Label();
            this.CourseName_comboBox = new System.Windows.Forms.ComboBox();
            this.Student_dataGridView = new System.Windows.Forms.DataGridView();
            this.password_panel = new System.Windows.Forms.Panel();
            this.StudentUsername_textBox = new System.Windows.Forms.TextBox();
            this.StudentPassword_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.student_header_pn.SuspendLayout();
            this.student_menu_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_dataGridView)).BeginInit();
            this.password_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Details";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.label1);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 1;
            // 
            // Student_Namelabel
            // 
            this.Student_Namelabel.AutoSize = true;
            this.Student_Namelabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Namelabel.Location = new System.Drawing.Point(116, 111);
            this.Student_Namelabel.Name = "Student_Namelabel";
            this.Student_Namelabel.Size = new System.Drawing.Size(108, 15);
            this.Student_Namelabel.TabIndex = 2;
            this.Student_Namelabel.Text = "Student FullName ";
            // 
            // student_menu_pn
            // 
            this.student_menu_pn.Controls.Add(this.Delete_button);
            this.student_menu_pn.Controls.Add(this.Update_button);
            this.student_menu_pn.Controls.Add(this.StudentInsert_button);
            this.student_menu_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_menu_pn.Location = new System.Drawing.Point(0, 43);
            this.student_menu_pn.Name = "student_menu_pn";
            this.student_menu_pn.Size = new System.Drawing.Size(730, 45);
            this.student_menu_pn.TabIndex = 3;
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(500, 7);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 30);
            this.Delete_button.TabIndex = 17;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.Location = new System.Drawing.Point(391, 7);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 30);
            this.Update_button.TabIndex = 16;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // StudentInsert_button
            // 
            this.StudentInsert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInsert_button.Location = new System.Drawing.Point(282, 7);
            this.StudentInsert_button.Name = "StudentInsert_button";
            this.StudentInsert_button.Size = new System.Drawing.Size(75, 30);
            this.StudentInsert_button.TabIndex = 15;
            this.StudentInsert_button.Text = "Insert";
            this.StudentInsert_button.UseVisualStyleBackColor = true;
            this.StudentInsert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Student_Email_label
            // 
            this.Student_Email_label.AutoSize = true;
            this.Student_Email_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Email_label.Location = new System.Drawing.Point(116, 169);
            this.Student_Email_label.Name = "Student_Email_label";
            this.Student_Email_label.Size = new System.Drawing.Size(85, 15);
            this.Student_Email_label.TabIndex = 4;
            this.Student_Email_label.Text = "Email Address";
            // 
            // StudentPhone_No_label
            // 
            this.StudentPhone_No_label.AutoSize = true;
            this.StudentPhone_No_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPhone_No_label.Location = new System.Drawing.Point(116, 140);
            this.StudentPhone_No_label.Name = "StudentPhone_No_label";
            this.StudentPhone_No_label.Size = new System.Drawing.Size(86, 15);
            this.StudentPhone_No_label.TabIndex = 5;
            this.StudentPhone_No_label.Text = "Phone Number";
            // 
            // StudentFullname_textBox
            // 
            this.StudentFullname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFullname_textBox.Location = new System.Drawing.Point(281, 110);
            this.StudentFullname_textBox.Name = "StudentFullname_textBox";
            this.StudentFullname_textBox.Size = new System.Drawing.Size(325, 21);
            this.StudentFullname_textBox.TabIndex = 6;
            // 
            // StudentEmail_textBox
            // 
            this.StudentEmail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEmail_textBox.Location = new System.Drawing.Point(281, 168);
            this.StudentEmail_textBox.Name = "StudentEmail_textBox";
            this.StudentEmail_textBox.Size = new System.Drawing.Size(325, 21);
            this.StudentEmail_textBox.TabIndex = 7;
            // 
            // StudentPhoneNo_textBox
            // 
            this.StudentPhoneNo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPhoneNo_textBox.Location = new System.Drawing.Point(281, 139);
            this.StudentPhoneNo_textBox.Name = "StudentPhoneNo_textBox";
            this.StudentPhoneNo_textBox.Size = new System.Drawing.Size(325, 21);
            this.StudentPhoneNo_textBox.TabIndex = 8;
            // 
            // StudnetCoursename_label
            // 
            this.StudnetCoursename_label.AutoSize = true;
            this.StudnetCoursename_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudnetCoursename_label.Location = new System.Drawing.Point(116, 198);
            this.StudnetCoursename_label.Name = "StudnetCoursename_label";
            this.StudnetCoursename_label.Size = new System.Drawing.Size(76, 15);
            this.StudnetCoursename_label.TabIndex = 9;
            this.StudnetCoursename_label.Text = "Course Name";
            // 
            // CourseName_comboBox
            // 
            this.CourseName_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName_comboBox.FormattingEnabled = true;
            this.CourseName_comboBox.Location = new System.Drawing.Point(281, 197);
            this.CourseName_comboBox.Name = "CourseName_comboBox";
            this.CourseName_comboBox.Size = new System.Drawing.Size(325, 21);
            this.CourseName_comboBox.TabIndex = 10;
            // 
            // Student_dataGridView
            // 
            this.Student_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Student_dataGridView.Location = new System.Drawing.Point(82, 320);
            this.Student_dataGridView.Name = "Student_dataGridView";
            this.Student_dataGridView.Size = new System.Drawing.Size(570, 195);
            this.Student_dataGridView.TabIndex = 13;
            this.Student_dataGridView.SelectionChanged += new System.EventHandler(this.Student_dataGridView_SelectionChanged);
            // 
            // password_panel
            // 
            this.password_panel.Controls.Add(this.StudentUsername_textBox);
            this.password_panel.Controls.Add(this.StudentPassword_textBox);
            this.password_panel.Controls.Add(this.label3);
            this.password_panel.Controls.Add(this.label2);
            this.password_panel.Location = new System.Drawing.Point(0, 224);
            this.password_panel.Name = "password_panel";
            this.password_panel.Size = new System.Drawing.Size(730, 90);
            this.password_panel.TabIndex = 23;
            // 
            // StudentUsername_textBox
            // 
            this.StudentUsername_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentUsername_textBox.Location = new System.Drawing.Point(281, 2);
            this.StudentUsername_textBox.Name = "StudentUsername_textBox";
            this.StudentUsername_textBox.Size = new System.Drawing.Size(325, 21);
            this.StudentUsername_textBox.TabIndex = 26;
            // 
            // StudentPassword_textBox
            // 
            this.StudentPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPassword_textBox.Location = new System.Drawing.Point(281, 31);
            this.StudentPassword_textBox.Name = "StudentPassword_textBox";
            this.StudentPassword_textBox.Size = new System.Drawing.Size(325, 21);
            this.StudentPassword_textBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Username";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.password_panel);
            this.Controls.Add(this.Student_dataGridView);
            this.Controls.Add(this.CourseName_comboBox);
            this.Controls.Add(this.StudnetCoursename_label);
            this.Controls.Add(this.StudentPhoneNo_textBox);
            this.Controls.Add(this.StudentEmail_textBox);
            this.Controls.Add(this.StudentFullname_textBox);
            this.Controls.Add(this.StudentPhone_No_label);
            this.Controls.Add(this.Student_Email_label);
            this.Controls.Add(this.student_menu_pn);
            this.Controls.Add(this.Student_Namelabel);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            this.student_menu_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Student_dataGridView)).EndInit();
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label Student_Namelabel;
        private System.Windows.Forms.Panel student_menu_pn;
        private System.Windows.Forms.Label Student_Email_label;
        private System.Windows.Forms.Label StudentPhone_No_label;
        private System.Windows.Forms.TextBox StudentFullname_textBox;
        private System.Windows.Forms.TextBox StudentEmail_textBox;
        private System.Windows.Forms.TextBox StudentPhoneNo_textBox;
        private System.Windows.Forms.Label StudnetCoursename_label;
        private System.Windows.Forms.ComboBox CourseName_comboBox;
        private System.Windows.Forms.DataGridView Student_dataGridView;
        private System.Windows.Forms.Button StudentInsert_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Panel password_panel;
        private System.Windows.Forms.TextBox StudentUsername_textBox;
        private System.Windows.Forms.TextBox StudentPassword_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}