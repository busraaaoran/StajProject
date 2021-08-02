using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        IDataResult<List<Appointment>> GetAll();

        IDataResult<Appointment> GetById(int id);

        IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails();

        IResult Add(Appointment appointment);

        IResult Delete(Appointment appointment);

        IResult Update(Appointment appointment);

    }
}
