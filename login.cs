using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _232137_OOP_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e) // This is the button that will take the user to the main form if the username and password are correct
        {
            if(username_textbox.Text == "abdullah" && password_textbox.Text == "232137") // This is the condition that will check if the username and password are correct
            {
                main main = new main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password"); // This message will be displayed if the username or password are incorrect
                username_textbox.Clear();
                password_textbox.Clear();
                username_textbox.Focus();
            }
        }

        private void clearfield_label_Click(object sender, EventArgs e) // This is the label that will clear the username and password fields
        {
            username_textbox.Clear();
            password_textbox.Clear();
            username_textbox.Focus();
        }

        private void exit_button_Click(object sender, EventArgs e) // This is the button that will close the application
        {
            Application.Exit();
        }
    }
}
