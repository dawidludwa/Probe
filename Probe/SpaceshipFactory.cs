using Probe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probe
{
	public class SpaceshipFactory
	{
		private readonly ICrewFactory crewFactory;

		public SpaceshipFactory(ICrewFactory crewFactory, IWeaponFactory weaponFactory, IShieldFactory shieldFactory, ICargoFactory cargoFactory, IFuelFactory fuelFactory)
		{
			this.crewFactory = crewFactory;
			

		}

		public ISpaceship Create()
		{
			SpaceshipBuilderBasicDir spaceshipBuilderBasicDir = new SpaceshipBuilderBasicDir();
			//return (ISpaceship)spaceshipBuilderBasicDir.BuildSmallProbe();

			return null;
		}
	}
}
