// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


//Car car = new Car{ BrandId=2, ColorId=2, CarName="Turhan's Car", DailyPrice=950, ModelYear=2016, Description="For family travelings!"  };

CarManager carManager = new CarManager(new EfCarDal());
UserManager userManager = new UserManager(new EfUserDal());
CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
BrandManager brandManager = new BrandManager(new EfBrandDal());
RentalManager rentalManager = new RentalManager(new EfRentalDal());

User user1 = new User { FirstName="Mustafa", LastName="Kaya", Email="mustafa@gmail.com", Password="123" };
User user2 = new User { FirstName="Berkay", LastName="Gürcan", Email="berkay@gmail.com", Password="123" };
User user3 = new User { FirstName="Avni Berka", LastName="Daloğlu", Email="avniberka@gmail.com", Password="123" };

Customer customer1 = new Customer { UserId=1, CompanyName="Kayaoğulları Holding" };
Customer customer2 = new Customer { UserId=2, CompanyName="Gurcan Holding" };
Customer customer3 = new Customer { UserId=3, CompanyName="Dalogullari Holding" };

Color color1 = new Color { Name = "Green" };
Color color2 = new Color { Name = "Blue" };

Brand brand1 = new Brand { Name = "TOGG" };
Brand brand2 = new Brand { Name = "Renault" };
Brand brand3 = new Brand { Name = "Ferrari" };

Car car1 = new Car { BrandId = 1, ColorId = 3, CarName = "Türkiye'nin Arabası", ModelYear = 2022, DailyPrice = 550, Description = "For family usage!"};
Car car2 = new Car { BrandId = 3, ColorId = 2, CarName = "Red devil", ModelYear = 2020, DailyPrice = 1250, Description = "For race!"};
Car car3 = new Car { BrandId = 2, ColorId = 1, CarName = "Je Mapple Em", ModelYear = 2017, DailyPrice = 250, Description = "For family usage!"};

Rental rental1 = new Rental { CarId = 4, CustomerId = 1, RentDate = DateTime.Now.ToUniversalTime() };
rentalManager.Add(rental1);

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