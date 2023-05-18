namespace checjmatelogin
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1439, 382);
            dataGridView1.TabIndex = 71;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(914, 223);
            button3.Name = "button3";
            button3.Size = new Size(126, 47);
            button3.TabIndex = 70;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(685, 223);
            button2.Name = "button2";
            button2.Size = new Size(126, 47);
            button2.TabIndex = 69;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(457, 223);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 68;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(722, 148);
            label9.Name = "label9";
            label9.Size = new Size(228, 40);
            label9.TabIndex = 67;
            label9.Text = "DESCRIPTION  :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(889, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(573, 27);
            textBox3.TabIndex = 66;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(559, 27);
            textBox1.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(16, 143);
            label7.Name = "label7";
            label7.Size = new Size(127, 40);
            label7.TabIndex = 64;
            label7.Text = "NAME  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(630, 31);
            label5.Name = "label5";
            label5.Size = new Size(99, 40);
            label5.TabIndex = 62;
            label5.Text = "LEAVE";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(481, 31);
            label4.Name = "label4";
            label4.Size = new Size(126, 40);
            label4.TabIndex = 61;
            label4.Text = "SALARY";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(233, 31);
            label3.Name = "label3";
            label3.Size = new Size(223, 40);
            label3.TabIndex = 60;
            label3.Text = "DEPARTMENTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(23, 31);
            label2.Name = "label2";
            label2.Size = new Size(177, 40);
            label2.TabIndex = 59;
            label2.Text = "EMPLOYEES";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(523, 544);
            label1.Name = "label1";
            label1.Size = new Size(0, 67);
            label1.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(763, 31);
            label8.Name = "label8";
            label8.Size = new Size(102, 40);
            label8.TabIndex = 72;
            label8.Text = "CLOSE";
            label8.Click += label8_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 798);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHECKMATE";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
    }
}