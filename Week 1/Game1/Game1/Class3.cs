using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Animal
    {
        public string Name;
        public string OwnerName;
        public int Age;
        public int LegCount;
        public Animal(string name, string ownerName, int age, int legCount)
        {
            this.Name = name;
            this.OwnerName = ownerName;
            this.Age = age;
            this.LegCount = legCount;
        }
    }

    class Cat: Animal
    {
        public int lives;

        public Cat(string name, string ownerName, int age) : base(name, ownerName, age, 4)
        {

            this.lives = 9;

        }

    }
}
