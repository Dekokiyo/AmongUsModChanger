using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsModChanger
{
    public partial class AmongUsModChanger : Form
    {
        public static bool IsUpdate = false;

        private void AmongUsModChanger_Load(object sender, EventArgs e)
        {

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
    }
}