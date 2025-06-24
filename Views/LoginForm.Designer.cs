namespace Unicom_TIC_Management_System.View
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Username_label = new System.Windows.Forms.Label();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Unicom_TIC_Management_System.Properties.Resources.images1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(134, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 249);
            this.panel1.TabIndex = 0;
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_label.Location = new System.Drawing.Point(132, 341);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(95, 25);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Username_textBox
            // 
            this.Username_textBox.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_textBox.Location = new System.Drawing.Point(259, 341);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(283, 27);
            this.Username_textBox.TabIndex = 2;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(132, 380);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(92, 25);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Password";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(259, 381);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(283, 27);
            this.Password_textBox.TabIndex = 4;
            this.Password_textBox.UseSystemPasswordChar = true;
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Login_button.Location = new System.Drawing.Point(231, 439);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(103, 31);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.ForeColor = System.Drawing.Color.Firebrick;
            this.Exit_button.Location = new System.Drawing.Point(366, 439);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(103, 31);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Exit_button;
    }
}