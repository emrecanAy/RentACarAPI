using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if(car.CarName.Length < 2 && car.DailyPrice > 0)
            {
                return new ErrorResult(Messages.EntityNameAndPriceInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.EntityAdded);
        }

        public IResult Delete(Car car)
        {
            if(car == null)
            {
                return new ErrorResult(Messages.EntityDoesntExists);
            }
            return new SuccessResult(Messages.EntityDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.EntitesListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(car => car.Id == id), Messages.EntitesListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.BrandId == brandId), Messages.EntitesListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.ColorId == colorId), Messages.EntitesListed);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.EntityUpdated);
        }
    }
}
