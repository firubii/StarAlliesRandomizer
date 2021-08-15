
namespace StarAlliesRandomizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.romfsPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openRomfs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.randCopyAbilities = new System.Windows.Forms.CheckBox();
            this.randAbilityPanel = new System.Windows.Forms.Panel();
            this.inclDropStars = new System.Windows.Forms.CheckBox();
            this.inclEnemyObj = new System.Windows.Forms.CheckBox();
            this.inclBoss = new System.Windows.Forms.CheckBox();
            this.inclMidBoss = new System.Windows.Forms.CheckBox();
            this.inclBasicEnemy = new System.Windows.Forms.CheckBox();
            this.copyRandMix = new System.Windows.Forms.RadioButton();
            this.copyRandEat = new System.Windows.Forms.RadioButton();
            this.copyRandByEnemy = new System.Windows.Forms.RadioButton();
            this.allowElement = new System.Windows.Forms.CheckBox();
            this.allowDreamFriend = new System.Windows.Forms.CheckBox();
            this.randHelpers = new System.Windows.Forms.CheckBox();
            this.randHelperPanel = new System.Windows.Forms.Panel();
            this.helperAllowDreamFriend = new System.Windows.Forms.CheckBox();
            this.randAttacks = new System.Windows.Forms.CheckBox();
            this.randAttackPanel = new System.Windows.Forms.Panel();
            this.atkRandColl = new System.Windows.Forms.CheckBox();
            this.atkRandBoss = new System.Windows.Forms.CheckBox();
            this.atkRandMBoss = new System.Windows.Forms.CheckBox();
            this.atkRandEnemy = new System.Windows.Forms.CheckBox();
            this.atkRandSerial = new System.Windows.Forms.CheckBox();
            this.atkRandKb = new System.Windows.Forms.CheckBox();
            this.atkRandAngle = new System.Windows.Forms.CheckBox();
            this.atkRandElement = new System.Windows.Forms.CheckBox();
            this.atkRandDamage = new System.Windows.Forms.CheckBox();
            this.randomize = new System.Windows.Forms.Button();
            this.romfsHelp = new System.Windows.Forms.Button();
            this.seed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.limitDmg = new System.Windows.Forms.NumericUpDown();
            this.doLimitDmg = new System.Windows.Forms.CheckBox();
            this.doLimitAngle = new System.Windows.Forms.CheckBox();
            this.limitAngle = new System.Windows.Forms.NumericUpDown();
            this.doLimitKb = new System.Windows.Forms.CheckBox();
            this.limitKb = new System.Windows.Forms.NumericUpDown();
            this.helperAllowElement = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.randAbilityPanel.SuspendLayout();
            this.randHelperPanel.SuspendLayout();
            this.randAttackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitDmg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitKb)).BeginInit();
            this.SuspendLayout();
            // 
            // romfsPath
            // 
            this.romfsPath.Location = new System.Drawing.Point(116, 6);
            this.romfsPath.Name = "romfsPath";
            this.romfsPath.Size = new System.Drawing.Size(313, 20);
            this.romfsPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game RomFS Path";
            // 
            // openRomfs
            // 
            this.openRomfs.Location = new System.Drawing.Point(435, 5);
            this.openRomfs.Name = "openRomfs";
            this.openRomfs.Size = new System.Drawing.Size(29, 22);
            this.openRomfs.TabIndex = 2;
            this.openRomfs.Text = "...";
            this.openRomfs.UseVisualStyleBackColor = true;
            this.openRomfs.Click += new System.EventHandler(this.openRomfs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 423);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randomizer Settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.randCopyAbilities);
            this.flowLayoutPanel1.Controls.Add(this.randAbilityPanel);
            this.flowLayoutPanel1.Controls.Add(this.randHelpers);
            this.flowLayoutPanel1.Controls.Add(this.randHelperPanel);
            this.flowLayoutPanel1.Controls.Add(this.randAttacks);
            this.flowLayoutPanel1.Controls.Add(this.randAttackPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(481, 404);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // randCopyAbilities
            // 
            this.randCopyAbilities.AutoSize = true;
            this.randCopyAbilities.Location = new System.Drawing.Point(3, 3);
            this.randCopyAbilities.Name = "randCopyAbilities";
            this.randCopyAbilities.Size = new System.Drawing.Size(144, 17);
            this.randCopyAbilities.TabIndex = 0;
            this.randCopyAbilities.Text = "Randomize Copy Abilities";
            this.toolTip.SetToolTip(this.randCopyAbilities, "Turn on to see additional options.");
            this.randCopyAbilities.UseVisualStyleBackColor = true;
            this.randCopyAbilities.CheckedChanged += new System.EventHandler(this.randCopyAbilities_CheckedChanged);
            // 
            // randAbilityPanel
            // 
            this.randAbilityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.randAbilityPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.randAbilityPanel.Controls.Add(this.inclDropStars);
            this.randAbilityPanel.Controls.Add(this.inclEnemyObj);
            this.randAbilityPanel.Controls.Add(this.inclBoss);
            this.randAbilityPanel.Controls.Add(this.inclMidBoss);
            this.randAbilityPanel.Controls.Add(this.inclBasicEnemy);
            this.randAbilityPanel.Controls.Add(this.copyRandMix);
            this.randAbilityPanel.Controls.Add(this.copyRandEat);
            this.randAbilityPanel.Controls.Add(this.copyRandByEnemy);
            this.randAbilityPanel.Controls.Add(this.allowElement);
            this.randAbilityPanel.Controls.Add(this.allowDreamFriend);
            this.randAbilityPanel.Location = new System.Drawing.Point(3, 26);
            this.randAbilityPanel.Name = "randAbilityPanel";
            this.randAbilityPanel.Size = new System.Drawing.Size(475, 102);
            this.randAbilityPanel.TabIndex = 1;
            this.randAbilityPanel.Visible = false;
            // 
            // inclDropStars
            // 
            this.inclDropStars.AutoSize = true;
            this.inclDropStars.Location = new System.Drawing.Point(251, 79);
            this.inclDropStars.Name = "inclDropStars";
            this.inclDropStars.Size = new System.Drawing.Size(114, 17);
            this.inclDropStars.TabIndex = 9;
            this.inclDropStars.Text = "Include Drop Stars";
            this.toolTip.SetToolTip(this.inclDropStars, "Also known as \"Recoil Stars\".\r\nAll stars dropped by enemies will have a random\r\nC" +
        "opy Ability and corresponding color.");
            this.inclDropStars.UseVisualStyleBackColor = true;
            // 
            // inclEnemyObj
            // 
            this.inclEnemyObj.AutoSize = true;
            this.inclEnemyObj.Location = new System.Drawing.Point(251, 60);
            this.inclEnemyObj.Name = "inclEnemyObj";
            this.inclEnemyObj.Size = new System.Drawing.Size(190, 17);
            this.inclEnemyObj.TabIndex = 8;
            this.inclEnemyObj.Text = "Include Inhale-able Enemy Objects";
            this.toolTip.SetToolTip(this.inclEnemyObj, "Examples:\r\nCappy\'s hat, Whispy Woods\'s apples");
            this.inclEnemyObj.UseVisualStyleBackColor = true;
            // 
            // inclBoss
            // 
            this.inclBoss.AutoSize = true;
            this.inclBoss.Location = new System.Drawing.Point(251, 41);
            this.inclBoss.Name = "inclBoss";
            this.inclBoss.Size = new System.Drawing.Size(207, 17);
            this.inclBoss.TabIndex = 7;
            this.inclBoss.Text = "Include King Dedede and Meta Knight";
            this.toolTip.SetToolTip(this.inclBoss, "Only works for throwing a Friend Heart after\r\nthey\'re defeated.");
            this.inclBoss.UseVisualStyleBackColor = true;
            // 
            // inclMidBoss
            // 
            this.inclMidBoss.AutoSize = true;
            this.inclMidBoss.Location = new System.Drawing.Point(251, 22);
            this.inclMidBoss.Name = "inclMidBoss";
            this.inclMidBoss.Size = new System.Drawing.Size(118, 17);
            this.inclMidBoss.TabIndex = 6;
            this.inclMidBoss.Text = "Include Mid-Bosses";
            this.inclMidBoss.UseVisualStyleBackColor = true;
            // 
            // inclBasicEnemy
            // 
            this.inclBasicEnemy.AutoSize = true;
            this.inclBasicEnemy.Location = new System.Drawing.Point(251, 3);
            this.inclBasicEnemy.Name = "inclBasicEnemy";
            this.inclBasicEnemy.Size = new System.Drawing.Size(206, 17);
            this.inclBasicEnemy.TabIndex = 5;
            this.inclBasicEnemy.Text = "Include Enemies without Copy Abilities";
            this.toolTip.SetToolTip(this.inclBasicEnemy, "Yes, this also affects Gordos and Shotzos.");
            this.inclBasicEnemy.UseVisualStyleBackColor = true;
            // 
            // copyRandMix
            // 
            this.copyRandMix.AutoSize = true;
            this.copyRandMix.Location = new System.Drawing.Point(18, 78);
            this.copyRandMix.Name = "copyRandMix";
            this.copyRandMix.Size = new System.Drawing.Size(142, 17);
            this.copyRandMix.TabIndex = 4;
            this.copyRandMix.Text = "Everything gives you Mix";
            this.toolTip.SetToolTip(this.copyRandMix, "When Kirby swallows anything, he gains Mix.");
            this.copyRandMix.UseVisualStyleBackColor = true;
            this.copyRandMix.CheckedChanged += new System.EventHandler(this.copyRandMix_CheckedChanged);
            // 
            // copyRandEat
            // 
            this.copyRandEat.AutoSize = true;
            this.copyRandEat.Location = new System.Drawing.Point(18, 59);
            this.copyRandEat.Name = "copyRandEat";
            this.copyRandEat.Size = new System.Drawing.Size(230, 17);
            this.copyRandEat.TabIndex = 3;
            this.copyRandEat.Text = "Eating anything gives a random Copy Ability";
            this.toolTip.SetToolTip(this.copyRandEat, "Every time Kirby swallows something, he gains a\r\nrandom Copy Ability. This includ" +
        "es inhaling food items.\r\nUses the game\'s random number generator.");
            this.copyRandEat.UseVisualStyleBackColor = true;
            // 
            // copyRandByEnemy
            // 
            this.copyRandByEnemy.AutoSize = true;
            this.copyRandByEnemy.Checked = true;
            this.copyRandByEnemy.Location = new System.Drawing.Point(18, 40);
            this.copyRandByEnemy.Name = "copyRandByEnemy";
            this.copyRandByEnemy.Size = new System.Drawing.Size(127, 17);
            this.copyRandByEnemy.TabIndex = 2;
            this.copyRandByEnemy.TabStop = true;
            this.copyRandByEnemy.Text = "Randomize by Enemy";
            this.toolTip.SetToolTip(this.copyRandByEnemy, "With nothing else selected, will only affect enemies\r\nthat already have Copy Abil" +
        "ities.");
            this.copyRandByEnemy.UseVisualStyleBackColor = true;
            this.copyRandByEnemy.CheckedChanged += new System.EventHandler(this.copyRandByEnemy_CheckedChanged);
            // 
            // allowElement
            // 
            this.allowElement.AutoSize = true;
            this.allowElement.Location = new System.Drawing.Point(18, 21);
            this.allowElement.Name = "allowElement";
            this.allowElement.Size = new System.Drawing.Size(97, 17);
            this.allowElement.TabIndex = 1;
            this.allowElement.Text = "Allow Elements";
            this.toolTip.SetToolTip(this.allowElement, "Copy Abilities that cannot normally gain elements\r\ncan have them using this, but " +
        "the majority of them\r\ndon\'t do anything.");
            this.allowElement.UseVisualStyleBackColor = true;
            // 
            // allowDreamFriend
            // 
            this.allowDreamFriend.AutoSize = true;
            this.allowDreamFriend.Location = new System.Drawing.Point(18, 2);
            this.allowDreamFriend.Name = "allowDreamFriend";
            this.allowDreamFriend.Size = new System.Drawing.Size(122, 17);
            this.allowDreamFriend.TabIndex = 0;
            this.allowDreamFriend.Text = "Allow Dream Friends";
            this.toolTip.SetToolTip(this.allowDreamFriend, "!!WARNING!!\r\nGetting Gooey or  Daroach through\r\ninhaling instantly crashes the ga" +
        "me.\r\nIt is impossible to get rid of a Dream Friend\r\nAbility without quitting out" +
        " to the mode select.");
            this.allowDreamFriend.UseVisualStyleBackColor = true;
            // 
            // randHelpers
            // 
            this.randHelpers.AutoSize = true;
            this.randHelpers.Location = new System.Drawing.Point(3, 134);
            this.randHelpers.Name = "randHelpers";
            this.randHelpers.Size = new System.Drawing.Size(118, 17);
            this.randHelpers.TabIndex = 2;
            this.randHelpers.Text = "Randomize Helpers";
            this.toolTip.SetToolTip(this.randHelpers, "Turn on to see additional options.\r\nCauses every Helper created through a Friend\r" +
        "\nHeart to be completely random.\r\nUses the game\'s random number generator.");
            this.randHelpers.UseVisualStyleBackColor = true;
            this.randHelpers.CheckedChanged += new System.EventHandler(this.randHelpers_CheckedChanged);
            // 
            // randHelperPanel
            // 
            this.randHelperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.randHelperPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.randHelperPanel.Controls.Add(this.helperAllowElement);
            this.randHelperPanel.Controls.Add(this.helperAllowDreamFriend);
            this.randHelperPanel.Location = new System.Drawing.Point(3, 157);
            this.randHelperPanel.Name = "randHelperPanel";
            this.randHelperPanel.Size = new System.Drawing.Size(475, 41);
            this.randHelperPanel.TabIndex = 3;
            this.randHelperPanel.Visible = false;
            // 
            // helperAllowDreamFriend
            // 
            this.helperAllowDreamFriend.AutoSize = true;
            this.helperAllowDreamFriend.Location = new System.Drawing.Point(18, 3);
            this.helperAllowDreamFriend.Name = "helperAllowDreamFriend";
            this.helperAllowDreamFriend.Size = new System.Drawing.Size(122, 17);
            this.helperAllowDreamFriend.TabIndex = 0;
            this.helperAllowDreamFriend.Text = "Allow Dream Friends";
            this.helperAllowDreamFriend.UseVisualStyleBackColor = true;
            // 
            // randAttacks
            // 
            this.randAttacks.AutoSize = true;
            this.randAttacks.Location = new System.Drawing.Point(3, 204);
            this.randAttacks.Name = "randAttacks";
            this.randAttacks.Size = new System.Drawing.Size(139, 17);
            this.randAttacks.TabIndex = 4;
            this.randAttacks.Text = "Randomize Attack Data";
            this.toolTip.SetToolTip(this.randAttacks, "Turn on to see additional options.\r\nThe options under here are unfinished due to\r" +
        "\nrequiring a lot more time to complete.");
            this.randAttacks.UseVisualStyleBackColor = true;
            this.randAttacks.CheckedChanged += new System.EventHandler(this.randAttacks_CheckedChanged);
            // 
            // randAttackPanel
            // 
            this.randAttackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.randAttackPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.randAttackPanel.Controls.Add(this.doLimitKb);
            this.randAttackPanel.Controls.Add(this.limitKb);
            this.randAttackPanel.Controls.Add(this.doLimitAngle);
            this.randAttackPanel.Controls.Add(this.limitAngle);
            this.randAttackPanel.Controls.Add(this.doLimitDmg);
            this.randAttackPanel.Controls.Add(this.limitDmg);
            this.randAttackPanel.Controls.Add(this.atkRandColl);
            this.randAttackPanel.Controls.Add(this.atkRandBoss);
            this.randAttackPanel.Controls.Add(this.atkRandMBoss);
            this.randAttackPanel.Controls.Add(this.atkRandEnemy);
            this.randAttackPanel.Controls.Add(this.atkRandSerial);
            this.randAttackPanel.Controls.Add(this.atkRandKb);
            this.randAttackPanel.Controls.Add(this.atkRandAngle);
            this.randAttackPanel.Controls.Add(this.atkRandElement);
            this.randAttackPanel.Controls.Add(this.atkRandDamage);
            this.randAttackPanel.Location = new System.Drawing.Point(3, 227);
            this.randAttackPanel.Name = "randAttackPanel";
            this.randAttackPanel.Size = new System.Drawing.Size(475, 127);
            this.randAttackPanel.TabIndex = 5;
            this.randAttackPanel.Visible = false;
            // 
            // atkRandColl
            // 
            this.atkRandColl.AutoSize = true;
            this.atkRandColl.Enabled = false;
            this.atkRandColl.Location = new System.Drawing.Point(251, 60);
            this.atkRandColl.Name = "atkRandColl";
            this.atkRandColl.Size = new System.Drawing.Size(144, 17);
            this.atkRandColl.TabIndex = 13;
            this.atkRandColl.Text = "Include Collision hitboxes";
            this.atkRandColl.UseVisualStyleBackColor = true;
            // 
            // atkRandBoss
            // 
            this.atkRandBoss.AutoSize = true;
            this.atkRandBoss.Enabled = false;
            this.atkRandBoss.Location = new System.Drawing.Point(251, 41);
            this.atkRandBoss.Name = "atkRandBoss";
            this.atkRandBoss.Size = new System.Drawing.Size(129, 17);
            this.atkRandBoss.TabIndex = 12;
            this.atkRandBoss.Text = "Include Boss hitboxes";
            this.atkRandBoss.UseVisualStyleBackColor = true;
            // 
            // atkRandMBoss
            // 
            this.atkRandMBoss.AutoSize = true;
            this.atkRandMBoss.Enabled = false;
            this.atkRandMBoss.Location = new System.Drawing.Point(251, 22);
            this.atkRandMBoss.Name = "atkRandMBoss";
            this.atkRandMBoss.Size = new System.Drawing.Size(149, 17);
            this.atkRandMBoss.TabIndex = 11;
            this.atkRandMBoss.Text = "Include Mid-Boss hitboxes";
            this.atkRandMBoss.UseVisualStyleBackColor = true;
            // 
            // atkRandEnemy
            // 
            this.atkRandEnemy.AutoSize = true;
            this.atkRandEnemy.Location = new System.Drawing.Point(251, 3);
            this.atkRandEnemy.Name = "atkRandEnemy";
            this.atkRandEnemy.Size = new System.Drawing.Size(138, 17);
            this.atkRandEnemy.TabIndex = 10;
            this.atkRandEnemy.Text = "Include Enemy hitboxes";
            this.atkRandEnemy.UseVisualStyleBackColor = true;
            // 
            // atkRandSerial
            // 
            this.atkRandSerial.AutoSize = true;
            this.atkRandSerial.Enabled = false;
            this.atkRandSerial.Location = new System.Drawing.Point(18, 79);
            this.atkRandSerial.Name = "atkRandSerial";
            this.atkRandSerial.Size = new System.Drawing.Size(155, 17);
            this.atkRandSerial.TabIndex = 4;
            this.atkRandSerial.Text = "Randomize Multi-hit Frames";
            this.atkRandSerial.UseVisualStyleBackColor = true;
            // 
            // atkRandKb
            // 
            this.atkRandKb.AutoSize = true;
            this.atkRandKb.Enabled = false;
            this.atkRandKb.Location = new System.Drawing.Point(18, 60);
            this.atkRandKb.Name = "atkRandKb";
            this.atkRandKb.Size = new System.Drawing.Size(152, 17);
            this.atkRandKb.TabIndex = 3;
            this.atkRandKb.Text = "Randomize Launch Speed";
            this.atkRandKb.UseVisualStyleBackColor = true;
            this.atkRandKb.CheckedChanged += new System.EventHandler(this.atkRandKb_CheckedChanged);
            // 
            // atkRandAngle
            // 
            this.atkRandAngle.AutoSize = true;
            this.atkRandAngle.Enabled = false;
            this.atkRandAngle.Location = new System.Drawing.Point(18, 41);
            this.atkRandAngle.Name = "atkRandAngle";
            this.atkRandAngle.Size = new System.Drawing.Size(153, 17);
            this.atkRandAngle.TabIndex = 2;
            this.atkRandAngle.Text = "Randomize Launch Angles";
            this.atkRandAngle.UseVisualStyleBackColor = true;
            this.atkRandAngle.CheckedChanged += new System.EventHandler(this.atkRandAngle_CheckedChanged);
            // 
            // atkRandElement
            // 
            this.atkRandElement.AutoSize = true;
            this.atkRandElement.Enabled = false;
            this.atkRandElement.Location = new System.Drawing.Point(18, 22);
            this.atkRandElement.Name = "atkRandElement";
            this.atkRandElement.Size = new System.Drawing.Size(125, 17);
            this.atkRandElement.TabIndex = 1;
            this.atkRandElement.Text = "Randomize Elements";
            this.atkRandElement.UseVisualStyleBackColor = true;
            // 
            // atkRandDamage
            // 
            this.atkRandDamage.AutoSize = true;
            this.atkRandDamage.Location = new System.Drawing.Point(18, 3);
            this.atkRandDamage.Name = "atkRandDamage";
            this.atkRandDamage.Size = new System.Drawing.Size(122, 17);
            this.atkRandDamage.TabIndex = 0;
            this.atkRandDamage.Text = "Randomize Damage";
            this.atkRandDamage.UseVisualStyleBackColor = true;
            this.atkRandDamage.CheckedChanged += new System.EventHandler(this.atkRandDamage_CheckedChanged);
            // 
            // randomize
            // 
            this.randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomize.Location = new System.Drawing.Point(12, 488);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(487, 23);
            this.randomize.TabIndex = 4;
            this.randomize.Text = "Randomize";
            this.randomize.UseVisualStyleBackColor = true;
            this.randomize.Click += new System.EventHandler(this.randomize_Click);
            // 
            // romfsHelp
            // 
            this.romfsHelp.Location = new System.Drawing.Point(470, 5);
            this.romfsHelp.Name = "romfsHelp";
            this.romfsHelp.Size = new System.Drawing.Size(29, 22);
            this.romfsHelp.TabIndex = 5;
            this.romfsHelp.Text = "?";
            this.romfsHelp.UseVisualStyleBackColor = true;
            this.romfsHelp.Click += new System.EventHandler(this.romfsHelp_Click);
            // 
            // seed
            // 
            this.seed.Location = new System.Drawing.Point(116, 33);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(383, 20);
            this.seed.TabIndex = 6;
            this.toolTip.SetToolTip(this.seed, "The seed supports both number and text seeds");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seed";
            // 
            // limitDmg
            // 
            this.limitDmg.Enabled = false;
            this.limitDmg.Location = new System.Drawing.Point(129, 97);
            this.limitDmg.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.limitDmg.Name = "limitDmg";
            this.limitDmg.Size = new System.Drawing.Size(77, 20);
            this.limitDmg.TabIndex = 14;
            this.limitDmg.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // doLimitDmg
            // 
            this.doLimitDmg.AutoSize = true;
            this.doLimitDmg.Checked = true;
            this.doLimitDmg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doLimitDmg.Enabled = false;
            this.doLimitDmg.Location = new System.Drawing.Point(18, 98);
            this.doLimitDmg.Name = "doLimitDmg";
            this.doLimitDmg.Size = new System.Drawing.Size(90, 17);
            this.doLimitDmg.TabIndex = 15;
            this.doLimitDmg.Text = "Limit Damage";
            this.toolTip.SetToolTip(this.doLimitDmg, "If left unchecked, damage can be all the way up to\r\nthe signed 32-bit integer lim" +
        "it (2,147,483,647)");
            this.doLimitDmg.UseVisualStyleBackColor = true;
            // 
            // doLimitAngle
            // 
            this.doLimitAngle.AutoSize = true;
            this.doLimitAngle.Enabled = false;
            this.doLimitAngle.Location = new System.Drawing.Point(251, 79);
            this.doLimitAngle.Name = "doLimitAngle";
            this.doLimitAngle.Size = new System.Drawing.Size(82, 17);
            this.doLimitAngle.TabIndex = 17;
            this.doLimitAngle.Text = "Limit Angles";
            this.doLimitAngle.UseVisualStyleBackColor = true;
            // 
            // limitAngle
            // 
            this.limitAngle.DecimalPlaces = 1;
            this.limitAngle.Enabled = false;
            this.limitAngle.Location = new System.Drawing.Point(362, 77);
            this.limitAngle.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.limitAngle.Name = "limitAngle";
            this.limitAngle.Size = new System.Drawing.Size(77, 20);
            this.limitAngle.TabIndex = 16;
            this.limitAngle.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // doLimitKb
            // 
            this.doLimitKb.AutoSize = true;
            this.doLimitKb.Checked = true;
            this.doLimitKb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doLimitKb.Enabled = false;
            this.doLimitKb.Location = new System.Drawing.Point(251, 98);
            this.doLimitKb.Name = "doLimitKb";
            this.doLimitKb.Size = new System.Drawing.Size(105, 17);
            this.doLimitKb.TabIndex = 19;
            this.doLimitKb.Text = "Limit Knockback";
            this.doLimitKb.UseVisualStyleBackColor = true;
            // 
            // limitKb
            // 
            this.limitKb.DecimalPlaces = 3;
            this.limitKb.Enabled = false;
            this.limitKb.Location = new System.Drawing.Point(362, 98);
            this.limitKb.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.limitKb.Name = "limitKb";
            this.limitKb.Size = new System.Drawing.Size(77, 20);
            this.limitKb.TabIndex = 18;
            this.limitKb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // helperAllowElement
            // 
            this.helperAllowElement.AutoSize = true;
            this.helperAllowElement.Location = new System.Drawing.Point(18, 20);
            this.helperAllowElement.Name = "helperAllowElement";
            this.helperAllowElement.Size = new System.Drawing.Size(97, 17);
            this.helperAllowElement.TabIndex = 1;
            this.helperAllowElement.Text = "Allow Elements";
            this.toolTip.SetToolTip(this.helperAllowElement, "Copy Abilities that cannot normally gain elements\r\ncan have them using this, but " +
        "the majority of them\r\ndon\'t do anything.");
            this.helperAllowElement.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.romfsHelp);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openRomfs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.romfsPath);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirby Star Allies Randomizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.randAbilityPanel.ResumeLayout(false);
            this.randAbilityPanel.PerformLayout();
            this.randHelperPanel.ResumeLayout(false);
            this.randHelperPanel.PerformLayout();
            this.randAttackPanel.ResumeLayout(false);
            this.randAttackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitDmg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitKb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox romfsPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openRomfs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox randCopyAbilities;
        private System.Windows.Forms.Panel randAbilityPanel;
        private System.Windows.Forms.CheckBox randHelpers;
        private System.Windows.Forms.CheckBox inclDropStars;
        private System.Windows.Forms.CheckBox inclEnemyObj;
        private System.Windows.Forms.CheckBox inclBoss;
        private System.Windows.Forms.CheckBox inclMidBoss;
        private System.Windows.Forms.CheckBox inclBasicEnemy;
        private System.Windows.Forms.RadioButton copyRandMix;
        private System.Windows.Forms.RadioButton copyRandEat;
        private System.Windows.Forms.RadioButton copyRandByEnemy;
        private System.Windows.Forms.CheckBox allowElement;
        private System.Windows.Forms.CheckBox allowDreamFriend;
        private System.Windows.Forms.Panel randHelperPanel;
        private System.Windows.Forms.CheckBox helperAllowDreamFriend;
        private System.Windows.Forms.CheckBox randAttacks;
        private System.Windows.Forms.Panel randAttackPanel;
        private System.Windows.Forms.CheckBox atkRandDamage;
        private System.Windows.Forms.CheckBox atkRandColl;
        private System.Windows.Forms.CheckBox atkRandBoss;
        private System.Windows.Forms.CheckBox atkRandMBoss;
        private System.Windows.Forms.CheckBox atkRandEnemy;
        private System.Windows.Forms.CheckBox atkRandSerial;
        private System.Windows.Forms.CheckBox atkRandKb;
        private System.Windows.Forms.CheckBox atkRandAngle;
        private System.Windows.Forms.CheckBox atkRandElement;
        private System.Windows.Forms.Button romfsHelp;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox doLimitKb;
        private System.Windows.Forms.NumericUpDown limitKb;
        private System.Windows.Forms.CheckBox doLimitAngle;
        private System.Windows.Forms.NumericUpDown limitAngle;
        private System.Windows.Forms.CheckBox doLimitDmg;
        private System.Windows.Forms.NumericUpDown limitDmg;
        private System.Windows.Forms.CheckBox helperAllowElement;
    }
}

