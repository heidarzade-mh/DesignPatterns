using System;
using Decorator.Abstractions;

namespace Decorator.Business
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
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

            bmwCar.Engine = "Diesel Engine";
            Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
        }
    }
}