using System.Diagnostics;

namespace ICE11A
{
        public enum FormType
        {
            Splash,
            Start,
            Selection,
            Next,
            Final,
            About
        }

        public enum ToastType
        {
            Success,
            Danger,
            Warning,
            Info
        }

        // Create a struct to hold character data
        public struct CharacterData
        {
            public string AGL;
            public string STR;
            public string VGR;
            public string PER;
            public string INT;
            public string WIL;
            public string CharacterName;
            public string Species;
            public string Career;
        }


    internal static class Program
    {
        public static SplashForm SplashForm;
        public static StartForm StartForm;
        public static SelectionForm SelectionForm;
        public static NextForm NextForm;
        public static FinalForm FinalForm;
        public static AboutForm AboutForm;

        public static List<Form> Forms;

        private static bool IsExiting = false;

        public static bool HasLoadedCharacter = false;

        public static string DownloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),"Downloads");

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            SplashForm = new SplashForm();
            StartForm = new StartForm();
            SelectionForm = new SelectionForm();
            NextForm = new NextForm();
            FinalForm = new FinalForm();
            AboutForm = new AboutForm();

            Forms =
            [
                SplashForm,
                StartForm,
                SelectionForm,
                NextForm,
                FinalForm,
                AboutForm
            ];

            Application.Run(SplashForm);
        }

        public static void ConfirmExit(FormClosingEventArgs e)
        {
            if (IsExiting)
            {
                return;
            }

            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                IsExiting = true;
                Application.Exit();
            }
        }

        public static void SaveCharacter(string path)
        {
            using StreamWriter writer = new StreamWriter(path);

            writer.WriteLine(Settings.Default.AGL);
            writer.WriteLine(Settings.Default.STR);
            writer.WriteLine(Settings.Default.VGR);
            writer.WriteLine(Settings.Default.PER);
            writer.WriteLine(Settings.Default.INT);
            writer.WriteLine(Settings.Default.WIL);
            writer.WriteLine(Settings.Default.CharacterName);
            writer.WriteLine(Settings.Default.Species);
            writer.WriteLine(Settings.Default.Career);
        }

        public static void LoadCharacter(string path)
        {

            try
            {
                // Check for file existence
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Character File does not exist");
                }

                // Check for empty file
                FileInfo info = new FileInfo(path);
                if (info.Length == 0)
                {
                    throw new FileFormatException("Character file is empty");
                }

                // Quick check for file validity by counting the number of lines
                string[] lines = File.ReadAllLines(path);
                if (lines.Length < Settings.Default.Properties.Count)
                {
                    throw new FileFormatException("Invalid Character file");
                }

                // Declaring a variable of type CharacterData
                CharacterData characterData;

                using StreamReader reader = new StreamReader(path);

                // Initialize character data from file
                characterData.AGL = reader.ReadLine();
                characterData.STR = reader.ReadLine();
                characterData.VGR = reader.ReadLine();
                characterData.PER = reader.ReadLine();
                characterData.INT = reader.ReadLine();
                characterData.WIL = reader.ReadLine();
                characterData.CharacterName = reader.ReadLine();
                characterData.Species = reader.ReadLine();
                characterData.Career = reader.ReadLine();

                if (  characterData.AGL == null || characterData.STR == null 
                   || characterData.VGR == null || characterData.PER == null 
                   || characterData.INT == null || characterData.WIL == null 
                   || characterData.CharacterName == null 
                   || characterData.Species == null || characterData.Career == null)
                {
                    throw new FileFormatException("Invalid Character file");
                }

                // reads data from the struct and assigns it to settings
                Settings.Default.AGL = characterData.AGL;
                Settings.Default.STR = characterData.STR;
                Settings.Default.VGR = characterData.VGR;
                Settings.Default.PER = characterData.PER;
                Settings.Default.INT = characterData.INT;
                Settings.Default.WIL = characterData.WIL;
                Settings.Default.CharacterName = characterData.CharacterName;
                Settings.Default.Species = characterData.Species;
                Settings.Default.Career = characterData.Career;
            }
            catch (FileNotFoundException e)
            {
                ShowToast("File Not Found: " + e.Message, ToastType.Danger);
            }
            catch (FileFormatException e)
            {
                ShowToast("Format Error: " + e.Message, ToastType.Danger);
            }
            catch (Exception e)
            {
                ShowToast("Error: " + e.Message, ToastType.Danger);
            }
        }

        public static void ShowToast(string message, ToastType type = ToastType.Success)
        {
            const int padding = 20;

            ToastForm toast = new ToastForm(message, type);

            // Determine the area to center the toast in
            Rectangle area = Form.ActiveForm.Bounds;

            // Calculate the position to center the toast at the top of the area
            int x = area.Left + (area.Width - toast.Width) / 2;
            int y = area.Top + padding;

            // Set the location of the toast and show it
            toast.Location = new Point(x, y);
            toast.TopMost = true;
            toast.Show(Form.ActiveForm);
        }

        public static void SaveCharacterBinary(string path)
        {
            // Create or overwrite the file
            FileStream filestream = new FileStream(path, FileMode.OpenOrCreate);

            // Create a BinaryWriter to write to the file
            using BinaryWriter writer = new BinaryWriter(filestream);

            // Write each setting to the file (use empty string if null)
            writer.Write(Settings.Default.AGL ?? "");
            writer.Write(Settings.Default.STR ?? "");
            writer.Write(Settings.Default.VGR ?? "");
            writer.Write(Settings.Default.PER ?? "");
            writer.Write(Settings.Default.INT ?? "");
            writer.Write(Settings.Default.WIL ?? "");
            writer.Write(Settings.Default.CharacterName ?? "");
            writer.Write(Settings.Default.Species ?? "");
            writer.Write(Settings.Default.Career ?? "");
        }

        public static bool LoadCharacterBinary(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Character File does not exist");
                }

                FileInfo info = new FileInfo(path);
                if (info.Length == 0)
                {
                    throw new FileFormatException("Character file is empty");
                }

                CharacterData characterData;
                FileStream fileStream = new FileStream(path, FileMode.Open);
                using BinaryReader reader = new BinaryReader(fileStream);

                characterData.AGL = reader.ReadString();
                characterData.STR = reader.ReadString();
                characterData.VGR = reader.ReadString();
                characterData.PER = reader.ReadString();
                characterData.INT = reader.ReadString();
                characterData.WIL = reader.ReadString();
                characterData.CharacterName = reader.ReadString();
                characterData.Species = reader.ReadString();
                characterData.Career = reader.ReadString();

                if (characterData.AGL == null || characterData.STR == null || characterData.VGR == null ||
                    characterData.PER == null || characterData.INT == null || characterData.WIL == null ||
                    characterData.CharacterName == null || characterData.Species == null ||
                    characterData.Career == null)
                {
                    throw new FileFormatException("Invalid Character file");
                }
                Settings.Default.AGL = characterData.AGL;
                Settings.Default.STR = characterData.STR;
                Settings.Default.VGR = characterData.VGR;
                Settings.Default.PER = characterData.PER;
                Settings.Default.INT = characterData.INT;
                Settings.Default.WIL = characterData.WIL;
                Settings.Default.CharacterName = characterData.CharacterName;
                Settings.Default.Species = characterData.Species;
                Settings.Default.Career = characterData.Career;

                return true;
            }
            catch (FileNotFoundException e)
            {
                ShowToast("File Not Found: " + e.Message, ToastType.Danger);
                return false;
            }
            catch (FileFormatException e)
            {
                ShowToast("Format Error: " + e.Message, ToastType.Danger);
                return false;
            }
            catch (Exception e)
            {
                ShowToast("Error: " + e.Message, ToastType.Danger);
                return false;
            }
        }


    }
}