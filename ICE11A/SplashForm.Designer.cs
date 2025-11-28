namespace ICE11A
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            Label_Title = new Label();
            PictureBox_Logo = new PictureBox();
            Timer_SplashForm = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).BeginInit();
            SuspendLayout();
            // 
            // Label_Title
            // 
            Label_Title.FlatStyle = FlatStyle.Flat;
            Label_Title.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Title.Location = new Point(40, 51);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(728, 115);
            Label_Title.TabIndex = 0;
            Label_Title.Text = "Character Generator";
            // 
            // PictureBox_Logo
            // 
            PictureBox_Logo.Location = new Point(51, 186);
            PictureBox_Logo.Name = "PictureBox_Logo";
            PictureBox_Logo.Size = new Size(690, 220);
            PictureBox_Logo.TabIndex = 1;
            PictureBox_Logo.TabStop = false;
            // 
            // Timer_SplashForm
            // 
            Timer_SplashForm.Enabled = true;
            Timer_SplashForm.Interval = 2000;
            Timer_SplashForm.Tick += Timer_SplashForm_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(PictureBox_Logo);
            Controls.Add(Label_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            Opacity = 0.7D;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Label_Title;
        private PictureBox PictureBox_Logo;
        private System.Windows.Forms.Timer Timer_SplashForm;
    }
}