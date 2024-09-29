using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    internal abstract class Animal : IGreeter
    {
        public string Name { get; protected set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract string Greetings();
    }
}
