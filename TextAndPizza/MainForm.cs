using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAndPizza.Properties;
using System.IO;
namespace TextAndPizza
{
    public partial class MainForm : Form
    {

        String name = "Text & Pizza";
        String vno = "0.5";
        List<String> ChatLog;
        int ChatLogNum;
        Boolean goNorth = false;
        Boolean goSouth = false;
        Boolean goEast = false;
        Boolean goWest = false;
        Boolean gameStarted = false;
        World GameWorld;
        MainForm mainForm;
        public String worldPath;
        

        public MainForm()
        {
            mainForm = this;
            InitializeComponent();
            this.AcceptButton = null;
            this.ActiveControl = InputBox;
            PrintMessage("Welcome to " + name + " v" + vno + Environment.NewLine + "Type 'help' for help." + Environment.NewLine + "You can also type 'load' to load a world from a file.");
            ChatLog = new List<String>();
            ChatLogNum = ChatLog.Count();
            // Initalize the world
            GameWorld = new World();
            //PrintMessage(RoomString(GameWorld.CurrentRoom))
            //Create the appdata folder.
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var TAP = Path.Combine(appdata, @"\TextAndPizza");
            Directory.CreateDirectory(TAP);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void CreateFolder(String Fname)
        {
            var TAP = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"\TextAndPizza");
            Directory.CreateDirectory(Path.Combine(TAP, @"\" + Fname));
        }

        public void EnterRoom(Room r)
        {
            if (r != null)
            {
                PrintMessage(RoomString(r));
                GameWorld.CurrentRoom = r;
            }
            else
            {
                PrintMessage("There is nothing there!");
            }
            goNorth = false;
            goSouth = false;
            goEast = false;
            goWest = false;
            List<Item> ToRemove = new List<Item>();
            if (GameWorld.CurrentRoom.getItems() != null)
            {
                foreach (Item itm in GameWorld.Inventory)
                {
                    foreach (Item rmitm in GameWorld.CurrentRoom.getItems())
                    {
                        if (itm == rmitm)
                        {
                            ToRemove.Add(rmitm);
                        }
                    }
                }
                foreach (Item itm in ToRemove)
                {
                    GameWorld.CurrentRoom.getItems().Remove(itm);
                }
            }
        }

        private void DialogueBox_TextChanged(object sender, EventArgs e)
        {
            DialogueBox.SelectionStart = DialogueBox.Text.Length;
            DialogueBox.ScrollToCaret();
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InputButton_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                ChatLogNum--;
                if (ChatLogNum <= 0)
                {
                    ChatLogNum = 0;
                }
                InputBox.Text = ChatLog[ChatLogNum];
            }
            else if (e.KeyCode == Keys.Down)
            {
                ChatLogNum++;
                if (ChatLogNum > ChatLog.Count())
                {
                    ChatLogNum = ChatLog.Count;
                }
                if (ChatLogNum == ChatLog.Count)
                {
                    InputBox.Text = "";
                }
                else
                {
                    InputBox.Text = ChatLog[ChatLogNum];
                } 
            }
        }

        public void AngleCorrections()
        {
            if (GameWorld.Direction == 5)
            {
                GameWorld.Direction = 1;
            }
            if (GameWorld.Direction == 4)
            {
                GameWorld.Direction = 0;
            }
            if (GameWorld.Direction < 0)
            {
                GameWorld.Direction = GameWorld.Direction * -1;
            }
        }

        public void AndCommand(String s)
        {
            String[] cmd = Regex.Split(s, " and ");
            foreach (String str in cmd)
            {
                RunCommand(str);
            }
        }

        public void RunCommand(String s)
        {
            ChatLog.Add(s);
            if (gameStarted)
            {
                if (GameWorld.Player.isDead())
                {
                    s = "quit";
                }
                s = s.ToLower();
                if (s.Replace(" ", "") == "")
                {
                    //Do nothing
                }
                else if (s.Contains("and"))
                {
                    AndCommand(s);
                }
                else if (s == "balance" || s == "purse")
                {
                    PrintMessage(GameWorld.Balance + " Gold");
                }
                else if (s.Contains("go "))
                {
                    if (!isBlocked())
                    {
                        Image img = CompassBox.Image;
                        int CorrectMove = 0;
                        if (s.Contains(" ahead") || s.Contains(" forward"))
                        {
                            AngleCorrections();
                            CorrectMove++;
                        }
                        else if (s.Contains(" right"))
                        {
                            GameWorld.Direction = GameWorld.Direction + 1;
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            AngleCorrections();
                            CorrectMove++;
                        }
                        else if (s.Contains(" left"))
                        {
                            GameWorld.Direction = GameWorld.Direction - 1;
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            AngleCorrections();
                            CorrectMove++;
                        }
                        else if (s.Contains(" back") || s.Contains(" backwards"))
                        {
                            GameWorld.Direction = GameWorld.Direction + 2;
                            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            AngleCorrections();
                            CorrectMove++;
                        }
                        CompassBox.Image = img;
                        if (CorrectMove != 0)
                        {
                            if (GameWorld.Direction == 0)
                            {
                                goNorth = true;
                                MapRooms();
                            }
                            if (GameWorld.Direction == 1)
                            {
                                goEast = true;
                                MapRooms();
                            }
                            if (GameWorld.Direction == 2)
                            {
                                goSouth = true;
                                MapRooms();
                            }
                            if (GameWorld.Direction == 3)
                            {
                                goWest = true;
                                MapRooms();
                            }
                        }
                        else
                        {
                            PrintMessage("That direction does not exist");
                        }
                    }
                    else
                    {
                        PrintMessage("You can't leave this room until all of the monsters are gone!");
                    }
                }
                else if (s == "quit")
                {
                    DialogResult Save = MessageBox.Show("Would you like to save your game?", "Shutting Down", MessageBoxButtons.YesNoCancel);
                    if (Save == DialogResult.Yes)
                    {
                        GameWorld.Save(worldPath);
                        Application.Exit();
                    }
                    else if (Save == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if (Save == DialogResult.Cancel)
                    {
                        //
                    }
                }
                else if (s.Contains("look at"))
                {
                    s = s.Replace(" the", "");
                    s = s.Replace("look at", "lookat");
                    String[] words = s.Split(' ');
                    if (words.Length > 1)
                    {
                        for (int i = 2; i < words.Length; i++)
                        {
                            words[1] = words[1] + " " + words[i];
                        }
                        int Counter = 0;
                        if (GameWorld.CurrentRoom.getItems() != null)
                        {
                            List<Item> Items = GameWorld.CurrentRoom.getItems();
                            foreach (Item itm in Items)
                            {
                                if (words[1] == itm.getName().ToLower())
                                {
                                    PrintMessage(itm.getDescription());
                                    Counter++;
                                }
                            }
                        }
                        if (GameWorld.CurrentRoom.getEntities() != null)
                        {
                            List<Entity> Entities = GameWorld.CurrentRoom.getEntities();
                            foreach (Entity en in Entities)
                            {
                                if (words[1] == en.getName().ToLower())
                                {
                                    PrintMessage(en.getDescription());
                                    Counter++;
                                }
                            }
                        }
                        if (Counter == 0)
                        {
                            PrintMessage("What you are looking for does not exist!");
                        }
                    }
                }
                else if (s.Contains("get ") || s.Contains("pick up "))
                {
                    if (GameWorld.CurrentRoom.getItems() != null)
                    {
                        s = s.Replace(" the", "");
                        s = s.Replace("pick up", "pickup");
                        String[] words = s.Split(' ');
                        if (words.Length > 1)
                        {
                            for (int i = 2; i < words.Length; i++)
                            {
                                words[1] = words[1] + " " + words[i];
                            }
                            List<Item> Items = GameWorld.CurrentRoom.getItems();
                            List<Item> PickupItems = new List<Item>();
                            int ItmCounter = 0;
                            foreach (Item itm in Items)
                            {
                                if (words[1] == itm.getName().ToLower())
                                {
                                    PickupItems.Add(itm);
                                    GameWorld.Inventory.Add(itm);
                                    GameWorld.Player.setDefence(GameWorld.Player.getDefence() + itm.getDefenceStats());
                                    GameWorld.Player.setStrength(GameWorld.Player.getStrength() + itm.getStrengthStats());
                                    ItmCounter++;
                                    PrintMessage("You have picked up the " + itm.getName().ToLower() + ".");
                                }
                            }
                            foreach (Item itm in PickupItems)
                            {
                                GameWorld.CurrentRoom.getItems().Remove(itm);
                            }
                            if (ItmCounter == 0)
                            {
                                PrintMessage("That item is not in this here!");
                            }
                        }
                        else
                        {
                            PrintMessage("Try typing 'get the object'");
                        }
                    }
                }
                else if (s.Contains("throw away") || s.Contains("put down"))
                {
                    s = s.Replace(" the", "");
                    s = s.Replace("throw away", "throwaway");
                    s = s.Replace("put down", "putdown");
                    List<Item> ToRemove = new List<Item>();
                    String[] words = s.Split(' ');
                    int ItmCounter = 0;
                    if (words.Length > 1)
                    {
                        for (int i = 2; i < words.Length; i++)
                        {
                            words[1] = words[1] + " " + words[i];
                        }
                        foreach (Item itm in GameWorld.Inventory)
                        {
                            if (words[1] == itm.getName().ToLower())
                            {
                                GameWorld.CurrentRoom.Items.Add(itm);
                                ToRemove.Add(itm);
                                PrintMessage("You have placed down your " + itm.getName().ToLower() + ".");
                                ItmCounter++;
                            }
                        }
                        if (ItmCounter == 0)
                        {
                            PrintMessage("You don't have that item to throw away!");
                        }
                        foreach (Item itm in ToRemove)
                        {
                            GameWorld.Inventory.Remove(itm);
                            GameWorld.Player.setDefence(GameWorld.Player.getDefence() - itm.getDefenceStats());
                            GameWorld.Player.setStrength(GameWorld.Player.getStrength() - itm.getStrengthStats());
                        }
                    }
                }
                else if (s.Contains("attack") || s.Contains("fight"))
                {
                    s = s.Replace(" the", "");
                    String[] words = s.Split(' ');
                    if (words.Length > 1)
                    {
                        for (int i = 2; i < words.Length; i++)
                        {
                            words[1] = words[1] + " " + words[i];
                        }
                        if (GameWorld.CurrentRoom.getEntities() != null)
                        {
                            List<Entity> Entities = GameWorld.CurrentRoom.getEntities();
                            List<Entity> ToDie = new List<Entity>();
                            foreach (Entity en in Entities)
                            {
                                if (words[1] == en.getName().ToLower())
                                {
                                    Combat(GameWorld.Player, en);
                                    if (en.isDead())
                                    {
                                        ToDie.Add(en);
                                    }
                                }
                                else
                                {
                                    PrintMessage("There is no " + words[1] + " here!");
                                }
                            }

                            foreach (Entity en in ToDie)
                            {
                                GameWorld.CurrentRoom.getEntities().Remove(en);
                            }
                        }
                    }
                }
                else if (s == "inventory")
                {
                    String msg = "Inventory:" + Environment.NewLine;
                    foreach (Item itm in GameWorld.Inventory)
                    {
                        msg = msg + "- " + itm.getName() + Environment.NewLine;
                    }
                    PrintMessage(msg);
                }
                else if (s == "where am i" || s == "whereami")
                {
                    PrintMessage(RoomString(GameWorld.CurrentRoom));
                }
                else if (s == "stats")
                {
                    PrintMessage("==Stats==" + Environment.NewLine
                        + "STRENGTH: " + GameWorld.Player.getStrength() + Environment.NewLine
                        + "TOUGHNESS:" + GameWorld.Player.getDefence() + Environment.NewLine
                        + "HEALTH: " + GameWorld.Player.getHealth() + "/" + GameWorld.Player.getMaxHealth() + Environment.NewLine
                        );
                }
                else if (s == "save")
                {
                    GameWorld.Save(worldPath);
                    PrintMessage("Game saved!" + Environment.NewLine);
                }
                else if (s == "load")
                {
                    PrintMessage("You have already started a game!");
                }
                else if (s == "more worlds" || s == "download worlds")
                {
                    PrintMessage("Download more worlds here: " + Environment.NewLine + "https://drive.google.com/folderview?id=0B-3zMtsP_y-9TjVXYTMtUHV4R0U&usp=sharing");
                }
                else if (s == "help")
                {
                    PrintMessage("==Help==" + Environment.NewLine
                        + "COMMANDS" + Environment.NewLine
                        + "- go ahead: Travel forward" + Environment.NewLine
                        + "- go right: Turn right" + Environment.NewLine
                        + "- go left: Turn left" + Environment.NewLine
                        + "- go back: Turn around and go back" + Environment.NewLine
                        + "- look at: Look at an item" + Environment.NewLine
                        + "- get: Get an item" + Environment.NewLine
                        + "- attack: Attack an entity" + Environment.NewLine
                        + "- stats: View your stats" + Environment.NewLine
                        + "- inventory: View the contents of your inventory" + Environment.NewLine
                        + "- where am i: Get information about where you are" + Environment.NewLine
                        + "- quit: Leave the game" + Environment.NewLine
                        + "- save: Saves the game" + Environment.NewLine
                        + "- load: Loads a saved game" + Environment.NewLine
                        + "- more worlds: A link to a place to download more worlds" + Environment.NewLine
                        );
                }
                else
                {
                    PrintMessage("That command is not understood!");
                }
            }
            else
            {
                if (s == "load")
                {
                    if (LoadWorldDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = LoadWorldDialog.FileName;
                        worldPath = filePath;
                        GameWorld = World.Load(filePath);
                        if (GameWorld != null)
                        {
                            PrintMessage("Game loaded!" + Environment.NewLine);
                            gameStarted = true;
                            // Print the current room's string to orient the player with their new world
                            PrintMessage(RoomString(GameWorld.CurrentRoom));
                            Image compass = CompassBox.Image;
                            if (GameWorld.Direction == 0)
                            {
                                //
                            } else if (GameWorld.Direction == 1)
                            {
                                compass.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            } else if (GameWorld.Direction == 2)
                            {
                                compass.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            } else if (GameWorld.Direction == 3)
                            {
                                compass.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            }
                            CompassBox.Image = compass;
                        }
                        else
                        {
                            //
                        }
                    }
                }
                else if (s == "worldbuild")
                {
                    WorldBuilder wbform = new WorldBuilder();
                    wbform.Show();
                }
                else
                {
                    PrintMessage("You must start a game before running any commands");
                }
            }
        }

        public string RoomString(Room r)
        {
            String msg = r.ToString();
            if (GameWorld.Direction == 0)
            {
                msg = msg.Replace("North ", "Ahead ");
                msg = msg.Replace("East ", "Right ");
                msg = msg.Replace("South of ", "Behind ");
                msg = msg.Replace(" west ", "left ");
            } else if (GameWorld.Direction == 1)
            {
                msg = msg.Replace("North ", "Left ");
                msg = msg.Replace("East ", " ahead ");
                msg = msg.Replace("South ", "Right ");
                msg = msg.Replace("West of ", "Behind ");

            } else if (GameWorld.Direction == 2)
            {
                msg = msg.Replace("North of ", "Behind ");
                msg = msg.Replace("East ", "Left ");
                msg = msg.Replace("South ", "Ahead ");
                msg = msg.Replace("West ", "Right ");
            } else if (GameWorld.Direction == 3)
            {
                msg = msg.Replace("North ", "Right ");
                msg = msg.Replace("East of ", "Behind ");
                msg = msg.Replace("South ", "Left ");
                msg = msg.Replace("West ", "Ahead ");
            }
            return msg;
        }

        public void Combat(Entity p, Entity m)
        {
            Random rnd = new Random();
            int phitroll = rnd.Next(20);
            int mhitroll = rnd.Next(20);
            int pcrit = rnd.Next(10);
            int mcrit = rnd.Next(10);
            int pdamage;
            int mdamage;
            if (mhitroll != 0)
            {
                mdamage = m.getStrength() - p.getDefence();
                if (mdamage < 0)
                {
                    mdamage = 0;
                }
                if (mcrit == 3)
                {
                    if (mdamage == 0)
                    {
                        mdamage = rnd.Next(p.getHealth() - 1);
                    }
                    else
                    {
                        mdamage = mdamage * 2;
                    }
                }
                p.DealDamage(mdamage);
                PrintMessage(m.getName() + " dealt " + mdamage + " to you, you are now on " + p.getHealth() + " health.");
            } else
            {
                PrintMessage("Your opponent missed you completely!");
            }
            if (phitroll != 0)
            {
                pdamage = p.getStrength() - m.getDefence();
                if (pdamage < 0)
                {
                    pdamage = 0;
                }
                if (pcrit == 7)
                {
                    if (pdamage == 0)
                    {
                        pdamage = rnd.Next(m.getHealth() - 1);
                    }
                    else
                    {
                        pdamage = pdamage * 2;
                        PrintMessage("You got a critical!");
                    }
                } else
                {
                    PrintMessage("You hit your target!");
                }
                m.DealDamage(pdamage);
            }
            else
            {
                PrintMessage("You completely missed and failed miserably!");
            }
            if (p.isDead())
            {
                PrintMessage(p.getName() + " died.");
            }
            if (m.isDead())
            {
                PrintMessage(m.getName() + " died.");
            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            PrintMessage(">" + InputBox.Text);
            RunCommand(InputBox.Text);
            InputBox.Text = "";
            ChatLogNum = ChatLog.Count();
        }

        public void PrintMessage(String msg)
        {
            if (msg.Replace(" ", "") != "" && msg.Replace(" ","") != ">")
            {
                DialogueBox.Text = DialogueBox.Text + msg + Environment.NewLine;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //
        }

        private void CompassBox_Click(object sender, EventArgs e)
        {

        }

        private void PlaceHolderCompass_Click(object sender, EventArgs e)
        {

        }

        public void MapRooms()
        {
            //Other
            if (goNorth)
            {
                    EnterRoom(GameWorld.CurrentRoom.NorthExit);
            }
            else if (goSouth)
            {
                    EnterRoom(GameWorld.CurrentRoom.SouthExit);
            }
            else if (goEast)
            {
                    EnterRoom(GameWorld.CurrentRoom.EastExit);
            }
            else if (goWest)
            {
                    EnterRoom(GameWorld.CurrentRoom.WestExit);
            }
            else
            {
                //Change to the room you want them to start in!
                EnterRoom(GameWorld.CurrentRoom);
            }
        }

        private Boolean isBlocked()
        {
            if (GameWorld.CurrentRoom.getEntities() != null)
            {
                int HostileCount = 0;
                foreach (Entity en in GameWorld.CurrentRoom.getEntities())
                {
                    if (!en.isFriendly())
                    {
                        HostileCount++;
                    }
                }
                if (HostileCount == 0)
                {
                    return false;
                } else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadWorldDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
