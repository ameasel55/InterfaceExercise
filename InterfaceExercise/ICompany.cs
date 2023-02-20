using System;
namespace InterfaceExercise
{
	public interface ICompany
	{
		public string Slogan { get; set; }
		public bool IsWorldwide { get; set; }

		public void PrintCompanyDetails();
	}
}

