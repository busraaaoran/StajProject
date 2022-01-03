using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAppointmentDal : EfEntityRepositoryBase<Appointment, ProjectDbContext>, IAppointmentDal
    {
        public List<AppointmentDetailDto> GetAppointmentDetails()
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                var result = from a in context.Appointments
                             join cu in context.Customers on a.CustomerId equals cu.CustomerId
                             join s in context.CarServices on a.ServiceId equals s.ServiceId
                             join c in context.Cars on a.CarId equals c.CarId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new AppointmentDetailDto
                             {
                                 ServiceName = s.ServiceName,
                                 ApptId = a.ApptId,
                                 BrandName = b.BrandName,
                                 CustomerName = cu.FirstName + " " + cu.LastName,
                                 ApptDate = a.ApptDate,
                                 LicencePlate = c.LicencePlate
                             };
                
                return result.ToList();

            }

           
        }
    }
}
