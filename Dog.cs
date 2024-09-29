using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    internal class Dog : Animal
    {
        public string Breed { 
            get; 
            private set; 
        }
        public Dog (string name, string breed) : base (name)
        {
            Breed = breed;
        }

        public override string Greetings()
        {
            return "Woof";
        }
    }
}
