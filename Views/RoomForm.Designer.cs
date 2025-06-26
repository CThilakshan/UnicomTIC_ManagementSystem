namespace Unicom_TIC_Management_System.Views
{
    partial class RoomForm
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
            this.RoomDetailslabel = new System.Windows.Forms.Label();
            this.Room_label = new System.Windows.Forms.Label();
            this.Roomtype_label = new System.Windows.Forms.Label();
            this.Room_textBox = new System.Windows.Forms.TextBox();
            this.Room_comboBox = new System.Windows.Forms.ComboBox();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Updat_button = new System.Windows.Forms.Button();
            this.Room_dataGridView = new System.Windows.Forms.DataGridView();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Room_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomDetailslabel
            // 
            this.RoomDetailslabel.AutoSize = true;
            this.RoomDetailslabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomDetailslabel.Location = new System.Drawing.Point(295, 28);
            this.RoomDetailslabel.Name = "RoomDetailslabel";
            this.RoomDetailslabel.Size = new System.Drawing.Size(126, 23);
            this.RoomDetailslabel.TabIndex = 0;
            this.RoomDetailslabel.Text = "Room Details";
            this.RoomDetailslabel.Click += new System.EventHandler(this.RoomDetailslabel_Click);
            // 
            // Room_label
            // 
            this.Room_label.AutoSize = true;
            this.Room_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_label.Location = new System.Drawing.Point(72, 102);
            this.Room_label.Name = "Room_label";
            this.Room_label.Size = new System.Drawing.Size(130, 25);
            this.Room_label.TabIndex = 1;
            this.Room_label.Text = "Room Name";
            // 
            // Roomtype_label
            // 
            this.Roomtype_label.AutoSize = true;
            this.Roomtype_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomtype_label.Location = new System.Drawing.Point(72, 162);
            this.Roomtype_label.Name = "Roomtype_label";
            this.Roomtype_label.Size = new System.Drawing.Size(122, 25);
            this.Roomtype_label.TabIndex = 2;
            this.Roomtype_label.Text = "Room Type";
            // 
            // Room_textBox
            // 
            this.Room_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_textBox.Location = new System.Drawing.Point(273, 102);
            this.Room_textBox.Name = "Room_textBox";
            this.Room_textBox.Size = new System.Drawing.Size(324, 31);
            this.Room_textBox.TabIndex = 3;
            // 
            // Room_comboBox
            // 
            this.Room_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_comboBox.FormattingEnabled = true;
            this.Room_comboBox.Items.AddRange(new object[] {
            "Lecturer Hall",
            "Computer Lab",
            "Nil"});
            this.Room_comboBox.Location = new System.Drawing.Point(273, 162);
            this.Room_comboBox.Name = "Room_comboBox";
            this.Room_comboBox.Size = new System.Drawing.Size(324, 33);
            this.Room_comboBox.TabIndex = 4;
            // 
            // Insert_button
            // 
            this.Insert_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_button.Location = new System.Drawing.Point(273, 223);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(97, 23);
            this.Insert_button.TabIndex = 5;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(500, 223);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(97, 23);
            this.Delete_button.TabIndex = 6;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Updat_button
            // 
            this.Updat_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updat_button.Location = new System.Drawing.Point(386, 223);
            this.Updat_button.Name = "Updat_button";
            this.Updat_button.Size = new System.Drawing.Size(97, 23);
            this.Updat_button.TabIndex = 7;
            this.Updat_button.Text = "Update";
            this.Updat_button.UseVisualStyleBackColor = true;
            this.Updat_button.Click += new System.EventHandler(this.Updat_button_Click);
            // 
            // Room_dataGridView
            // 
            this.Room_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Room_dataGridView.Location = new System.Drawing.Point(86, 315);
            this.Room_dataGridView.Name = "Room_dataGridView";
            this.Room_dataGridView.Size = new System.Drawing.Size(511, 150);
            this.Room_dataGridView.TabIndex = 8;
            this.Room_dataGridView.SelectionChanged += new System.EventHandler(this.Room_dataGridView_SelectionChanged);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_textBox.Location = new System.Drawing.Point(269, 276);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(283, 26);
            this.Search_textBox.TabIndex = 9;
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(150, 276);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(97, 26);
            this.Search_button.TabIndex = 10;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 507);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.Room_dataGridView);
            this.Controls.Add(this.Updat_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Room_comboBox);
            this.Controls.Add(this.Room_textBox);
            this.Controls.Add(this.Roomtype_label);
            this.Controls.Add(this.Room_label);
            this.Controls.Add(this.RoomDetailslabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.Room_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoomDetailslabel;
        private System.Windows.Forms.Label Room_label;
        private System.Windows.Forms.Label Roomtype_label;
        private System.Windows.Forms.TextBox Room_textBox;
        private System.Windows.Forms.ComboBox Room_comboBox;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Updat_button;
        private System.Windows.Forms.DataGridView Room_dataGridView;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Button Search_button;
    }
}