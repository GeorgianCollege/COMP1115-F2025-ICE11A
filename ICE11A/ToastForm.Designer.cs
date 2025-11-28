namespace ICE11A
{
    partial class ToastForm
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
            Label_Message = new Label();
            ToastTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Label_Message
            // 
            Label_Message.AutoSize = true;
            Label_Message.Font = new Font("Calibri", 14F, FontStyle.Bold);
            Label_Message.Location = new Point(10, 30);
            Label_Message.Margin = new Padding(5, 0, 5, 0);
            Label_Message.Name = "Label_Message";
            Label_Message.Size = new Size(238, 46);
            Label_Message.TabIndex = 0;
            Label_Message.Text = "Your Message";
            // 
            // ToastTimer
            // 
            ToastTimer.Interval = 1500;
            ToastTimer.Tick += ToastTimer_Tick;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(700, 100);
            ControlBox = false;
            Controls.Add(Label_Message);
            Font = new Font("Calibri", 14F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            MinimumSize = new Size(700, 100);
            Name = "ToastForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ToastForm";
            TopMost = true;
            Shown += ToastForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Message;
        private System.Windows.Forms.Timer ToastTimer;
    }
}