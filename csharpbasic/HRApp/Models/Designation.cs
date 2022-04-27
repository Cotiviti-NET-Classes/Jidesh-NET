using System;
using System.ComponentModel.DataAnnotations;


namespace HRApp.Models
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }
        [Required]
        public string DesignationName { get; set; }
        public double Compensation { get; set; }

        public List<Employee>? employees{get;set;}
    }
}