using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string BedSize { get; set; }
        public bool FourWheelDrive { get; set; }

        public int NumberOfDoors { get; set; }
        public bool HasCupholders { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasSunroof { get; set; }

        public string Slogan { get; set; }
        public bool IsWorldwide { get; set; }

        public void PrintVehicleDetails()
        {
            Console.WriteLine(BedSize);
            Console.WriteLine(FourWheelDrive);
            Console.WriteLine(NumberOfDoors);
            Console.WriteLine(HasCupholders);
            Console.WriteLine(NumberOfSeats);
            Console.WriteLine(HasSunroof);
        }
        public void PrintCompanyDetails()
        {
            Console.WriteLine(Slogan);
            Console.WriteLine(IsWorldwide);
        }
    }
}

