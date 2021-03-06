//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RR2_MVC_10152019.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Employee
    {
        public int EmployeeID { get; set; }
        
        [Required(ErrorMessage ="Please enter a first name.")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a middle name.")]
        [StringLength(20)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your street address.")]
        [StringLength(20)]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter your city.")]
        [StringLength(20)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state abbreviation")]
        [StringLength(2)]
        public string State { get; set; }

        [RegularExpression(@"^\d{5}-\d{4}|\d{5}|[A-Z]\d[A-Z] \d[A-Z]\d$", ErrorMessage = "Zip should be something like 90032")]
        public string Zip { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-..]?([0-9]{3})[-..]?([0-9]{4})$", ErrorMessage = "This is not a valid phone number - should be like 6264577866")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "An email is required.")]
        [RegularExpression(@"\w+([-+.']w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email is not valid! Try something like victorazula@krebner.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A valid social security number is required.")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "The SSN you entered is not valid!")]
        public string SSN { get; set; }

        [Required(ErrorMessage = "Annual income is required.")]
        [Range(1, 200000, ErrorMessage = "Income must be between 1 and 200000 dollars.")]
        public Nullable<decimal> Income { get; set; }

        [Required(ErrorMessage = "Please enter a Job Title.")]
        [StringLength(20)]
        public string JobTitle { get; set; }
    }
}
