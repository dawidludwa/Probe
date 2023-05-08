using Probe.Interfaces;

namespace Probe
{
	internal class SpaceshipBuilderBasicDir : ISpaceshipBuilderBasicDir
	{
		private SpaceshipBuilder builder;

		public SpaceshipBuilder Builder { set { builder = value; } }

		public Spaceship BuildSmallProbe(ICrewFactory crewFactory, IWeaponFactory weaponFactory, IShieldFactory shieldFactory, ICargoFactory cargoFactory, IFuelFactory fuelFactory)
		{
			builder.Reset();
			builder.WithName("Small Probe")
				.WithSpeed(1.0)
				.WithRange(1)
				.WithWeapon(weaponFactory.Create())
				.WithShield(shieldFactory.Create())
				.WithCargo(cargoFactory.Create())
				.WithFuel(fuelFactory.Create())
				.WithPrice(1);
			return builder.Build();
		}

		public Spaceship BuildMediumProbe(ICrewFactory crewFactory, IWeaponFactory weaponFactory, IShieldFactory shieldFactory, ICargoFactory cargoFactory, IFuelFactory fuelFactory)
		{
			builder.Reset();
			builder.WithName("Medium Probe")
				.WithSpeed(2.0)
				.WithRange(2)
				.WithWeapon(weaponFactory.Create())
				.WithShield(shieldFactory.Create())
				.WithCargo(cargoFactory.Create())
				.WithFuel(fuelFactory.Create())
				.WithPrice(2);
			return builder.Build();
		}

		public Spaceship BuildLargeProbe(ICrewFactory crewFactory, IWeaponFactory weaponFactory, IShieldFactory shieldFactory, ICargoFactory cargoFactory, IFuelFactory fuelFactory)
		{
			builder.Reset();
			builder.WithName("Small Spaceship")
				.WithCrew(crewFactory.Create())
				.WithSpeed(3.0)
				.WithRange(3)
				.WithWeapon(weaponFactory.Create())
				.WithShield(shieldFactory.Create())
				.WithCargo(cargoFactory.Create())
				.WithFuel(fuelFactory.Create())
				.WithPrice(3);
			return builder.Build();
		}
	}
}
