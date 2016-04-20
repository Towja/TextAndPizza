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
        Entity Player = new Entity("You", 10, 5, 5);
        int Balance;
        List<Item> Inventory = new List<Item>();
        Room CurrentRoom;
        //Declare rooms
        Room DungeonRoomC;
        Room DungeonRoomN;
        Room DungeonRoomS;
        Room DungeonRoomE;
        Room DungeonRoomW;
        Room DungeonRoomExit;
        public int Direction;
        Entity Zombie1 = new Entity("Zombie", 10, 6, 4);

        public MainForm()
        {
            InitializeComponent();
            this.AcceptButton = null;
            this.ActiveControl = InputBox;
            //Player.setDead(false);
            PrintMessage("Welcome to " + name + " v" + vno + Environment.NewLine + "Type 'help' for help.");
            Player.setDescription("Looking good!");
            Direction = 0;
            ChatLog = new List<String>();
            ChatLogNum = ChatLog.Count();
            Balance = 0;
            MapRooms();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        public void EnterRoom(Room r)
        {
            if (r != null)
            {
                PrintMessage(RoomString(r));
                CurrentRoom = r;
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
            if (CurrentRoom.getItems() != null)
            {
                foreach (Item itm in Inventory)
                {
                    foreach (Item rmitm in CurrentRoom.getItems())
                    {
                        if (itm == rmitm)
                        {
                            ToRemove.Add(rmitm);
                        }
                    }
                }
                foreach (Item itm in ToRemove)
                {
                    CurrentRoom.getItems().Remove(itm);
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
            if (Direction == 5)
            {
                Direction = 1;
            }
            if (Direction == 4)
            {
                Direction = 0;
            }
            if (Direction < 0)
            {
                Direction = Direction * -1;
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
            if (Player.isDead())
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
                PrintMessage(Balance + " Gold");
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
                        Direction = Direction + 1;
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        AngleCorrections();
                        CorrectMove++;
                    }
                    else if (s.Contains(" left"))
                    {
                        Direction = Direction - 1;
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        AngleCorrections();
                        CorrectMove++;
                    }
                    else if (s.Contains(" back") || s.Contains(" backwards"))
                    {
                        Direction = Direction + 2;
                        img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        AngleCorrections();
                        CorrectMove++;
                    }
                    CompassBox.Image = img;
                    if (CorrectMove != 0)
                    {
                        if (Direction == 0)
                        {
                            goNorth = true;
                            MapRooms();
                        }
                        if (Direction == 1)
                        {
                            goEast = true;
                            MapRooms();
                        }
                        if (Direction == 2)
                        {
                            goSouth = true;
                            MapRooms();
                        }
                        if (Direction == 3)
                        {
                            goWest = true;
                            MapRooms();
                        }
                    }
                    else
                    {
                        PrintMessage("That direction does not exist");
                    }
                } else
                {
                    PrintMessage("You can't leave this room until all of the monsters are gone!");
                }
            }
            else if (s == "quit")
            {
                Application.Exit();
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
                    if (CurrentRoom.getItems() != null)
                    {
                        List<Item> Items = CurrentRoom.getItems();
                        foreach (Item itm in Items)
                        {
                            if (words[1] == itm.getName().ToLower())
                            {
                                PrintMessage(itm.getDescription());
                                Counter++;
                            }
                        }
                    }
                    if (CurrentRoom.getEntities() != null)
                    {
                        List<Entity> Entities = CurrentRoom.getEntities();
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
            else if (s.Contains("get") || s.Contains("pick up"))
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
                    List<Item> Items = CurrentRoom.getItems();
                    List<Item> PickupItems = new List<Item>();
                    int ItmCounter = 0;
                    foreach (Item itm in Items)
                    {
                        if (words[1] == itm.getName().ToLower())
                        {
                            PickupItems.Add(itm);
                            Inventory.Add(itm);
                            Player.setDefence(Player.getDefence() + itm.getDefenceStats());
                            Player.setStrength(Player.getStrength() + itm.getStrengthStats());
                            ItmCounter++;
                            PrintMessage("You have picked up the " + itm.getName().ToLower() + ".");
                        }
                    }
                    foreach (Item itm in PickupItems)
                    {
                        CurrentRoom.getItems().Remove(itm);
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
                    foreach (Item itm in Inventory)
                    {
                        if (words[1] == itm.getName().ToLower())
                        {
                            CurrentRoom.Items.Add(itm);
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
                        Inventory.Remove(itm);
                        Player.setDefence(Player.getDefence() - itm.getDefenceStats());
                        Player.setStrength(Player.getStrength() - itm.getStrengthStats());
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
                    if (CurrentRoom.getEntities() != null)
                    {
                        List<Entity> Entities = CurrentRoom.getEntities();
                        List<Entity> ToDie = new List<Entity>();
                        foreach (Entity en in Entities)
                        {
                            if (words[1] == en.getName().ToLower())
                            {
                                Combat(Player, en);
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
                            CurrentRoom.getEntities().Remove(en);
                        }
                    }
                }
            }
            else if (s == "inventory")
            {
                String msg = "Inventory:" + Environment.NewLine;
                foreach (Item itm in Inventory)
                {
                    msg = msg + "- " + itm.getName() + Environment.NewLine;
                }
                PrintMessage(msg);
            }
            else if (s == "where am i" || s == "whereami")
            {
                PrintMessage(RoomString(CurrentRoom));
            }
            else if (s == "stats")
            {
                PrintMessage("==Stats==" + Environment.NewLine
                    + "STRENGTH: " + Player.getStrength() + Environment.NewLine
                    + "TOUGHNESS:" + Player.getDefence() + Environment.NewLine
                    + "HEALTH: " + Player.getHealth() + "/" + Player.getMaxHealth() + Environment.NewLine
                    );
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
                    + "- save: NOT YET IMPLEMENTED"
                    );
            }
            else
            {
                PrintMessage("That command is not understood!");
            }
        }

        public string RoomString(Room r)
        {
            String msg = r.ToString();
            if (Direction == 0)
            {
                msg = msg.Replace("North ", "Ahead ");
                msg = msg.Replace("East ", "Right ");
                msg = msg.Replace("South of ", "Behind ");
                msg = msg.Replace(" west ", "left ");
            } else if (Direction == 1)
            {
                msg = msg.Replace("North ", "Left ");
                msg = msg.Replace("East ", " ahead ");
                msg = msg.Replace("South ", "Right ");
                msg = msg.Replace("West of ", "Behind ");

            } else if (Direction == 2)
            {
                msg = msg.Replace("North of ", "Behind ");
                msg = msg.Replace("East ", "Left ");
                msg = msg.Replace("South ", "Ahead ");
                msg = msg.Replace("West ", "Right ");
            } else if (Direction == 3)
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
            //Declare Rooms

            //DungeonRoomC
            DungeonRoomC = new Room("Dungeon Room",
                "a cold stony dungeon room, lit by some torches on the walls, which provide almost no heat."
                );
            Item Sword1 = new Item("Iron Sword",
                "an old, slightly rusty iron sword"
                );
            Sword1.setStats(2, 0);
            //Item Sword1 = new Item(name, desc);
            List<Item> DungeonRoomCItems = new List<Item>();
            DungeonRoomCItems.Add(Sword1);
            DungeonRoomC.setItems(DungeonRoomCItems);

            //DungeonRoomN
            DungeonRoomN = new Room("Dungeon Room",
                "a cold stony dungeon room, damp to the touch, and lit only by the light shining through from the south door."
                );
            Item DeadTorch1 = new Item("Extinguished Torch",
                "lying on the ground. It may have been put out by the dampness"
                );
            List<Item> DungeonRoomNItems = new List<Item>();
            Zombie1.setDescription("a rotting corpse that looks somehow... Alive...");
            List<Entity> DungeonRoomNEntities = new List<Entity>();
            DungeonRoomNEntities.Add(Zombie1);
            DungeonRoomN.setEntities(DungeonRoomNEntities);
            DungeonRoomNItems.Add(DeadTorch1);
            DungeonRoomN.setItems(DungeonRoomNItems);

            //DungeonRoomE
            DungeonRoomE = new Room("Dungeon Room",
                "far better lit than all of the other rooms, and it feels significantly warmer too"
                );
            Item Chestplate1 = new Item("Iron Chestplate",
                "a slightly worn out iron chestplate"
                );
            Chestplate1.setStats(0, 3);
            List<Item> DungeonRoomEItems = new List<Item>();
            DungeonRoomEItems.Add(Chestplate1);
            DungeonRoomE.setItems(DungeonRoomEItems);

            //DungeonRoomExit
            DungeonRoomExit = new Room("Exit",
                "a nice and refreshingly breezy room, with light flowing in from outside!"
                );
            //Map Exits
            DungeonRoomC.setNorthExit(DungeonRoomN);
            DungeonRoomN.setSouthExit(DungeonRoomC);
            DungeonRoomC.setEastExit(DungeonRoomE);
            DungeonRoomE.setWestExit(DungeonRoomC);
            DungeonRoomExit.setSouthExit(DungeonRoomN);
            DungeonRoomN.setNorthExit(DungeonRoomExit);

            //Other
            if (goNorth)
            {
                    EnterRoom(CurrentRoom.NorthExit);
            }
            else if (goSouth)
            {
                    EnterRoom(CurrentRoom.SouthExit);
            }
            else if (goEast)
            {
                    EnterRoom(CurrentRoom.EastExit);
            }
            else if (goWest)
            {
                    EnterRoom(CurrentRoom.WestExit);
            }
            else
            {
                //Change to the room you want them to start in!
                EnterRoom(DungeonRoomC);
            }
        }

        private Boolean isBlocked()
        {
            if (CurrentRoom.getEntities() != null)
            {
                int HostileCount = 0;
                foreach (Entity en in CurrentRoom.getEntities())
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
    }
}
