using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICSService
    {
        IDataResult<List<CarService>> GetAll();

        IDataResult<CarService> GetById(int id);

        IResult Add(CarService carService);

        IResult Delete(CarService carService);

        IResult Update(CarService carService);
    }
}
