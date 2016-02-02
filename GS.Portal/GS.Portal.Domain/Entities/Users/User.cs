using System;

namespace GS.Portal.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public string Role { get; set; }
        public DateTime DateOfJoining { get; set; }
        //public int EmployeeSequence { get; set; }
    }
}
