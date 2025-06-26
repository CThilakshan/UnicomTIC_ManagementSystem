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
            this.UserDetailsdataGridView.Location = new System.Drawing.Point(77, 112);
            this.UserDetailsdataGridView.Name = "UserDetailsdataGridView";
            this.UserDetailsdataGridView.Size = new System.Drawing.Size(569, 362);
            this.UserDetailsdataGridView.TabIndex = 33;
            this.UserDetailsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.UserDetailsdataGridView);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.DataGridView UserDetailsdataGridView;
    }
}