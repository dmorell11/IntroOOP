namespace IntroOOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create the university mascot
            Dog universityMascot = new Dog("Penn", "Beagle");

            // Define the classroom names and capacities
            var classroomDetails = new List<(string name, int capacity)>
            {
                ("Math 101", 30),
                ("Science 201", 25),
                ("History 301", 20)
            };

            // Create the university with 3 classrooms (with capacities of 30, 25, and 20 students respectively)
            University upenn = new University(universityMascot, classroomDetails);

            // Create students
            Student alice = new Student("Alice", 20, HairType.Long);
            Student bob = new Student("Bob", 19, HairType.Short);

            // Create an underage student 
            Student kevin = new Student("Kevin", 15, HairType.Short);

            // Create an unregistered student
            Student charlie = new Student("Charlie", 21, HairType.Short);

            // Create a teacher
            Teacher drSmith = new Teacher("Dr. Smith", 50000);
            

            // Add students and teachers to the university
            upenn.AddNewStudent(alice);
            upenn.AddNewStudent(bob);
            upenn.AddNewTeacher(drSmith);

            // Attempt to add an underage student
            upenn.AddNewStudent(kevin); // This will show an error

            // Assign teacher and students to a classroom
            Classroom mathClassroom = upenn.Classrooms[0]; // Select the first classroom
            Classroom scienceClassroom = upenn.Classrooms[1]; // Select the first classroom

            upenn.AssignTeacherToClassroom(drSmith, mathClassroom);
            upenn.AssignStudentToClassroom(alice, mathClassroom);
            upenn.AssignStudentToClassroom(bob, mathClassroom);

            // Attempt to assign an unregistered student
            upenn.AssignStudentToClassroom(charlie, mathClassroom); // This will show an error

            // Attempt to assign a student to a classroom without teacher
            upenn.AssignStudentToClassroom(alice, scienceClassroom); // This will show an error

            // List the members of the classroom
            Console.WriteLine(mathClassroom.ListClassroomMembers());

            // Greeting from the mascot
            Console.WriteLine(universityMascot.Greetings());
        }


        // Main first classes
        /*
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
        */
    }


}