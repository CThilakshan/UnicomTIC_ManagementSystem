using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Views;

namespace Unicom_TIC_Management_System.View
{
    public partial class TimetableForm : Form
    {
        public TimetableForm()
        {
            InitializeComponent();
        }
        public void LoadForm(object formObj)
        {
            if (this.TimeTableCenter_panel.Controls.Count > 0)
            {
                this.TimeTableCenter_panel.Controls.RemoveAt(0);
            }

            if (formObj is Form form)
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.TimeTableCenter_panel.Controls.Add(form);
                this.TimeTableCenter_panel.Tag = form;
                form.Show();
                form.BringToFront();
            }

        }
        private void Room_button_Click(object sender, EventArgs e)
        {
            LoadForm(new RoomForm());
        }
    }
}
