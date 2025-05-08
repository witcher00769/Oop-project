namespace _232137_OOP_project
{
    partial class Rulesinput
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
            this.Ip_comboBox = new System.Windows.Forms.ComboBox();
            this.ip_label = new System.Windows.Forms.Label();
            this.rulenum_label = new System.Windows.Forms.Label();
            this.rulenum_textbox = new System.Windows.Forms.TextBox();
            this.Ports_label = new System.Windows.Forms.Label();
            this.Ports_comboBox = new System.Windows.Forms.ComboBox();
            this.Protocol_label = new System.Windows.Forms.Label();
            this.protocol_comboBox = new System.Windows.Forms.ComboBox();
            this.decision_label = new System.Windows.Forms.Label();
            this.decision_comboBox = new System.Windows.Forms.ComboBox();
            this.IP_textbox = new System.Windows.Forms.TextBox();
            this.Ports_textbox = new System.Windows.Forms.TextBox();
            this.next_button = new System.Windows.Forms.Button();
            this.Rulesinput_panel = new System.Windows.Forms.Panel();
            this.matchString_textbox = new System.Windows.Forms.TextBox();
            this.data_label = new System.Windows.Forms.Label();
            this.back_button_rulesinput = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Rulesinput_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ip_comboBox
            // 
            this.Ip_comboBox.BackColor = System.Drawing.Color.White;
            this.Ip_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ip_comboBox.FormattingEnabled = true;
            this.Ip_comboBox.Items.AddRange(new object[] {
            "Source IP",
            "Destination IP"});
            this.Ip_comboBox.Location = new System.Drawing.Point(54, 142);
            this.Ip_comboBox.Name = "Ip_comboBox";
            this.Ip_comboBox.Size = new System.Drawing.Size(161, 28);
            this.Ip_comboBox.TabIndex = 0;
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Font = new System.Drawing.Font("HP Simplified Hans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.ip_label.Location = new System.Drawing.Point(50, 119);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(90, 20);
            this.ip_label.TabIndex = 1;
            this.ip_label.Text = "IP Address";
            // 
            // rulenum_label
            // 
            this.rulenum_label.AutoSize = true;
            this.rulenum_label.Font = new System.Drawing.Font("HP Simplified Hans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulenum_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.rulenum_label.Location = new System.Drawing.Point(50, 74);
            this.rulenum_label.Name = "rulenum_label";
            this.rulenum_label.Size = new System.Drawing.Size(110, 20);
            this.rulenum_label.TabIndex = 2;
            this.rulenum_label.Text = "Rule Number";
            // 
            // rulenum_textbox
            // 
            this.rulenum_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rulenum_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rulenum_textbox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rulenum_textbox.Location = new System.Drawing.Point(270, 74);
            this.rulenum_textbox.Name = "rulenum_textbox";
            this.rulenum_textbox.Size = new System.Drawing.Size(160, 26);
            this.rulenum_textbox.TabIndex = 3;
            this.rulenum_textbox.TextChanged += new System.EventHandler(this.rulenum_textbox_TextChanged);
            // 
            // Ports_label
            // 
            this.Ports_label.AutoSize = true;
            this.Ports_label.Font = new System.Drawing.Font("HP Simplified Hans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ports_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.Ports_label.Location = new System.Drawing.Point(50, 185);
            this.Ports_label.Name = "Ports_label";
            this.Ports_label.Size = new System.Drawing.Size(51, 20);
            this.Ports_label.TabIndex = 4;
            this.Ports_label.Text = "Ports";
            // 
            // Ports_comboBox
            // 
            this.Ports_comboBox.BackColor = System.Drawing.Color.White;
            this.Ports_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ports_comboBox.FormattingEnabled = true;
            this.Ports_comboBox.Items.AddRange(new object[] {
            "Source Port",
            "Destination Port"});
            this.Ports_comboBox.Location = new System.Drawing.Point(54, 208);
            this.Ports_comboBox.Name = "Ports_comboBox";
            this.Ports_comboBox.Size = new System.Drawing.Size(161, 28);
            this.Ports_comboBox.TabIndex = 5;
            // 
            // Protocol_label
            // 
            this.Protocol_label.AutoSize = true;
            this.Protocol_label.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Protocol_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.Protocol_label.Location = new System.Drawing.Point(51, 295);
            this.Protocol_label.Name = "Protocol_label";
            this.Protocol_label.Size = new System.Drawing.Size(72, 22);
            this.Protocol_label.TabIndex = 6;
            this.Protocol_label.Text = "Protocol";
            // 
            // protocol_comboBox
            // 
            this.protocol_comboBox.BackColor = System.Drawing.Color.White;
            this.protocol_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.protocol_comboBox.FormattingEnabled = true;
            this.protocol_comboBox.Items.AddRange(new object[] {
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
            this.protocol_comboBox.Location = new System.Drawing.Point(55, 320);
            this.protocol_comboBox.Name = "protocol_comboBox";
            this.protocol_comboBox.Size = new System.Drawing.Size(161, 28);
            this.protocol_comboBox.TabIndex = 7;
            // 
            // decision_label
            // 
            this.decision_label.AutoSize = true;
            this.decision_label.Font = new System.Drawing.Font("HP Simplified Hans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decision_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decision_label.Location = new System.Drawing.Point(50, 367);
            this.decision_label.Name = "decision_label";
            this.decision_label.Size = new System.Drawing.Size(73, 20);
            this.decision_label.TabIndex = 8;
            this.decision_label.Text = "Decision";
            // 
            // decision_comboBox
            // 
            this.decision_comboBox.BackColor = System.Drawing.Color.White;
            this.decision_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decision_comboBox.FormattingEnabled = true;
            this.decision_comboBox.Items.AddRange(new object[] {
            "Allow",
            "Deny"});
            this.decision_comboBox.Location = new System.Drawing.Point(54, 390);
            this.decision_comboBox.Name = "decision_comboBox";
            this.decision_comboBox.Size = new System.Drawing.Size(161, 28);
            this.decision_comboBox.TabIndex = 9;
            // 
            // IP_textbox
            // 
            this.IP_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.IP_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IP_textbox.Location = new System.Drawing.Point(270, 143);
            this.IP_textbox.Name = "IP_textbox";
            this.IP_textbox.Size = new System.Drawing.Size(203, 26);
            this.IP_textbox.TabIndex = 10;
            this.IP_textbox.TextChanged += new System.EventHandler(this.IP_textbox_TextChanged);
            // 
            // Ports_textbox
            // 
            this.Ports_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Ports_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ports_textbox.Location = new System.Drawing.Point(270, 209);
            this.Ports_textbox.Name = "Ports_textbox";
            this.Ports_textbox.Size = new System.Drawing.Size(203, 26);
            this.Ports_textbox.TabIndex = 11;
            this.Ports_textbox.TextChanged += new System.EventHandler(this.Ports_textbox_TextChanged);
            // 
            // next_button
            // 
            this.next_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.next_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.next_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.next_button.FlatAppearance.BorderSize = 2;
            this.next_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.next_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(142)))));
            this.next_button.Location = new System.Drawing.Point(297, 329);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(158, 58);
            this.next_button.TabIndex = 31;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Rulesinput_panel
            // 
            this.Rulesinput_panel.Controls.Add(this.matchString_textbox);
            this.Rulesinput_panel.Controls.Add(this.next_button);
            this.Rulesinput_panel.Controls.Add(this.data_label);
            this.Rulesinput_panel.Controls.Add(this.Ports_textbox);
            this.Rulesinput_panel.Controls.Add(this.decision_comboBox);
            this.Rulesinput_panel.Controls.Add(this.IP_textbox);
            this.Rulesinput_panel.Controls.Add(this.decision_label);
            this.Rulesinput_panel.Controls.Add(this.rulenum_textbox);
            this.Rulesinput_panel.Controls.Add(this.protocol_comboBox);
            this.Rulesinput_panel.Controls.Add(this.back_button_rulesinput);
            this.Rulesinput_panel.Controls.Add(this.Protocol_label);
            this.Rulesinput_panel.Controls.Add(this.pictureBox1);
            this.Rulesinput_panel.Controls.Add(this.rulenum_label);
            this.Rulesinput_panel.Controls.Add(this.ip_label);
            this.Rulesinput_panel.Controls.Add(this.Ports_comboBox);
            this.Rulesinput_panel.Controls.Add(this.Ip_comboBox);
            this.Rulesinput_panel.Controls.Add(this.Ports_label);
            this.Rulesinput_panel.Location = new System.Drawing.Point(0, 3);
            this.Rulesinput_panel.Name = "Rulesinput_panel";
            this.Rulesinput_panel.Size = new System.Drawing.Size(934, 471);
            this.Rulesinput_panel.TabIndex = 34;
            // 
            // matchString_textbox
            // 
            this.matchString_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.matchString_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchString_textbox.Location = new System.Drawing.Point(270, 253);
            this.matchString_textbox.Name = "matchString_textbox";
            this.matchString_textbox.Size = new System.Drawing.Size(203, 26);
            this.matchString_textbox.TabIndex = 35;
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.data_label.Location = new System.Drawing.Point(51, 253);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(45, 22);
            this.data_label.TabIndex = 34;
            this.data_label.Text = "Data";
            // 
            // back_button_rulesinput
            // 
            this.back_button_rulesinput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_button_rulesinput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.back_button_rulesinput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button_rulesinput.Image = global::_232137_OOP_project.Properties.Resources.icons8_go_back_24;
            this.back_button_rulesinput.Location = new System.Drawing.Point(12, 9);
            this.back_button_rulesinput.Name = "back_button_rulesinput";
            this.back_button_rulesinput.Size = new System.Drawing.Size(71, 67);
            this.back_button_rulesinput.TabIndex = 33;
            this.back_button_rulesinput.UseVisualStyleBackColor = true;
            this.back_button_rulesinput.Click += new System.EventHandler(this.back_button_rulesinput_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_232137_OOP_project.Properties.Resources.Form2design;
            this.pictureBox1.Location = new System.Drawing.Point(308, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Rulesinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(933, 474);
            this.Controls.Add(this.Rulesinput_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rulesinput";
            this.Text = "Rulesinput";
            this.Load += new System.EventHandler(this.Rulesinput_Load);
            this.Rulesinput_panel.ResumeLayout(false);
            this.Rulesinput_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Ip_comboBox;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.Label rulenum_label;
        private System.Windows.Forms.TextBox rulenum_textbox;
        private System.Windows.Forms.Label Ports_label;
        private System.Windows.Forms.ComboBox Ports_comboBox;
        private System.Windows.Forms.Label Protocol_label;
        private System.Windows.Forms.ComboBox protocol_comboBox;
        private System.Windows.Forms.Label decision_label;
        private System.Windows.Forms.ComboBox decision_comboBox;
        private System.Windows.Forms.TextBox IP_textbox;
        private System.Windows.Forms.TextBox Ports_textbox;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_button_rulesinput;
        private System.Windows.Forms.Panel Rulesinput_panel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox matchString_textbox;
        private System.Windows.Forms.Label data_label;
    }
}