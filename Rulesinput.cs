using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace _232137_OOP_project
{
    // Defining a class called Rulesinput which inherits from the Form class
    public partial class Rulesinput : Form
    {
        // Private fields to store rule properties
        private string sourceIP;
        private string destinationIP;
        private int sourcePort;
        private int destinationPort;
        private string protocol;
        private string decision;
        private string matchString;

        // Constructor for the Rulesinput class
        public Rulesinput()
        {
            // Initialize form components
            InitializeComponent();

            // Set initial text and color for TextBoxes
            rulenum_textbox.Text = "";
            IP_textbox.Text = "xxx.xxx.xxx.xxx";
            Ports_textbox.Text = "0-65535";
            matchString_textbox.Text = "Enter match string"; // New TextBox for match string
            IP_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            Ports_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            rulenum_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            matchString_textbox.ForeColor = System.Drawing.SystemColors.GrayText;

            // Attach event handlers for TextBoxes
            IP_textbox.Enter += IPaddress_textbox_Enter;
            IP_textbox.Leave += IPaddress_textbox_Leave;
            Ports_textbox.Enter += Port_textbox_Enter;
            Ports_textbox.Leave += Port_textbox_Leave;
            rulenum_textbox.Enter += Rule_Enter;
            rulenum_textbox.Leave += Rule_Leave;
            matchString_textbox.Enter += MatchString_textbox_Enter; // Event handler for match string
            matchString_textbox.Leave += MatchString_textbox_Leave;
          
         
        }

        private void IPaddress_textbox_Enter(object sender, EventArgs e) // Event handler for IP address TextBox 
        {
            if (IP_textbox.Text == "xxx.xxx.xxx.xxx")
            {
                IP_textbox.Text = "";
                IP_textbox.ForeColor = System.Drawing.Color.White;
            }
        }

        private void IPaddress_textbox_Leave(object sender, EventArgs e) // Event handler for IP address TextBox
        {
            if (string.IsNullOrWhiteSpace(IP_textbox.Text))
            {
                IP_textbox.Text = "xxx.xxx.xxx.xxx";
                IP_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void Port_textbox_Enter(object sender, EventArgs e) // Event handler for Port TextBox
        {
            if (Ports_textbox.Text == "0-65535")
            {
                Ports_textbox.Text = "";
                Ports_textbox.ForeColor = System.Drawing.Color.White; 
            }
        }

        private void Port_textbox_Leave(object sender, EventArgs e) // Event handler for Port TextBox
        {
            if (string.IsNullOrWhiteSpace(Ports_textbox.Text))
            {
                Ports_textbox.Text = "0-65535";
                Ports_textbox.ForeColor = System.Drawing.SystemColors.GrayText; 
            }
        }

        private void Rule_Enter(object sender, EventArgs e) // Event handler for Rule TextBox
        {
            if (rulenum_textbox.Text == "")
            {
                rulenum_textbox.Text = "";
                rulenum_textbox.ForeColor = System.Drawing.Color.White;
            }
        }

        private void Rule_Leave(object sender, EventArgs e) // Event handler for Rule TextBox
        {
            if (string.IsNullOrWhiteSpace(rulenum_textbox.Text))
            {
                rulenum_textbox.Text = "";
                rulenum_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void MatchString_textbox_Enter(object sender, EventArgs e) // Event handler for match string TextBox
        {
            if (matchString_textbox.Text == "Enter match string")
            {
                matchString_textbox.Text = "";
                matchString_textbox.ForeColor = System.Drawing.Color.White;
            }
        }

        private void MatchString_textbox_Leave(object sender, EventArgs e) // Event handler for match string TextBox
        {
            if (string.IsNullOrWhiteSpace(matchString_textbox.Text))
            {
                matchString_textbox.Text = "Enter match string";
                matchString_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }


        private void Rulesinput_Load(object sender, EventArgs e) // Load the form and set default values for ComboBoxes
        {
            Ip_comboBox.SelectedIndex = 0;
            Ports_comboBox.SelectedIndex = 0;
            protocol_comboBox.SelectedIndex = 0;
            decision_comboBox.SelectedIndex = 0;
        }

        private void ruleNumTextBox_KeyPress(object sender, KeyPressEventArgs e) // Validate input for rule number
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only integers for Rule Number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string ruleNumber = rulenum_textbox.Text;
            string ipAddress = IP_textbox.Text;
            string port = Ports_textbox.Text;
            string protocol = protocol_comboBox.SelectedItem?.ToString();
            string decision = decision_comboBox.SelectedItem?.ToString();
            string matchString = matchString_textbox.Text; // Capture match string

            if (!int.TryParse(ruleNumber, out _))
            {
                MessageBox.Show("Rule number must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidIP(ipAddress))
            {
                MessageBox.Show("Please enter a valid IP address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(ipAddress) || string.IsNullOrEmpty(port) || string.IsNullOrEmpty(protocol) || string.IsNullOrEmpty(decision) || string.IsNullOrEmpty(matchString))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ipAddressType = Ip_comboBox.SelectedItem.ToString() == "Source IP" ? "SRC" : "DST";
            string portType = Ports_comboBox.SelectedItem.ToString() == "Source Port" ? "SP" : "DP";

            string rule = $"{ruleNumber},{ipAddressType},{ipAddress},{portType},{port},{protocol},{decision},{matchString}"; // Include match string

            SaveRule(rule);

            MessageBox.Show("Rule saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rulenum_textbox.Clear();
            IP_textbox.Clear();
            Ports_textbox.Clear();
            protocol_comboBox.SelectedIndex = 0;
            decision_comboBox.SelectedIndex = 0;
            matchString_textbox.Clear(); // Clear match string textbox
        }

        private bool IsValidIP(string ip)
        {
            if (ip == null) return false;

            var parts = ip.Split('.');
            if (parts.Length != 4) return false;

            foreach (var part in parts)
            {
                if (!int.TryParse(part, out int num) || num < 0 || num > 255)
                {
                    return false;
                }
            }
            return true;
        }

        private void SaveRule(string rule) // Save rule to a file
        {
            string filePath = "E:\\rules.txt";
            //new rule is added to the file to next line
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(rule);
            }
        }

        public void loadform(object form) // Method to load a form into the panel
        {
            if (this.Rulesinput_panel.Controls.Count > 0)
            {
                this.Rulesinput_panel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Rulesinput_panel.Controls.Add(f);
            this.Rulesinput_panel.Tag = f;
            f.Show();
        }

        private void back_button_rulesinput_Click_1(object sender, EventArgs e)
        {
            loadform(new getform());
            this.rulenum_label.Hide();
            this.rulenum_textbox.Hide();
            this.ip_label.Hide();
            this.IP_textbox.Hide();
            this.Ip_comboBox.Hide();
            this.Ports_label.Hide();
            this.Ports_textbox.Hide();
            this.Ports_comboBox.Hide();
            this.Protocol_label.Hide();
            this.protocol_comboBox.Hide();
            this.decision_label.Hide();
            this.decision_comboBox.Hide();
            this.next_button.Hide();
            this.pictureBox1.Hide();
            this.back_button_rulesinput.Hide();
            this.data_label.Hide(); 
            this.matchString_textbox.Hide(); 
        }

        private void rulenum_textbox_TextChanged(object sender, EventArgs e) // Validate rule number
        {
            errorProvider1.SetError(rulenum_textbox, "");
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            string rulenumber = rulenum_textbox.Text.Trim();
            if (string.IsNullOrWhiteSpace(rulenumber))
            {
                errorProvider1.SetError(rulenum_textbox, "Rule number is required.");
                return;
            }
            else if (!IsNumeric(rulenum_textbox.Text))
            {
                rulenum_textbox.Text = rulenum_textbox.Text.Remove(rulenum_textbox.Text.Length - 1);
                rulenum_textbox.SelectionStart = rulenum_textbox.Text.Length;
                errorProvider1.SetError(rulenum_textbox, "Please enter a numeric value");
            }
        }

        private bool IsNumeric(string text) // Check if the input is a number
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void IP_textbox_TextChanged(object sender, EventArgs e) // Validate IP address
        {
            errorProvider1.SetError(IP_textbox, "");
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            string ipAddress = IP_textbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                errorProvider1.SetError(IP_textbox, "IP address is required.");
                return;
            }

            string[] parts = ipAddress.Split('.');

            if (parts.Length != 4)
            {
                errorProvider1.SetError(IP_textbox, "Invalid IP address format. Please use xxx.xxx.xxx.xxx format.");
                return;
            }

            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int num) || num < 0 || num > 255)
                {
                    errorProvider1.SetError(IP_textbox, "Invalid IP address format. Each part must be a number between 0 and 255.");
                    return;
                }
            }
        }

        private void Ports_textbox_TextChanged(object sender, EventArgs e) // Validate port number
        {
            errorProvider1.SetError(Ports_textbox, "");

            string portText = Ports_textbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(portText))
            {
                errorProvider1.SetError(Ports_textbox, "Port number is required.");
                return;
            }

            if (!int.TryParse(portText, out int port))
            {
                errorProvider1.SetError(Ports_textbox, "Please enter a numeric value.");
                return;
            }

            if (port < 0 || port > 65535)
            {
                errorProvider1.SetError(Ports_textbox, "Port number must be between 0 and 65535.");
                return;
            }
        }

        // Method to apply rules to a packet
        public bool ApplyRuleToPacket(FirewallRule rule, Packet packet)
        {
            // Check if the match string is found in the packet data
            if (packet.Data.Contains(rule.MatchString))
            {
                return true;
            }
            return false;
        }
    }

    // Define a class for FirewallRule
    public class FirewallRule
    {
        // Properties of a FirewallRule
        public int RuleNumber { get; set; }
        public string SourceIP { get; set; }
        public string DestinationIP { get; set; }
        public int SourcePort { get; set; }
        public int DestinationPort { get; set; }
        public string Protocol { get; set; }
        public string Decision { get; set; }
        public string MatchString { get; set; } 
    }

    // Define a class for Packet
    public class Packet
    {
        // Properties of a Packet
        public string SourceIP { get; set; }
        public string DestinationIP { get; set; }
        public int SourcePort { get; set; }
        public int DestinationPort { get; set; }
        public string Protocol { get; set; }
        public string Data { get; set; } 
    }
}
