namespace IntroOOP
{
    internal class Student : Person
    {
        private static int idCounter = 0;
        public int Id { get; private set; }

        public Student (string name, int age, HairType hair) : base (name, age, hair)
        {
            Id = ++idCounter;
        }

        public override string Greetings()
        {
            return "Hello, I am a student";
        }

        public override string ToString()
        {
            return $"- {Name} (ID: {Id})\n";
        }
    }
}
