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
        public Dictionary<string, Room> worldRooms = new Dictionary<string, Room>();

        // Data related to the rooms and layout of the world
        // TODO: Make this just an array of rooms to allow things such as loading a different level
        // and procedural generation?

        // Initializes the world
        // At the moment this just creates a hardcoded world
        //functionality will be added to load a world

        //Make an openfile dialog for loading the world
        [NonSerialized()]
        public OpenFileDialog worldDialog = new OpenFileDialog();

        public World()
        {
            // Initalize player data
            Player = new Entity("You", 10, 5, 5);
            Player.setDescription("Looking Good!");
            Inventory = new List<Item>();
            Direction = 0;
            Balance = 0;
        }

        public void setStartRoom(String id)
        {
            CurrentRoom = worldRooms[id];
        }

        //Add rooms through this (For the world builder)
        public void AddRoom(String id, String name, String description, List<Item> items, List<Entity> entities, Room nExit, Room sExit, Room eExit, Room wExit)
        {
            //Create a room
            Room room = new Room(name, description);
            //set room items and entities
            room.setItems(items);
            room.setEntities(entities);
            //Set room exits
            room.setNorthExit(nExit);
            room.setEastExit(eExit);
            room.setSouthExit(sExit);
            room.setWestExit(wExit);
            //Add room to the rooms dictionary
            worldRooms.Add(id, room);
        }

        public void deleteRoom(String id)
        {
            worldRooms.Remove(id);
        }

        // Saves the current world state to a file in the Users AppData
        public void Save(String path)
        {
            // Filename that the file will be saved to
            string fileName = Environment.ExpandEnvironmentVariables(path);

            // Creates the directory (if not already created)
            Directory.CreateDirectory(Path.GetDirectoryName(fileName));

            // Save the world
            Stream stream = null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
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

        public static World Load(String path, String extension)
        {
            // Filename to load from
            String fileName = Environment.ExpandEnvironmentVariables(path);

            if (Path.GetExtension(path) == extension)
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
                MessageBox.Show("There was a problem with your world. Please ensure it is a Text and Pizza World File (\"" + extension + "\")");
                return null;
            } 
        }
    }
}
