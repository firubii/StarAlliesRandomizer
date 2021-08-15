using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;
using StarAlliesRandomizer.Types;
using StarAlliesRandomizer.Util;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace StarAlliesRandomizer
{
    public partial class MainForm : Form
    {
        public static string ExeDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        static int[] CopyAbilities = new int[]
        {
            0,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,31
        };
        static int[] DreamFriends = new int[]
        {
            56,57,58,59,60,61,62,63,64,65,66,67,68
        };
        static int[] AbilityElements = new int[]
        {
            0x0, 0x4, 0x8, 0x20, 0x100, 0x10000
        };

        static string[] BasicEnemies = new string[]
        {
            "Bouncy",
            "Brontoburt",
            "Cappy",
            "Brontoburt",
            "Chip",
            "Coner",
            "Dekabu",
            "Dekabu.Kokabu",
            "Gabon",
            "Glunk",
            "Gordo",
            "Grizzo",
            "Jaharbeliever",
            "Kabu",
            "Mamatee",
            "MaskEnemy",
            "Nruff",
            "Propeller",
            "Scarfy",
            "ShieldEnemy",
            "Shotzo",
            "Squishy",
            "TwoFace",
            "Waddledee",
            "Wonkey"
        };

        static string[] Enemies = new string[]
        {
            "Beetlie",
            "BioSpark",
            "Birdon",
            "Bladeknight",
            "Bomber",
            "Broomhatter",
            "Burningleo",
            "Chilly",
            "Chip",
            "Como",
            "Conce",
            "Coner",
            "EnemyCommon.Parasol",
            "FestivalEnemy",
            "FloatSlime",
            "Gim",
            "Knucklejoe",
            "Nesp",
            "Noddy",
            "Poppybrosjr",
            "Rocky",
            "Sirkibble",
            "StickEnemy",
            "Waddledoo",
            "Walky",
            "WaterEnemy",
            "Wester"
        };

        static string[] MidBosses = new string[]
        {
            "BigBouncy",
            "Bonkers",
            "Bugzzy",
            "ChefKawasaki",
            "Misterfrosty",
            "Vivitia",
        };

        static string[] Bosses = new string[]
        {
            "Kingdedede.DeadBody",
            "MetaKnight.DeadBody",
        };

        static string[] EnemyObjects = new string[]
        {
            "Cappy.Hat",
            "Gabon.Skull",
            "Marx.Cutter",
            "Marx.IceBall",
            "Whispywoods.Apple",
        };

        static string[] DropStars = new string[]
        {
            "EnemyCommon.DropStar"
        };

        public MainForm()
        {
            InitializeComponent();
            if (File.Exists(ExeDir + "\\Config.xml"))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(ExeDir + "\\Config.xml");
                romfsPath.Text = xml["Config"]["RomFS"].InnerText;
            }
            else
            {
                XmlDocument xml = new XmlDocument();
                xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", ""));

                XmlElement root = xml.CreateElement("Config");
                XmlElement romfs = xml.CreateElement("RomFS");
                romfs.InnerText = romfsPath.Text;
                root.AppendChild(romfs);

                xml.AppendChild(root);

                xml.Save(ExeDir + "\\Config.xml");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", ""));

            XmlElement root = xml.CreateElement("Config");
            XmlElement romfs = xml.CreateElement("RomFS");
            romfs.InnerText = romfsPath.Text;
            root.AppendChild(romfs);

            xml.AppendChild(root);

            xml.Save(ExeDir + "\\Config.xml");
        }

        private void openRomfs_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog open = new CommonOpenFileDialog();
            open.IsFolderPicker = true;
            if (open.ShowDialog() == CommonFileDialogResult.Ok)
            {
                romfsPath.Text = open.FileName;
            }
        }

        private void romfsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                  "This program requires Kirby Star Allies's 4.0.0 RomFS to work properly." +
                "\nClick the elipses (...) button and select the directory containing the game's RomFS, or enter it yourself in the box." +
                "\nThe RomFS path provided will be saved in Config.xml when the program is closed and autofilled in when the program opens." +
                "\n" +
                "\nNote that not all 3.77GB files in the RomFS are needed to randomize the game. The necessary files are:" +
                "\n   - gfx/Common/Hero/Kirby/Base.bfres.cmp (Unimplemented currently)" +
                "\n   - mint/Step.bin" +
                "\n   - The entire \"map\" directory (Unimplemented currently)" +
                "\nThis totals to only 167.84MB" +
                "\n" +
                "\nHover over anything in the program for more information about the option.",
                this.Text,
                MessageBoxButtons.OK);
        }

        private void randCopyAbilities_CheckedChanged(object sender, EventArgs e)
        {
            randAbilityPanel.Visible = randCopyAbilities.Checked;
        }

        private void copyRandByEnemy_CheckedChanged(object sender, EventArgs e)
        {
            inclBasicEnemy.Enabled = copyRandByEnemy.Checked;
            inclMidBoss.Enabled = copyRandByEnemy.Checked;
            inclBoss.Enabled = copyRandByEnemy.Checked;
            inclEnemyObj.Enabled = copyRandByEnemy.Checked;
            inclDropStars.Enabled = copyRandByEnemy.Checked;
        }

        private void copyRandMix_CheckedChanged(object sender, EventArgs e)
        {
            allowDreamFriend.Enabled = !copyRandMix.Checked;
            allowElement.Enabled = !copyRandMix.Checked;
        }

        private void randHelpers_CheckedChanged(object sender, EventArgs e)
        {
            randHelperPanel.Visible = randHelpers.Checked;
        }

        private void randAttacks_CheckedChanged(object sender, EventArgs e)
        {
            randAttackPanel.Visible = randAttacks.Checked;
        }

        private void atkRandDamage_CheckedChanged(object sender, EventArgs e)
        {
            doLimitDmg.Enabled = atkRandDamage.Checked;
            limitDmg.Enabled = atkRandDamage.Checked;
        }

        private void atkRandAngle_CheckedChanged(object sender, EventArgs e)
        {
            doLimitAngle.Enabled = atkRandAngle.Checked;
            limitAngle.Enabled = atkRandAngle.Checked;
        }

        private void atkRandKb_CheckedChanged(object sender, EventArgs e)
        {
            doLimitKb.Enabled = atkRandKb.Checked;
            limitKb.Enabled = atkRandKb.Checked;
        }

        private void randomize_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            Console.WriteLine("Creating seed...");
            int rngSeed;
            if (seed.Text != "")
            {
                if (int.TryParse(seed.Text, out int parsedSeed))
                    rngSeed = parsedSeed;
                else
                    rngSeed = BitConverter.ToInt32(HashCalculator.Calculate(seed.Text), 0);
            }
            else
                rngSeed = rng.Next(int.MinValue, int.MaxValue);

            Console.WriteLine("Seed: " + rngSeed);

            string outDir = ExeDir + $"\\OutFiles\\seed_{rngSeed}";

            if (!File.Exists(romfsPath.Text + "\\mint\\Step.bin"))
            {
                MessageBox.Show($"Error: Could not find the path \"{romfsPath.Text}\\mint\\Step.bin\".", this.Text, MessageBoxButtons.OK);
                return;
            }

            Console.WriteLine("Loading Step.bin Mint binary...");
            Archive mintStep;
            using (EndianBinaryReader reader = new EndianBinaryReader(new FileStream(romfsPath.Text + "\\mint\\Step.bin", FileMode.Open, FileAccess.Read)))
            {
                mintStep = new Archive(reader);
            }

            rng = new Random(rngSeed);
            if (randCopyAbilities.Checked)
            {
                List<int> abilities = CopyAbilities.ToList();
                if (allowDreamFriend.Checked)
                    abilities.AddRange(DreamFriends);

                if (copyRandByEnemy.Checked)
                {
                    List<string> randTargets = Enemies.ToList();
                    if (inclBasicEnemy.Checked)
                        randTargets.AddRange(BasicEnemies);
                    if (inclMidBoss.Checked)
                        randTargets.AddRange(MidBosses);
                    if (inclBoss.Checked)
                        randTargets.AddRange(Bosses);
                    if (inclEnemyObj.Checked)
                        randTargets.AddRange(EnemyObjects);
                    if (inclDropStars.Checked)
                        randTargets.AddRange(DropStars);

                    Console.WriteLine("Randomizing Enemy Copy Abilities...");
                    for (int i = 0; i < randTargets.Count; i++)
                    {
                        string script;
                        if (randTargets[i].Contains('.'))
                            script = "Scn.Step.Chara." + randTargets[i] + ".Setting";
                        else
                            script = "Scn.Step.Chara." + randTargets[i] + "." + randTargets[i] + ".Setting";

                        Console.WriteLine("Processing " + script + "...");

                        string[] newScript = File.ReadAllLines(ExeDir + "\\MintScripts\\CopyAbilities\\Enemies\\" + script + ".mints");
                        for (int l = 0; l < newScript.Length; l++)
                        {
                            if (newScript[l].Contains("%ABILITY_ID%"))
                            {
                                int newAbility = abilities[rng.Next(0, abilities.Count)];
                                newScript[l] = newScript[l].Replace("%ABILITY_ID%", newAbility.ToString());
                                Console.WriteLine($"Given Ability {newAbility}");
                            }
                            else if (newScript[l].Contains("%ELEMENT_ID%"))
                            {
                                if (allowElement.Checked)
                                {
                                    int newElement = AbilityElements[rng.Next(0, AbilityElements.Length)];
                                    newScript[l] = newScript[l].Replace("%ELEMENT_ID%", newElement.ToString());
                                    Console.WriteLine($"Given Element {newElement}");
                                }
                                else
                                    newScript[l] = newScript[l].Replace("%ELEMENT_ID%", "0");
                            }
                        }

                        mintStep.Scripts[script] = new MintScript(newScript, new byte[] { 2, 1, 5, 1 });
                    }

                    if (inclDropStars.Checked)
                    {
                        Console.WriteLine("Assembling custom script Scn.Step.Chara.WeaponUtil...");
                        string[] newScript = File.ReadAllLines(ExeDir + "\\MintScripts\\CopyAbilities\\Enemies\\Scn.Step.Chara.WeaponUtil.mints");
                        for (int l = 0; l < newScript.Length; l++)
                        {
                            if (newScript[l].Contains("%ALLOW_DREAM_FRIENDS%"))
                                newScript[l] = newScript[l].Replace("%ALLOW_DREAM_FRIENDS%", Convert.ToInt32(allowDreamFriend.Checked).ToString());
                            else if (newScript[l].Contains("%RANDOM_ELEMENTS%"))
                                newScript[l] = newScript[l].Replace("%RANDOM_ELEMENTS%", Convert.ToInt32(allowElement.Checked).ToString());
                        }

                        mintStep.Scripts["Scn.Step.Chara.WeaponUtil"] = new MintScript(newScript, new byte[] { 2, 1, 5, 1 });
                    }
                }
                else if (copyRandEat.Checked)
                {
                    Console.WriteLine("Assembling custom script Scn.Step.Hero.Common.StateDrink...");
                    string[] newScript = File.ReadAllLines(ExeDir + "\\MintScripts\\CopyAbilities\\FullRandom\\Scn.Step.Hero.Common.StateDrink.mints");
                    for (int l = 0; l < newScript.Length; l++)
                    {
                        if (newScript[l].Contains("%ALLOW_DREAM_FRIENDS%"))
                            newScript[l] = newScript[l].Replace("%ALLOW_DREAM_FRIENDS%", Convert.ToInt32(allowDreamFriend.Checked).ToString());
                        else if (newScript[l].Contains("%RANDOM_ELEMENTS%"))
                            newScript[l] = newScript[l].Replace("%RANDOM_ELEMENTS%", Convert.ToInt32(allowElement.Checked).ToString());
                    }

                    mintStep.Scripts["Scn.Step.Hero.Common.StateDrink"] = new MintScript(newScript, new byte[] { 2, 1, 5, 1 });
                }
                else if (copyRandMix.Checked)
                {
                    Console.WriteLine("Assembling custom script Scn.Step.Hero.Common.StateDrink...");

                    mintStep.Scripts["Scn.Step.Hero.Common.StateDrink"] = new MintScript(File.ReadAllLines(ExeDir + "\\MintScripts\\CopyAbilities\\Mix\\Scn.Step.Hero.Common.StateDrink.mints"), new byte[] { 2, 1, 5, 1 });
                }
            }

            if (randHelpers.Checked)
            {
                Console.WriteLine("Assembling custom script Scn.Step.Chara.KibidangoReact...");
                string[] newScript = File.ReadAllLines(ExeDir + "\\MintScripts\\Helpers\\Scn.Step.Chara.KibidangoReact.mints");
                for (int l = 0; l < newScript.Length; l++)
                {
                    if (newScript[l].Contains("%ALLOW_DREAM_FRIENDS%"))
                        newScript[l] = newScript[l].Replace("%ALLOW_DREAM_FRIENDS%", Convert.ToInt32(helperAllowDreamFriend.Checked).ToString());
                    else if (newScript[l].Contains("%RANDOM_ELEMENTS%"))
                        newScript[l] = newScript[l].Replace("%RANDOM_ELEMENTS%", Convert.ToInt32(helperAllowElement.Checked).ToString());
                }

                mintStep.Scripts["Scn.Step.Chara.KibidangoReact"] = new MintScript(newScript, new byte[] { 2, 1, 5, 1 });
            }

            rng = new Random(rngSeed);
            if (randAttacks.Checked)
            {
                if (atkRandDamage.Checked)
                {
                    int limitDamage = int.MaxValue;
                    if (doLimitDmg.Checked)
                        limitDamage = (int)limitDmg.Value;

                    var attackPowerScripts = mintStep.Scripts.Where(x => ((x.Key.StartsWith("Scn.Step.Hero.") && x.Key.EndsWith(".AttackPower")) || (atkRandEnemy.Checked && x.Key.EndsWith(".AttackPower"))) );
                    Dictionary<byte[], string> blankHashes = new Dictionary<byte[], string>();
                    Dictionary<string, string[]> newScripts = new Dictionary<string, string[]>();
                    foreach (KeyValuePair<string, MintScript> pair in attackPowerScripts)
                    {
                        string[] script = pair.Value.WriteText(ref blankHashes);
                        for (int i = 0; i < script.Length; i++)
                        {
                            if (script[i].StartsWith("\t\t\tldsrc4 r0, "))
                            {
                                script[i] = "\t\t\tldsrc4 r0, " + rng.Next(1, limitDamage);
                            }
                        }
                        newScripts.Add(pair.Key, script);
                    }
                    foreach (KeyValuePair<string, string[]> pair in newScripts)
                    {
                        Console.WriteLine($"Processing {pair.Key}...");
                        mintStep.Scripts[pair.Key] = new MintScript(pair.Value, new byte[] { 2, 1, 5, 1 });
                    }
                }
            }

            if (!Directory.Exists(outDir + "\\mint"))
                Directory.CreateDirectory(outDir + "\\mint");

            Console.WriteLine("Saving Step Mint binary...");
            mintStep.Write(outDir + "\\mint\\Step.bin");

            MessageBox.Show($"Successfully randomized!\nMod-ready files saved to \"{outDir}\"");
        }


        //-- Yaml tests --

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Binary files|*.bin";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Yaml yaml = new Yaml(open.FileName);

                for (int i = 0; i < yaml.Root.Length; i++)
                {
                    if (yaml.Root.Type == Yaml.Type.Hash)
                        PrintYaml(yaml.Root[yaml.Root.Key(i)], yaml.Root.Key(i), 0);
                    else if (yaml.Root.Type == Yaml.Type.Array)
                        PrintYaml(yaml.Root[i], i.ToString(), 0);
                }
            }
        }

        void PrintYaml(Yaml.Data data, string name, int tabIndex)
        {
            string text = "";
            for (int i = 0; i < tabIndex; i++)
                text += "\t";
            text += $"- [{data.Type}] {name}";
            switch (data.Type)
            {
                case Yaml.Type.Int:
                    text += ": " + data.ToInt();
                    break;
                case Yaml.Type.Float:
                    text += ": " + data.ToFloat();
                    break;
                case Yaml.Type.Bool:
                    text += ": " + data.ToBool();
                    break;
                case Yaml.Type.String:
                    text += ": \"" + data.ToString() + "\"";
                    break;
                case Yaml.Type.Array:
                case Yaml.Type.Hash:
                    text += ": " + data.Length + " children";
                    break;
            }

            Console.WriteLine(text);
            for (int i = 0; i < data.Length; i++)
            {
                if (data.Type == Yaml.Type.Hash)
                    PrintYaml(data[data.Key(i)], data.Key(i), tabIndex + 1);
                else if (data.Type == Yaml.Type.Array)
                    PrintYaml(data[i], i.ToString(), tabIndex + 1);
            }
        }
    }
}
