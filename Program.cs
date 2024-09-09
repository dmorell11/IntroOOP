namespace IntroOOP
{
    class Program
    {
        static void Main(string[] args) 
        {
            var ana = new Person("Ana", 27, HairType.Long);
            Person juan = new Person("Juan");

            Person luis = new Student("Luis", 19, HairType.Short, 96);
            Person maria = new Student("Maria", 18, HairType.Long, 190);

            Student lucia = new Student("Lucia", 17, HairType.Long, 199);
            
            Teacher daniel = new Teacher("Daniel", 78000.5);

            IGreeter duke = new Dog("Duke", "Collie");
            IGreeter lulu = new Dog("Lulu", "Collie");
            IGreeter pedro = new Student("Pedro", 32, HairType.Short, 78);


            Animal[] pets = { (Animal)duke, (Animal)lulu };

            //TODO Initialize List
            List<Person> people = new List<Person>();
            people.Add(juan);
            people.Add(ana);

            List<IGreeter> greeters = new List<IGreeter>();
            greeters.Add(juan);
            greeters.Add(ana);
            greeters.Add(duke);
            greeters.Add(daniel);


            //TODO Initialize Dictionary
            Dictionary<int, Student> studentsById = new Dictionary<int, Student>();
            studentsById[lucia.Id] = lucia;
            studentsById[((Student)maria).Id] = ((Student)maria);

            Console.WriteLine(studentsById[lucia.Id].Name);

            Console.WriteLine(duke.Greetings());
            Console.WriteLine(pedro.Greetings());

            Console.WriteLine(ana.Name);
            lucia.Age = 20;
            Console.WriteLine(lucia.Age);
            Console.WriteLine(pedro.Greetings());
            Console.WriteLine(daniel.Greetings());

            Console.WriteLine(((Student)maria).Id);

            if (maria is Student mariaStudent)
            {
                Console.WriteLine(mariaStudent.Id);
            }

            Testing.TryFoorLoop();
            Testing.TryDoWhileLoop();

            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }

            foreach (IGreeter greeter in greeters)
            {
                Console.WriteLine(greeter.Greetings());
            }
        }
    }

    
}