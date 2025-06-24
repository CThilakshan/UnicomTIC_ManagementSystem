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
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 462);
            this.Controls.Add(this.RoomDetailslabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoomDetailslabel;
    }
}