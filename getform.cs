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
    public partial class getform : Form
    {
        
        public getform()
        {
            InitializeComponent();
        }

        private void getform_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addrule_button_Click(object sender, EventArgs e) // This is the button that will take the user to the rules input form
        {
            loadform(new Rulesinput());
            this.getform_design.Hide();
            this.addrule_button.Hide();
            this.packet_button.Hide();
            this.getstart_label.Hide();
            this.back_button_getform.Hide();
        }
        public void loadform(object form) // This function will load the form that is passed to it as a parameter
        {
            if (this.getform_panel.Controls.Count > 0)
            {
                this.getform_panel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.getform_panel.Controls.Add(f);
            this.getform_panel.Tag = f;
            f.Show();
        }
        private void getstart_label_Click(object sender, EventArgs e)
        {

        }

        private void packet_button_Click(object sender, EventArgs e) // This is the button that will take the user to the packet input form
        {
            loadform(new packetform());
            this.getform_design.Hide();
            this.addrule_button.Hide();
            this.packet_button.Hide();
            this.getstart_label.Hide();
            this.back_button_getform.Hide();
        }

        private void getform_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_panel_getform_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e) // This is the back button that will take the user back to the main form
        {
            this.Hide();
            main main = new main();
            main.Show();
        }
    }
  
}
