using System;
using System.ComponentModel.DataAnnotations;


namespace HRApplicationAR.Models
{
    public class Employee
    {
        //neme
        [Required(ErrorMessage = "Please Enter Name.")]
        [StringLength(20,MinimumLength = 3)]
        public string EmployeeName { get; set; }

        //department
        [Required(ErrorMessage = "Please Select Department.")]
        public string Department { get; set; }

        //is Active
        [Required(ErrorMessage = "The value 'is invalid'")]
        public bool isActive { get; set; }

        //Job Title
        [Required(ErrorMessage = "Job Title is Missing.")]
        [DataType(DataType.Text)]
        public string JobTitle { get; set; }

        //Date of Birth
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        //Email
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}
