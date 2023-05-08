using Probe.Interfaces;

namespace Probe
{
	public interface ISpaceshipBuilderBasicDir
	{
		SpaceshipBuilder Builder { set; }

		Spaceship BuildLargeProbe(ICrewFactory crewFactory, IWeaponFactory weaponFactory, IShieldFactory shieldFactory, ICargoFactory cargoFactory, IFuelFactory fuelFactory);
		Spaceship BuildMediumProbe(ICrewFactory crewFactory, IWeaponFactory weaponFactory, IShieldFactory shieldFactory, ICargoFactory cargoFactory, IFuelFactory fuelFactory);
		Spaceship BuildSmallProbe(ICrewFactory crewFactory, IWeaponFactory weaponFactory, IShieldFactory shieldFactory, ICargoFactory cargoFactory, IFuelFactory fuelFactory);
	}
}