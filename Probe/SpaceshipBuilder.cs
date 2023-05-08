using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probe
{
	internal class SpaceshipBuilder
	{
		private Spaceship spaceship;
		public SpaceshipBuilder()
		{
			Reset();
		}
		public SpaceshipBuilder WithName(string name)
		{
			spaceship.Name = name;
			return this;
		}
		public SpaceshipBuilder WithCrew(ICrew crew)
		{
			spaceship.Crew = crew;
			return this;
		}
		public SpaceshipBuilder WithSpeed(double speed)
		{
			spaceship.Speed = speed;
			return this;
		}
		public SpaceshipBuilder WithRange(int range)
		{
			spaceship.Range = range;
			return this;
		}
		public SpaceshipBuilder WithWeapon(IWeapon weapon)
		{
			spaceship.Weapon = weapon;
			return this;
		}
		public SpaceshipBuilder WithShield(IShield shield)
		{
			spaceship.Shield = shield;
			return this;
		}
		public SpaceshipBuilder WithCargo(ICargo cargo)
		{
			spaceship.Cargo = cargo;
			return this;
		}
		public SpaceshipBuilder WithFuel(IFuel fuel)
		{
			spaceship.Fuel = fuel;
			return this;
		}
		public SpaceshipBuilder WithPrice(int price)
		{
			spaceship.Price = price;
			return this;
		}
		public Spaceship Build()
		{
			return spaceship;
		}

		public void Reset()
		{
			this.spaceship = new Spaceship();
		}
	}
}
