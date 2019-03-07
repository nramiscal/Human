using System;

namespace Human
{
    class Program
    {

        class Human
        {
            // Fields for Human
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int health;
             
            // add a public "getter" property to access healthcopy
            public int HealthProp
            {
                get
                {
                    return health;
                }
            }
             
            // Add a constructor that takes a value to set Name, and set the remaining fields to default values
            public Human(string name)
            {
                Name = name;
                Strength = 3;
                Dexterity = 3;
                Intelligence = 3;
                health = 100;
            }
            // Add a constructor to assign custom values to all fields
            public Human(string name, int strength, int dexterity, int intelligence, int h)
            {
                Name = name;
                Strength = strength;
                Dexterity = dexterity;
                Intelligence = intelligence;
                health = h;
            }
             
            // Build Attack method
            // Now add a new method called Attack, which when invoked, should reduce the 
            // health of a Human object that is passed as a parameter. The damage done should 
            // be 5 * strength (5 points of damage to the attacked, for each 1 point of 
            // strength of the attacker). This method should return the remaining health of 
            // the target object.
            public int Attack(Human target)
            {
                target.health -= 5 * Strength;
                return target.health;
            }
        }
    
        static void Main(string[] args)
        {
            
        }
    }
}
