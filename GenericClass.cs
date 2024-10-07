using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    class GenericClass<T1, T2> where T1 : Person
    {
        T1 person;
        T2 attribute;

        string AskForThePersonName()
        {
            return person.Name;
        }

        T1 AskForThePerson()
        {
            return person;
        }
    }
}
