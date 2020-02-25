using km956216_MIS4200_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace km956216_MIS4200.Models
{
    public class Vets
    {
        
        public int vetsID { get; set; }
        [Display(Name = "Vet First Name")]
        [Required(ErrorMessage ="Vet Name is Required")]
        [StringLength(20)]
        public string vetFirstName { get; set; }
        [Display(Name = "Vet Last Name")]
        [Required(ErrorMessage = "Vet Last Name Required")]
        [StringLength(20)]
        public string vetLastName { get; set; }
        [Display(Name = "Vet Age")]
        [Required(ErrorMessage = "Vet Age is Required")]
        [StringLength(20)]
        public string age { get; set; }


        //public ICollection<appointmentDetails> appointmentDetails { get; set; }
        public string FullName
        {
            get { return vetLastName + ", "+ vetFirstName;  }


        }

    }
}