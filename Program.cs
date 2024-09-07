namespace IntroOOP
{
    class Program
    {
        static void Main(string[] args) 
        {
            Person ana = new Student("Ana", 27, 32);
            Person luis = new Student("Luis", 19, 96);
            Person maria = new Student("Maria", 18, 190);

            Student lucia = new Student("Lucia", 17, 199);
            Student pedro = new Student("Pedro", 32, 78);

            //TODO Add class Teacher

            //TODO: Explain why both can call Greetings
            maria.Greetings();
            pedro.Greetings();

            //TODO: Correct casting
            //(Student)maria.GetId();

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("It is 0");
                }

                //TODO: Explain else if, else and switch with enum
            }

            //TODO: Explain while, do while
        }
    }

    
}