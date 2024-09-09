using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    internal class Teacher : Person
    {
        private double salary;

        public Teacher(string name, double salary) : base(name)
        {
            this.salary = salary;
        }

        public override string Greetings()
        {
            return $"{base.Greetings()}, and a teacher with a salary of {salary}";
        }
    }
}
