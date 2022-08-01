using System;
using System.IO;
using System.Windows.Forms;
using static AmongUsModChanger.Program;

namespace AmongUsModChanger
{
    public partial class AmongUsModChanger : Form
    {
        public string AmongUsFolderPass;
        public string AmongUsExePass;
        public string Presets;
        public string PresetFolderPass = @"C:\Program Files\AmongUsModChanger\Presets";
        public string AmongUsVanillaCopy = @"C:\Program Files\AmongUsModChanger\AmongUsCopy";
        public string SettingFilePass = @"C:\Program Files\AmongUsModChanger\data.txt";
        private void AmongUsModChanger_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(@"C:\Program Files\") + @"\AmongUsModChanger\");
            Directory.CreateDirectory(Path.GetDirectoryName(@"C:\Program Files\") + @"\AmongUsModChanger\Presets\");
            Directory.CreateDirectory(Path.GetDirectoryName(@"C:\Program Files\") + @"\AmongUsModChanger\AmongUsCopy\");

            int counter = 0;

            // Read the file and display it line by line.
            if (System.IO.File.Exists(SettingFilePass))
            {
                foreach (string line in System.IO.File.ReadLines(SettingFilePass))
                {
                    if (counter == 0)
                    {
                        AmongUsExePass = line;
                        AmongUsFolderPass = Path.GetDirectoryName(line);
                        AmongUsDirectory.Text = AmongUsExePass;
                        counter++;
                    }
                    else if (counter == 1)
                    {
                        PresetName.Text = line;
                        if (PresetName.Text == "")
                            PresetName.Text = "未選択";
                        counter++;
                    }
                    else if (counter == 2)
                    {
                        Preset1Button.Text = line;
                        Preset1TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 3)
                    {
                        Preset2Button.Text = line;
                        Preset2TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 4)
                    {
                        Preset3Button.Text = line;
                        Preset3TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 5)
                    {
                        Preset4Button.Text = line;
                        Preset4TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 6)
                    {
                        Preset5Button.Text = line;
                        Preset5TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 7)
                    {
                        Preset6Button.Text = line;
                        Preset6TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 8)
                    {
                        Preset7Button.Text = line;
                        Preset7TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 9)
                    {
                        Preset8Button.Text = line;
                        Preset8TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 10)
                    {
                        Preset9Button.Text = line;
                        Preset9TextBox.Text = line;
                        counter++;
                    }
                    else if (counter == 11)
                    {
                        Preset10Button.Text = line;
                        Preset10TextBox.Text = line;
                        counter++;
                    }
                }
            }
            Preset1Button.Text = Preset1TextBox.Text;
            Preset2Button.Text = Preset2TextBox.Text;
            Preset3Button.Text = Preset3TextBox.Text;
            Preset4Button.Text = Preset4TextBox.Text;
            Preset5Button.Text = Preset5TextBox.Text;
            Preset6Button.Text = Preset6TextBox.Text;
            Preset7Button.Text = Preset7TextBox.Text;
            Preset8Button.Text = Preset8TextBox.Text;
            Preset9Button.Text = Preset9TextBox.Text;
            Preset10Button.Text = Preset10TextBox.Text;
        }
        public AmongUsModChanger()
        {
            InitializeComponent();
        }

        // Directory Button
        private void DirectoryBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = SelectDirectory.ShowDialog();
            if (dr == DialogResult.OK)
            {
                AmongUsDirectory.Text = SelectDirectory.FileName;
            }
            if (!System.IO.File.Exists(AmongUsVanillaCopy + "\\Among Us.exe"))
            {
                CopyDirectory(AmongUsFolderPass, AmongUsVanillaCopy);
            }
        }

        // Preset Name Apply
        private void PresetNameApply_Click(object sender, EventArgs e)
        {
            Preset1Button.Text = Preset1TextBox.Text;
            Preset2Button.Text = Preset2TextBox.Text;
            Preset3Button.Text = Preset3TextBox.Text;
            Preset4Button.Text = Preset4TextBox.Text;
            Preset5Button.Text = Preset5TextBox.Text;
            Preset6Button.Text = Preset6TextBox.Text;
            Preset7Button.Text = Preset7TextBox.Text;
            Preset8Button.Text = Preset8TextBox.Text;
            Preset9Button.Text = Preset9TextBox.Text;
            Preset10Button.Text = Preset10TextBox.Text;
        }

        // Discord Button
        private void DiscordServerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/QuXJPfYfvw");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Dekokiyo/AmongUsModChanger");
        }

        private void Preset1Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass1 = PresetFolderPass + "\\Preset1";
                Presets = "Preset1";
                LoadingMod = Preset1TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass1))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass1);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass1, AmongUsFolderPass);
            }
        }

        private void Preset2Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass2 = PresetFolderPass + "\\Preset2";
                Presets = "Preset2";
                LoadingMod = Preset2TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass2))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass2);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass2, AmongUsFolderPass);
            }
        }

        private void Preset3Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass3 = PresetFolderPass + "\\Preset3";
                Presets = "Preset3";
                LoadingMod = Preset3TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass3))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass3);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass3, AmongUsFolderPass);
            }
        }

        private void Preset4Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass4 = PresetFolderPass + "\\Preset4";
                Presets = "Preset4";
                LoadingMod = Preset4TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass4))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass4);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass4, AmongUsFolderPass);
            }
        }

        private void Preset5Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass5 = PresetFolderPass + "\\Preset5";
                Presets = "Preset5";
                LoadingMod = Preset5TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass5))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass5);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass5, AmongUsFolderPass);
            }
        }

        private void Preset6Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass6 = PresetFolderPass + "\\Preset6";
                Presets = "Preset6";
                LoadingMod = Preset6TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass6))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass6);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass6, AmongUsFolderPass);
            }
        }

        private void Preset7Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass7 = PresetFolderPass + "\\Preset7";
                Presets = "Preset7";
                LoadingMod = Preset7TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass7))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass7);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass7, AmongUsFolderPass);
            }
        }

        private void Preset8Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass8 = PresetFolderPass + "\\Preset8";
                Presets = "Preset8";
                LoadingMod = Preset8TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass8))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass8);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass8, AmongUsFolderPass);
            }
        }

        private void Preset9Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass9 = PresetFolderPass + "\\Preset9";
                Presets = "Preset9";
                LoadingMod = Preset9TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass9))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass9);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass9, AmongUsFolderPass);
            }
        }

        private void Preset10Button_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
            {
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
            {
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string PresetFolderPass10 = PresetFolderPass + "\\Preset10";
                Presets = "Preset10";
                LoadingMod = Preset10TextBox.Text;
                PresetName.Text = LoadingMod;
                if (!System.IO.Directory.Exists(PresetFolderPass10))
                {
                    CopyDirectory(AmongUsVanillaCopy, PresetFolderPass10);
                }
                Directory.Delete(AmongUsFolderPass, true);
                CopyDirectory(PresetFolderPass10, AmongUsFolderPass);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AmongUsExePass = AmongUsDirectory.Text;
            AmongUsFolderPass = Path.GetDirectoryName(AmongUsExePass);
            File.WriteAllText(SettingFilePass, "");
            File.AppendAllText(SettingFilePass, AmongUsExePass + Environment.NewLine);
            File.AppendAllText(SettingFilePass, LoadingMod + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset1Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset2Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset3Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset4Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset5Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset6Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset7Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset8Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset9Button.Text + Environment.NewLine);
            File.AppendAllText(SettingFilePass, Preset10Button.Text + Environment.NewLine);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
    "保存されているデータをリセットしますか?",
    "警告",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning,
    MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                File.WriteAllText(SettingFilePass, "");
                AmongUsFolderPass = "";
                AmongUsDirectory.Text = "";
                PresetName.Text = "未選択";
                Preset1Button.Text = "Preset1";
                Preset2Button.Text = "Preset2";
                Preset3Button.Text = "Preset3";
                Preset4Button.Text = "Preset4";
                Preset5Button.Text = "Preset5";
                Preset6Button.Text = "Preset6";
                Preset7Button.Text = "Preset7";
                Preset8Button.Text = "Preset8";
                Preset9Button.Text = "Preset9";
                Preset10Button.Text = "Preset10";
                Preset1TextBox.Text = "Preset1";
                Preset2TextBox.Text = "Preset2";
                Preset3TextBox.Text = "Preset3";
                Preset4TextBox.Text = "Preset4";
                Preset5TextBox.Text = "Preset5";
                Preset6TextBox.Text = "Preset6";
                Preset7TextBox.Text = "Preset7";
                Preset8TextBox.Text = "Preset8";
                Preset9TextBox.Text = "Preset9";
                Preset10TextBox.Text = "Preset10";
                MessageBox.Show("リセットしました。", "リセット");
            }
            else
            {
                MessageBox.Show("キャンセルしました。", "キャンセル");
            }
        }

        // Steam Start Button
        private void Steam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://rungameid/945360");
        }

        // Epic Start Button
        private void Epic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("com.epicgames.launcher://apps/33956bcb55d4452d8c47e16b94e294bd%3A729a86a5146640a2ace9e8c595414c56%3A963137e4c29d4c79a81323b8fab03a40?action=launch&silent=true");
        }

        // Open Game Directory
        private void OpenGameDirectory_Click(object sender, EventArgs e)
        {
            if (AmongUsDirectory.Text == "")
                MessageBox.Show("ゲームディレクトリを指定してください。", "エラーコード1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!(Path.GetFileName(AmongUsDirectory.Text) == "Among Us.exe"))
                MessageBox.Show("ゲームディレクトリが正しく指定されていません。\nAmong Us.exeを指定し直してください。", "エラーコード2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                System.Diagnostics.Process.Start(AmongUsFolderPass);
        }

        // Open Presets Directory
        private void OpenModFiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(PresetFolderPass);
        }

        private void RemoveVanilla_Click(object sender, EventArgs e)
        {
            PresetName.Text = "未選択";
            Directory.Delete(AmongUsFolderPass, true);
            CopyDirectory(AmongUsVanillaCopy, AmongUsFolderPass);
        }
    }
}