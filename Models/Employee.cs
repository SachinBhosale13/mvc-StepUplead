using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabets are allowed")]
        [Display(Name = "First name")]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabets are allowed")]
        [Display(Name = "Last name")]
        public string last_name { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Company name")]
        public string company_name { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Company size")]
        public string company_size { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Job role")]
        public string job_role { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Job department")]
        public string job_dept { get; set; }
        
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only numbers are allowed.")]        
        [Display(Name = "Phone")]
        public string phone { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Country")]
        public string country { get; set; }

        [Required]        
        public string ip_address { get; set; }

        [Required]        
        public string browser_details { get; set; }

        [Required]        
        public string url_link { get; set; }

        [Required]        
        public string os_info { get; set; }

    }
}
