using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarServiceManager : ICSService
    {
        ICarServiceDal _carServiceDal;

        public CarServiceManager(ICarServiceDal carServiceDal)
        {
            _carServiceDal = carServiceDal;
        }

        public IResult Add(CarService carService)
        {
            _carServiceDal.Add(carService);

            return new SuccessResult(Messages.CarServiceAdded);
        }

        public IResult Delete(CarService carService)
        {
            _carServiceDal.Delete(carService);

            return new SuccessResult(Messages.CarServiceDeleted);
        }

        public IDataResult<List<CarService>> GetAll()
        {
            return new SuccessDataResult<List<CarService>>(_carServiceDal.GetAll(), Messages.CarServicesListed);
        }

        public IDataResult<CarService> GetById(int id)
        {
            return new SuccessDataResult<CarService>(_carServiceDal.Get(cs => cs.ServiceId == id));
        }

        public IResult Update(CarService carService)
        {
            _carServiceDal.Update(carService);

            return new SuccessResult(Messages.CarServiceUpdated);
        }
    }
}
