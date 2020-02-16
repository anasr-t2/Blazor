using System;
using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopHRM.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="First Name is required.")]
        [StringLength(50,ErrorMessage = "First Name is too long.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name is too long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "BOD is required.")]
        [DataType(DataType.Date,ErrorMessage ="BOD must be a date")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage ="Email must be a valid email address")]
        public string Email { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string PhoneNumber { get; set; }
        public bool Smoker { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public string Comment { get; set; }
        [Required(ErrorMessage = "Joined Date is required.")]
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }
        
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
