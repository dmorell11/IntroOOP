namespace IntroOOP
{
    //TODO Add enum for hair
    internal abstract class Person
    {
        private string name;
        private int age;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public abstract void Greetings();

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
