namespace Probe.Interfaces
{
    public interface ISpaceship
    {
        ICargo Cargo { get; }
        ICrew Crew { get; }
        IFuel Fuel { get; }
        string Name { get; }
        int Price { get; }
        int Range { get; }
        IShield Shield { get; }
        double Speed { get; }
        IWeapon Weapon { get; }
    }
}