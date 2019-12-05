using System;

namespace Human
{
    class Program
    {

    }
    class Human 
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        
        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string n)
        {
            Name = n; 
            Strength = 0;
            Intelligence = 0;
            Dexterity = 0;
            health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string n, int s, int i, int d, int h)
        {
            Name = n;
            Strength = s;
            Intelligence = i;
            Dexterity = d;
            health = h;
        }
        // Build Attack method
        public int Attack(Human target)
        {
            var Tar = (Human) target;
            Tar.Health -= 5 * Strength;
            Console.WriteLine($"ATTACK! {Tar.Name} loses {5 * Strength} pts from their Health!");
        }
    }
}
