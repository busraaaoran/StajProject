using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Appointment:IEntity
    {
        [Key]
        public int ApptId { get; set; }

        public int CarId { get; set; }

        public int ServiceId { get; set; }

        public int CustomerId { get; set; }

        public DateTime ApptDate { get; set; }

    }
}
