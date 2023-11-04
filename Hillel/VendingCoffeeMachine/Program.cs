using System;
using System.Text;
using VendingCoffeeMachine;
using VendingCoffeeMachine.Contracts;

class Program
{
    public static void AddCoffee(ICoffee coffee)
    {
        coffee.AddCoffee();
    } 
    public static void AddSugar(ISugar coffee)
    {
        coffee.AddSugar();
    } 
    public static void AddWater(IWater coffee)
    {
        coffee.AddWater();
    } 
    public static void AddMilk(IMilk coffee)
    {
        coffee.AddMilk();
    } 
    
    public static void Main()
    {
        Cup cup = new Cup();
        //cup.Stir();
        AddCoffee(cup);
        AddWater(cup);
        AddMilk(cup);
        AddSugar(cup);
        cup.Stir();
       
    }
}