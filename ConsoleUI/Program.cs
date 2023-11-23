// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


//Car car = new Car{ BrandId=1, ColorId=4, CarName="Test Car 2", DailyPrice=250, ModelYear=2021, Description="Test description 2."  };

//CarManager carManager = new CarManager(new EfCarDal());

//AddTest(car, carManager);
if(5 == 6)
{

}
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
    carManager.GetAll().ForEach(car =>
    {
        Console.WriteLine(car.CarName);
    });
}