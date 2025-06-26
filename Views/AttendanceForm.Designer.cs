namespace Unicom_TIC_Management_System.Views
{
    partial class AttendanceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.student_header_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attendance  Details";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.label2);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 362);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_textBox.Location = new System.Drawing.Point(265, 80);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(311, 26);
            this.Search_textBox.TabIndex = 33;
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(140, 78);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(99, 29);
            this.Search_button.TabIndex = 34;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_Textbox_Click);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Button Search_button;
    }
}