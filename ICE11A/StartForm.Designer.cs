namespace ICE11A
{
    partial class StartForm
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
            Button_New = new Button();
            Button_Load = new Button();
            Button_Exit = new Button();
            SuspendLayout();
            // 
            // Button_New
            // 
            Button_New.BackColor = Color.ForestGreen;
            Button_New.ForeColor = SystemColors.Window;
            Button_New.Location = new Point(151, 127);
            Button_New.Margin = new Padding(4);
            Button_New.Name = "Button_New";
            Button_New.Size = new Size(260, 80);
            Button_New.TabIndex = 0;
            Button_New.Text = "New Character";
            Button_New.UseVisualStyleBackColor = false;
            Button_New.Click += Button_New_Click;
            // 
            // Button_Load
            // 
            Button_Load.BackColor = SystemColors.HotTrack;
            Button_Load.ForeColor = SystemColors.Window;
            Button_Load.Location = new Point(151, 270);
            Button_Load.Margin = new Padding(4);
            Button_Load.Name = "Button_Load";
            Button_Load.Size = new Size(260, 80);
            Button_Load.TabIndex = 1;
            Button_Load.Text = "Load Character";
            Button_Load.UseVisualStyleBackColor = false;
            Button_Load.Click += Button_Load_Click;
            // 
            // Button_Exit
            // 
            Button_Exit.Location = new Point(151, 413);
            Button_Exit.Margin = new Padding(4);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(260, 80);
            Button_Exit.TabIndex = 2;
            Button_Exit.Text = "Exit";
            Button_Exit.UseVisualStyleBackColor = true;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(16F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 681);
            Controls.Add(Button_Exit);
            Controls.Add(Button_Load);
            Controls.Add(Button_New);
            Font = new Font("Calibri", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            FormClosing += StartForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button Button_New;
        private Button Button_Load;
        private Button Button_Exit;
    }
}