namespace IntroOOP
{
    public enum HairType { None, Short, Long}
    internal class Person : IGreeter
    {
        private string name;
        private int age;
        private HairType hair = HairType.None;
        
        public string Name => name;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age > 18)
                {
                    age = value;
                }
            }
        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age, HairType hair)
        {
            this.age = age;
            this.name = name;
            this.hair = hair;
        }
        public virtual string Greetings()
        {
            return "Hello, I am person";
        }
    }
}
