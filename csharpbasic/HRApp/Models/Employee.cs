using HRApp.Enums;
namespace HRApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public DateTime JoiningDate { get; set; }

        public Gender Gender { get; set; }

    }
}