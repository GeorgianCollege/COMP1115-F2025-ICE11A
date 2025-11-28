namespace ICE11A
{
    partial class SelectionForm
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
            Button_Next = new Button();
            TextBox_Name = new TextBox();
            GroupBox_Species = new GroupBox();
            RadioButton_Alien = new RadioButton();
            RadioButton_Robot = new RadioButton();
            RadioButton_Human = new RadioButton();
            CheckBox_ShowRandom = new CheckBox();
            Button_Random = new Button();
            Button_Reset = new Button();
            Panel_SecondaryAttributes = new Panel();
            Label_SecondaryAttributes = new Label();
            TextBox_RES = new TextBox();
            TextBox_TOU = new TextBox();
            TextBox_AWA = new TextBox();
            Label_RES = new Label();
            Label_TOU = new Label();
            Label_AWA = new Label();
            Panel_CoreAttributes = new Panel();
            label1 = new Label();
            TextBox_WIL = new TextBox();
            TextBox_INT = new TextBox();
            Label_AGL = new Label();
            TextBox_PER = new TextBox();
            Label_STR = new Label();
            TextBox_VGR = new TextBox();
            Label_VGR = new Label();
            TextBox_STR = new TextBox();
            Label_PER = new Label();
            TextBox_AGL = new TextBox();
            Label_INT = new Label();
            Label_WIL = new Label();
            Label_Career = new Label();
            ComboBox_Career = new ComboBox();
            GroupBox_Species.SuspendLayout();
            Panel_SecondaryAttributes.SuspendLayout();
            Panel_CoreAttributes.SuspendLayout();
            SuspendLayout();
            // 
            // Button_Next
            // 
            Button_Next.Enabled = false;
            Button_Next.Font = new Font("Calibri", 12F);
            Button_Next.Location = new Point(491, 640);
            Button_Next.Name = "Button_Next";
            Button_Next.Size = new Size(170, 70);
            Button_Next.TabIndex = 0;
            Button_Next.Text = "Next";
            Button_Next.UseVisualStyleBackColor = true;
            Button_Next.Click += Button_Next_Click;
            // 
            // TextBox_Name
            // 
            TextBox_Name.BorderStyle = BorderStyle.FixedSingle;
            TextBox_Name.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBox_Name.Location = new Point(43, 35);
            TextBox_Name.Name = "TextBox_Name";
            TextBox_Name.PlaceholderText = "Enter Name";
            TextBox_Name.Size = new Size(360, 47);
            TextBox_Name.TabIndex = 50;
            // 
            // GroupBox_Species
            // 
            GroupBox_Species.Controls.Add(RadioButton_Alien);
            GroupBox_Species.Controls.Add(RadioButton_Robot);
            GroupBox_Species.Controls.Add(RadioButton_Human);
            GroupBox_Species.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GroupBox_Species.Location = new Point(431, 420);
            GroupBox_Species.Name = "GroupBox_Species";
            GroupBox_Species.Size = new Size(230, 181);
            GroupBox_Species.TabIndex = 49;
            GroupBox_Species.TabStop = false;
            GroupBox_Species.Text = "Species";
            // 
            // RadioButton_Alien
            // 
            RadioButton_Alien.AutoSize = true;
            RadioButton_Alien.Font = new Font("Segoe UI", 9F);
            RadioButton_Alien.Location = new Point(17, 122);
            RadioButton_Alien.Name = "RadioButton_Alien";
            RadioButton_Alien.Size = new Size(99, 36);
            RadioButton_Alien.TabIndex = 38;
            RadioButton_Alien.Text = "Alien";
            RadioButton_Alien.UseVisualStyleBackColor = true;
            RadioButton_Alien.CheckedChanged += RadioButton_Species_CheckedChanged;
            // 
            // RadioButton_Robot
            // 
            RadioButton_Robot.AutoSize = true;
            RadioButton_Robot.Font = new Font("Segoe UI", 9F);
            RadioButton_Robot.Location = new Point(17, 80);
            RadioButton_Robot.Name = "RadioButton_Robot";
            RadioButton_Robot.Size = new Size(108, 36);
            RadioButton_Robot.TabIndex = 37;
            RadioButton_Robot.Text = "Robot";
            RadioButton_Robot.UseVisualStyleBackColor = true;
            RadioButton_Robot.CheckedChanged += RadioButton_Species_CheckedChanged;
            // 
            // RadioButton_Human
            // 
            RadioButton_Human.AutoSize = true;
            RadioButton_Human.Checked = true;
            RadioButton_Human.Font = new Font("Segoe UI", 9F);
            RadioButton_Human.Location = new Point(17, 38);
            RadioButton_Human.Name = "RadioButton_Human";
            RadioButton_Human.Size = new Size(123, 36);
            RadioButton_Human.TabIndex = 36;
            RadioButton_Human.TabStop = true;
            RadioButton_Human.Text = "Human";
            RadioButton_Human.UseVisualStyleBackColor = true;
            RadioButton_Human.CheckedChanged += RadioButton_Species_CheckedChanged;
            // 
            // CheckBox_ShowRandom
            // 
            CheckBox_ShowRandom.AutoSize = true;
            CheckBox_ShowRandom.Checked = true;
            CheckBox_ShowRandom.CheckState = CheckState.Checked;
            CheckBox_ShowRandom.Location = new Point(353, 155);
            CheckBox_ShowRandom.Name = "CheckBox_ShowRandom";
            CheckBox_ShowRandom.Size = new Size(290, 36);
            CheckBox_ShowRandom.TabIndex = 48;
            CheckBox_ShowRandom.Text = "Show Random Button?";
            CheckBox_ShowRandom.UseVisualStyleBackColor = true;
            CheckBox_ShowRandom.CheckedChanged += CheckBox_ShowRandom_CheckedChanged;
            // 
            // Button_Random
            // 
            Button_Random.BackColor = SystemColors.HotTrack;
            Button_Random.Font = new Font("Calibri", 12F);
            Button_Random.ForeColor = SystemColors.ButtonHighlight;
            Button_Random.Location = new Point(268, 640);
            Button_Random.Name = "Button_Random";
            Button_Random.Size = new Size(170, 70);
            Button_Random.TabIndex = 47;
            Button_Random.Text = "Random";
            Button_Random.UseVisualStyleBackColor = false;
            Button_Random.Click += Button_Random_Click;
            // 
            // Button_Reset
            // 
            Button_Reset.BackColor = Color.Orange;
            Button_Reset.Font = new Font("Calibri", 12F);
            Button_Reset.Location = new Point(45, 640);
            Button_Reset.Name = "Button_Reset";
            Button_Reset.Size = new Size(170, 70);
            Button_Reset.TabIndex = 46;
            Button_Reset.Text = "Reset";
            Button_Reset.UseVisualStyleBackColor = false;
            Button_Reset.Click += Button_Reset_Click;
            // 
            // Panel_SecondaryAttributes
            // 
            Panel_SecondaryAttributes.BorderStyle = BorderStyle.FixedSingle;
            Panel_SecondaryAttributes.Controls.Add(Label_SecondaryAttributes);
            Panel_SecondaryAttributes.Controls.Add(TextBox_RES);
            Panel_SecondaryAttributes.Controls.Add(TextBox_TOU);
            Panel_SecondaryAttributes.Controls.Add(TextBox_AWA);
            Panel_SecondaryAttributes.Controls.Add(Label_RES);
            Panel_SecondaryAttributes.Controls.Add(Label_TOU);
            Panel_SecondaryAttributes.Controls.Add(Label_AWA);
            Panel_SecondaryAttributes.Location = new Point(45, 420);
            Panel_SecondaryAttributes.Name = "Panel_SecondaryAttributes";
            Panel_SecondaryAttributes.Size = new Size(355, 181);
            Panel_SecondaryAttributes.TabIndex = 45;
            // 
            // Label_SecondaryAttributes
            // 
            Label_SecondaryAttributes.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_SecondaryAttributes.Location = new Point(23, 9);
            Label_SecondaryAttributes.Name = "Label_SecondaryAttributes";
            Label_SecondaryAttributes.Size = new Size(305, 44);
            Label_SecondaryAttributes.TabIndex = 33;
            Label_SecondaryAttributes.Text = "Secondary Attributes";
            // 
            // TextBox_RES
            // 
            TextBox_RES.BackColor = SystemColors.Window;
            TextBox_RES.BorderStyle = BorderStyle.FixedSingle;
            TextBox_RES.Font = new Font("Calibri", 12F);
            TextBox_RES.Location = new Point(212, 106);
            TextBox_RES.Name = "TextBox_RES";
            TextBox_RES.ReadOnly = true;
            TextBox_RES.Size = new Size(79, 47);
            TextBox_RES.TabIndex = 29;
            TextBox_RES.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox_TOU
            // 
            TextBox_TOU.BackColor = SystemColors.Window;
            TextBox_TOU.BorderStyle = BorderStyle.FixedSingle;
            TextBox_TOU.Font = new Font("Calibri", 12F);
            TextBox_TOU.Location = new Point(117, 106);
            TextBox_TOU.Name = "TextBox_TOU";
            TextBox_TOU.ReadOnly = true;
            TextBox_TOU.Size = new Size(79, 47);
            TextBox_TOU.TabIndex = 28;
            TextBox_TOU.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox_AWA
            // 
            TextBox_AWA.BackColor = SystemColors.Window;
            TextBox_AWA.BorderStyle = BorderStyle.FixedSingle;
            TextBox_AWA.Font = new Font("Calibri", 12F);
            TextBox_AWA.Location = new Point(22, 106);
            TextBox_AWA.Name = "TextBox_AWA";
            TextBox_AWA.ReadOnly = true;
            TextBox_AWA.Size = new Size(79, 47);
            TextBox_AWA.TabIndex = 27;
            TextBox_AWA.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_RES
            // 
            Label_RES.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_RES.Location = new Point(212, 64);
            Label_RES.Name = "Label_RES";
            Label_RES.Size = new Size(79, 39);
            Label_RES.TabIndex = 26;
            Label_RES.Text = "RES";
            Label_RES.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label_TOU
            // 
            Label_TOU.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_TOU.Location = new Point(117, 64);
            Label_TOU.Name = "Label_TOU";
            Label_TOU.Size = new Size(79, 39);
            Label_TOU.TabIndex = 25;
            Label_TOU.Text = "TOU";
            Label_TOU.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label_AWA
            // 
            Label_AWA.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_AWA.Location = new Point(20, 64);
            Label_AWA.Name = "Label_AWA";
            Label_AWA.Size = new Size(89, 39);
            Label_AWA.TabIndex = 24;
            Label_AWA.Text = "AWA";
            Label_AWA.TextAlign = ContentAlignment.TopCenter;
            // 
            // Panel_CoreAttributes
            // 
            Panel_CoreAttributes.BorderStyle = BorderStyle.FixedSingle;
            Panel_CoreAttributes.Controls.Add(label1);
            Panel_CoreAttributes.Controls.Add(TextBox_WIL);
            Panel_CoreAttributes.Controls.Add(TextBox_INT);
            Panel_CoreAttributes.Controls.Add(Label_AGL);
            Panel_CoreAttributes.Controls.Add(TextBox_PER);
            Panel_CoreAttributes.Controls.Add(Label_STR);
            Panel_CoreAttributes.Controls.Add(TextBox_VGR);
            Panel_CoreAttributes.Controls.Add(Label_VGR);
            Panel_CoreAttributes.Controls.Add(TextBox_STR);
            Panel_CoreAttributes.Controls.Add(Label_PER);
            Panel_CoreAttributes.Controls.Add(TextBox_AGL);
            Panel_CoreAttributes.Controls.Add(Label_INT);
            Panel_CoreAttributes.Controls.Add(Label_WIL);
            Panel_CoreAttributes.Location = new Point(45, 228);
            Panel_CoreAttributes.Name = "Panel_CoreAttributes";
            Panel_CoreAttributes.Size = new Size(599, 171);
            Panel_CoreAttributes.TabIndex = 44;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 1);
            label1.Name = "label1";
            label1.Size = new Size(244, 44);
            label1.TabIndex = 32;
            label1.Text = "Core Attributes";
            // 
            // TextBox_WIL
            // 
            TextBox_WIL.BackColor = SystemColors.Window;
            TextBox_WIL.BorderStyle = BorderStyle.FixedSingle;
            TextBox_WIL.Font = new Font("Calibri", 12F);
            TextBox_WIL.Location = new Point(497, 97);
            TextBox_WIL.Name = "TextBox_WIL";
            TextBox_WIL.ReadOnly = true;
            TextBox_WIL.Size = new Size(79, 47);
            TextBox_WIL.TabIndex = 23;
            TextBox_WIL.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox_INT
            // 
            TextBox_INT.BackColor = SystemColors.Window;
            TextBox_INT.BorderStyle = BorderStyle.FixedSingle;
            TextBox_INT.Font = new Font("Calibri", 12F);
            TextBox_INT.Location = new Point(402, 97);
            TextBox_INT.Name = "TextBox_INT";
            TextBox_INT.ReadOnly = true;
            TextBox_INT.Size = new Size(79, 47);
            TextBox_INT.TabIndex = 22;
            TextBox_INT.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_AGL
            // 
            Label_AGL.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_AGL.Location = new Point(22, 55);
            Label_AGL.Name = "Label_AGL";
            Label_AGL.Size = new Size(79, 39);
            Label_AGL.TabIndex = 12;
            Label_AGL.Text = "AGL";
            Label_AGL.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_PER
            // 
            TextBox_PER.BackColor = SystemColors.Window;
            TextBox_PER.BorderStyle = BorderStyle.FixedSingle;
            TextBox_PER.Font = new Font("Calibri", 12F);
            TextBox_PER.Location = new Point(307, 97);
            TextBox_PER.Name = "TextBox_PER";
            TextBox_PER.ReadOnly = true;
            TextBox_PER.Size = new Size(79, 47);
            TextBox_PER.TabIndex = 21;
            TextBox_PER.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_STR
            // 
            Label_STR.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_STR.Location = new Point(117, 55);
            Label_STR.Name = "Label_STR";
            Label_STR.Size = new Size(79, 39);
            Label_STR.TabIndex = 13;
            Label_STR.Text = "STR";
            Label_STR.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_VGR
            // 
            TextBox_VGR.BackColor = SystemColors.Window;
            TextBox_VGR.BorderStyle = BorderStyle.FixedSingle;
            TextBox_VGR.Font = new Font("Calibri", 12F);
            TextBox_VGR.Location = new Point(212, 97);
            TextBox_VGR.Name = "TextBox_VGR";
            TextBox_VGR.ReadOnly = true;
            TextBox_VGR.Size = new Size(79, 47);
            TextBox_VGR.TabIndex = 20;
            TextBox_VGR.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_VGR
            // 
            Label_VGR.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_VGR.Location = new Point(212, 55);
            Label_VGR.Name = "Label_VGR";
            Label_VGR.Size = new Size(79, 39);
            Label_VGR.TabIndex = 14;
            Label_VGR.Text = "VGR";
            Label_VGR.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_STR
            // 
            TextBox_STR.BackColor = SystemColors.Window;
            TextBox_STR.BorderStyle = BorderStyle.FixedSingle;
            TextBox_STR.Font = new Font("Calibri", 12F);
            TextBox_STR.Location = new Point(117, 97);
            TextBox_STR.Name = "TextBox_STR";
            TextBox_STR.ReadOnly = true;
            TextBox_STR.Size = new Size(79, 47);
            TextBox_STR.TabIndex = 19;
            TextBox_STR.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_PER
            // 
            Label_PER.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_PER.Location = new Point(307, 55);
            Label_PER.Name = "Label_PER";
            Label_PER.Size = new Size(79, 39);
            Label_PER.TabIndex = 15;
            Label_PER.Text = "PER";
            Label_PER.TextAlign = ContentAlignment.TopCenter;
            // 
            // TextBox_AGL
            // 
            TextBox_AGL.BackColor = SystemColors.Window;
            TextBox_AGL.BorderStyle = BorderStyle.FixedSingle;
            TextBox_AGL.Font = new Font("Calibri", 12F);
            TextBox_AGL.Location = new Point(22, 97);
            TextBox_AGL.Name = "TextBox_AGL";
            TextBox_AGL.ReadOnly = true;
            TextBox_AGL.Size = new Size(79, 47);
            TextBox_AGL.TabIndex = 18;
            TextBox_AGL.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_INT
            // 
            Label_INT.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_INT.Location = new Point(402, 55);
            Label_INT.Name = "Label_INT";
            Label_INT.Size = new Size(79, 39);
            Label_INT.TabIndex = 16;
            Label_INT.Text = "INT";
            Label_INT.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label_WIL
            // 
            Label_WIL.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_WIL.Location = new Point(497, 55);
            Label_WIL.Name = "Label_WIL";
            Label_WIL.Size = new Size(79, 39);
            Label_WIL.TabIndex = 17;
            Label_WIL.Text = "WIL";
            Label_WIL.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label_Career
            // 
            Label_Career.Font = new Font("Calibri", 12F, FontStyle.Bold);
            Label_Career.Location = new Point(43, 108);
            Label_Career.Name = "Label_Career";
            Label_Career.Size = new Size(244, 44);
            Label_Career.TabIndex = 43;
            Label_Career.Text = "Select Career";
            // 
            // ComboBox_Career
            // 
            ComboBox_Career.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Career.Font = new Font("Calibri", 12F);
            ComboBox_Career.FormattingEnabled = true;
            ComboBox_Career.Location = new Point(45, 155);
            ComboBox_Career.Name = "ComboBox_Career";
            ComboBox_Career.Size = new Size(242, 47);
            ComboBox_Career.TabIndex = 42;
            ComboBox_Career.SelectedIndexChanged += ComboBox_Career_SelectedIndexChanged;
            // 
            // SelectionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 752);
            Controls.Add(TextBox_Name);
            Controls.Add(GroupBox_Species);
            Controls.Add(CheckBox_ShowRandom);
            Controls.Add(Button_Random);
            Controls.Add(Button_Reset);
            Controls.Add(Panel_SecondaryAttributes);
            Controls.Add(Panel_CoreAttributes);
            Controls.Add(Label_Career);
            Controls.Add(ComboBox_Career);
            Controls.Add(Button_Next);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectionForm";
            FormClosing += SelectionForm_FormClosing;
            Load += SelectionForm_Load;
            GroupBox_Species.ResumeLayout(false);
            GroupBox_Species.PerformLayout();
            Panel_SecondaryAttributes.ResumeLayout(false);
            Panel_SecondaryAttributes.PerformLayout();
            Panel_CoreAttributes.ResumeLayout(false);
            Panel_CoreAttributes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Next;
        private TextBox TextBox_Name;
        private GroupBox GroupBox_Species;
        private RadioButton RadioButton_Alien;
        private RadioButton RadioButton_Robot;
        private RadioButton RadioButton_Human;
        private CheckBox CheckBox_ShowRandom;
        private Button Button_Random;
        private Button Button_Reset;
        private Panel Panel_SecondaryAttributes;
        private Label Label_SecondaryAttributes;
        private TextBox TextBox_RES;
        private TextBox TextBox_TOU;
        private TextBox TextBox_AWA;
        private Label Label_RES;
        private Label Label_TOU;
        private Label Label_AWA;
        private Panel Panel_CoreAttributes;
        private Label label1;
        private TextBox TextBox_WIL;
        private TextBox TextBox_INT;
        private Label Label_AGL;
        private TextBox TextBox_PER;
        private Label Label_STR;
        private TextBox TextBox_VGR;
        private Label Label_VGR;
        private TextBox TextBox_STR;
        private Label Label_PER;
        private TextBox TextBox_AGL;
        private Label Label_INT;
        private Label Label_WIL;
        private Label Label_Career;
        private ComboBox ComboBox_Career;
    }
}
