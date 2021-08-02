using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public IResult Add(Appointment appointment)
        {
            if (appointment.ApptDate > DateTime.Now)
            {
                return new ErrorResult(Messages.CustomerIdInvalid);
            }
            _appointmentDal.Add(appointment);

            return new SuccessResult(Messages.AppointmentScheduled);
        }

        public IResult Delete(Appointment appointment)
        {
            _appointmentDal.Delete(appointment);

            return new SuccessResult(Messages.ApptDeleted);
        }

        public IDataResult<List<Appointment>> GetAll()
        {
            if (DateTime.Now.Hour == 20)
            {
                return new ErrorDataResult<List<Appointment>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(),Messages.ApptsListed);
        }

        public IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails()
        {
            return new SuccessDataResult<List<AppointmentDetailDto>>(_appointmentDal.GetAppointmentDetails());
        }
        
        public IDataResult<Appointment> GetById(int id)
        {
            return new SuccessDataResult<Appointment>(_appointmentDal.Get(a => a.ApptId == id));
        }

        public IResult Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);

            return new SuccessResult(Messages.ApptUpdated);
        }
    }
}
