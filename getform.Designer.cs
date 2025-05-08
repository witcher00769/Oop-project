namespace _232137_OOP_project
{
    partial class getform
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
            this.addrule_button = new System.Windows.Forms.Button();
            this.packet_button = new System.Windows.Forms.Button();
            this.getstart_label = new System.Windows.Forms.Label();
            this.getform_panel = new System.Windows.Forms.Panel();
            this.back_button_getform = new System.Windows.Forms.Button();
            this.getform_design = new System.Windows.Forms.PictureBox();
            this.getform_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getform_design)).BeginInit();
            this.SuspendLayout();
            // 
            // addrule_button
            // 
            this.addrule_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addrule_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addrule_button.FlatAppearance.BorderSize = 2;
            this.addrule_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.addrule_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addrule_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addrule_button.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrule_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(142)))));
            this.addrule_button.Location = new System.Drawing.Point(100, 204);
            this.addrule_button.Name = "addrule_button";
            this.addrule_button.Size = new System.Drawing.Size(157, 55);
            this.addrule_button.TabIndex = 11;
            this.addrule_button.Text = "Add Rule";
            this.addrule_button.UseVisualStyleBackColor = false;
            this.addrule_button.Click += new System.EventHandler(this.addrule_button_Click);
            // 
            // packet_button
            // 
            this.packet_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.packet_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.packet_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.packet_button.FlatAppearance.BorderSize = 2;
            this.packet_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.packet_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.packet_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.packet_button.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packet_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(142)))));
            this.packet_button.Location = new System.Drawing.Point(100, 274);
            this.packet_button.Name = "packet_button";
            this.packet_button.Size = new System.Drawing.Size(157, 55);
            this.packet_button.TabIndex = 12;
            this.packet_button.Text = "Packet";
            this.packet_button.UseVisualStyleBackColor = false;
            this.packet_button.Click += new System.EventHandler(this.packet_button_Click);
            // 
            // getstart_label
            // 
            this.getstart_label.AutoSize = true;
            this.getstart_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getstart_label.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getstart_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.getstart_label.Location = new System.Drawing.Point(91, 129);
            this.getstart_label.Name = "getstart_label";
            this.getstart_label.Size = new System.Drawing.Size(651, 54);
            this.getstart_label.TabIndex = 13;
            this.getstart_label.Text = "Get Started with Packet Inspection!\r\n";
            this.getstart_label.Click += new System.EventHandler(this.getstart_label_Click);
            // 
            // getform_panel
            // 
            this.getform_panel.Controls.Add(this.packet_button);
            this.getform_panel.Controls.Add(this.getstart_label);
            this.getform_panel.Controls.Add(this.addrule_button);
            this.getform_panel.Controls.Add(this.back_button_getform);
            this.getform_panel.Controls.Add(this.getform_design);
            this.getform_panel.Location = new System.Drawing.Point(-5, 0);
            this.getform_panel.Name = "getform_panel";
            this.getform_panel.Size = new System.Drawing.Size(950, 479);
            this.getform_panel.TabIndex = 14;
            this.getform_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.getform_panel_Paint);
            // 
            // back_button_getform
            // 
            this.back_button_getform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_button_getform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.back_button_getform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_button_getform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.back_button_getform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button_getform.Image = global::_232137_OOP_project.Properties.Resources.icons8_back_30;
            this.back_button_getform.Location = new System.Drawing.Point(12, 9);
            this.back_button_getform.Name = "back_button_getform";
            this.back_button_getform.Size = new System.Drawing.Size(71, 67);
            this.back_button_getform.TabIndex = 1;
            this.back_button_getform.UseVisualStyleBackColor = false;
            this.back_button_getform.Click += new System.EventHandler(this.button1_Click);
            // 
            // getform_design
            // 
            this.getform_design.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.getform_design.Image = global::_232137_OOP_project.Properties.Resources.form_design_1_gray_right;
            this.getform_design.Location = new System.Drawing.Point(382, -82);
            this.getform_design.Name = "getform_design";
            this.getform_design.Size = new System.Drawing.Size(729, 572);
            this.getform_design.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.getform_design.TabIndex = 0;
            this.getform_design.TabStop = false;
            this.getform_design.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // getform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(933, 477);
            this.Controls.Add(this.getform_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "getform";
            this.Text = "getform";
            this.Load += new System.EventHandler(this.getform_Load);
            this.getform_panel.ResumeLayout(false);
            this.getform_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getform_design)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox getform_design;
        private System.Windows.Forms.Button addrule_button;
        private System.Windows.Forms.Button packet_button;
        private System.Windows.Forms.Label getstart_label;
        private System.Windows.Forms.Panel getform_panel;
        private System.Windows.Forms.Button back_button_getform;
    }
}