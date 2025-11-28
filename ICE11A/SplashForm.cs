namespace ICE11A
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer_SplashForm_Tick(object sender, EventArgs e)
        {
            this.Timer_SplashForm.Stop();
            this.Hide();
            Program.Forms[(int)FormType.Start].Show();
        }
    }
}
