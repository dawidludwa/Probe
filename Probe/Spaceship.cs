using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Probe.Interfaces;

namespace Probe
{
    internal class Spaceship : ISpaceship
	{
		public string Name { get; internal set; }
		public ICrew Crew { get; internal set; }
		public double Speed { get; internal set; }
		public int Range { get; internal set; }
		public IWeapon Weapon { get; internal set; }
		public IShield Shield { get; internal set; }
		public ICargo Cargo { get; internal set; }
		public IFuel Fuel { get; internal set; }
		public int Price { get; internal set; }
	}
}
