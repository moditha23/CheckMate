namespace checjmatelogin
{
    partial class End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(End));
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(693, 337);
            button1.Name = "button1";
            button1.Size = new Size(122, 49);
            button1.TabIndex = 97;
            button1.Text = "END";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // End
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 798);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "End";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "End";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}