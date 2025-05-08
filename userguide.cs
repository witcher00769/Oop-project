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
    public partial class userguide : Form
    {
        public userguide()
        {
            InitializeComponent();
            
        }
        private void userguide_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false; 

            // Define bold font
            Font boldFont = new Font(richTextBox1.Font, FontStyle.Bold);
            Font regularFont = new Font(richTextBox1.Font, FontStyle.Regular);

            // Add and format text
            AddBoldText("FIREWALL TUTOR GUI PROJECT USER GUIDE\n", boldFont);
            AddRegularText("Welcome to the Firewall Tutor GUI! This guide will help you navigate through the features of the Firewall Tutor and make the most out of its functionalities. Follow the steps below to get started with ease.\n\n", regularFont);

            AddBoldText("HOME MAIN PAGE\n", boldFont);
            AddRegularText("When you first launch the Firewall Tutor GUI, you will see the Home Main Page. This page introduces you to the interface and provides a brief overview of the application's purpose. To begin using the application, click on the Get Started button located at the bottom of the screen.\n\n", regularFont);

            AddBoldText("GETTING STARTED\n", boldFont);
            AddRegularText("Upon clicking the Get Started button, you will be redirected to the main functionality page. Here, you will see two primary options:\n- Add Rule\n- Packet\n\n", regularFont);

            AddBoldText("ADDING A RULE\n", boldFont);
            AddRegularText("To add a new rule, follow these steps:\n", regularFont);
            AddRegularText("1. Click on the Add Rule button:\n", regularFont);
            AddRegularText("   - This will open a new form where you can input the details for your new firewall rule.\n", regularFont);
            AddRegularText("2. Fill in the Rule Details:\n", regularFont);
            AddRegularText("   - Rule Number: Enter a unique number to identify the rule.\n", regularFont);
            AddRegularText("   - IP Address: Specify the IP address to which this rule will apply.\n", regularFont);
            AddRegularText("   - Port Number: Enter the port number for the rule.\n", regularFont);
            AddRegularText("   - Select Protocol: Choose the appropriate protocol from the dropdown menu (e.g., TCP, UDP).\n", regularFont);
            AddRegularText("   - Select Decision: Decide whether the rule will allow or block the traffic and select the appropriate decision from the dropdown menu.\n", regularFont);
            AddRegularText("3. Save the Rule:\n", regularFont);
            AddRegularText("   - Once all the details are filled in, click the Save button to add the rule to your firewall configuration.\n\n", regularFont);

            AddBoldText("ENTERING PACKET INFORMATION\n", boldFont);
            AddRegularText("To check a packet against the firewall rules, follow these steps:\n", regularFont);
            AddRegularText("1. Click on the Packet button:\n", regularFont);
            AddRegularText("   - This will open a new form where you can input the packet information.\n", regularFont);
            AddRegularText("2. Fill in the Packet Details:\n", regularFont);
            AddRegularText("   - Source IP: Enter the IP address of the source of the packet.\n", regularFont);
            AddRegularText("   - Destination IP: Enter the IP address of the destination of the packet.\n", regularFont);
            AddRegularText("   - Source Port: Enter the source port number.\n", regularFont);
            AddRegularText("   - Destination Port: Enter the destination port number.\n", regularFont);
            AddRegularText("   - Select Protocol: Choose the protocol used by the packet from the dropdown menu (e.g., TCP, UDP).\n", regularFont);
            AddRegularText("   - Enter Data: Provide any additional data that the packet carries.\n", regularFont);
            AddRegularText("3. Check the Packet:\n", regularFont);
            AddRegularText("   - After entering all the details, click the Check button to see if the packet matches any of the existing firewall rules. The application will provide a decision based on the rules you've set up.\n\n", regularFont);

            AddBoldText("TIPS FOR EFFICIENT USE\n", boldFont);
            AddRegularText("- Consistency: Make sure to use consistent rule numbers and clear IP addresses to avoid confusion.\n", regularFont);
            AddRegularText("- Documentation: Regularly document the rules you add and the decisions you make for future reference.\n", regularFont);
            AddRegularText("- Review Rules: Periodically review and update your rules to ensure they are effective against current threats.\n\n", regularFont);

            AddBoldText("TROUBLESHOOTING\n", boldFont);
            AddRegularText("If you encounter any issues or have questions:\n", regularFont);
            AddRegularText("- Refer to the Documentation: The User Guide button on the main page provides comprehensive help and tutorials.\n", regularFont);
            AddRegularText("- Contact Support: If you need further assistance, please contact our support team through the Help Center.\n\n", regularFont);

            AddRegularText("By following this guide, you will be able to effectively manage your firewall using the Firewall Tutor GUI. Explore, configure, and secure your network with confidence!\n\n", regularFont);
            AddBoldText("Welcome aboard and happy networking!\n", boldFont);

            richTextBox1.ReadOnly = true; // Make it read-only 
        }

        private void AddBoldText(string text, Font font) // Function to add bold text to the RichTextBox
        {
            richTextBox1.SelectionFont = font;
            richTextBox1.AppendText(text);
        }

        private void AddRegularText(string text, Font font) // Function to add regular text to the RichTextBox
        {
            richTextBox1.SelectionFont = font;
            richTextBox1.AppendText(text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
