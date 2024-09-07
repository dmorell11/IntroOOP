namespace IntroOOP
{
    internal class Person
    {
        private string name;
        public int age;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public virtual void IncreaseAge()
        {
            age++;
            Console.WriteLine(age);
        }

        public void ChangeNumber(ref int number)
        {
            number++;
            Console.WriteLine(number);
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int newAge)
        {
            if (age > 18)
            {
                age = newAge;
            }
        }
    }
}
