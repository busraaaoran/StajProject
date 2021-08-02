using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CarService:IEntity
    {
        [Key]
        public int ServiceId { get; set; }

        public string PhoneNo { get; set; }

        public string ServiceName { get; set; }

        public string Address { get; set; }

    }
}
