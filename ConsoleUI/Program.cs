// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


//Car car = new Car{ BrandId=2, ColorId=2, CarName="Turhan's Car", DailyPrice=950, ModelYear=2016, Description="For family travelings!"  };

//CarManager carManager = new CarManager(new EfCarDal());

//AddTest(car, carManager);

static void AddTest(Car car, CarManager carManager)
{
    try
    {
        carManager.Add(car);
        Console.WriteLine("Success!");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void GetAllTest(CarManager carManager)
{
    carManager.GetAll().Data.ForEach(car =>
    {
        Console.WriteLine(car.CarName);
    });
}