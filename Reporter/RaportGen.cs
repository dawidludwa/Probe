
using Probe.Interfaces;

namespace RaportGen
{
	internal class RaportGen
	{
		public void PrintDetails(ISpaceship spaceship)
		{
			Console.WriteLine(spaceship.Name);
		}
	}
}
