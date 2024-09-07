namespace IntroOOP
{
    enum Hair { }
    class Program
    {
        static void Main(string[] args) 
        {
            Person ana = new Person("Ana", 27);
            Person luis = new Person("Luis", 19);

            Student lucia = new Student("Lucia", 17, 199);

            Student1 pedro = new Student1();
            pedro.Greetings();

            Person maria = new Student("Maria", 18, 190);


            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("It is 0");
                }

                Console.WriteLine(i);
            }
            
            ((Student)maria).GetId();

            Console.WriteLine(maria.age);
            ana.IncreaseAge();
            Console.WriteLine(ana.age);

            luis.SetAge(23);

            Console.WriteLine(luis.GetAge());
        }
    }

    
}