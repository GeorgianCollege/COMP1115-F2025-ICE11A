using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE11A
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConfirmExit(e);
        }

        private void Button_New_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Selection].Show();
            Hide();
        }

        /// <summary>
        /// This event handler loads a character from a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Load_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Load Character";
            dialog.Filter = "Character Files (*.chr)|*.chr|All Files (*.*)|*.*";
            dialog.InitialDirectory = Program.DownloadsFolder;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Program.LoadCharacter(dialog.FileName);
                Program.HasLoadedCharacter = true;
                Program.Forms[(int)FormType.Selection].Show();
                Hide();
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
