using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Category
        
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Job Category")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "Job Details")]   
        public string CategoryDescription { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }


    }
}