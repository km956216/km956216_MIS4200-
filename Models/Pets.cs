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
        public int vetId { get; set; }
        public virtual Vets vets { get; set; }

    }
}