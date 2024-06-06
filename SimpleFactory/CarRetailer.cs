using SimpleFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory;
public class CarRetailer
{
    public Car? Sell(string model)
    {
        var car = SimpleCarFactory.BuildCar(model);
        
        if(car == null)
        {
            Console.WriteLine("we don't have that");
            return null;
        }

        car.TestSteering();
        car.TestTires();
        car.SignDocuments();
        car.Shine();

        return car;
    }
}
