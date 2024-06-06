using SimpleFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory;
public class SimpleCarFactory
{
    public static Car? BuildCar(string model)
    {
        var validatedModel = model.ToLower();
        // other validation...

        return validatedModel switch
        {
            "aston martin" => new AstonMartin(),
            "lada" => new Lada(),
            "reno" => new Reno(),
            _ => null
        };
    }
}
