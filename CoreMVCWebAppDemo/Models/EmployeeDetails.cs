using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCWebAppDemo.Models
{
    public class EmployeeDetails
    {
       
        [Display(Name ="Employee Code" )]
        [Required]
        [StringLength(10)]
        public string EmployeeCode { get; set; }
        
        [Display(Name = "Employee Name")]
        [Required]
        public string EmployeeName { get; set; }
        [Display(Name = "Employee Designation")]
        public string EmployeeDesignation { get; set; }

    }
}
