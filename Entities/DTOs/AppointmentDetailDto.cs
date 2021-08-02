using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AppointmentDetailDto:IDto
    {
        public int ApptId { get; set; }

        public string BrandName { get; set; }

        public string CustomerName { get; set; }

        public string ServiceName { get; set; }
    }
}
