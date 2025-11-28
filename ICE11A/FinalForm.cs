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
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This event handler displays the Next form and hides the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Back_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Next].Show();
            this.Hide();
        }

        /// <summary>
        /// This event handler displays the About box as a dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_About_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.About].ShowDialog();
        }

        /// <summary>
        /// This event handler confirms exit when the form is closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConfirmExit(e);
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            TextBox_Name.Text = Settings.Default.CharacterName;
            TextBox_Career.Text = Settings.Default.Career;
            TextBox_Species.Text = Settings.Default.Species;
            TextBox_AGL.Text = Settings.Default.AGL;
            TextBox_STR.Text = Settings.Default.STR;
            TextBox_VGR.Text = Settings.Default.VGR;
            TextBox_PER.Text = Settings.Default.PER;
            TextBox_INT.Text = Settings.Default.INT;
            TextBox_WIL.Text = Settings.Default.WIL;

            ComputeSecondaryAttributes();
        }

        private void ComputeSecondaryAttributes()
        {
            TextBox_AWA.Text = (Convert.ToInt32(TextBox_AGL.Text) + Convert.ToInt32(TextBox_PER.Text)).ToString();
            TextBox_TOU.Text = (Convert.ToInt32(TextBox_STR.Text) + Convert.ToInt32(TextBox_VGR.Text)).ToString();
            TextBox_RES.Text = (Convert.ToInt32(TextBox_INT.Text) + Convert.ToInt32(TextBox_WIL.Text)).ToString();
        }

        /// <summary>
        /// This event handler saves the character to a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Save_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = "Save Character";
            dialog.Filter = "Character Files (*.chr)|*.chr|All Files (*.*)|*.*";
            dialog.InitialDirectory = Program.DownloadsFolder;
            dialog.FileName = Settings.Default.CharacterName + ".chr";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Program.SaveCharacter(dialog.FileName);

                Program.ShowToast("Character Saved!");
            }
        }
    }
}
