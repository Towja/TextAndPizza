using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TextAndPizza
{
    // Handles all game and player state
    [Serializable]
    class World
    {
        // Data related to the player
        public Entity Player;
        public List<Item> Inventory;
        public int Balance = 0;
        public Room CurrentRoom { get; set; }
        public int Direction;

        // Data related to the rooms and layout of the world
        // TODO: Make this just an array of rooms to allow things such as loading a different level
        // and procedural generation?
        public Room DungeonRoomC;
        Room DungeonRoomN;
        Room DungeonRoomE;
        Room DungeonRoomExit;

        // Initializes the world
        // At the moment this just creates a hardcoded world
        //functionality will be added to load a world

        //Make an openfile dialog for loading the world
        public OpenFileDialog worldDialog = new OpenFileDialog();

        public World()
        {
            // Initalize player data
            Player = new Entity("You", 10, 5, 5);
            Player.setDescription("Looking Good!");
            Inventory = new List<Item>();
            Direction = 0;
            Balance = 0;

            // Initalize Rooms
            InitalizeRooms();
            CurrentRoom = DungeonRoomC;
        }


        //Add rooms through this (For the world builder)
        public void AddRoom(String id, String name, String description, List<Item> items, List<Entity> entities, Room nExit, Room sExit, Room eExit, Room wExit)
        {
            //
        }

        // Initalizes the rooms
        // TODO: Make this more generic
        public void InitalizeRooms()
        {
            //DungeonRoomC
            DungeonRoomC = new Room("Dungeon Room",
                "a cold stony dungeon room, lit by some torches on the walls, which provide almost no heat.");
            Item Sword1 = new Item("Iron Sword",
                "an old, slightly rusty iron sword");
            Sword1.setStats(2, 0);
            //Item Sword1 = new Item(name, desc);
            List<Item> DungeonRoomCItems = new List<Item>();
            DungeonRoomCItems.Add(Sword1);
            DungeonRoomC.setItems(DungeonRoomCItems);

            //DungeonRoomN
            DungeonRoomN = new Room("Dungeon Room",
                "a cold stony dungeon room, damp to the touch, and lit only by the light shining through from the south door.");
            Item DeadTorch1 = new Item("Extinguished Torch",
                "lying on the ground. It may have been put out by the dampness");
            List<Item> DungeonRoomNItems = new List<Item>();
            Entity Zombie1 = new Entity("Zombie", 10, 6, 4);
            Zombie1.setDescription("a rotting corpse that looks somehow... Alive...");
            List<Entity> DungeonRoomNEntities = new List<Entity>();
            DungeonRoomNEntities.Add(Zombie1);
            DungeonRoomN.setEntities(DungeonRoomNEntities);
            DungeonRoomNItems.Add(DeadTorch1);
            DungeonRoomN.setItems(DungeonRoomNItems);

            //DungeonRoomE
            DungeonRoomE = new Room("Dungeon Room",
                "far better lit than all of the other rooms, and it feels significantly warmer too");
            Item Chestplate1 = new Item("Iron Chestplate",
                "a slightly worn out iron chestplate");
            Chestplate1.setStats(0, 3);
            List<Item> DungeonRoomEItems = new List<Item>();
            DungeonRoomEItems.Add(Chestplate1);
            DungeonRoomE.setItems(DungeonRoomEItems);

            //DungeonRoomExit
            DungeonRoomExit = new Room("Exit",
                "a nice and refreshingly breezy room, with light flowing in from outside!");
            //Map Exits
            DungeonRoomC.setNorthExit(DungeonRoomN);
            DungeonRoomN.setSouthExit(DungeonRoomC);
            DungeonRoomC.setEastExit(DungeonRoomE);
            DungeonRoomE.setWestExit(DungeonRoomC);
            DungeonRoomExit.setSouthExit(DungeonRoomN);
            DungeonRoomN.setNorthExit(DungeonRoomExit);
        }

        // Saves the current world state to a file in the Users AppData
        public void Save(String path)
        {
            // Filename that the file will be saved to
            string fileName = Environment.ExpandEnvironmentVariables(path);

            // Save the world
            Stream stream = null;
            MessageBox.Show(path);
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

                //This is broken!
                formatter.Serialize(stream, this);
            }
            catch (Exception ex)
            {
                // Ignore any errors
                throw ex;
            }
            finally
            {
                // Close the file
                if (null != stream)
                    stream.Close();
            }
        }

        public static World Load(String path)
        {
            // Filename to load from
            String fileName = Environment.ExpandEnvironmentVariables(path);
            //String fileName = Environment.ExpandEnvironmentVariables("%AppData%\\savefile.bin");

            if (fileName.Contains(".bin"))
            {
                // Load the file
                Stream stream = null;
                World savedWorld = null;
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                    // This is also very broken
                    savedWorld = (World)formatter.Deserialize(stream);
                }
                catch
                {
                    // Ignore all errors
                    // TODO: Handle having no save file
                }
                finally
                {
                    // Close the file
                    if (null != stream)
                        stream.Close();
                }

                // Return the loaded world object
                return savedWorld;
            }
            else
            {
                MessageBox.Show("There was a problem with your world. Please ensure it is a \".bin\" file");
                return null;
            } 
        }
    }
}
