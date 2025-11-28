namespace ICE11A
{
    partial class NextForm
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
            Button_Next = new Button();
            Button_Back = new Button();
            SuspendLayout();
            // 
            // Button_Next
            // 
            Button_Next.Location = new Point(596, 345);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(170, 70);
            Button_Next.TabIndex = 1;
            Button_Next.Text = "Next";
            Button_Next.UseVisualStyleBackColor = true;
            Button_Next.Click += Button_Next_Click;
            // 
            // Button_Back
            // 
            Button_Back.Location = new Point(39, 345);
            Button_Back.Name = "Button_Back";
            Button_Back.Size = new Size(170, 70);
            Button_Back.TabIndex = 2;
            Button_Back.Text = "Back";
            Button_Back.UseVisualStyleBackColor = true;
            Button_Back.Click += Button_Back_Click;
            // 
            // NextForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Button_Back);
            Controls.Add(Button_Next);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NextForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NextForm";
            FormClosing += NextForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button Button_Next;
        private Button Button_Back;
    }
}