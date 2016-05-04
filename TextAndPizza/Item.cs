using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAndPizza
{
    [Serializable]
    public class Item
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String[] Verbs { get; set; }
        public String Color { get; set; }
        public Boolean canPickup { get; set; }
        public Boolean givesLight { get; set; }
        public int StrengthStats { get; set; }
        public int DefenceStats { get; set; }


        public Item(String name, String description)
        {
            Name = name;
            Description = description;
        }
        //Get & Set name
        public void setName(String s)
        {
            Name = s;
        }

        public String getName()
        {
            return Name;
        }

        public void setDescription(String s)
        {
            Description = s;
        }

        public String getDescription()
        {
            return Description;
        }
        
        public void setStats(int off, int def)
        {
            StrengthStats = off;
            DefenceStats = def;
        }

        public int getStrengthStats()
        {
            return StrengthStats;
        }

        public int getDefenceStats()
        {
            return DefenceStats;
        }

        public override string ToString()
        {
            if (Description != null)
            {
                return "The " + getName().ToLower() + " appears to be " + Description + ".";
            }
            else
            {
                return getName() + " is nondescript!";
            }
        }
    }
}
