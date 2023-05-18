namespace checjmatelogin
{
    partial class Checkmate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkmate));
            label7 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 37F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(520, 500);
            label7.Name = "label7";
            label7.Size = new Size(454, 84);
            label7.TabIndex = 65;
            label7.Text = "TAP TO LOGIN";
            label7.Click += label7_Click;
            // 
            // Checkmate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 798);
            Controls.Add(label7);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Checkmate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHECKMATE";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
    }
}