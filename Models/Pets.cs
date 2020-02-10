using km956216_MIS4200_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace km956216_MIS4200.Models
{
    public class Pets
    {
        public int petsID { get; set; }
        public string petName { get; set; }
        public string description { get; set; }

        public string age { get; set; }

        public ICollection<appointmentDetails> appointmentDetails { get; set; }

        public int vetsID { get; set; }

        public virtual Vets vets { get; set; }


    }
}