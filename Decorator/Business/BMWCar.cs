using Decorator.Abstractions;

namespace Decorator.Business
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";
        private string CarBody { get; set; }
        private string CarDoor { get; set; }
        private string CarWheels { get; set; }
        private string CarGlass { get; set; }
        public string Engine { get; set; }

        public override string ToString()
        {
            return "BMWCar [CarName=" + CarName + ", CarBody=" + CarBody + ", CarDoor=" + CarDoor + ", CarWheels="
                   + CarWheels + ", CarGlass=" + CarGlass + ", Engine=" + Engine + "]";
        }

        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarWheels = "6 car glasses";
            CarGlass = "4 MRF wheels";
            return this;
        }
    }
}