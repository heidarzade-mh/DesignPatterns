using System;
using Decorator.Abstractions;

namespace Decorator.Business
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }

        private static void AddEngine(ICar car)
        {
            if (car is not BMWCar bmwCar) return;
            
            bmwCar.Engine = "Petrol Engine";
            Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
        }
    }
}