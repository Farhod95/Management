using Management.Application;

namespace Management.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService();
            studentService.AddStudent("Karim", "Soliyev");
            studentService.AddStudent("Isroil", "Abduraxmanov");

        }
    }
}
