namespace Unicom_TIC_Management_System.View
{
    partial class CourseForm
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
            this.CoursedataGridView = new System.Windows.Forms.DataGridView();
            this.Course_NamecomboBox = new System.Windows.Forms.ComboBox();
            this.Course_name_label = new System.Windows.Forms.Label();
            this.Subject_NametextBox = new System.Windows.Forms.TextBox();
            this.Course_name_textBox = new System.Windows.Forms.TextBox();
            this.Subject_namelabel = new System.Windows.Forms.Label();
            this.CourseDelete_button = new System.Windows.Forms.Button();
            this.CourseUpdate_button = new System.Windows.Forms.Button();
            this.CourseInsert_button = new System.Windows.Forms.Button();
            this.student_menu_pn = new System.Windows.Forms.Panel();
            this.CourseSearch_button = new System.Windows.Forms.Button();
            this.Course_namelabel = new System.Windows.Forms.Label();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.Course_Details = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubjectDelete_button = new System.Windows.Forms.Button();
            this.SubjectUpdate_button = new System.Windows.Forms.Button();
            this.SubjectInsert_button = new System.Windows.Forms.Button();
            this.Subject_dataGridView = new System.Windows.Forms.DataGridView();
            this.Subject_Details = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView)).BeginInit();
            this.student_menu_pn.SuspendLayout();
            this.student_header_pn.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Subject_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursedataGridView
            // 
            this.CoursedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursedataGridView.Location = new System.Drawing.Point(119, 137);
            this.CoursedataGridView.Name = "CoursedataGridView";
            this.CoursedataGridView.Size = new System.Drawing.Size(519, 100);
            this.CoursedataGridView.TabIndex = 26;
            this.CoursedataGridView.SelectionChanged += new System.EventHandler(this.CoursedataGridView_SelectionChanged);
            // 
            // Course_NamecomboBox
            // 
            this.Course_NamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_NamecomboBox.FormattingEnabled = true;
            this.Course_NamecomboBox.Location = new System.Drawing.Point(281, 379);
            this.Course_NamecomboBox.Name = "Course_NamecomboBox";
            this.Course_NamecomboBox.Size = new System.Drawing.Size(325, 26);
            this.Course_NamecomboBox.TabIndex = 23;
            // 
            // Course_name_label
            // 
            this.Course_name_label.AutoSize = true;
            this.Course_name_label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_name_label.Location = new System.Drawing.Point(116, 380);
            this.Course_name_label.Name = "Course_name_label";
            this.Course_name_label.Size = new System.Drawing.Size(91, 18);
            this.Course_name_label.TabIndex = 22;
            this.Course_name_label.Text = "Course Name";
            // 
            // Subject_NametextBox
            // 
            this.Subject_NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_NametextBox.Location = new System.Drawing.Point(281, 341);
            this.Subject_NametextBox.Name = "Subject_NametextBox";
            this.Subject_NametextBox.Size = new System.Drawing.Size(325, 24);
            this.Subject_NametextBox.TabIndex = 20;
            // 
            // Course_name_textBox
            // 
            this.Course_name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_name_textBox.Location = new System.Drawing.Point(281, 103);
            this.Course_name_textBox.Name = "Course_name_textBox";
            this.Course_name_textBox.Size = new System.Drawing.Size(325, 24);
            this.Course_name_textBox.TabIndex = 19;
            // 
            // Subject_namelabel
            // 
            this.Subject_namelabel.AutoSize = true;
            this.Subject_namelabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_namelabel.Location = new System.Drawing.Point(116, 341);
            this.Subject_namelabel.Name = "Subject_namelabel";
            this.Subject_namelabel.Size = new System.Drawing.Size(95, 18);
            this.Subject_namelabel.TabIndex = 17;
            this.Subject_namelabel.Text = "Subject Name";
            // 
            // CourseDelete_button
            // 
            this.CourseDelete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDelete_button.Location = new System.Drawing.Point(531, 7);
            this.CourseDelete_button.Name = "CourseDelete_button";
            this.CourseDelete_button.Size = new System.Drawing.Size(75, 30);
            this.CourseDelete_button.TabIndex = 17;
            this.CourseDelete_button.Text = "Delete";
            this.CourseDelete_button.UseVisualStyleBackColor = true;
            this.CourseDelete_button.Click += new System.EventHandler(this.CourseDelete_button_Click);
            // 
            // CourseUpdate_button
            // 
            this.CourseUpdate_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseUpdate_button.Location = new System.Drawing.Point(325, 7);
            this.CourseUpdate_button.Name = "CourseUpdate_button";
            this.CourseUpdate_button.Size = new System.Drawing.Size(75, 30);
            this.CourseUpdate_button.TabIndex = 16;
            this.CourseUpdate_button.Text = "Update";
            this.CourseUpdate_button.UseVisualStyleBackColor = true;
            this.CourseUpdate_button.Click += new System.EventHandler(this.CourseUpdate_button_Click);
            // 
            // CourseInsert_button
            // 
            this.CourseInsert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseInsert_button.Location = new System.Drawing.Point(119, 7);
            this.CourseInsert_button.Name = "CourseInsert_button";
            this.CourseInsert_button.Size = new System.Drawing.Size(75, 30);
            this.CourseInsert_button.TabIndex = 15;
            this.CourseInsert_button.Text = "Insert";
            this.CourseInsert_button.UseVisualStyleBackColor = true;
            this.CourseInsert_button.Click += new System.EventHandler(this.CourseInsert_button_Click);
            // 
            // student_menu_pn
            // 
            this.student_menu_pn.Controls.Add(this.CourseSearch_button);
            this.student_menu_pn.Controls.Add(this.CourseDelete_button);
            this.student_menu_pn.Controls.Add(this.CourseUpdate_button);
            this.student_menu_pn.Controls.Add(this.CourseInsert_button);
            this.student_menu_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_menu_pn.Location = new System.Drawing.Point(0, 43);
            this.student_menu_pn.Name = "student_menu_pn";
            this.student_menu_pn.Size = new System.Drawing.Size(730, 45);
            this.student_menu_pn.TabIndex = 16;
            this.student_menu_pn.Paint += new System.Windows.Forms.PaintEventHandler(this.student_menu_pn_Paint);
            // 
            // CourseSearch_button
            // 
            this.CourseSearch_button.Location = new System.Drawing.Point(627, 14);
            this.CourseSearch_button.Name = "CourseSearch_button";
            this.CourseSearch_button.Size = new System.Drawing.Size(75, 23);
            this.CourseSearch_button.TabIndex = 30;
            this.CourseSearch_button.Text = "search";
            this.CourseSearch_button.UseVisualStyleBackColor = true;
            this.CourseSearch_button.Click += new System.EventHandler(this.CourseSearch_button_Click);
            // 
            // Course_namelabel
            // 
            this.Course_namelabel.AutoSize = true;
            this.Course_namelabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_namelabel.Location = new System.Drawing.Point(116, 105);
            this.Course_namelabel.Name = "Course_namelabel";
            this.Course_namelabel.Size = new System.Drawing.Size(96, 18);
            this.Course_namelabel.TabIndex = 15;
            this.Course_namelabel.Text = "Course Name ";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.Course_Details);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 14;
            // 
            // Course_Details
            // 
            this.Course_Details.AutoSize = true;
            this.Course_Details.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_Details.Location = new System.Drawing.Point(306, 9);
            this.Course_Details.Name = "Course_Details";
            this.Course_Details.Size = new System.Drawing.Size(121, 25);
            this.Course_Details.TabIndex = 0;
            this.Course_Details.Text = "Course Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubjectDelete_button);
            this.panel1.Controls.Add(this.SubjectUpdate_button);
            this.panel1.Controls.Add(this.SubjectInsert_button);
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 45);
            this.panel1.TabIndex = 27;
            // 
            // SubjectDelete_button
            // 
            this.SubjectDelete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectDelete_button.Location = new System.Drawing.Point(534, 7);
            this.SubjectDelete_button.Name = "SubjectDelete_button";
            this.SubjectDelete_button.Size = new System.Drawing.Size(75, 30);
            this.SubjectDelete_button.TabIndex = 20;
            this.SubjectDelete_button.Text = "Delete";
            this.SubjectDelete_button.UseVisualStyleBackColor = true;
            this.SubjectDelete_button.Click += new System.EventHandler(this.SubjectDelete_button_Click);
            // 
            // SubjectUpdate_button
            // 
            this.SubjectUpdate_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectUpdate_button.Location = new System.Drawing.Point(328, 7);
            this.SubjectUpdate_button.Name = "SubjectUpdate_button";
            this.SubjectUpdate_button.Size = new System.Drawing.Size(75, 30);
            this.SubjectUpdate_button.TabIndex = 19;
            this.SubjectUpdate_button.Text = "Update";
            this.SubjectUpdate_button.UseVisualStyleBackColor = true;
            this.SubjectUpdate_button.Click += new System.EventHandler(this.SubjectUpdate_button_Click);
            // 
            // SubjectInsert_button
            // 
            this.SubjectInsert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectInsert_button.Location = new System.Drawing.Point(122, 7);
            this.SubjectInsert_button.Name = "SubjectInsert_button";
            this.SubjectInsert_button.Size = new System.Drawing.Size(75, 30);
            this.SubjectInsert_button.TabIndex = 18;
            this.SubjectInsert_button.Text = "Insert";
            this.SubjectInsert_button.UseVisualStyleBackColor = true;
            this.SubjectInsert_button.Click += new System.EventHandler(this.SubjectInsert_button_Click);
            // 
            // Subject_dataGridView
            // 
            this.Subject_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Subject_dataGridView.Location = new System.Drawing.Point(119, 413);
            this.Subject_dataGridView.Name = "Subject_dataGridView";
            this.Subject_dataGridView.Size = new System.Drawing.Size(519, 100);
            this.Subject_dataGridView.TabIndex = 28;
            this.Subject_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Subject_dataGridView_CellContentClick);
            this.Subject_dataGridView.SelectionChanged += new System.EventHandler(this.Subject_dataGridView_SelectionChanged);
            // 
            // Subject_Details
            // 
            this.Subject_Details.AutoSize = true;
            this.Subject_Details.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_Details.Location = new System.Drawing.Point(303, 256);
            this.Subject_Details.Name = "Subject_Details";
            this.Subject_Details.Size = new System.Drawing.Size(127, 25);
            this.Subject_Details.TabIndex = 29;
            this.Subject_Details.Text = "Subject Details";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.Subject_Details);
            this.Controls.Add(this.Subject_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CoursedataGridView);
            this.Controls.Add(this.Course_NamecomboBox);
            this.Controls.Add(this.Course_name_label);
            this.Controls.Add(this.Subject_NametextBox);
            this.Controls.Add(this.Course_name_textBox);
            this.Controls.Add(this.Subject_namelabel);
            this.Controls.Add(this.student_menu_pn);
            this.Controls.Add(this.Course_namelabel);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView)).EndInit();
            this.student_menu_pn.ResumeLayout(false);
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Subject_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CoursedataGridView;
        private System.Windows.Forms.ComboBox Course_NamecomboBox;
        private System.Windows.Forms.Label Course_name_label;
        private System.Windows.Forms.TextBox Subject_NametextBox;
        private System.Windows.Forms.TextBox Course_name_textBox;
        private System.Windows.Forms.Label Subject_namelabel;
        private System.Windows.Forms.Button CourseDelete_button;
        private System.Windows.Forms.Button CourseUpdate_button;
        private System.Windows.Forms.Button CourseInsert_button;
        private System.Windows.Forms.Panel student_menu_pn;
        private System.Windows.Forms.Label Course_namelabel;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label Course_Details;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Subject_dataGridView;
        private System.Windows.Forms.Button SubjectDelete_button;
        private System.Windows.Forms.Button SubjectUpdate_button;
        private System.Windows.Forms.Button SubjectInsert_button;
        private System.Windows.Forms.Label Subject_Details;
        private System.Windows.Forms.Button CourseSearch_button;
    }
}