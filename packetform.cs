using System.IO;
using System.Windows.Forms;
using System;

namespace _232137_OOP_project
{
    public partial class packetform : Form
    {
        string textfile= @"E:\\rules.txt";   

        // Constructor
        public packetform()
        {
            InitializeComponent();
            SetInitialDemoText(); // Set initial demo text
            AttachEventHandlers(); // Attach event handlers to controls
        }

        // Method to set initial demo text
        private void SetInitialDemoText()
        {
            packet_srcip_textbox.Text = "xxx.xxx.xxx.xxx";
            packet_dstip_textbox.Text = "xxx.xxx.xxx.xxx";
            Packet_srcport_textbox.Text = "0-65353";
            packet_dstport_textbox.Text = "0-65353";
            packet_data_textbox.Text = "Enter packet data here";
            // Set the text color to gray
            packet_srcip_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            packet_dstip_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            Packet_srcport_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            packet_dstport_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            packet_data_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        // Method to attach event handlers to controls
        private void AttachEventHandlers()
        {
            // Source IP TextBox events
            packet_srcip_textbox.Enter += Packetsrcip_textbox_Enter;
            packet_srcip_textbox.Leave += Packetsrcip_textbox_Leave;
            // Destination IP TextBox events
            packet_dstip_textbox.Enter += Packetdstip_textbox_Enter;
            packet_dstip_textbox.Leave += Packetdstip_textbox_Leave;
            // Source Port TextBox events
            Packet_srcport_textbox.Enter += Packetsrcport_textbox_Enter;
            Packet_srcport_textbox.Leave += Packetsrcport_textbox_Leave;
            // Destination Port TextBox events
            packet_dstport_textbox.Enter += Packetdstport_textbox_Enter;
            packet_dstport_textbox.Leave += Packetdstport_textbox_Leave;
            // Data TextBox events
            packet_data_textbox.Enter += Packetdata_textbox_Enter;
            packet_data_textbox.Leave += Packetdata_textbox_Leave;
            // Keydown event for Enter key
        }

        // Event handler for Source IP TextBox Enter event
        private void Packetsrcip_textbox_Enter(object sender, EventArgs e)
        {
            if (packet_srcip_textbox.Text == "xxx.xxx.xxx.xxx")
            {
                packet_srcip_textbox.Text = "";
                packet_srcip_textbox.ForeColor = System.Drawing.Color.White;
            }
        }

        // Event handler for Source IP TextBox Leave event
        private void Packetsrcip_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packet_srcip_textbox.Text))
            {
                packet_srcip_textbox.Text = "xxx.xxx.xxx.xxx";
                packet_srcip_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        // Event handler for Destination IP TextBox Enter event
        private void Packetdstip_textbox_Enter(object sender, EventArgs e)
        {
            if (packet_dstip_textbox.Text == "xxx.xxx.xxx.xxx")
            {
                packet_dstip_textbox.Text = "";
                packet_dstip_textbox.ForeColor = System.Drawing.Color.White;
            }
        }

        // Event handler for Destination IP TextBox Leave event
        private void Packetdstip_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packet_dstip_textbox.Text))
            {
                packet_dstip_textbox.Text = "xxx.xxx.xxx.xxx";
                packet_dstip_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        // Event handler for Source Port TextBox Enter event
        private void Packetsrcport_textbox_Enter(object sender, EventArgs e)
        {
            if (Packet_srcport_textbox.Text == "0-65353")
            {
                Packet_srcport_textbox.Text = "";
                Packet_srcport_textbox.ForeColor = System.Drawing.Color.White;
            }
        }

        // Event handler for Source Port TextBox Leave event
        private void Packetsrcport_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Packet_srcport_textbox.Text))
            {
                Packet_srcport_textbox.Text = "0-65353";
                Packet_srcport_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        // Event handler for Destination Port TextBox Enter event
        private void Packetdstport_textbox_Enter(object sender, EventArgs e)
        {
            if (packet_dstport_textbox.Text == "0-65353")
            {
                packet_dstport_textbox.Text = "";
                packet_dstport_textbox.ForeColor = System.Drawing.Color.White;
            }
        }

        // Event handler for Destination Port TextBox Leave event
        private void Packetdstport_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packet_dstport_textbox.Text))
            {
                packet_dstport_textbox.Text = "0-65353";
                packet_dstport_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        // Event handler for Data TextBox Enter event
        private void Packetdata_textbox_Enter(object sender, EventArgs e)
        {
            if (packet_data_textbox.Text == "Enter packet data here")
            {
                packet_data_textbox.Text = "";
                packet_data_textbox.ForeColor = System.Drawing.Color.White;
            }
        }

        // Event handler for Data TextBox Leave event
        private void Packetdata_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(packet_data_textbox.Text))
            {
                packet_data_textbox.Text = "Enter packet data here";
                packet_data_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        // Event handler for check_button Click event
        private void check_button_Click(object sender, EventArgs e)
        {
            string sourceIP = packet_srcip_textbox.Text;
            string destinationIP = packet_dstip_textbox.Text;
            string sourcePort = Packet_srcport_textbox.Text;
            string destinationPort = packet_dstport_textbox.Text;
            string protocol = packet_protocol_comboBox.SelectedItem?.ToString();
            string data = packet_data_textbox.Text;

            if (string.IsNullOrEmpty(sourceIP) || string.IsNullOrEmpty(destinationIP) || string.IsNullOrEmpty(sourcePort) || string.IsNullOrEmpty(destinationPort) || string.IsNullOrEmpty(protocol) || string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Please fill in all packet fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string decision = CheckRules(sourceIP, destinationIP, sourcePort, destinationPort, protocol, data);
            MessageBox.Show(decision, "Decision", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearPacketFormFields(); // Clear the packet form fields
        }

        // Method to check rules based on packet details
        private string CheckRules(string sourceIP, string destinationIP, string sourcePort, string destinationPort, string protocol, string data)
        {
            string filePath = "E:\\rules.txt";
            if (!File.Exists(filePath))
            {
                return "No rules file found.";
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length != 8)
                    {
                        continue; // Skip invalid rules
                    }

                    string ruleNumber = parts[0];
                    string ruleIPType = parts[1];
                    string ruleIP = parts[2];
                    string rulePortType = parts[3];
                    string rulePort = parts[4];
                    string ruleProtocol = parts[5];
                    string ruleDecision = parts[6];
                    string matchString = parts[7];

                    bool ipMatch = (ruleIPType == "SRC" && sourceIP == ruleIP) || (ruleIPType == "DST" && destinationIP == ruleIP);
                    bool portMatch = (rulePortType == "SP" && sourcePort == rulePort) || (rulePortType == "DP" && destinationPort == rulePort);
                    bool protocolMatch = protocol == ruleProtocol;
                    bool dataMatch = data.Contains(matchString);
 
                    if ((ipMatch || portMatch || protocolMatch || dataMatch))
                    {
                        //also display what part of the rule matched

                        string time = DateTime.Now.ToString("HH:mm:ss");

                        return $"Decision: {ruleDecision}\nRule Applied: {ruleNumber}\nTime:{time}";
                    }
                }
            }

            return "No matching rule found.";
        }

        // Method to clear packet form fields
        private void ClearPacketFormFields()
        {
            packet_srcip_textbox.Clear();
            packet_dstip_textbox.Clear();
            Packet_srcport_textbox.Clear();
            packet_dstport_textbox.Clear();
            packet_protocol_comboBox.SelectedIndex = -1;
            packet_data_textbox.Clear();
        }

        // Method to load a form into the packet panel
        public void loadform(object form)
        {
            if (this.packet_panel.Controls.Count > 0)
            {
                this.packet_panel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.packet_panel.Controls.Add(f);
            this.packet_panel.Tag = f;
            f.Show();
        }

        // Event handler for back_button_packets Click event
        private void back_button_packets_Click(object sender, EventArgs e)
        {
            loadform(new getform());
            HidePacketFormFields(); // Hide packet form fields
        }

        // Method to hide packet form fields
        private void HidePacketFormFields()
        {
            back_button_packets.Hide();
            getstart_label.Hide();
            packet_data_textbox.Hide();
            packet_dstip_textbox.Hide();
            packet_dstport_textbox.Hide();
            packet_protocol_comboBox.Hide();
            packet_srcip_textbox.Hide();
            Packet_srcport_textbox.Hide();
            check_button.Hide();
            srcip_label.Hide();
            dstip_label.Hide();
            srcport_label.Hide();
            dstport_label.Hide();
            protocol_label.Hide();
           
            data_label.Hide();
        }

        private void packet_srcip_textbox_TextChanged(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider1.SetError(packet_srcip_textbox, "");

            // Get the text from the source IP TextBox
            string ipAddress = packet_srcip_textbox.Text.Trim();

            // Check if the IP address is empty
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                errorProvider1.SetError(packet_srcip_textbox, "IP address is required.");
                return;
            }

            // Split the IP address by periods
            string[] parts = ipAddress.Split('.');

            // Check if there are exactly four parts
            if (parts.Length != 4)
            {
                errorProvider1.SetError(packet_srcip_textbox, "Invalid IP address format. Please use xxx.xxx.xxx.xxx format.");
                return;
            }

            // Check if each part is a valid number between 0 and 255
            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int num) || num < 0 || num > 255)
                {
                    errorProvider1.SetError(packet_srcip_textbox, "Invalid IP address format. Each part must be a number between 0 and 255.");
                    return;
                }
            }
        }

        private void packet_dstip_textbox_TextChanged(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider1.SetError(packet_dstip_textbox, "");
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Get the text from the source IP TextBox
            string ipAddress = packet_dstip_textbox.Text.Trim();

            // Check if the IP address is empty
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                errorProvider1.SetError(packet_dstip_textbox, "IP address is required.");
                return;
            }

            // Split the IP address by periods
            string[] parts = ipAddress.Split('.');

            // Check if there are exactly four parts
            if (parts.Length != 4)
            {
                errorProvider1.SetError(packet_dstip_textbox, "Invalid IP address format. Please use xxx.xxx.xxx.xxx format.");
                return;
            }

            // Check if each part is a valid number between 0 and 255
            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int num) || num < 0 || num > 255)
                {
                    errorProvider1.SetError(packet_dstip_textbox, "Invalid IP address format. Each part must be a number between 0 and 255.");
                    return;
                }
            }
        }

        private void Packet_srcport_textbox_TextChanged(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider1.SetError(Packet_srcport_textbox, "");

            // Get the text from the source port TextBox
            string portText = Packet_srcport_textbox.Text.Trim();

            // Check if the port number is empty
            if (string.IsNullOrWhiteSpace(portText))
            {
                errorProvider1.SetError(Packet_srcport_textbox, "Port number is required.");
                return;
            }

            // Check if the input is a valid number
            if (!int.TryParse(portText, out int port))
            {
                errorProvider1.SetError(Packet_srcport_textbox, "Please enter a numeric value.");
                return;
            }

            // Check if the port number is within the valid range (0 - 65535)
            if (port < 0 || port > 65535)
            {
                errorProvider1.SetError(Packet_srcport_textbox, "Port number must be between 0 and 65535.");
                return;
            }
        }

        private void packet_dstport_textbox_TextChanged(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider1.SetError(packet_dstport_textbox, "");

            // Get the text from the source port TextBox
            string portText = packet_dstport_textbox.Text.Trim();

            // Check if the port number is empty
            if (string.IsNullOrWhiteSpace(portText))
            {
                errorProvider1.SetError(packet_dstport_textbox, "Port number is required.");
                return;
            }

            // Check if the input is a valid number
            if (!int.TryParse(portText, out int port))
            {
                errorProvider1.SetError(packet_dstport_textbox, "Please enter a numeric value.");
                return;
            }

            // Check if the port number is within the valid range (0 - 65535)
            if (port < 0 || port > 65535)
            {
                errorProvider1.SetError(packet_dstport_textbox, "Port number must be between 0 and 65535.");
                return;
            }
        }
        private void packet_data_textbox_TextChanged(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider1.SetError(packet_data_textbox, "");

            // Get the text from the data TextBox
            string data = packet_data_textbox.Text.Trim();

            // Check if the data is empty
            if (string.IsNullOrWhiteSpace(data))
            {
                errorProvider1.SetError(packet_data_textbox, "Data is required.");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(File.Exists(textfile))
            {
                string text = File.ReadAllText(textfile);
                showrule_textbox.Text= text;
            }
        }

        private void packet_protocol_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
