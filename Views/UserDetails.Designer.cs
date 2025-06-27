namespace Unicom_TIC_Management_System.Views
{
    partial class UserDetails
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
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.User_label = new System.Windows.Forms.Label();
            this.UserDetailsdataGridView = new System.Windows.Forms.DataGridView();
            this.Name_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Usname_textBox = new System.Windows.Forms.TextBox();
            this.Ususername_textBox = new System.Windows.Forms.TextBox();
            this.Uspassword_textBox = new System.Windows.Forms.TextBox();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.student_header_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.User_label);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 32;
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.Location = new System.Drawing.Point(281, 9);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(113, 25);
            this.User_label.TabIndex = 0;
            this.User_label.Text = "User  Details";
            // 
            // UserDetailsdataGridView
            // 
            this.UserDetailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDetailsdataGridView.Location = new System.Drawing.Point(72, 214);
            this.UserDetailsdataGridView.Name = "UserDetailsdataGridView";
            this.UserDetailsdataGridView.Size = new System.Drawing.Size(569, 300);
            this.UserDetailsdataGridView.TabIndex = 33;
            this.UserDetailsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.UserDetailsdataGridView.SelectionChanged += new System.EventHandler(this.UserDetailsdataGridView_SelectionChanged);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(141, 64);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(54, 20);
            this.Name_label.TabIndex = 34;
            this.Name_label.Text = "Name";
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.Location = new System.Drawing.Point(141, 98);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(85, 20);
            this.UserName_label.TabIndex = 35;
            this.UserName_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(141, 132);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(82, 20);
            this.Password_label.TabIndex = 36;
            this.Password_label.Text = "Password";
            this.Password_label.Click += new System.EventHandler(this.Password_label_Click);
            // 
            // Usname_textBox
            // 
            this.Usname_textBox.Location = new System.Drawing.Point(256, 63);
            this.Usname_textBox.Name = "Usname_textBox";
            this.Usname_textBox.Size = new System.Drawing.Size(285, 20);
            this.Usname_textBox.TabIndex = 37;
            // 
            // Ususername_textBox
            // 
            this.Ususername_textBox.Location = new System.Drawing.Point(256, 98);
            this.Ususername_textBox.Name = "Ususername_textBox";
            this.Ususername_textBox.Size = new System.Drawing.Size(285, 20);
            this.Ususername_textBox.TabIndex = 38;
            // 
            // Uspassword_textBox
            // 
            this.Uspassword_textBox.Location = new System.Drawing.Point(256, 133);
            this.Uspassword_textBox.Name = "Uspassword_textBox";
            this.Uspassword_textBox.Size = new System.Drawing.Size(285, 20);
            this.Uspassword_textBox.TabIndex = 39;
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(245, 172);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(88, 23);
            this.Update_button.TabIndex = 40;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(376, 172);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(88, 23);
            this.Delete_button.TabIndex = 41;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Uspassword_textBox);
            this.Controls.Add(this.Ususername_textBox);
            this.Controls.Add(this.Usname_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.UserDetailsdataGridView);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.DataGridView UserDetailsdataGridView;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Usname_textBox;
        private System.Windows.Forms.TextBox Ususername_textBox;
        private System.Windows.Forms.TextBox Uspassword_textBox;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
    }
}