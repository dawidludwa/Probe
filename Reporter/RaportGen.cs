
using Probe.Interfaces;
using System.Text;

namespace RaportGen
{
	public class RaportGen
	{
		public string PrintDetails(ISpaceship spaceship)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(spaceship.Name);
			sb.AppendLine("Crew: " + spaceship.Crew);
			sb.AppendLine("Speed: " + spaceship.Speed);
			sb.AppendLine("Range: " + spaceship.Range);
			sb.AppendLine("Weapon: " + spaceship.Weapon);
			sb.AppendLine("Shield: " + spaceship.Shield);
			sb.AppendLine("Cargo: " + spaceship.Cargo);
			sb.AppendLine("Fuel: " + spaceship.Fuel);
			sb.AppendLine("Price: " + spaceship.Price);

			return sb.ToString();
		}
	}
}
