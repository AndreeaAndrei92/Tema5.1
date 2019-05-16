using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> kittens = new List<Animal>();
            kittens.Add(new Kitten("pisica1", 1));
            kittens.Add(new Kitten("pisica2", 2));
            kittens.Add(new Kitten("pisica3", 5));


            List<Animal> tomcats = new List<Animal>();
            tomcats.Add(new Tomcat("motan1", 2));
            tomcats.Add(new Tomcat("motan2", 3));
            tomcats.Add(new Tomcat("motan3", 6));


            List<Animal> dogs = new List<Animal>();
            dogs.Add(new Dog("catel1", "male", 8, "breeed"));
            dogs.Add(new Dog("catel2", "male", 4, "breeeeeed"));
            dogs.Add(new Dog("catel3", "female", 2, "breeeed"));


            List<Animal> frogs = new List<Animal>();
            frogs.Add(new Frog("broasca1", "male", 1, "pink"));
            frogs.Add(new Frog("broasca1", "male", 2, "green"));
            frogs.Add(new Frog("broasca1", "female", 3, "purple"));
        }
    }
}
