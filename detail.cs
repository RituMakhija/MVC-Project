//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SLKPortal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class detail
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please Enter your First Name", AllowEmptyStrings =false)]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Please Enter your Last Name", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter your Phone Number", AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter the Gender", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Enter your Date of Birth", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please Enter your Email-ID", AllowEmptyStrings = false)]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Please Enter your Address", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter your city", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter the Zip Code", AllowEmptyStrings = false)]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please Enter your State", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string State { get; set; }
        [Required(ErrorMessage = "Please Enter your Country", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please Enter your chosen Department", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please Enter your Tenth Board", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string TenthBoard { get; set; }
        [Required(ErrorMessage = "Please Enter your Tenth Marks", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public Nullable<int> TenthMarks { get; set; }
        [Required(ErrorMessage = "Please Enter your Twelfth Board", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string TwelfthBoard { get; set; }
        [Required(ErrorMessage = "Please Enter your Twelfth Marks", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public Nullable<int> TwelfthMarks { get; set; }
        
        public virtual registration registration { get; set; }
    }

    public enum Department
    {
        [Display(Name ="Computer Science")]
        ComputerScience,
        [Display(Name = "Information Science")]
        InformationScience,
        ElectronicsAndCommunication,
    }
}
