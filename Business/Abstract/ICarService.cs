﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetAllByBrandId(int id);

        IDataResult<Car> GetById(int id);

        IResult Add(Car car);

        IResult Delete(Car car);

        IResult Update(Car car);

        IResult AddTransactionalTest(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
