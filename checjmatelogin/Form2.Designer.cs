namespace checjmatelogin
{
    partial class login2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login2));
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            btn_login1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            username = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_login1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(username);
            panel1.Location = new Point(483, 302);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 340);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(4, 215);
            label1.Name = "label1";
            label1.Size = new Size(235, 47);
            label1.TabIndex = 88;
            label1.Text = "PASSWORD :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(6, 136);
            label7.Name = "label7";
            label7.Size = new Size(232, 47);
            label7.TabIndex = 87;
            label7.Text = "USERNAME :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(196, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 120);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Snow;
            button2.Location = new Point(385, 286);
            button2.Name = "button2";
            button2.Size = new Size(140, 45);
            button2.TabIndex = 7;
            button2.Text = "Admin Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(197, 286);
            button1.Name = "button1";
            button1.Size = new Size(140, 45);
            button1.TabIndex = 5;
            button1.Text = "Employer Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_login1
            // 
            btn_login1.AllowDrop = true;
            btn_login1.BackColor = SystemColors.Highlight;
            btn_login1.Cursor = Cursors.Hand;
            btn_login1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login1.ForeColor = Color.Snow;
            btn_login1.Location = new Point(3, 286);
            btn_login1.Name = "btn_login1";
            btn_login1.Size = new Size(140, 45);
            btn_login1.TabIndex = 4;
            btn_login1.Text = "Employee Login";
            btn_login1.UseVisualStyleBackColor = false;
            btn_login1.Click += btn_login1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.Location = new Point(244, 226);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(256, 34);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Location = new Point(245, 146);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // username
            // 
            username.BackColor = Color.Transparent;
            username.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.FromArgb(255, 128, 0);
            username.Location = new Point(35, 146);
            username.Name = "username";
            username.Size = new Size(188, 39);
            username.TabIndex = 0;
            // 
            // login2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 798);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHECKMATE";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label username;
        private Button button1;
        private Button btn_login1;
        private TextBox textBox2;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
    }
}