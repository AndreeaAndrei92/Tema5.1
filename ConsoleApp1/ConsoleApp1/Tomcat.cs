using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tomcat : Cat, ISound
    {
        private string tomcatSay = "MAU MAU";

        public Tomcat(string name, byte age) : base(name, "male", age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string MakeSound(string animalSound)
        {
            return this.tomcatSay.ToString();
        }
    }
}
