using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{	 
		public int HorsePower { get; set; }
		public bool FoldFlatSeats  { get; set; }

        public int NumberOfDoors { get; set; }
        public bool HasCupholders { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasSunroof { get; set; }

        public string Slogan { get; set; }
        public bool IsWorldwide { get; set; }

        public void PrintVehicleDetails()
        {
            Console.WriteLine(HorsePower);
            Console.WriteLine(FoldFlatSeats);
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
