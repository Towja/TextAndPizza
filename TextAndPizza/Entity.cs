using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAndPizza
{
    public class Entity
    {
        public String Name { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Defence { get; set; }
        public Boolean Friendly { get; set; }
        public String Description { get; set; }
        public Boolean Dead { get; set; }
        public int exp { get; set; }

        public Entity(String name, int maxhealth, int strength, int defence)
        {
            Name = name;
            MaxHealth = maxhealth;
            Strength = strength;
            Defence = defence;
            CalculateHealth();
            Health = maxhealth;
            setDead(false);
            exp = 0;
        }

        public void setName(String s)
        {
            Name = s;
        }

        public string getName()
        {
            return Name;
        }

        public void setMaxHealth(int i)
        {
            MaxHealth = i;
        }

        public int getMaxHealth()
        {
            return MaxHealth;
        }

        public void setStrength(int i)
        {
            Strength = i;
        }

        public int getStrength()
        {
            return Strength;
        }

        public void setDefence(int i)
        {
            Defence = i;
        }

        public int getDefence()
        {
            return Defence;
        }

        public void setFriendly(Boolean yn)
        {
            Friendly = yn;
        }

        public bool isFriendly()
        {
            return Friendly;
        }

        public int getHealth()
        {
            return Health;
        }

        public void setDescription(String s)
        {
            Description = s;
        }

        public string getDescription()
        {
            return Description;
        }
 
        public void DealDamage(int d)
        {
            Damage = d;
            CalculateHealth();
        }

        public void Kill()
        {
            Dead = true;
        }

        public bool isDead()
        {
            return Dead;
        }

        public void setDead(Boolean yn)
        {
            Dead = yn;
        }

        public void setExp(int i)
        {
            exp = i;
            CalculateLevel();
        }

        public void CalculateLevel()
        {
            for (int i = 0; exp-i*i > 0; i++)
            {
                if (exp-i*i < 0)
                {
                    int itg = i - i;
                    while (itg > 0)
                    {
                        LevelUp();
                        itg = itg - i;
                    }
                }
            }
        }

        public void LevelUp()
        {
            setMaxHealth(getMaxHealth() + 5);
            setDefence(getDefence() + 1);
            setStrength(getStrength() + 1);
        }

        private void CalculateHealth()
        {
            Health = Health - Damage;
            if (Health <= 0)
            {
                Kill();
            }
        }

        public override string ToString()
        {
            String msg = getName() + getDescription() + Environment.NewLine;
            return msg;
        }
    }
}
