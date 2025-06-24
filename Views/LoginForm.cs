using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controllers;

namespace Unicom_TIC_Management_System.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Username_textBox.Text.Trim();
                string password = Password_textBox.Text.Trim();

                LoginController login = new LoginController();
                bool isValid = login.userlogin(username, password); // Pass input directly

                if (isValid)
                {
                    // Navigate to MainForm
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
