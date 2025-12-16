using ManagementDomain.Modals;

namespace Management.Application.Services
{
    public class StudentServices
    {

        public DbContext DbContext { get; set; }
        public StudentServices()
        {
            this.DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName);
        
       
            
          
    }


}

