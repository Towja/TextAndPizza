﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAndPizza
{
    [Serializable]
    public class Room
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public List<Item> Items { get; set; }
        public List<Entity> Entities { get; set; }
        public Room NorthExit { get; set; }
        public Room SouthExit { get; set; }
        public Room EastExit { get; set; }
        public Room WestExit { get; set; }

        public Room(String name, String description)
        {
            Name = name;
            Description = description;
        }

        public void setName(String s)
        {
            Name = s;
        }

        public String getName()
        {
            return Name;
        }

        public void setItems(List<Item> it)
        {
            Items = it;
        }

        public List<Item> getItems()
        {
            return Items;
        }

        public void setEntities(List<Entity> en)
        {
            Entities = en;
        }

        public List<Entity> getEntities()
        {
            return Entities;
        }

        public void setDescription(String s)
        {
            Description = s;
        }

        public String getDescription()
        {
            return Description;
        }

        public void setNorthExit(Room room)
        {
            NorthExit = room;
        }

        public String getNorthExit()
        {
            return NorthExit.Name;
        }

        public void setSouthExit(Room room)
        {
            SouthExit = room;
        }

        public String getSouthExit()
        {
            return SouthExit.Name;
        }

        public void setEastExit(Room room)
        {
            EastExit = room;
        }

        public String getEastExit()
        {
            return EastExit.Name;
        }

        public void setWestExit(Room room)
        {
            WestExit = room;
        }

        public String getWestExit()
        {
            return WestExit.Name;
        }

        public override string ToString()
        {
            String msg = "You are in " + getDescription() + Environment.NewLine;
            if (Items != null)
            {
                if (Items.Count != 0)
                {
                    msg = msg + "In the " + getName() + " you see a:" + Environment.NewLine;
                    foreach (Item it in Items)
                    {
                        msg = msg + "- " + it.getName() + Environment.NewLine;
                    }
                }
                else
                {
                    //
                }
            }
            if (Entities != null)
            {
                if (Entities.Count != 0)
                {
                    msg = msg + "You also see some creatures:" + Environment.NewLine;
                    foreach (Entity en in Entities)
                    {
                        msg = msg + "- " + en.getName() + Environment.NewLine;
                    }
                }
                else
                {
                    msg = msg + "";
                } 
            }
            if (NorthExit != null)
            {
                msg = msg + "North of you is a " + getNorthExit().ToLower() + "." + Environment.NewLine;
            }
            if (SouthExit != null)
            {
                msg = msg + "South of you is a " + getSouthExit().ToLower() + "." + Environment.NewLine;
            }
            if (WestExit != null)
            {
                msg = msg + "West of you is a " + getWestExit().ToLower() + "." + Environment.NewLine;
            }
            if (EastExit != null)
            {
                msg = msg + "East of you is a " + getEastExit().ToLower() + "." + Environment.NewLine;
            }
            return msg;
        }
    }
}
