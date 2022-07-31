namespace AmongUsModChanger
{
    partial class AmongUsModChanger
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmongUsModChanger));
            this.SelectDirectory = new System.Windows.Forms.OpenFileDialog();
            this.DirectoryBtn = new System.Windows.Forms.Button();
            this.AmongUsDirectory = new System.Windows.Forms.TextBox();
            this.ChooseAmongUsDirectory = new System.Windows.Forms.Label();
            this.Preset1Button = new System.Windows.Forms.Button();
            this.SelectModText = new System.Windows.Forms.Label();
            this.Preset2Button = new System.Windows.Forms.Button();
            this.Preset3Button = new System.Windows.Forms.Button();
            this.Preset4Button = new System.Windows.Forms.Button();
            this.Preset5Button = new System.Windows.Forms.Button();
            this.Preset6Button = new System.Windows.Forms.Button();
            this.Preset7Button = new System.Windows.Forms.Button();
            this.Preset8Button = new System.Windows.Forms.Button();
            this.Preset9Button = new System.Windows.Forms.Button();
            this.Preset10Button = new System.Windows.Forms.Button();
            this.Preset1TextBox = new System.Windows.Forms.TextBox();
            this.Preset2TextBox = new System.Windows.Forms.TextBox();
            this.Preset3TextBox = new System.Windows.Forms.TextBox();
            this.Preset4TextBox = new System.Windows.Forms.TextBox();
            this.Preset5TextBox = new System.Windows.Forms.TextBox();
            this.Preset6TextBox = new System.Windows.Forms.TextBox();
            this.Preset7TextBox = new System.Windows.Forms.TextBox();
            this.Preset8TextBox = new System.Windows.Forms.TextBox();
            this.Preset9TextBox = new System.Windows.Forms.TextBox();
            this.Preset10TextBox = new System.Windows.Forms.TextBox();
            this.SetPresetText = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Num3 = new System.Windows.Forms.Label();
            this.Num4 = new System.Windows.Forms.Label();
            this.Num5 = new System.Windows.Forms.Label();
            this.Num6 = new System.Windows.Forms.Label();
            this.Num7 = new System.Windows.Forms.Label();
            this.Num8 = new System.Windows.Forms.Label();
            this.Num9 = new System.Windows.Forms.Label();
            this.Num10 = new System.Windows.Forms.Label();
            this.PresetNameApply = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Steam = new System.Windows.Forms.Button();
            this.Epic = new System.Windows.Forms.Button();
            this.StartOption = new System.Windows.Forms.Label();
            this.OpenModFiles = new System.Windows.Forms.Button();
            this.OpenGameDirectory = new System.Windows.Forms.Button();
            this.Chuui = new System.Windows.Forms.Label();
            this.HowToUse = new System.Windows.Forms.Label();
            this.DiscordServerLink = new System.Windows.Forms.LinkLabel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateIsAllived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectDirectory
            // 
            this.SelectDirectory.FileName = "SelectDirectory";
            this.SelectDirectory.Filter = "Among Us.exe|Among Us.exe";
            // 
            // DirectoryBtn
            // 
            this.DirectoryBtn.Location = new System.Drawing.Point(633, 39);
            this.DirectoryBtn.Name = "DirectoryBtn";
            this.DirectoryBtn.Size = new System.Drawing.Size(82, 23);
            this.DirectoryBtn.TabIndex = 0;
            this.DirectoryBtn.Text = "参照";
            this.DirectoryBtn.UseVisualStyleBackColor = true;
            this.DirectoryBtn.Click += new System.EventHandler(this.DirectoryBtn_Click);
            // 
            // AmongUsDirectory
            // 
            this.AmongUsDirectory.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.AmongUsDirectory.Location = new System.Drawing.Point(12, 39);
            this.AmongUsDirectory.Name = "AmongUsDirectory";
            this.AmongUsDirectory.ReadOnly = true;
            this.AmongUsDirectory.Size = new System.Drawing.Size(615, 23);
            this.AmongUsDirectory.TabIndex = 1;
            // 
            // ChooseAmongUsDirectory
            // 
            this.ChooseAmongUsDirectory.AutoSize = true;
            this.ChooseAmongUsDirectory.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.ChooseAmongUsDirectory.Location = new System.Drawing.Point(7, 9);
            this.ChooseAmongUsDirectory.Name = "ChooseAmongUsDirectory";
            this.ChooseAmongUsDirectory.Size = new System.Drawing.Size(625, 24);
            this.ChooseAmongUsDirectory.TabIndex = 2;
            this.ChooseAmongUsDirectory.Text = "AmongUsのゲームディレクトリを指定してください。(Among Us.exe)";
            // 
            // Preset1Button
            // 
            this.Preset1Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset1Button.Location = new System.Drawing.Point(16, 120);
            this.Preset1Button.Name = "Preset1Button";
            this.Preset1Button.Size = new System.Drawing.Size(150, 70);
            this.Preset1Button.TabIndex = 3;
            this.Preset1Button.Text = "Preset1";
            this.Preset1Button.UseVisualStyleBackColor = true;
            // 
            // SelectModText
            // 
            this.SelectModText.AutoSize = true;
            this.SelectModText.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.SelectModText.Location = new System.Drawing.Point(105, 82);
            this.SelectModText.Name = "SelectModText";
            this.SelectModText.Size = new System.Drawing.Size(133, 20);
            this.SelectModText.TabIndex = 4;
            this.SelectModText.Text = "プリセットを選択";
            // 
            // Preset2Button
            // 
            this.Preset2Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset2Button.Location = new System.Drawing.Point(16, 196);
            this.Preset2Button.Name = "Preset2Button";
            this.Preset2Button.Size = new System.Drawing.Size(150, 70);
            this.Preset2Button.TabIndex = 5;
            this.Preset2Button.Text = "Preset2";
            this.Preset2Button.UseVisualStyleBackColor = true;
            // 
            // Preset3Button
            // 
            this.Preset3Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset3Button.Location = new System.Drawing.Point(16, 272);
            this.Preset3Button.Name = "Preset3Button";
            this.Preset3Button.Size = new System.Drawing.Size(150, 70);
            this.Preset3Button.TabIndex = 6;
            this.Preset3Button.Text = "Preset3";
            this.Preset3Button.UseVisualStyleBackColor = true;
            // 
            // Preset4Button
            // 
            this.Preset4Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset4Button.Location = new System.Drawing.Point(16, 348);
            this.Preset4Button.Name = "Preset4Button";
            this.Preset4Button.Size = new System.Drawing.Size(150, 70);
            this.Preset4Button.TabIndex = 7;
            this.Preset4Button.Text = "Preset4";
            this.Preset4Button.UseVisualStyleBackColor = true;
            // 
            // Preset5Button
            // 
            this.Preset5Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset5Button.Location = new System.Drawing.Point(16, 424);
            this.Preset5Button.Name = "Preset5Button";
            this.Preset5Button.Size = new System.Drawing.Size(150, 70);
            this.Preset5Button.TabIndex = 8;
            this.Preset5Button.Text = "Preset5";
            this.Preset5Button.UseVisualStyleBackColor = true;
            // 
            // Preset6Button
            // 
            this.Preset6Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset6Button.Location = new System.Drawing.Point(172, 120);
            this.Preset6Button.Name = "Preset6Button";
            this.Preset6Button.Size = new System.Drawing.Size(150, 70);
            this.Preset6Button.TabIndex = 9;
            this.Preset6Button.Text = "Preset6";
            this.Preset6Button.UseVisualStyleBackColor = true;
            // 
            // Preset7Button
            // 
            this.Preset7Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset7Button.Location = new System.Drawing.Point(172, 196);
            this.Preset7Button.Name = "Preset7Button";
            this.Preset7Button.Size = new System.Drawing.Size(150, 70);
            this.Preset7Button.TabIndex = 10;
            this.Preset7Button.Text = "Preset7";
            this.Preset7Button.UseVisualStyleBackColor = true;
            // 
            // Preset8Button
            // 
            this.Preset8Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset8Button.Location = new System.Drawing.Point(172, 272);
            this.Preset8Button.Name = "Preset8Button";
            this.Preset8Button.Size = new System.Drawing.Size(150, 70);
            this.Preset8Button.TabIndex = 11;
            this.Preset8Button.Text = "Preset8";
            this.Preset8Button.UseVisualStyleBackColor = true;
            // 
            // Preset9Button
            // 
            this.Preset9Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset9Button.Location = new System.Drawing.Point(172, 348);
            this.Preset9Button.Name = "Preset9Button";
            this.Preset9Button.Size = new System.Drawing.Size(150, 70);
            this.Preset9Button.TabIndex = 12;
            this.Preset9Button.Text = "Preset9";
            this.Preset9Button.UseVisualStyleBackColor = true;
            // 
            // Preset10Button
            // 
            this.Preset10Button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset10Button.Location = new System.Drawing.Point(172, 424);
            this.Preset10Button.Name = "Preset10Button";
            this.Preset10Button.Size = new System.Drawing.Size(150, 70);
            this.Preset10Button.TabIndex = 13;
            this.Preset10Button.Text = "Preset10";
            this.Preset10Button.UseVisualStyleBackColor = true;
            // 
            // Preset1TextBox
            // 
            this.Preset1TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset1TextBox.Location = new System.Drawing.Point(356, 122);
            this.Preset1TextBox.Name = "Preset1TextBox";
            this.Preset1TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset1TextBox.TabIndex = 14;
            this.Preset1TextBox.Text = "Preset1";
            // 
            // Preset2TextBox
            // 
            this.Preset2TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset2TextBox.Location = new System.Drawing.Point(356, 151);
            this.Preset2TextBox.Name = "Preset2TextBox";
            this.Preset2TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset2TextBox.TabIndex = 15;
            this.Preset2TextBox.Text = "Preset2";
            // 
            // Preset3TextBox
            // 
            this.Preset3TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset3TextBox.Location = new System.Drawing.Point(356, 180);
            this.Preset3TextBox.Name = "Preset3TextBox";
            this.Preset3TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset3TextBox.TabIndex = 16;
            this.Preset3TextBox.Text = "Preset3";
            // 
            // Preset4TextBox
            // 
            this.Preset4TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset4TextBox.Location = new System.Drawing.Point(356, 209);
            this.Preset4TextBox.Name = "Preset4TextBox";
            this.Preset4TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset4TextBox.TabIndex = 17;
            this.Preset4TextBox.Text = "Preset4";
            // 
            // Preset5TextBox
            // 
            this.Preset5TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset5TextBox.Location = new System.Drawing.Point(356, 238);
            this.Preset5TextBox.Name = "Preset5TextBox";
            this.Preset5TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset5TextBox.TabIndex = 18;
            this.Preset5TextBox.Text = "Preset5";
            // 
            // Preset6TextBox
            // 
            this.Preset6TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset6TextBox.Location = new System.Drawing.Point(356, 267);
            this.Preset6TextBox.Name = "Preset6TextBox";
            this.Preset6TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset6TextBox.TabIndex = 19;
            this.Preset6TextBox.Text = "Preset6";
            // 
            // Preset7TextBox
            // 
            this.Preset7TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset7TextBox.Location = new System.Drawing.Point(356, 296);
            this.Preset7TextBox.Name = "Preset7TextBox";
            this.Preset7TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset7TextBox.TabIndex = 20;
            this.Preset7TextBox.Text = "Preset7";
            // 
            // Preset8TextBox
            // 
            this.Preset8TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset8TextBox.Location = new System.Drawing.Point(356, 325);
            this.Preset8TextBox.Name = "Preset8TextBox";
            this.Preset8TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset8TextBox.TabIndex = 21;
            this.Preset8TextBox.Text = "Preset8";
            // 
            // Preset9TextBox
            // 
            this.Preset9TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset9TextBox.Location = new System.Drawing.Point(356, 354);
            this.Preset9TextBox.Name = "Preset9TextBox";
            this.Preset9TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset9TextBox.TabIndex = 22;
            this.Preset9TextBox.Text = "Preset9";
            // 
            // Preset10TextBox
            // 
            this.Preset10TextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Preset10TextBox.Location = new System.Drawing.Point(356, 383);
            this.Preset10TextBox.Name = "Preset10TextBox";
            this.Preset10TextBox.Size = new System.Drawing.Size(196, 23);
            this.Preset10TextBox.TabIndex = 23;
            this.Preset10TextBox.Text = "Preset10";
            // 
            // SetPresetText
            // 
            this.SetPresetText.AutoSize = true;
            this.SetPresetText.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.SetPresetText.Location = new System.Drawing.Point(359, 82);
            this.SetPresetText.Name = "SetPresetText";
            this.SetPresetText.Size = new System.Drawing.Size(189, 20);
            this.SetPresetText.TabIndex = 24;
            this.SetPresetText.Text = "プリセットの名前を指定";
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num1.Location = new System.Drawing.Point(335, 125);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(15, 16);
            this.Num1.TabIndex = 25;
            this.Num1.Text = "1";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num2.Location = new System.Drawing.Point(335, 154);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(15, 16);
            this.Num2.TabIndex = 26;
            this.Num2.Text = "2";
            // 
            // Num3
            // 
            this.Num3.AutoSize = true;
            this.Num3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num3.Location = new System.Drawing.Point(335, 183);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(15, 16);
            this.Num3.TabIndex = 27;
            this.Num3.Text = "3";
            // 
            // Num4
            // 
            this.Num4.AutoSize = true;
            this.Num4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num4.Location = new System.Drawing.Point(335, 212);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(15, 16);
            this.Num4.TabIndex = 28;
            this.Num4.Text = "4";
            // 
            // Num5
            // 
            this.Num5.AutoSize = true;
            this.Num5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num5.Location = new System.Drawing.Point(335, 241);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(15, 16);
            this.Num5.TabIndex = 29;
            this.Num5.Text = "5";
            // 
            // Num6
            // 
            this.Num6.AutoSize = true;
            this.Num6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num6.Location = new System.Drawing.Point(335, 270);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(15, 16);
            this.Num6.TabIndex = 30;
            this.Num6.Text = "6";
            // 
            // Num7
            // 
            this.Num7.AutoSize = true;
            this.Num7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num7.Location = new System.Drawing.Point(335, 299);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(15, 16);
            this.Num7.TabIndex = 31;
            this.Num7.Text = "7";
            // 
            // Num8
            // 
            this.Num8.AutoSize = true;
            this.Num8.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num8.Location = new System.Drawing.Point(335, 328);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(15, 16);
            this.Num8.TabIndex = 32;
            this.Num8.Text = "8";
            // 
            // Num9
            // 
            this.Num9.AutoSize = true;
            this.Num9.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num9.Location = new System.Drawing.Point(335, 357);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(15, 16);
            this.Num9.TabIndex = 33;
            this.Num9.Text = "9";
            // 
            // Num10
            // 
            this.Num10.AutoSize = true;
            this.Num10.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Num10.Location = new System.Drawing.Point(331, 386);
            this.Num10.Name = "Num10";
            this.Num10.Size = new System.Drawing.Size(23, 16);
            this.Num10.TabIndex = 34;
            this.Num10.Text = "10";
            // 
            // PresetNameApply
            // 
            this.PresetNameApply.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.PresetNameApply.Location = new System.Drawing.Point(356, 424);
            this.PresetNameApply.Name = "PresetNameApply";
            this.PresetNameApply.Size = new System.Drawing.Size(196, 70);
            this.PresetNameApply.TabIndex = 35;
            this.PresetNameApply.Text = "変更を適用";
            this.PresetNameApply.UseVisualStyleBackColor = true;
            this.PresetNameApply.Click += new System.EventHandler(this.PresetNameApply_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.SaveButton.Location = new System.Drawing.Point(565, 120);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 81);
            this.SaveButton.TabIndex = 36;
            this.SaveButton.Text = "設定を保存する";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ResetButton.Location = new System.Drawing.Point(731, 120);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(150, 81);
            this.ResetButton.TabIndex = 37;
            this.ResetButton.Text = "リセット";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // Steam
            // 
            this.Steam.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Steam.Location = new System.Drawing.Point(16, 555);
            this.Steam.Name = "Steam";
            this.Steam.Size = new System.Drawing.Size(150, 81);
            this.Steam.TabIndex = 38;
            this.Steam.Text = "Steamで起動";
            this.Steam.UseVisualStyleBackColor = true;
            // 
            // Epic
            // 
            this.Epic.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Epic.Location = new System.Drawing.Point(172, 555);
            this.Epic.Name = "Epic";
            this.Epic.Size = new System.Drawing.Size(150, 81);
            this.Epic.TabIndex = 39;
            this.Epic.Text = "Epicで起動";
            this.Epic.UseVisualStyleBackColor = true;
            // 
            // StartOption
            // 
            this.StartOption.AutoSize = true;
            this.StartOption.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.StartOption.Location = new System.Drawing.Point(111, 518);
            this.StartOption.Name = "StartOption";
            this.StartOption.Size = new System.Drawing.Size(112, 20);
            this.StartOption.TabIndex = 40;
            this.StartOption.Text = "ゲームを起動";
            // 
            // OpenModFiles
            // 
            this.OpenModFiles.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.OpenModFiles.Location = new System.Drawing.Point(356, 555);
            this.OpenModFiles.Name = "OpenModFiles";
            this.OpenModFiles.Size = new System.Drawing.Size(196, 81);
            this.OpenModFiles.TabIndex = 41;
            this.OpenModFiles.Text = "プリセットフォルダを開く";
            this.OpenModFiles.UseVisualStyleBackColor = true;
            // 
            // OpenGameDirectory
            // 
            this.OpenGameDirectory.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.OpenGameDirectory.Location = new System.Drawing.Point(356, 500);
            this.OpenGameDirectory.Name = "OpenGameDirectory";
            this.OpenGameDirectory.Size = new System.Drawing.Size(196, 49);
            this.OpenGameDirectory.TabIndex = 42;
            this.OpenGameDirectory.Text = "ゲームディレクトリを開く";
            this.OpenGameDirectory.UseVisualStyleBackColor = true;
            // 
            // Chuui
            // 
            this.Chuui.AutoSize = true;
            this.Chuui.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Chuui.Location = new System.Drawing.Point(582, 517);
            this.Chuui.Name = "Chuui";
            this.Chuui.Size = new System.Drawing.Size(420, 112);
            this.Chuui.TabIndex = 43;
            this.Chuui.Text = "処理中に強制終了するのはおやめください。\nこのツールによって発生したいかなる損害にも責任を負いかねます。\n\nこのツールは、AmongUsまたInnersloth " +
    "LLCと提携しておらず、\nこれに含まれるコンテンツは、Innersloth LLC によって承認\nまたはその他の形で後援されているわけではありません。\n©Inn" +
    "ersloth LLC";
            // 
            // HowToUse
            // 
            this.HowToUse.AutoSize = true;
            this.HowToUse.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.HowToUse.Location = new System.Drawing.Point(592, 220);
            this.HowToUse.Name = "HowToUse";
            this.HowToUse.Size = new System.Drawing.Size(395, 20);
            this.HowToUse.TabIndex = 44;
            this.HowToUse.Text = "【使い方はこちらのDiscordサーバーをご覧ください】";
            // 
            // DiscordServerLink
            // 
            this.DiscordServerLink.AutoSize = true;
            this.DiscordServerLink.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.DiscordServerLink.Location = new System.Drawing.Point(648, 250);
            this.DiscordServerLink.Name = "DiscordServerLink";
            this.DiscordServerLink.Size = new System.Drawing.Size(266, 40);
            this.DiscordServerLink.TabIndex = 45;
            this.DiscordServerLink.TabStop = true;
            this.DiscordServerLink.Text = "Discord Server";
            this.DiscordServerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordServerLink_LinkClicked);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.UpdateButton.Location = new System.Drawing.Point(585, 354);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(231, 81);
            this.UpdateButton.TabIndex = 46;
            this.UpdateButton.Text = "アップデート";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // UpdateIsAllived
            // 
            this.UpdateIsAllived.AutoSize = true;
            this.UpdateIsAllived.Enabled = false;
            this.UpdateIsAllived.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.UpdateIsAllived.Location = new System.Drawing.Point(582, 321);
            this.UpdateIsAllived.Name = "UpdateIsAllived";
            this.UpdateIsAllived.Size = new System.Drawing.Size(234, 24);
            this.UpdateIsAllived.TabIndex = 47;
            this.UpdateIsAllived.Text = "アップデートがあります！";
            // 
            // AmongUsModChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 642);
            this.Controls.Add(this.UpdateIsAllived);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DiscordServerLink);
            this.Controls.Add(this.HowToUse);
            this.Controls.Add(this.Chuui);
            this.Controls.Add(this.OpenGameDirectory);
            this.Controls.Add(this.OpenModFiles);
            this.Controls.Add(this.StartOption);
            this.Controls.Add(this.Epic);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PresetNameApply);
            this.Controls.Add(this.Num10);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.SetPresetText);
            this.Controls.Add(this.Preset10TextBox);
            this.Controls.Add(this.Preset9TextBox);
            this.Controls.Add(this.Preset8TextBox);
            this.Controls.Add(this.Preset7TextBox);
            this.Controls.Add(this.Preset6TextBox);
            this.Controls.Add(this.Preset5TextBox);
            this.Controls.Add(this.Preset4TextBox);
            this.Controls.Add(this.Preset3TextBox);
            this.Controls.Add(this.Preset2TextBox);
            this.Controls.Add(this.Preset1TextBox);
            this.Controls.Add(this.Preset10Button);
            this.Controls.Add(this.Preset9Button);
            this.Controls.Add(this.Preset8Button);
            this.Controls.Add(this.Preset7Button);
            this.Controls.Add(this.Preset6Button);
            this.Controls.Add(this.Preset5Button);
            this.Controls.Add(this.Preset4Button);
            this.Controls.Add(this.Preset3Button);
            this.Controls.Add(this.Preset2Button);
            this.Controls.Add(this.Preset1Button);
            this.Controls.Add(this.SelectModText);
            this.Controls.Add(this.ChooseAmongUsDirectory);
            this.Controls.Add(this.AmongUsDirectory);
            this.Controls.Add(this.DirectoryBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AmongUsModChanger";
            this.RightToLeftLayout = true;
            this.Text = "AmongUsModChanger";
            this.Load += new System.EventHandler(this.AmongUsModChanger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog SelectDirectory;
        private System.Windows.Forms.Button DirectoryBtn;
        private System.Windows.Forms.TextBox AmongUsDirectory;
        private System.Windows.Forms.Label ChooseAmongUsDirectory;
        private System.Windows.Forms.Label SelectModText;
        private System.Windows.Forms.Button Preset1Button;
        private System.Windows.Forms.Button Preset2Button;
        private System.Windows.Forms.Button Preset3Button;
        private System.Windows.Forms.Button Preset4Button;
        private System.Windows.Forms.Button Preset5Button;
        private System.Windows.Forms.Button Preset6Button;
        private System.Windows.Forms.Button Preset7Button;
        private System.Windows.Forms.Button Preset8Button;
        private System.Windows.Forms.Button Preset9Button;
        private System.Windows.Forms.Button Preset10Button;
        private System.Windows.Forms.TextBox Preset1TextBox;
        private System.Windows.Forms.TextBox Preset2TextBox;
        private System.Windows.Forms.TextBox Preset3TextBox;
        private System.Windows.Forms.TextBox Preset4TextBox;
        private System.Windows.Forms.TextBox Preset5TextBox;
        private System.Windows.Forms.TextBox Preset6TextBox;
        private System.Windows.Forms.TextBox Preset7TextBox;
        private System.Windows.Forms.TextBox Preset8TextBox;
        private System.Windows.Forms.TextBox Preset9TextBox;
        private System.Windows.Forms.TextBox Preset10TextBox;
        private System.Windows.Forms.Label SetPresetText;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Num3;
        private System.Windows.Forms.Label Num4;
        private System.Windows.Forms.Label Num5;
        private System.Windows.Forms.Label Num6;
        private System.Windows.Forms.Label Num7;
        private System.Windows.Forms.Label Num8;
        private System.Windows.Forms.Label Num9;
        private System.Windows.Forms.Label Num10;
        private System.Windows.Forms.Button PresetNameApply;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button Steam;
        private System.Windows.Forms.Button Epic;
        private System.Windows.Forms.Label StartOption;
        private System.Windows.Forms.Button OpenModFiles;
        private System.Windows.Forms.Button OpenGameDirectory;
        private System.Windows.Forms.Label Chuui;
        private System.Windows.Forms.Label HowToUse;
        private System.Windows.Forms.LinkLabel DiscordServerLink;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label UpdateIsAllived;
    }
}