using km956216_MIS4200.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace km956216_MIS4200_.Models
{
    public class appointmentDetails
    {
        [Key]
        public int appointentDetailsID { get; set; }

        public DateTime dateTime { get; set; }

        public int petID { get; set; }

        public virtual Pets Pets { get; set; }

        public int vetID { get; set; }

        public virtual Vets Vets { get; set; }
    }
}