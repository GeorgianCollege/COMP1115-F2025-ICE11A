namespace ICE11A
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            TableLayoutPanel = new TableLayoutPanel();
            Label_Author = new Label();
            PictureBox_Logo = new PictureBox();
            Label_ProductName = new Label();
            Label_Version = new Label();
            Label_Copyright = new Label();
            Label_CompanyName = new Label();
            Button_OK = new Button();
            TextBox_Description = new TextBox();
            TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            TableLayoutPanel.Controls.Add(Label_Author, 1, 4);
            TableLayoutPanel.Controls.Add(PictureBox_Logo, 0, 0);
            TableLayoutPanel.Controls.Add(Label_ProductName, 1, 0);
            TableLayoutPanel.Controls.Add(Label_Version, 1, 1);
            TableLayoutPanel.Controls.Add(Label_Copyright, 1, 2);
            TableLayoutPanel.Controls.Add(Label_CompanyName, 1, 3);
            TableLayoutPanel.Controls.Add(Button_OK, 1, 6);
            TableLayoutPanel.Controls.Add(TextBox_Description, 1, 5);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(20, 22);
            TableLayoutPanel.Margin = new Padding(6, 7, 6, 7);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 7;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            TableLayoutPanel.Size = new Size(903, 653);
            TableLayoutPanel.TabIndex = 0;
            // 
            // Label_Author
            // 
            Label_Author.Dock = DockStyle.Fill;
            Label_Author.Location = new Point(310, 260);
            Label_Author.Margin = new Padding(13, 0, 6, 0);
            Label_Author.MaximumSize = new Size(0, 42);
            Label_Author.Name = "Label_Author";
            Label_Author.Size = new Size(587, 42);
            Label_Author.TabIndex = 25;
            Label_Author.Text = "Author Name";
            Label_Author.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PictureBox_Logo
            // 
            PictureBox_Logo.Dock = DockStyle.Fill;
            PictureBox_Logo.Image = (Image)resources.GetObject("PictureBox_Logo.Image");
            PictureBox_Logo.Location = new Point(6, 7);
            PictureBox_Logo.Margin = new Padding(6, 7, 6, 7);
            PictureBox_Logo.Name = "PictureBox_Logo";
            TableLayoutPanel.SetRowSpan(PictureBox_Logo, 7);
            PictureBox_Logo.Size = new Size(285, 639);
            PictureBox_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Logo.TabIndex = 12;
            PictureBox_Logo.TabStop = false;
            // 
            // Label_ProductName
            // 
            Label_ProductName.Dock = DockStyle.Fill;
            Label_ProductName.Location = new Point(310, 0);
            Label_ProductName.Margin = new Padding(13, 0, 6, 0);
            Label_ProductName.MaximumSize = new Size(0, 42);
            Label_ProductName.Name = "Label_ProductName";
            Label_ProductName.Size = new Size(587, 42);
            Label_ProductName.TabIndex = 19;
            Label_ProductName.Text = "Product Name";
            Label_ProductName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label_Version
            // 
            Label_Version.Dock = DockStyle.Fill;
            Label_Version.Location = new Point(310, 65);
            Label_Version.Margin = new Padding(13, 0, 6, 0);
            Label_Version.MaximumSize = new Size(0, 42);
            Label_Version.Name = "Label_Version";
            Label_Version.Size = new Size(587, 42);
            Label_Version.TabIndex = 0;
            Label_Version.Text = "Version";
            Label_Version.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label_Copyright
            // 
            Label_Copyright.Dock = DockStyle.Fill;
            Label_Copyright.Location = new Point(310, 130);
            Label_Copyright.Margin = new Padding(13, 0, 6, 0);
            Label_Copyright.MaximumSize = new Size(0, 42);
            Label_Copyright.Name = "Label_Copyright";
            Label_Copyright.Size = new Size(587, 42);
            Label_Copyright.TabIndex = 21;
            Label_Copyright.Text = "Copyright";
            Label_Copyright.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label_CompanyName
            // 
            Label_CompanyName.Dock = DockStyle.Fill;
            Label_CompanyName.Location = new Point(310, 195);
            Label_CompanyName.Margin = new Padding(13, 0, 6, 0);
            Label_CompanyName.MaximumSize = new Size(0, 42);
            Label_CompanyName.Name = "Label_CompanyName";
            Label_CompanyName.Size = new Size(587, 42);
            Label_CompanyName.TabIndex = 22;
            Label_CompanyName.Text = "Company Name";
            Label_CompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Button_OK
            // 
            Button_OK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button_OK.DialogResult = DialogResult.Cancel;
            Button_OK.Location = new Point(735, 593);
            Button_OK.Margin = new Padding(6, 7, 6, 7);
            Button_OK.Name = "Button_OK";
            Button_OK.Size = new Size(162, 53);
            Button_OK.TabIndex = 24;
            Button_OK.Text = "&OK";
            Button_OK.Click += Button_OK_Click;
            // 
            // TextBox_Description
            // 
            TextBox_Description.Dock = DockStyle.Fill;
            TextBox_Description.Location = new Point(310, 332);
            TextBox_Description.Margin = new Padding(13, 7, 6, 7);
            TextBox_Description.Multiline = true;
            TextBox_Description.Name = "TextBox_Description";
            TextBox_Description.ReadOnly = true;
            TextBox_Description.ScrollBars = ScrollBars.Both;
            TextBox_Description.Size = new Size(587, 247);
            TextBox_Description.TabIndex = 23;
            TextBox_Description.TabStop = false;
            TextBox_Description.Text = "Description";
            // 
            // AboutForm
            // 
            AcceptButton = Button_OK;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 697);
            Controls.Add(TableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Padding = new Padding(20, 22, 20, 22);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutForm";
            TableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Logo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.Label Label_ProductName;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.Label Label_Copyright;
        private System.Windows.Forms.Label Label_CompanyName;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.Button Button_OK;
        private Label Label_Author;
    }
}
