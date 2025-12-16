using Management.Application;
using Management.Domain.Models;

namespace Management.Client
{
    internal class Program
    {
        static public StudentService studentService = new StudentService();

        private const int PAROL = 1234;
        static void Main(string[] args)
        {

            Console.WriteLine("\n Assalomu alaykum, xurmatli o'qituvchi !");

            int count = 1;
            do
            {
                Console.Write("\n Parolingizni kiriting: ");
                int parol = int.Parse(Console.ReadLine());
                if (parol == PAROL)
                {
                    ShowStudentMenu();
                }

            } while (count++ < 3);
        }

        public static void ShowStudentMenu()
        {
            Console.WriteLine(" Xush kelibsiz, Elbek !");
            Console.WriteLine(" Quyidagi menyudan birini tanlang:");
            Console.WriteLine(" 1. Yangi talaba qo'shish");
            Console.WriteLine(" 2. Talabalar ro'yxatini ko'rish");
            Console.WriteLine(" 3. Qabul soni");

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: AddStudent(); break;
                case 2: ShowStudents(); break;
                case 3:  ShowAcceptedCount(); break;
                default: Console.WriteLine(" Noto'g'ri tanlov!"); break;
            }
        }

        private static void AddStudent()
        {
            Console.Write(" Talabaning ismini kiriting: ");
            string firstName = Console.ReadLine();
            Console.Write(" Talabaning familiyasini kiriting: ");
            string lastName = Console.ReadLine();
            studentService.AddStudent(firstName, lastName);
            Console.WriteLine(" Talaba muvaffaqiyatli qo'shildi.");
        }

        private static void ShowStudents()
        {
            Student[] students = studentService.GetStudents();
            Console.WriteLine(" Talabalar ro'yxati:");
            foreach (var student in students)
            {
                if (student == null) continue;
                Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}");
            }
        }
        private static void ShowAcceptedCount()
        {
            Console.WriteLine($" Qabul qilingan talabalar soni: {studentService.DbContext.StudentCount}");
        }
    }
}