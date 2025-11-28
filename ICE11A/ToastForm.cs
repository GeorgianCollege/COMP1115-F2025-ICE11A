using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE11A
{
    public partial class ToastForm : Form
    {
        public ToastForm()
        {
            InitializeComponent();
        }

        public ToastForm(string message, ToastType type)
        {
            InitializeComponent();
            Label_Message.Text = message;

            switch (type)
            {
                case ToastType.Success:
                    BackColor = ColorTranslator.FromHtml("#198754");
                    break;

                case ToastType.Danger:
                    BackColor = ColorTranslator.FromHtml("#DC3545");
                    break;

                case ToastType.Warning:
                    BackColor = ColorTranslator.FromHtml("#FFC107");
                    break;

                case ToastType.Info:
                    BackColor = ColorTranslator.FromHtml("#0DCAF0");
                    break;

                default:
                    BackColor = ColorTranslator.FromHtml("#6C757D");
                    break;
            }
        }

        private void ToastForm_Shown(object sender, EventArgs e)
        {
            ToastTimer.Start();
        }

        private void ToastTimer_Tick(object sender, EventArgs e)
        {
            ToastTimer.Stop();
            Close();
        }
    }
}
