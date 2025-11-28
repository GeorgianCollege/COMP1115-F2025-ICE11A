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
    public partial class NextForm : Form
    {
        public NextForm()
        {
            InitializeComponent();


        }

        /// <summary>
        /// This event handler displays the Start form and hides the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Back_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Selection].Show();
            this.Hide();
        }

        /// <summary>
        /// This event handler displays the Final form and hides the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Next_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Final].Show();
            this.Hide();
        }


        /// <summary>
        /// This event handler confirms exit when the form is closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConfirmExit(e);
        }
    }
}
