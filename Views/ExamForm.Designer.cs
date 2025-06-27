namespace Unicom_TIC_Management_System.View
{
    partial class ExamForm
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
            this.Exam_dataGridView = new System.Windows.Forms.DataGridView();
            this.CourseName_comboBox = new System.Windows.Forms.ComboBox();
            this.ExamCoursename_label = new System.Windows.Forms.Label();
            this.Examname_textBox = new System.Windows.Forms.TextBox();
            this.EaxmDate_label = new System.Windows.Forms.Label();
            this.ExamSubjectname_label = new System.Windows.Forms.Label();
            this.ExamDelete_button = new System.Windows.Forms.Button();
            this.ExamUpdate_button = new System.Windows.Forms.Button();
            this.ExamInsert_button = new System.Windows.Forms.Button();
            this.student_menu_pn = new System.Windows.Forms.Panel();
            this.Exam_Namelabel = new System.Windows.Forms.Label();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.Exam_label = new System.Windows.Forms.Label();
            this.Exam_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Subjectname_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exam_dataGridView)).BeginInit();
            this.student_menu_pn.SuspendLayout();
            this.student_header_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exam_dataGridView
            // 
            this.Exam_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Exam_dataGridView.Location = new System.Drawing.Point(82, 338);
            this.Exam_dataGridView.Name = "Exam_dataGridView";
            this.Exam_dataGridView.Size = new System.Drawing.Size(570, 195);
            this.Exam_dataGridView.TabIndex = 34;
            // 
            // CourseName_comboBox
            // 
            this.CourseName_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName_comboBox.FormattingEnabled = true;
            this.CourseName_comboBox.Location = new System.Drawing.Point(281, 191);
            this.CourseName_comboBox.Name = "CourseName_comboBox";
            this.CourseName_comboBox.Size = new System.Drawing.Size(325, 21);
            this.CourseName_comboBox.TabIndex = 33;
            // 
            // ExamCoursename_label
            // 
            this.ExamCoursename_label.AutoSize = true;
            this.ExamCoursename_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamCoursename_label.Location = new System.Drawing.Point(116, 196);
            this.ExamCoursename_label.Name = "ExamCoursename_label";
            this.ExamCoursename_label.Size = new System.Drawing.Size(76, 15);
            this.ExamCoursename_label.TabIndex = 32;
            this.ExamCoursename_label.Text = "Course Name";
            // 
            // Examname_textBox
            // 
            this.Examname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Examname_textBox.Location = new System.Drawing.Point(281, 128);
            this.Examname_textBox.Name = "Examname_textBox";
            this.Examname_textBox.Size = new System.Drawing.Size(325, 21);
            this.Examname_textBox.TabIndex = 29;
            // 
            // EaxmDate_label
            // 
            this.EaxmDate_label.AutoSize = true;
            this.EaxmDate_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EaxmDate_label.Location = new System.Drawing.Point(116, 165);
            this.EaxmDate_label.Name = "EaxmDate_label";
            this.EaxmDate_label.Size = new System.Drawing.Size(66, 15);
            this.EaxmDate_label.TabIndex = 28;
            this.EaxmDate_label.Text = "Exam Date";
            // 
            // ExamSubjectname_label
            // 
            this.ExamSubjectname_label.AutoSize = true;
            this.ExamSubjectname_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamSubjectname_label.Location = new System.Drawing.Point(116, 227);
            this.ExamSubjectname_label.Name = "ExamSubjectname_label";
            this.ExamSubjectname_label.Size = new System.Drawing.Size(79, 15);
            this.ExamSubjectname_label.TabIndex = 27;
            this.ExamSubjectname_label.Text = "Subject Name";
            // 
            // ExamDelete_button
            // 
            this.ExamDelete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamDelete_button.Location = new System.Drawing.Point(500, 7);
            this.ExamDelete_button.Name = "ExamDelete_button";
            this.ExamDelete_button.Size = new System.Drawing.Size(75, 30);
            this.ExamDelete_button.TabIndex = 17;
            this.ExamDelete_button.Text = "Delete";
            this.ExamDelete_button.UseVisualStyleBackColor = true;
            // 
            // ExamUpdate_button
            // 
            this.ExamUpdate_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamUpdate_button.Location = new System.Drawing.Point(391, 7);
            this.ExamUpdate_button.Name = "ExamUpdate_button";
            this.ExamUpdate_button.Size = new System.Drawing.Size(75, 30);
            this.ExamUpdate_button.TabIndex = 16;
            this.ExamUpdate_button.Text = "Update";
            this.ExamUpdate_button.UseVisualStyleBackColor = true;
            // 
            // ExamInsert_button
            // 
            this.ExamInsert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamInsert_button.Location = new System.Drawing.Point(282, 7);
            this.ExamInsert_button.Name = "ExamInsert_button";
            this.ExamInsert_button.Size = new System.Drawing.Size(75, 30);
            this.ExamInsert_button.TabIndex = 15;
            this.ExamInsert_button.Text = "Insert";
            this.ExamInsert_button.UseVisualStyleBackColor = true;
            this.ExamInsert_button.Click += new System.EventHandler(this.ExamInsert_button_Click);
            // 
            // student_menu_pn
            // 
            this.student_menu_pn.Controls.Add(this.ExamDelete_button);
            this.student_menu_pn.Controls.Add(this.ExamUpdate_button);
            this.student_menu_pn.Controls.Add(this.ExamInsert_button);
            this.student_menu_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_menu_pn.Location = new System.Drawing.Point(0, 43);
            this.student_menu_pn.Name = "student_menu_pn";
            this.student_menu_pn.Size = new System.Drawing.Size(730, 45);
            this.student_menu_pn.TabIndex = 26;
            // 
            // Exam_Namelabel
            // 
            this.Exam_Namelabel.AutoSize = true;
            this.Exam_Namelabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exam_Namelabel.Location = new System.Drawing.Point(116, 134);
            this.Exam_Namelabel.Name = "Exam_Namelabel";
            this.Exam_Namelabel.Size = new System.Drawing.Size(76, 15);
            this.Exam_Namelabel.TabIndex = 25;
            this.Exam_Namelabel.Text = "Exam Name ";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.Exam_label);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 24;
            // 
            // Exam_label
            // 
            this.Exam_label.AutoSize = true;
            this.Exam_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exam_label.Location = new System.Drawing.Point(306, 9);
            this.Exam_label.Name = "Exam_label";
            this.Exam_label.Size = new System.Drawing.Size(117, 25);
            this.Exam_label.TabIndex = 0;
            this.Exam_label.Text = "Exam Details";
            // 
            // Exam_dateTimePicker
            // 
            this.Exam_dateTimePicker.Location = new System.Drawing.Point(282, 160);
            this.Exam_dateTimePicker.Name = "Exam_dateTimePicker";
            this.Exam_dateTimePicker.Size = new System.Drawing.Size(324, 20);
            this.Exam_dateTimePicker.TabIndex = 35;
            // 
            // Subjectname_comboBox
            // 
            this.Subjectname_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subjectname_comboBox.FormattingEnabled = true;
            this.Subjectname_comboBox.Location = new System.Drawing.Point(281, 223);
            this.Subjectname_comboBox.Name = "Subjectname_comboBox";
            this.Subjectname_comboBox.Size = new System.Drawing.Size(325, 21);
            this.Subjectname_comboBox.TabIndex = 36;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.Subjectname_comboBox);
            this.Controls.Add(this.Exam_dateTimePicker);
            this.Controls.Add(this.Exam_dataGridView);
            this.Controls.Add(this.CourseName_comboBox);
            this.Controls.Add(this.ExamCoursename_label);
            this.Controls.Add(this.Examname_textBox);
            this.Controls.Add(this.EaxmDate_label);
            this.Controls.Add(this.ExamSubjectname_label);
            this.Controls.Add(this.student_menu_pn);
            this.Controls.Add(this.Exam_Namelabel);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)(this.Exam_dataGridView)).EndInit();
            this.student_menu_pn.ResumeLayout(false);
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Exam_dataGridView;
        private System.Windows.Forms.ComboBox CourseName_comboBox;
        private System.Windows.Forms.Label ExamCoursename_label;
        private System.Windows.Forms.TextBox Examname_textBox;
        private System.Windows.Forms.Label EaxmDate_label;
        private System.Windows.Forms.Label ExamSubjectname_label;
        private System.Windows.Forms.Button ExamDelete_button;
        private System.Windows.Forms.Button ExamUpdate_button;
        private System.Windows.Forms.Button ExamInsert_button;
        private System.Windows.Forms.Panel student_menu_pn;
        private System.Windows.Forms.Label Exam_Namelabel;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label Exam_label;
        private System.Windows.Forms.DateTimePicker Exam_dateTimePicker;
        private System.Windows.Forms.ComboBox Subjectname_comboBox;
    }
}