namespace checjmatelogin
{
    partial class Complaint_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complaint_Employee));
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(622, 27);
            label5.Name = "label5";
            label5.Size = new Size(102, 40);
            label5.TabIndex = 98;
            label5.Text = "CLOSE";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(268, 28);
            label3.Name = "label3";
            label3.Size = new Size(99, 40);
            label3.TabIndex = 97;
            label3.Text = "LEAVE";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 29);
            label4.Name = "label4";
            label4.Size = new Size(226, 40);
            label4.TabIndex = 95;
            label4.Text = "CHECK SALARY";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(392, 27);
            label2.Name = "label2";
            label2.Size = new Size(188, 40);
            label2.TabIndex = 94;
            label2.Text = "COMPLAINT";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(360, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 27);
            dateTimePicker1.TabIndex = 102;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(63, 119);
            label1.Name = "label1";
            label1.Size = new Size(291, 40);
            label1.TabIndex = 101;
            label1.Text = "COMPLAINT DATE  :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1047, 129);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 28);
            comboBox2.TabIndex = 104;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(812, 119);
            label8.Name = "label8";
            label8.Size = new Size(231, 40);
            label8.TabIndex = 103;
            label8.Text = "DEPARTMENT  :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(63, 194);
            label9.Name = "label9";
            label9.Size = new Size(212, 40);
            label9.TabIndex = 105;
            label9.Text = "COMPLAINT  :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(290, 197);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1119, 475);
            richTextBox1.TabIndex = 106;
            richTextBox1.Text = "";
            // 
            // Complaint_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 798);
            Controls.Add(richTextBox1);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Complaint_Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label8;
        private Label label9;
        private RichTextBox richTextBox1;
    }
}