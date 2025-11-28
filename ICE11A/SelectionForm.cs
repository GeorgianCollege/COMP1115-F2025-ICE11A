using System.Diagnostics;

namespace ICE11A
{
    enum Career
    {
        Army,
        Psion,
        Rogue,
        Telepath
    }
    public partial class SelectionForm : Form
    {
        // Variable Setup

        Random random = new Random();

        string[] Careers = Enum.GetNames<Career>();

        int[][] CareerStats =
        [
            [35, 35, 30, 30, 25, 25], // Army
            [30, 35, 30, 25, 35, 25], // Psion
            [35, 30, 30, 35, 25, 25], // Rogue
            [25, 30, 30, 35, 25, 35]  // Telepath
        ];

        TextBox[] PrimaryStatTextBoxes;

        TextBox[] SecondaryStatTextBoxes;

        string SelectedCareer;

        string SelectedSpecies = "Human";
       
        public SelectionForm()
        {
            InitializeComponent();

            // Populate the ComboBox with career options
            ComboBox_Career.Items.Clear();
            ComboBox_Career.Items.AddRange(Careers);

            PrimaryStatTextBoxes =
            [
                TextBox_AGL,
                TextBox_STR,
                TextBox_VGR,
                TextBox_PER,
                TextBox_INT,
                TextBox_WIL
            ];

            SecondaryStatTextBoxes =
            [
                TextBox_AWA,
                TextBox_TOU,
                TextBox_RES
            ];
        }

        /// <summary>
        /// This event handler displays the Next form and hides the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Next_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Next].Show();

            Settings.Default.AGL = TextBox_AGL.Text;
            Settings.Default.STR = TextBox_STR.Text;
            Settings.Default.VGR = TextBox_VGR.Text;
            Settings.Default.PER = TextBox_PER.Text;
            Settings.Default.INT = TextBox_INT.Text;
            Settings.Default.WIL = TextBox_WIL.Text;
            Settings.Default.Career = SelectedCareer;
            Settings.Default.Species = SelectedSpecies;
            Settings.Default.CharacterName = TextBox_Name.Text;
            this.Hide();
        }

        /// <summary>
        /// This event handler confirms exit when the form is closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConfirmExit(e);
        }

        private void ComboBox_Career_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Career.SelectedIndex < 0) { return; }

            SelectedCareer = ComboBox_Career.SelectedItem.ToString();

            for (int attribute = 0; attribute < PrimaryStatTextBoxes.Length; attribute++)
            {
                PrimaryStatTextBoxes[attribute].Text = CareerStats[ComboBox_Career.SelectedIndex][attribute].ToString();
            }

            ComputeSecondaryAttributes();

            Button_Next.Enabled = true;
        }

        /// <summary>
        /// This method computes secondary attributes based on primary attributes.
        /// </summary>
        private void ComputeSecondaryAttributes()
        {
            TextBox_AWA.Text = (Convert.ToInt32(TextBox_AGL.Text) + Convert.ToInt32(TextBox_PER.Text)).ToString();
            TextBox_TOU.Text = (Convert.ToInt32(TextBox_STR.Text) + Convert.ToInt32(TextBox_VGR.Text)).ToString();
            TextBox_RES.Text = (Convert.ToInt32(TextBox_INT.Text) + Convert.ToInt32(TextBox_WIL.Text)).ToString();
        }

        /// <summary>
        /// This event handler resets all fields to their default state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Reset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Reset", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ComboBox_Career.SelectedIndex = -1;

                SelectedCareer = string.Empty;

                foreach (var stat in PrimaryStatTextBoxes)
                {
                    stat.Text = string.Empty;
                }

                foreach (var stat in SecondaryStatTextBoxes)
                {
                    stat.Text = string.Empty;
                }

                Button_Next.Enabled = false;
            }
        }

        /// <summary>
        ///  This event handler randomly rolls primary stats using 6d10 drop lowest method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Random_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Random Rolls are Destructive. Are you sure?", "Confirm Random", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ComboBox_Career.SelectedIndex = -1;

                SelectedCareer = "Random";

                foreach (var stat in PrimaryStatTextBoxes)
                {
                    stat.Text = Roll6d10DropLowest().ToString();
                }

                ComputeSecondaryAttributes();

                Button_Next.Enabled = true;
            }
        }

        /// <summary>
        /// This method rolls 6d10, drops the lowest die, and returns the total of the remaining dice.
        /// </summary>
        /// <returns>
        /// This method returns the total of rolling 6d10 and dropping the lowest die.
        /// </returns>
        int Roll6d10DropLowest()
        {
            int[] rolls = new int[6];
            for (int die = 0; die < 6; die++)
            {
                rolls[die] = random.Next(1, 11);
            }

            Array.Sort(rolls);

            int total = 0;
            for (int die = 1; die < 6; die++)
            {
                total += rolls[die];
            }
            return total;
        }

        /// <summary>
        /// This method rolls 5d10 and returns the total.
        /// </summary>
        /// <remarks>
        /// <b>Deprecated:</b> Use <see cref="Roll6d10DropLowest"/> instead.
        /// </remarks>
        /// <deprecated>
        /// This method is deprecated and may be removed in future versions.
        /// </deprecated>
        /// <returns>
        /// This method returns the total of rolling 5d10.
        /// </returns>
        int Roll5d10()
        {
            int total = 0;
            for (int die = 0; die < 5; die++)
            {
                total += random.Next(1, 11);
            }
            return total;
        }

        /// <summary>
        /// This event handler shows or hides the Random button based on the CheckBox state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_ShowRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_ShowRandom.Checked)
            {
                Button_Random.Show();
            }
            else
            {
                Button_Random.Hide();
            }
        }

        private void RadioButton_Species_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            SelectedSpecies = radioButton.Text;
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            if (Program.HasLoadedCharacter)
            {
                TextBox_AGL.Text = Settings.Default.AGL;
                TextBox_STR.Text = Settings.Default.STR;
                TextBox_VGR.Text = Settings.Default.VGR;
                TextBox_PER.Text = Settings.Default.PER;
                TextBox_INT.Text = Settings.Default.INT;
                TextBox_WIL.Text = Settings.Default.WIL;
                ComboBox_Career.SelectedItem = Settings.Default.Career;
                SelectedSpecies = Settings.Default.Species;
                TextBox_Name.Text = Settings.Default.CharacterName;

                switch (SelectedSpecies)
                {
                    case "Human":
                        RadioButton_Human.Checked = true;
                        break;
                    case "Robot":
                        RadioButton_Robot.Checked = true;
                        break;
                    case "Alien":
                        RadioButton_Alien.Checked = true;
                        break;
                    default:
                        RadioButton_Human.Checked = true;
                        break;
                }

                ComputeSecondaryAttributes();

                Program.ShowToast("Character Loaded!");
            }
        }
    }
}
