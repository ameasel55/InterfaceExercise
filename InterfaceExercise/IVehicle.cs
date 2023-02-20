using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int NumberOfDoors { get; set; }
		public bool HasCupholders { get; set; }
		public int NumberOfSeats { get; set; }
		public bool HasSunroof{ get; set; }

		public void PrintVehicleDetails();
	}
}

