using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spelet123
{
    class Player
    {
        private string name;
        private int health;
        private int steps;
        private int water;
        int damage = 5;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Health
        {
            set { health = value; }
            get { return health; }
        }
        public int Steps
        {
            set { steps = value; }
            get { return steps; }
        }
        public int Water
        {
            set { water = value; }
            get { return Water; }
        }
        public int DamageTaken()
        {
            health = health - damage;
            return health;
        }
        public int Thirst()
        {
            water = water - damage;
            return water;
        }
        public int StepTaken()
        {
            return ++steps;
        }
    }
}
