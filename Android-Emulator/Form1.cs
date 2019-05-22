using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Android_Emulator
{
    using Utility;
    public partial class MainForm : Form
    {
        public static T[] ReverseArray<T>(T[] array)
        {
            T[] flippedArray = new T[array.Length];
            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
                flippedArray[j] = array[i];

            return flippedArray;
        }

        const string EMULATOR_EXE = "%android_home%\\emulator\\emulator.exe";

        private BindingList<string> mCommands;
        private PresetPool mPresetPool;

        private bool mIsAddingPreset;
        private bool mIsLoading = true;

        public MainForm()
        {
            InitializeComponent();

            mPresetPool = new PresetPool("presets.txt");

            // Get all the emulators;
            string data = Shell.Run(EMULATOR_EXE + " -list-avds");
            string[] emulators = data.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries); ;

            CB_emulators.DataSource = ReverseArray(emulators);

            // Load in all the saved commands
            FileHandler.Load("commands.txt", out mCommands);

            LB_commands.DataSource = mCommands;
            LB_chosenCMDs.DataSource = mPresetPool.ActivePreset;
            CB_presets.DataSource = mPresetPool.Names;

            mIsLoading = false;
            CB_presets.SelectedIndex = mPresetPool.IndexOfCurrentPreset;
        }

        private void btn_createCMD_Click(object sender, EventArgs e)
        {
            string text = tb_newCMD.Text;

            if (text == "")
                MessageBox.Show("Does not accept empty input");
            else if(mCommands.Contains(text))
                MessageBox.Show("Value already exists!");
            else
                mCommands.Add(tb_newCMD.Text);

            tb_newCMD.Text = "";
            FileHandler.Save("commands.txt", mCommands);
        }

        private void BTN_deleteCMD_Click(object sender, EventArgs e)
        {
            int index = LB_commands.SelectedIndex;
            if (index < 0)
                return;

            DialogResult result = MessageBox.Show("Are you sure you wish to delete this command?", "Delete Command", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                mCommands.RemoveAt(index);
                FileHandler.Save("commands.txt", mCommands);
            }
        }

        private void BTN_addCMD_Click(object sender, EventArgs e)
        {
    
            string cmd = LB_commands.SelectedItem as string;
            if (!mPresetPool.AddToActivePreset(cmd))
                return;

            LB_chosenCMDs.Update();
            if (LB_commands.SelectedIndex < LB_commands.Items.Count - 1)
                LB_commands.SelectedIndex++;
        }

        private void cmd_removeCMD_Click(object sender, EventArgs e)
        {
            int index = LB_chosenCMDs.SelectedIndex;
            if (index < 0)
                return;

            mPresetPool.RemoveFromActivePreset(index);
            LB_chosenCMDs.Update();
        }

        private void BTN_runStop_Click(object sender, EventArgs e)
        {
            string device = CB_emulators.SelectedItem as string;
            if (device == "")
                return;

            string arguments = GenerateArguments();
            Shell.RunExternal(device, $"{EMULATOR_EXE} -avd {device} {arguments}", CB_hideConsole.Checked);
        }

        private string GenerateArguments()
        {
            string argument = "";
            foreach(var arg in LB_chosenCMDs.Items)
                argument += arg + " ";

            return argument;
        }

        private void BTN_presetAdd_Click(object sender, EventArgs e)
        {
            if(mIsAddingPreset)
            {
                if (TB_addNewPreset.Text == "")
                    return;

                mPresetPool.CreatePreset(TB_addNewPreset.Text);
                CB_presets.SelectedIndex = mPresetPool.IndexOfCurrentPreset;
                DisableAddingPreset();
                return;
            }

            EnableAddingPreset();
        }

        private void EnableAddingPreset()
        {
            TB_addNewPreset.Visible = true;
            BTN_presetRemove.Text = "x";
            mIsAddingPreset = true;
        }

        private void DisableAddingPreset()
        {
            mIsAddingPreset = false;
            BTN_presetRemove.Text = "-";
            TB_addNewPreset.Visible = false;
            TB_addNewPreset.Text = "";
        }

        private void BTN_presetRemove_Click(object sender, EventArgs e)
        {
            if(mIsAddingPreset)
            {
                DisableAddingPreset();
                return;
            }

            string item = CB_presets.SelectedItem as string;
            if (item == "")
                return;

            DialogResult result = MessageBox.Show("Are you sure you wish to delete this preset?", "Delete Preset", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                mPresetPool.DeletePreset(item);
            CB_presets.Update();
        }

        private void CB_presets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mIsLoading)
                return;

            mPresetPool.SetActivePreset(CB_presets.SelectedIndex);
            LB_chosenCMDs.DataSource = mPresetPool.ActivePreset;
            LB_chosenCMDs.Update();
        }
    }
}
