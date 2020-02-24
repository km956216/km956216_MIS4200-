using km956216_MIS4200_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace km956216_MIS4200.Models
{
    public class Pets
    {
        public int petsID { get; set; }
        [Display (Name = "Pet Name" )]
        [Required(ErrorMessage = "Pet Name is Required")]
        [StringLength(20)]
        public string petName { get; set; }
        [Display(Name = "Pet Description")]
        [Required(ErrorMessage = "Pet Description is Required")]
        [StringLength(20)]


        public string description { get; set; }
        [Display(Name = "Pet Age")]
        [Required(ErrorMessage = "Pet Age is Required")]
        [StringLength(5)]

        public string age { get; set; }
        
        //public ICollection<appointmentDetails> appointmentDetails { get; set; }
        
        public int vetsID { get; set; }

        
        public virtual Vets vets { get; set; }


        


    }
}