using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal : IComparable<Animal>
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public byte Age { get; set; }
    }
}

