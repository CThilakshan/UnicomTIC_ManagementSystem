namespace Unicom_TIC_Management_System.View
{
    partial class MarkForm
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
            this.Mark_dataGridView = new System.Windows.Forms.DataGridView();
            this.ExamMark_textBox = new System.Windows.Forms.TextBox();
            this.ExamSubjectname_label = new System.Windows.Forms.Label();
            this.MarkDelete_button = new System.Windows.Forms.Button();
            this.MarkUpdate_button = new System.Windows.Forms.Button();
            this.MarkInsert_button = new System.Windows.Forms.Button();
            this.student_menu_pn = new System.Windows.Forms.Panel();
            this.ExamMarks_label = new System.Windows.Forms.Label();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.Exam_label = new System.Windows.Forms.Label();
            this.Subjectname_comboBox = new System.Windows.Forms.ComboBox();
            this.Student_comboBox = new System.Windows.Forms.ComboBox();
            this.Student_label = new System.Windows.Forms.Label();
            this.MarkExamName_label = new System.Windows.Forms.Label();
            this.CourseName_comboBox = new System.Windows.Forms.ComboBox();
            this.MarkCoursename_label = new System.Windows.Forms.Label();
            this.ExamName_comboBox = new System.Windows.Forms.ComboBox();
            this.Descendingorder_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mark_dataGridView)).BeginInit();
            this.student_menu_pn.SuspendLayout();
            this.student_header_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mark_dataGridView
            // 
            this.Mark_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mark_dataGridView.Location = new System.Drawing.Point(82, 322);
            this.Mark_dataGridView.Name = "Mark_dataGridView";
            this.Mark_dataGridView.Size = new System.Drawing.Size(570, 195);
            this.Mark_dataGridView.TabIndex = 45;
            this.Mark_dataGridView.SelectionChanged += new System.EventHandler(this.Mark_dataGridView_SelectionChanged);
            // 
            // ExamMark_textBox
            // 
            this.ExamMark_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamMark_textBox.Location = new System.Drawing.Point(274, 114);
            this.ExamMark_textBox.Name = "ExamMark_textBox";
            this.ExamMark_textBox.Size = new System.Drawing.Size(325, 21);
            this.ExamMark_textBox.TabIndex = 42;
            // 
            // ExamSubjectname_label
            // 
            this.ExamSubjectname_label.AutoSize = true;
            this.ExamSubjectname_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamSubjectname_label.Location = new System.Drawing.Point(116, 215);
            this.ExamSubjectname_label.Name = "ExamSubjectname_label";
            this.ExamSubjectname_label.Size = new System.Drawing.Size(79, 15);
            this.ExamSubjectname_label.TabIndex = 40;
            this.ExamSubjectname_label.Text = "Subject Name";
            // 
            // MarkDelete_button
            // 
            this.MarkDelete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkDelete_button.Location = new System.Drawing.Point(500, 7);
            this.MarkDelete_button.Name = "MarkDelete_button";
            this.MarkDelete_button.Size = new System.Drawing.Size(75, 30);
            this.MarkDelete_button.TabIndex = 17;
            this.MarkDelete_button.Text = "Delete";
            this.MarkDelete_button.UseVisualStyleBackColor = true;
            this.MarkDelete_button.Click += new System.EventHandler(this.MarkDelete_button_Click);
            // 
            // MarkUpdate_button
            // 
            this.MarkUpdate_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkUpdate_button.Location = new System.Drawing.Point(391, 7);
            this.MarkUpdate_button.Name = "MarkUpdate_button";
            this.MarkUpdate_button.Size = new System.Drawing.Size(75, 30);
            this.MarkUpdate_button.TabIndex = 16;
            this.MarkUpdate_button.Text = "Update";
            this.MarkUpdate_button.UseVisualStyleBackColor = true;
            this.MarkUpdate_button.Click += new System.EventHandler(this.MarkUpdate_button_Click);
            // 
            // MarkInsert_button
            // 
            this.MarkInsert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkInsert_button.Location = new System.Drawing.Point(282, 7);
            this.MarkInsert_button.Name = "MarkInsert_button";
            this.MarkInsert_button.Size = new System.Drawing.Size(75, 30);
            this.MarkInsert_button.TabIndex = 15;
            this.MarkInsert_button.Text = "Insert";
            this.MarkInsert_button.UseVisualStyleBackColor = true;
            this.MarkInsert_button.Click += new System.EventHandler(this.MarkInsert_button_Click);
            // 
            // student_menu_pn
            // 
            this.student_menu_pn.Controls.Add(this.Descendingorder_button);
            this.student_menu_pn.Controls.Add(this.MarkDelete_button);
            this.student_menu_pn.Controls.Add(this.MarkUpdate_button);
            this.student_menu_pn.Controls.Add(this.MarkInsert_button);
            this.student_menu_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_menu_pn.Location = new System.Drawing.Point(0, 43);
            this.student_menu_pn.Name = "student_menu_pn";
            this.student_menu_pn.Size = new System.Drawing.Size(730, 45);
            this.student_menu_pn.TabIndex = 39;
            // 
            // ExamMarks_label
            // 
            this.ExamMarks_label.AutoSize = true;
            this.ExamMarks_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamMarks_label.Location = new System.Drawing.Point(116, 116);
            this.ExamMarks_label.Name = "ExamMarks_label";
            this.ExamMarks_label.Size = new System.Drawing.Size(76, 15);
            this.ExamMarks_label.TabIndex = 38;
            this.ExamMarks_label.Text = "Exam Marks";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.Exam_label);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 37;
            // 
            // Exam_label
            // 
            this.Exam_label.AutoSize = true;
            this.Exam_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exam_label.Location = new System.Drawing.Point(306, 9);
            this.Exam_label.Name = "Exam_label";
            this.Exam_label.Size = new System.Drawing.Size(121, 25);
            this.Exam_label.TabIndex = 0;
            this.Exam_label.Text = "Marks Details";
            // 
            // Subjectname_comboBox
            // 
            this.Subjectname_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subjectname_comboBox.FormattingEnabled = true;
            this.Subjectname_comboBox.Location = new System.Drawing.Point(274, 213);
            this.Subjectname_comboBox.Name = "Subjectname_comboBox";
            this.Subjectname_comboBox.Size = new System.Drawing.Size(325, 21);
            this.Subjectname_comboBox.TabIndex = 47;
            this.Subjectname_comboBox.SelectedIndexChanged += new System.EventHandler(this.Subjectname_comboBox_SelectedIndexChanged);
            // 
            // Student_comboBox
            // 
            this.Student_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_comboBox.FormattingEnabled = true;
            this.Student_comboBox.Location = new System.Drawing.Point(274, 246);
            this.Student_comboBox.Name = "Student_comboBox";
            this.Student_comboBox.Size = new System.Drawing.Size(325, 21);
            this.Student_comboBox.TabIndex = 49;
            // 
            // Student_label
            // 
            this.Student_label.AutoSize = true;
            this.Student_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_label.Location = new System.Drawing.Point(116, 248);
            this.Student_label.Name = "Student_label";
            this.Student_label.Size = new System.Drawing.Size(81, 15);
            this.Student_label.TabIndex = 48;
            this.Student_label.Text = "Student Name";
            // 
            // MarkExamName_label
            // 
            this.MarkExamName_label.AutoSize = true;
            this.MarkExamName_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkExamName_label.Location = new System.Drawing.Point(116, 149);
            this.MarkExamName_label.Name = "MarkExamName_label";
            this.MarkExamName_label.Size = new System.Drawing.Size(72, 15);
            this.MarkExamName_label.TabIndex = 50;
            this.MarkExamName_label.Text = "Exam Name";
            // 
            // CourseName_comboBox
            // 
            this.CourseName_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName_comboBox.FormattingEnabled = true;
            this.CourseName_comboBox.Location = new System.Drawing.Point(274, 180);
            this.CourseName_comboBox.Name = "CourseName_comboBox";
            this.CourseName_comboBox.Size = new System.Drawing.Size(325, 21);
            this.CourseName_comboBox.TabIndex = 53;
            // 
            // MarkCoursename_label
            // 
            this.MarkCoursename_label.AutoSize = true;
            this.MarkCoursename_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkCoursename_label.Location = new System.Drawing.Point(116, 182);
            this.MarkCoursename_label.Name = "MarkCoursename_label";
            this.MarkCoursename_label.Size = new System.Drawing.Size(76, 15);
            this.MarkCoursename_label.TabIndex = 52;
            this.MarkCoursename_label.Text = "Course Name";
            // 
            // ExamName_comboBox
            // 
            this.ExamName_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamName_comboBox.FormattingEnabled = true;
            this.ExamName_comboBox.Location = new System.Drawing.Point(274, 147);
            this.ExamName_comboBox.Name = "ExamName_comboBox";
            this.ExamName_comboBox.Size = new System.Drawing.Size(325, 21);
            this.ExamName_comboBox.TabIndex = 54;
            // 
            // Descendingorder_button
            // 
            this.Descendingorder_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descendingorder_button.Location = new System.Drawing.Point(82, 7);
            this.Descendingorder_button.Name = "Descendingorder_button";
            this.Descendingorder_button.Size = new System.Drawing.Size(169, 29);
            this.Descendingorder_button.TabIndex = 18;
            this.Descendingorder_button.Text = "Marks Descending Order";
            this.Descendingorder_button.UseVisualStyleBackColor = true;
            this.Descendingorder_button.Click += new System.EventHandler(this.Descendingorder_button_Click);
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.ExamName_comboBox);
            this.Controls.Add(this.CourseName_comboBox);
            this.Controls.Add(this.MarkCoursename_label);
            this.Controls.Add(this.MarkExamName_label);
            this.Controls.Add(this.Student_comboBox);
            this.Controls.Add(this.Student_label);
            this.Controls.Add(this.Mark_dataGridView);
            this.Controls.Add(this.ExamMark_textBox);
            this.Controls.Add(this.ExamSubjectname_label);
            this.Controls.Add(this.student_menu_pn);
            this.Controls.Add(this.ExamMarks_label);
            this.Controls.Add(this.student_header_pn);
            this.Controls.Add(this.Subjectname_comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            ((System.ComponentModel.ISupportInitialize)(this.Mark_dataGridView)).EndInit();
            this.student_menu_pn.ResumeLayout(false);
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Mark_dataGridView;
        private System.Windows.Forms.TextBox ExamMark_textBox;
        private System.Windows.Forms.Label ExamSubjectname_label;
        private System.Windows.Forms.Button MarkDelete_button;
        private System.Windows.Forms.Button MarkUpdate_button;
        private System.Windows.Forms.Button MarkInsert_button;
        private System.Windows.Forms.Panel student_menu_pn;
        private System.Windows.Forms.Label ExamMarks_label;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label Exam_label;
        private System.Windows.Forms.ComboBox Subjectname_comboBox;
        private System.Windows.Forms.ComboBox Student_comboBox;
        private System.Windows.Forms.Label Student_label;
        private System.Windows.Forms.Label MarkExamName_label;
        private System.Windows.Forms.ComboBox CourseName_comboBox;
        private System.Windows.Forms.Label MarkCoursename_label;
        private System.Windows.Forms.ComboBox ExamName_comboBox;
        private System.Windows.Forms.Button Descendingorder_button;
    }
}