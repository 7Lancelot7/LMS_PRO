using System;
using System.Drawing;

namespace VendingCoffeeMachine
{
    /// <summary>
    /// Represents a cup for holding coffee, sugar, water, and milk.
    /// </summary>
    public class Cup : CupBase
    {
        /// <summary>
        /// Mix the contents of the cup.
        /// </summary>
        public override void Stir()
        {
            Console.WriteLine("Stir... Stir...");
            Console.WriteLine("The drink is ready!");
        }

        /// <summary>
        /// Initializes a new instance of the Cup class.
        /// </summary>
        public Cup()
        {
        }
    }
}