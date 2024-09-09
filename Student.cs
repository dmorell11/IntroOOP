namespace IntroOOP
{
    internal class Student : Person
    {
        public int Id { get; private set; }

        public Student (string name, int age, HairType hair, int id) : base (name, age, hair)
        {
            Id = id;
        }

        public override string Greetings()
        {
            return "Hello, I am a student";
        }
    }
}
