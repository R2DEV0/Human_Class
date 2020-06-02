using System;

namespace Human
{
    class HumanClass
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int HealthProp
        {
            get{return health;}
        }
        public HumanClass(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public HumanClass(string name, int str, int intel, int dex, int heal)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = heal;
        }

        public int Attack(HumanClass target)
        {
            target.health = target.health - (Strength * 5);
            return(target.health);
        }
        
        public static void Main(string[] args)
        {
            HumanClass Kevin = new HumanClass("Kevin");
            HumanClass BonJovi = new HumanClass("BonJovi");
            Console.WriteLine($"{Kevin.Name}'s Remaining Health = " + BonJovi.Attack(Kevin));
        }
    }
}