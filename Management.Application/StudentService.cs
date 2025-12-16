using Management.Domain.Models;
using Management.Infrastructure.Data;

namespace Management.Application
{
    public class StudentService
    {
        public DbContext DbContext { get; set; }
        public StudentService()
        {
            this.DbContext=new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
        {
            if(this.DbContext.StudentCount >= this.DbContext.Students.Length)
            {
                return;
            }
            Student newStudent = new Student
            {
                Id = new Random().Next(1, 1000).ToString(),
                FirstName = firstName,
                LastName = lastName
            };

            this.DbContext.Students[this.DbContext.StudentCount] = newStudent;
            this.DbContext.StudentCount++;
        }

        public Student[] GetStudents()
        {
          return this.DbContext.Students;
        }
    }
}