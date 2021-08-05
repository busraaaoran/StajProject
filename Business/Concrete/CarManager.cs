using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;
        public CarManager(ICarDal carDal, IBrandService brandService)
        {
            _carDal = carDal;
            _brandService = brandService;
        }
        
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfBrandCountCorrect(car.BrandId), CheckIfCarLicencePlateAlreadyExist(car.LicencePlate));

            if (result!=null)
            {
                return result;
            }

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
           
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if(DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);

        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id),Messages.CarInfoDisplayed);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }

        private IResult CheckIfBrandCountCorrect(int brandId)
        {
            var result = _carDal.GetAll(c => c.BrandId == brandId).Count;
            if (result >= 50)
            {
                return new ErrorResult(Messages.CarBrandCountError);
            }

            return new SuccessResult();
        }

        private IResult CheckIfCarLicencePlateAlreadyExist(string licencePlate)
        {
            var result = _carDal.GetAll(c => c.LicencePlate == licencePlate).Count;

            if (result > 0)
            {
                return new ErrorResult(Messages.CarLicencePlateAlreadyExists);
            }

            return new SuccessResult();
        }

        private IResult checkbrandnumber()
        {
            var result = _brandService.GetAll();

            if (result.Data.Count > 15)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}
