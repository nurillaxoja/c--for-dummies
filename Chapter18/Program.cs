using System;

namespace Chapter18
{
    interface IDisplayble
    {
        string Display();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting students list");
            Student[] students = Student.CreateStudentsList();
            Array.Sort(students);
            DisplayArray(students);

            Console.WriteLine("\nSorting birds list:");
            Bird[] birds = Bird.CreateBirdList();
            Array.Sort(birds);
            DisplayArray(birds);

        }

        public static void DisplayArray(IDisplayble[] displaybles)
        {
            foreach (IDisplayble displayble in displaybles)
            {
                Console.WriteLine("{0}", displayble.Display());
            }
        }
    }
    class Student : IComparable<Student>, IDisplayble
    {

        static string[] names = { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
        static double[] grades = { 0, 85, 50, 100, 30 };

        public string Name { get; private set; }
        public double Grade { get; private set; }
        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public static Student[] CreateStudentsList()
        {
            Student[] students = new Student[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                students[i] = new Student(names[i], grades[i]);
            }
            return students;
        }


        public int CompareTo(Student rightStudent)
        {
            Student leftStudent = this;
            if (rightStudent.Grade < leftStudent.Grade)
            {
                return -1;
            }
            if (rightStudent.Grade > leftStudent.Grade)
            {
                return 1;
            }
            return 0;
        }
        public string Display()
        {
            string padName = Name.PadRight(9);
            return string.Format("{0} : {1:N0}", padName, Grade);
        }
    }
    class Bird : IComparable<Bird>, IDisplayble
    {
        public Bird(string name)
        {
            Name = name;
        }
        static string[] birdNames = {"Oriole","Hawk","Robin","Cardinal",
        "Bluejay", "Finch","Sparrow"};

        public static Bird[] CreateBirdList()
        {
            Bird[] birds = new Bird[birdNames.Length];
            for (int i = 0; i < birds.Length; i++)
            {
                birds[i] = new Bird(birdNames[i]);
            }
            return birds;
        }
        public string Name { get; private set; }

        public int CompareTo(Bird rightBird)
        {
            Bird leftBird = this;
            return String.Compare(leftBird.Name, rightBird.Name);
        }
        public string Display()
        {
            return Name;
        }

    }
}
