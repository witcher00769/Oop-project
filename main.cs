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
    //form that is inherited from the main form
    public partial class main : Form 
    {
        public main()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.main_panel.Controls.Count > 0)
            {
                this.main_panel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void getstart_button_Click(object sender, EventArgs e) // This is the button that will take the user to the getform form
        {
            loadform(new getform());
            this.Blue_picture.Hide();
            this.getstart_button.Hide();
            this.FWtitle_label.Hide();
            this.FWsubtitle_label.Hide();
            this.FWdescrip_label.Hide();
        }

        private void mainF_panel_Paint(object sender, PaintEventArgs e) 
        {
           
        }

        private void exit_button_Click(object sender, EventArgs e) // This is the button that will close the application
        {
            this.Close();
        }

        private void Dashboard_button_Click(object sender, EventArgs e) // This is the button that will take the user to the main form
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void About_button_Click(object sender, EventArgs e) // This is the button that will take the user to the about form
        {
            loadform(new About());
            this.Blue_picture.Hide();
            this.getstart_button.Hide();
            this.FWtitle_label.Hide();
            this.FWsubtitle_label.Hide();
            this.FWdescrip_label.Hide();
        }

        private void user_button_Click(object sender, EventArgs e) // This is the button that will take the user to the user guide form
        {
            loadform(new userguide());
            this.Blue_picture.Hide();
            this.getstart_button.Hide();
            this.FWtitle_label.Hide();
            this.FWsubtitle_label.Hide();
            this.FWdescrip_label.Hide();

        }

        private void Login_button_Click(object sender, EventArgs e) // This is the button that will take the user to the login form
        {
            this.Hide();
            login l = new login();
            l.Show();

        }
    }
}
