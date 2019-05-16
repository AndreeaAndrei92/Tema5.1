using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

        class Kitten : Cat
        {
            private string kittenSay = "miau-miau";

            public Kitten(string name, byte age) : base(name, "female", age)
            {
                this.Name = name;
                this.Age = age;
            }

            public override string MakeSound(string animalSound)
            {
                return this.kittenSay.ToString();
            }
        }
    }

