using AutoFixture;
using Moq;
using Moq.AutoMock;
using Probe.Interfaces;

namespace TestProject1
{
	public class PrintDetailsTest
	{
		[Fact]
		public void Raport1()
		{

			var mocker = new AutoMocker();

			var raportGen = mocker.CreateInstance<RaportGen.RaportGen>();

			var spaceshipObj = new Mock<ISpaceship>();
			spaceshipObj.Setup(x => x.Name).Returns("lol");

			var result = raportGen.PrintDetails(spaceshipObj.Object);

			string expected = "lol\r\nCrew: \r\nSpeed: 0\r\nRange: 0\r\nWeapon: \r\nShield: \r\nCargo: \r\nFuel: \r\nPrice: 0\r\n";
			Assert.Equal(expected, result);
		}
	}
}