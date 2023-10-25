using System.Threading.Channels;
using VendingCoffeeMachine.Contracts;

namespace VendingCoffeeMachine;

/// <summary>
/// Base class representing a cup that can hold coffee, sugar, water, and milk.
/// </summary>
public abstract class CupBase : ICoffee, ISugar, IWater, IMilk
{
    /// <summary>
    /// Mix the contents of the cup.
    /// </summary>
    public abstract void Stir();

    /// <summary>
    /// Protected constructor for CupBase.
    /// </summary>
    protected CupBase()
    {
    }

    /// <summary>
    /// Add coffee to the cup.
    /// </summary>
    public void AddCoffee()
    {
        Console.WriteLine("Coffee was added");
    }

    /// <summary>
    /// Add sugar to the cup.
    /// </summary>
    public void AddSugar()
    {
        Console.WriteLine("Sugar was added");
    }

    /// <summary>
    /// Add water to the cup.
    /// </summary>
    public void AddWater()
    {
        Console.WriteLine("Water was added");
    }

    /// <summary>
    /// Add milk to the cup.
    /// </summary>
    public void AddMilk()
    {
        Console.WriteLine("Milk was added");
    }
}
