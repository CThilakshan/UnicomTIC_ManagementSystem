namespace Unicom_TIC_Management_System.View
{
    partial class StaffForm
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
            this.StaffdataGridView = new System.Windows.Forms.DataGridView();
            this.StaffDelete_button = new System.Windows.Forms.Button();
            this.StaffUpdate_button = new System.Windows.Forms.Button();
            this.StaffInsert_button = new System.Windows.Forms.Button();
            this.student_menu_pn = new System.Windows.Forms.Panel();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.Staff_Details = new System.Windows.Forms.Label();
            this.StaffPhoneNo_textBox = new System.Windows.Forms.TextBox();
            this.StaffEmail_textBox = new System.Windows.Forms.TextBox();
            this.StaffFullname_textBox = new System.Windows.Forms.TextBox();
            this.StudentPhone_No_label = new System.Windows.Forms.Label();
            this.Student_Email_label = new System.Windows.Forms.Label();
            this.Staff_Namelabel = new System.Windows.Forms.Label();
            this.stupaswordpanel = new System.Windows.Forms.Panel();
            this.StaffUsername_textBox = new System.Windows.Forms.TextBox();
            this.StaffPassword_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StaffdataGridView)).BeginInit();
            this.student_menu_pn.SuspendLayout();
            this.student_header_pn.SuspendLayout();
            this.stupaswordpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffdataGridView
            // 
            this.StaffdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffdataGridView.Location = new System.Drawing.Point(82, 336);
            this.StaffdataGridView.Name = "StaffdataGridView";
            this.StaffdataGridView.Size = new System.Drawing.Size(570, 195);
            this.StaffdataGridView.TabIndex = 26;
            this.StaffdataGridView.SelectionChanged += new System.EventHandler(this.StaffdataGridView_SelectionChanged);
            // 
            // StaffDelete_button
            // 
            this.StaffDelete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffDelete_button.Location = new System.Drawing.Point(500, 7);
            this.StaffDelete_button.Name = "StaffDelete_button";
            this.StaffDelete_button.Size = new System.Drawing.Size(75, 30);
            this.StaffDelete_button.TabIndex = 17;
            this.StaffDelete_button.Text = "Delete";
            this.StaffDelete_button.UseVisualStyleBackColor = true;
            this.StaffDelete_button.Click += new System.EventHandler(this.StaffDelete_button_Click);
            // 
            // StaffUpdate_button
            // 
            this.StaffUpdate_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffUpdate_button.Location = new System.Drawing.Point(391, 7);
            this.StaffUpdate_button.Name = "StaffUpdate_button";
            this.StaffUpdate_button.Size = new System.Drawing.Size(75, 30);
            this.StaffUpdate_button.TabIndex = 16;
            this.StaffUpdate_button.Text = "Update";
            this.StaffUpdate_button.UseVisualStyleBackColor = true;
            this.StaffUpdate_button.Click += new System.EventHandler(this.StaffUpdate_button_Click);
            // 
            // StaffInsert_button
            // 
            this.StaffInsert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffInsert_button.Location = new System.Drawing.Point(282, 7);
            this.StaffInsert_button.Name = "StaffInsert_button";
            this.StaffInsert_button.Size = new System.Drawing.Size(75, 30);
            this.StaffInsert_button.TabIndex = 15;
            this.StaffInsert_button.Text = "Insert";
            this.StaffInsert_button.UseVisualStyleBackColor = true;
            this.StaffInsert_button.Click += new System.EventHandler(this.StaffInsert_button_Click);
            // 
            // student_menu_pn
            // 
            this.student_menu_pn.Controls.Add(this.StaffDelete_button);
            this.student_menu_pn.Controls.Add(this.StaffUpdate_button);
            this.student_menu_pn.Controls.Add(this.StaffInsert_button);
            this.student_menu_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_menu_pn.Location = new System.Drawing.Point(0, 43);
            this.student_menu_pn.Name = "student_menu_pn";
            this.student_menu_pn.Size = new System.Drawing.Size(730, 45);
            this.student_menu_pn.TabIndex = 16;
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.Staff_Details);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 14;
            // 
            // Staff_Details
            // 
            this.Staff_Details.AutoSize = true;
            this.Staff_Details.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Details.Location = new System.Drawing.Point(306, 9);
            this.Staff_Details.Name = "Staff_Details";
            this.Staff_Details.Size = new System.Drawing.Size(112, 25);
            this.Staff_Details.TabIndex = 0;
            this.Staff_Details.Text = "Staff Details";
            // 
            // StaffPhoneNo_textBox
            // 
            this.StaffPhoneNo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPhoneNo_textBox.Location = new System.Drawing.Point(285, 140);
            this.StaffPhoneNo_textBox.Name = "StaffPhoneNo_textBox";
            this.StaffPhoneNo_textBox.Size = new System.Drawing.Size(325, 21);
            this.StaffPhoneNo_textBox.TabIndex = 32;
            // 
            // StaffEmail_textBox
            // 
            this.StaffEmail_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffEmail_textBox.Location = new System.Drawing.Point(285, 169);
            this.StaffEmail_textBox.Name = "StaffEmail_textBox";
            this.StaffEmail_textBox.Size = new System.Drawing.Size(325, 21);
            this.StaffEmail_textBox.TabIndex = 31;
            // 
            // StaffFullname_textBox
            // 
            this.StaffFullname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffFullname_textBox.Location = new System.Drawing.Point(285, 111);
            this.StaffFullname_textBox.Name = "StaffFullname_textBox";
            this.StaffFullname_textBox.Size = new System.Drawing.Size(325, 21);
            this.StaffFullname_textBox.TabIndex = 30;
            // 
            // StudentPhone_No_label
            // 
            this.StudentPhone_No_label.AutoSize = true;
            this.StudentPhone_No_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPhone_No_label.Location = new System.Drawing.Point(120, 141);
            this.StudentPhone_No_label.Name = "StudentPhone_No_label";
            this.StudentPhone_No_label.Size = new System.Drawing.Size(86, 15);
            this.StudentPhone_No_label.TabIndex = 29;
            this.StudentPhone_No_label.Text = "Phone Number";
            // 
            // Student_Email_label
            // 
            this.Student_Email_label.AutoSize = true;
            this.Student_Email_label.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Email_label.Location = new System.Drawing.Point(120, 170);
            this.Student_Email_label.Name = "Student_Email_label";
            this.Student_Email_label.Size = new System.Drawing.Size(85, 15);
            this.Student_Email_label.TabIndex = 28;
            this.Student_Email_label.Text = "Email Address";
            // 
            // Staff_Namelabel
            // 
            this.Staff_Namelabel.AutoSize = true;
            this.Staff_Namelabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Namelabel.Location = new System.Drawing.Point(120, 112);
            this.Staff_Namelabel.Name = "Staff_Namelabel";
            this.Staff_Namelabel.Size = new System.Drawing.Size(95, 15);
            this.Staff_Namelabel.TabIndex = 27;
            this.Staff_Namelabel.Text = "Staff FullName ";
            // 
            // stupaswordpanel
            // 
            this.stupaswordpanel.Controls.Add(this.StaffUsername_textBox);
            this.stupaswordpanel.Controls.Add(this.StaffPassword_textBox);
            this.stupaswordpanel.Controls.Add(this.label3);
            this.stupaswordpanel.Controls.Add(this.label2);
            this.stupaswordpanel.Location = new System.Drawing.Point(0, 194);
            this.stupaswordpanel.Name = "stupaswordpanel";
            this.stupaswordpanel.Size = new System.Drawing.Size(730, 61);
            this.stupaswordpanel.TabIndex = 39;
            // 
            // StaffUsername_textBox
            // 
            this.StaffUsername_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffUsername_textBox.Location = new System.Drawing.Point(285, 5);
            this.StaffUsername_textBox.Name = "StaffUsername_textBox";
            this.StaffUsername_textBox.Size = new System.Drawing.Size(325, 21);
            this.StaffUsername_textBox.TabIndex = 42;
            // 
            // StaffPassword_textBox
            // 
            this.StaffPassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPassword_textBox.Location = new System.Drawing.Point(285, 34);
            this.StaffPassword_textBox.Name = "StaffPassword_textBox";
            this.StaffPassword_textBox.Size = new System.Drawing.Size(325, 21);
            this.StaffPassword_textBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Username";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.stupaswordpanel);
            this.Controls.Add(this.StaffPhoneNo_textBox);
            this.Controls.Add(this.StaffEmail_textBox);
            this.Controls.Add(this.StaffFullname_textBox);
            this.Controls.Add(this.StudentPhone_No_label);
            this.Controls.Add(this.Student_Email_label);
            this.Controls.Add(this.Staff_Namelabel);
            this.Controls.Add(this.StaffdataGridView);
            this.Controls.Add(this.student_menu_pn);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            ((System.ComponentModel.ISupportInitialize)(this.StaffdataGridView)).EndInit();
            this.student_menu_pn.ResumeLayout(false);
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            this.stupaswordpanel.ResumeLayout(false);
            this.stupaswordpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffdataGridView;
        private System.Windows.Forms.Button StaffDelete_button;
        private System.Windows.Forms.Button StaffUpdate_button;
        private System.Windows.Forms.Button StaffInsert_button;
        private System.Windows.Forms.Panel student_menu_pn;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label Staff_Details;
        private System.Windows.Forms.TextBox StaffPhoneNo_textBox;
        private System.Windows.Forms.TextBox StaffEmail_textBox;
        private System.Windows.Forms.TextBox StaffFullname_textBox;
        private System.Windows.Forms.Label StudentPhone_No_label;
        private System.Windows.Forms.Label Student_Email_label;
        private System.Windows.Forms.Label Staff_Namelabel;
        private System.Windows.Forms.Panel stupaswordpanel;
        private System.Windows.Forms.TextBox StaffUsername_textBox;
        private System.Windows.Forms.TextBox StaffPassword_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}