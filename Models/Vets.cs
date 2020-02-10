using km956216_MIS4200_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace km956216_MIS4200.Models
{
    public class Vets
    {

        public int vetsID { get; set; }
        public string vetFirstName { get; set; }
        public string vetLastName { get; set; }

        public string age { get; set; }
        public string patients { get; set; }

        public ICollection<appointmentDetails> appointmentDetails { get; set; }


    }
}