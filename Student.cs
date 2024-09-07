namespace IntroOOP
{
    internal class Student : Person
    {
        int id;

        public Student (string name, int age, int id) : base (name, age)
        {
            this.id = id;
        }

        public override void Greetings()
        {
            Console.WriteLine("Hello, I am a student");
        }

        public int GetId() { return id; }
    }
}
