using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRApp.Enums;
namespace HRApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public int DesignationId { get; set; }
        public Designation? Designation { get; set; }
        // [ForeignKey("Dept")]
        // public int DeptID{get;set;}
        // [ForeignKey("Designation")]
        // public int DesignationID{get;set;}
        // public virtual Department Dept { get; set; }
        // public virtual Designation Designation { get; set; }

    }
}