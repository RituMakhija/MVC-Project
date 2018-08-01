using System;  
using System.ComponentModel.DataAnnotations;  
  
namespace CalenderControlInMVCUsingjQuery.Models
{
    public class EmpModel
    {
        [Display(Name = "Enter Date")]
        public DateTime EnterDate { get; set; }
    }
}