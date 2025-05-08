namespace _232137_OOP_project
{
    partial class packetform
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
            this.components = new System.ComponentModel.Container();
            this.data_label = new System.Windows.Forms.Label();
            this.protocol_label = new System.Windows.Forms.Label();
            this.dstport_label = new System.Windows.Forms.Label();
            this.srcport_label = new System.Windows.Forms.Label();
            this.dstip_label = new System.Windows.Forms.Label();
            this.srcip_label = new System.Windows.Forms.Label();
            this.packet_data_textbox = new System.Windows.Forms.TextBox();
            this.Packet_srcport_textbox = new System.Windows.Forms.TextBox();
            this.packet_dstport_textbox = new System.Windows.Forms.TextBox();
            this.packet_dstip_textbox = new System.Windows.Forms.TextBox();
            this.packet_srcip_textbox = new System.Windows.Forms.TextBox();
            this.getstart_label = new System.Windows.Forms.Label();
            this.check_button = new System.Windows.Forms.Button();
            this.packet_protocol_comboBox = new System.Windows.Forms.ComboBox();
            this.packet_panel = new System.Windows.Forms.Panel();
            this.back_button_packets = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.showrule_button = new System.Windows.Forms.Button();
            this.showrule_textbox = new System.Windows.Forms.TextBox();
            this.packet_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_label.ForeColor = System.Drawing.Color.White;
            this.data_label.Location = new System.Drawing.Point(62, 372);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(49, 18);
            this.data_label.TabIndex = 40;
            this.data_label.Text = "Data:";
            // 
            // protocol_label
            // 
            this.protocol_label.AutoSize = true;
            this.protocol_label.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protocol_label.ForeColor = System.Drawing.Color.White;
            this.protocol_label.Location = new System.Drawing.Point(62, 290);
            this.protocol_label.Name = "protocol_label";
            this.protocol_label.Size = new System.Drawing.Size(80, 18);
            this.protocol_label.TabIndex = 39;
            this.protocol_label.Text = "protocol:";
            // 
            // dstport_label
            // 
            this.dstport_label.AutoSize = true;
            this.dstport_label.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstport_label.ForeColor = System.Drawing.Color.White;
            this.dstport_label.Location = new System.Drawing.Point(62, 250);
            this.dstport_label.Name = "dstport_label";
            this.dstport_label.Size = new System.Drawing.Size(141, 18);
            this.dstport_label.TabIndex = 38;
            this.dstport_label.Text = "destination port:";
            // 
            // srcport_label
            // 
            this.srcport_label.AutoSize = true;
            this.srcport_label.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcport_label.ForeColor = System.Drawing.Color.White;
            this.srcport_label.Location = new System.Drawing.Point(62, 205);
            this.srcport_label.Name = "srcport_label";
            this.srcport_label.Size = new System.Drawing.Size(103, 18);
            this.srcport_label.TabIndex = 37;
            this.srcport_label.Text = "source port:";
            // 
            // dstip_label
            // 
            this.dstip_label.AutoSize = true;
            this.dstip_label.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dstip_label.ForeColor = System.Drawing.Color.White;
            this.dstip_label.Location = new System.Drawing.Point(62, 155);
            this.dstip_label.Name = "dstip_label";
            this.dstip_label.Size = new System.Drawing.Size(187, 18);
            this.dstip_label.TabIndex = 36;
            this.dstip_label.Text = "destination IP address:";
            // 
            // srcip_label
            // 
            this.srcip_label.AutoSize = true;
            this.srcip_label.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcip_label.ForeColor = System.Drawing.Color.White;
            this.srcip_label.Location = new System.Drawing.Point(62, 100);
            this.srcip_label.Name = "srcip_label";
            this.srcip_label.Size = new System.Drawing.Size(149, 18);
            this.srcip_label.TabIndex = 35;
            this.srcip_label.Text = "source IP address:";
            // 
            // packet_data_textbox
            // 
            this.packet_data_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.packet_data_textbox.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packet_data_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.packet_data_textbox.Location = new System.Drawing.Point(295, 364);
            this.packet_data_textbox.Name = "packet_data_textbox";
            this.packet_data_textbox.Size = new System.Drawing.Size(221, 26);
            this.packet_data_textbox.TabIndex = 34;
            // 
            // Packet_srcport_textbox
            // 
            this.Packet_srcport_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Packet_srcport_textbox.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Packet_srcport_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.Packet_srcport_textbox.Location = new System.Drawing.Point(295, 205);
            this.Packet_srcport_textbox.Name = "Packet_srcport_textbox";
            this.Packet_srcport_textbox.Size = new System.Drawing.Size(221, 26);
            this.Packet_srcport_textbox.TabIndex = 32;
            this.Packet_srcport_textbox.TextChanged += new System.EventHandler(this.Packet_srcport_textbox_TextChanged);
            // 
            // packet_dstport_textbox
            // 
            this.packet_dstport_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.packet_dstport_textbox.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packet_dstport_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.packet_dstport_textbox.Location = new System.Drawing.Point(295, 250);
            this.packet_dstport_textbox.Name = "packet_dstport_textbox";
            this.packet_dstport_textbox.Size = new System.Drawing.Size(221, 26);
            this.packet_dstport_textbox.TabIndex = 31;
            this.packet_dstport_textbox.TextChanged += new System.EventHandler(this.packet_dstport_textbox_TextChanged);
            // 
            // packet_dstip_textbox
            // 
            this.packet_dstip_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.packet_dstip_textbox.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packet_dstip_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.packet_dstip_textbox.Location = new System.Drawing.Point(295, 155);
            this.packet_dstip_textbox.Name = "packet_dstip_textbox";
            this.packet_dstip_textbox.Size = new System.Drawing.Size(221, 26);
            this.packet_dstip_textbox.TabIndex = 30;
            this.packet_dstip_textbox.TextChanged += new System.EventHandler(this.packet_dstip_textbox_TextChanged);
            // 
            // packet_srcip_textbox
            // 
            this.packet_srcip_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.packet_srcip_textbox.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packet_srcip_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.packet_srcip_textbox.Location = new System.Drawing.Point(295, 100);
            this.packet_srcip_textbox.Name = "packet_srcip_textbox";
            this.packet_srcip_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.packet_srcip_textbox.Size = new System.Drawing.Size(221, 26);
            this.packet_srcip_textbox.TabIndex = 29;
            this.packet_srcip_textbox.TextChanged += new System.EventHandler(this.packet_srcip_textbox_TextChanged);
            // 
            // getstart_label
            // 
            this.getstart_label.AutoSize = true;
            this.getstart_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getstart_label.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getstart_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.getstart_label.Location = new System.Drawing.Point(73, 9);
            this.getstart_label.Name = "getstart_label";
            this.getstart_label.Size = new System.Drawing.Size(479, 54);
            this.getstart_label.TabIndex = 41;
            this.getstart_label.Text = "Let\'s Check Your Network!";
            // 
            // check_button
            // 
            this.check_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.check_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.check_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.check_button.FlatAppearance.BorderSize = 2;
            this.check_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.check_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(142)))));
            this.check_button.Location = new System.Drawing.Point(316, 402);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(165, 58);
            this.check_button.TabIndex = 42;
            this.check_button.Text = "Check";
            this.check_button.UseVisualStyleBackColor = false;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // packet_protocol_comboBox
            // 
            this.packet_protocol_comboBox.BackColor = System.Drawing.Color.White;
            this.packet_protocol_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packet_protocol_comboBox.FormattingEnabled = true;
            this.packet_protocol_comboBox.Items.AddRange(new object[] {
            "HTTP",
            "FTP",
            "UDP",
            "IP",
            "SMTP",
            "SSH",
            "POP",
            "TCP",
            "ARP",
            "IMAP",
            "DNS"});
            this.packet_protocol_comboBox.Location = new System.Drawing.Point(65, 324);
            this.packet_protocol_comboBox.Name = "packet_protocol_comboBox";
            this.packet_protocol_comboBox.Size = new System.Drawing.Size(161, 28);
            this.packet_protocol_comboBox.TabIndex = 43;
            this.packet_protocol_comboBox.SelectedIndexChanged += new System.EventHandler(this.packet_protocol_comboBox_SelectedIndexChanged);
            // 
            // packet_panel
            // 
            this.packet_panel.Controls.Add(this.check_button);
            this.packet_panel.Controls.Add(this.data_label);
            this.packet_panel.Controls.Add(this.dstip_label);
            this.packet_panel.Controls.Add(this.packet_protocol_comboBox);
            this.packet_panel.Controls.Add(this.packet_data_textbox);
            this.packet_panel.Controls.Add(this.srcip_label);
            this.packet_panel.Controls.Add(this.packet_dstport_textbox);
            this.packet_panel.Controls.Add(this.protocol_label);
            this.packet_panel.Controls.Add(this.Packet_srcport_textbox);
            this.packet_panel.Controls.Add(this.showrule_textbox);
            this.packet_panel.Controls.Add(this.packet_dstip_textbox);
            this.packet_panel.Controls.Add(this.dstport_label);
            this.packet_panel.Controls.Add(this.packet_srcip_textbox);
            this.packet_panel.Controls.Add(this.showrule_button);
            this.packet_panel.Controls.Add(this.srcport_label);
            this.packet_panel.Location = new System.Drawing.Point(-3, 2);
            this.packet_panel.Name = "packet_panel";
            this.packet_panel.Size = new System.Drawing.Size(935, 469);
            this.packet_panel.TabIndex = 45;
            // 
            // back_button_packets
            // 
            this.back_button_packets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_button_packets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.back_button_packets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button_packets.Image = global::_232137_OOP_project.Properties.Resources.icons8_go_back_24;
            this.back_button_packets.Location = new System.Drawing.Point(12, 9);
            this.back_button_packets.Name = "back_button_packets";
            this.back_button_packets.Size = new System.Drawing.Size(71, 67);
            this.back_button_packets.TabIndex = 44;
            this.back_button_packets.UseVisualStyleBackColor = true;
            this.back_button_packets.Click += new System.EventHandler(this.back_button_packets_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // showrule_button
            // 
            this.showrule_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showrule_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.showrule_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.showrule_button.FlatAppearance.BorderSize = 2;
            this.showrule_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.showrule_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.showrule_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showrule_button.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showrule_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(142)))));
            this.showrule_button.Location = new System.Drawing.Point(635, 68);
            this.showrule_button.Name = "showrule_button";
            this.showrule_button.Size = new System.Drawing.Size(165, 58);
            this.showrule_button.TabIndex = 46;
            this.showrule_button.Text = "Show Rules";
            this.showrule_button.UseVisualStyleBackColor = false;
            this.showrule_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // showrule_textbox
            // 
            this.showrule_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.showrule_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showrule_textbox.Font = new System.Drawing.Font("HP Simplified Hans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showrule_textbox.ForeColor = System.Drawing.Color.White;
            this.showrule_textbox.Location = new System.Drawing.Point(545, 142);
            this.showrule_textbox.Multiline = true;
            this.showrule_textbox.Name = "showrule_textbox";
            this.showrule_textbox.ReadOnly = true;
            this.showrule_textbox.Size = new System.Drawing.Size(379, 222);
            this.showrule_textbox.TabIndex = 47;
            this.showrule_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // packetform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(933, 474);
            this.Controls.Add(this.back_button_packets);
            this.Controls.Add(this.getstart_label);
            this.Controls.Add(this.packet_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "packetform";
            this.Text = "packetform";
            this.packet_panel.ResumeLayout(false);
            this.packet_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.Label protocol_label;
        private System.Windows.Forms.Label dstport_label;
        private System.Windows.Forms.Label srcport_label;
        private System.Windows.Forms.Label dstip_label;
        private System.Windows.Forms.Label srcip_label;
        private System.Windows.Forms.TextBox packet_data_textbox;
        private System.Windows.Forms.TextBox Packet_srcport_textbox;
        private System.Windows.Forms.TextBox packet_dstport_textbox;
        private System.Windows.Forms.TextBox packet_dstip_textbox;
        private System.Windows.Forms.TextBox packet_srcip_textbox;
        private System.Windows.Forms.Label getstart_label;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.ComboBox packet_protocol_comboBox;
        private System.Windows.Forms.Button back_button_packets;
        private System.Windows.Forms.Panel packet_panel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button showrule_button;
        private System.Windows.Forms.TextBox showrule_textbox;
    }
}