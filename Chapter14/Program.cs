using System;

namespace Chapter14
{
    public class Student
    {
        public string name;
        public string firstname;
        public string secondname;

        public void SetName(string fname, string sname)
        {
            firstname = fname;
            secondname = sname;
        }
        public string ToNameString()
        {
            string s = firstname + " " + secondname;
            return s;
        }
    }

    public class Student1
    {
        public string _name;
        public int _id;
        public string _firstName;
        public string _lastName;

        public void InitStudent(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }


        public string ToNameString()
        {
            return _firstName + " " + _lastName;
        }



        CourseInstance _courseInstance;

        public void Init(string name, int id)
        {
            this._name = name;
            this._id = id;
            _courseInstance = null;
        }
        public void Enroll(string sCourseId)
        {
            _courseInstance = new CourseInstance();
            _courseInstance.Init(this, sCourseId);
        }
        public void DisplayCourse()
        {
            Console.WriteLine(_name);
            _courseInstance.Display();
        }
    }
    public class CourseInstance
    {
        public Student1 _student1;
        public string _courseId;


        public void Init(Student1 student1, string CourseId)
        {
            this._student1 = student1;
            this._courseId = CourseId;
        }
        public void Display()
        {
            Console.WriteLine(_courseId);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //Console.WriteLine("First name:");
            //student.name = "Xoja";
            //OutputName(student);
            //Console.WriteLine("Last name :");
            //SetName(student, "Willa");
            //OutputName(student);
            //student.SetName("xoja", "xojaev");
            //Console.WriteLine("student name -> " + student.ToNameString());



            //Student1 student1 = new Student1();
            //student1.Init("Xoja ", 1234);
            //Console.WriteLine("Inserting into list xoja cource  biology" +
            //    " 101");
            //Console.WriteLine("info about student ");
            //student1.DisplayCourse();



        }
        public static void OutputName(Student student)
        {
            Console.WriteLine("Student.name = {0}", student.name);
        }
        public static void SetName(Student student, string name)
        {
            student.name = name;
        }
    }
}
