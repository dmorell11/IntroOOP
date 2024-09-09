namespace IntroOOP
{
    class Program
    {
        static void Main(string[] args) 
        {
            Person ana = new Person("Ana", 27, HairType.Long);
            Person juan = new Person("Juan");

            Person luis = new Student("Luis", 19, HairType.Short, 96);
            Person maria = new Student("Maria", 18, HairType.Long, 190);

            Student lucia = new Student("Lucia", 17, HairType.Long, 199);
            Student pedro = new Student("Pedro", 32, HairType.Short, 78);
            
            Teacher daniel = new Teacher("Daniel", 78000.5);

            

            Console.WriteLine(ana.Name);
            lucia.Age = 20;
            Console.WriteLine(lucia.Age);
            Console.WriteLine(lucia.Id);
            Console.WriteLine(pedro.Greetings());
            Console.WriteLine(daniel.Greetings());

            //TODO: Correct casting
            //(Student)maria.GetId();


            Testing.TryFoorLoop();
            Testing.TryDoWhileLoop();
            

        }
    }

    
}