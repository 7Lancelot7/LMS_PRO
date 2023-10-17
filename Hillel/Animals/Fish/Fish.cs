namespace Animals.Fish
{
    /// <summary>
    /// Represents a Fish, a type of Animal.
    /// </summary>
    public class Fish : Animal
    {
        /// <summary>
        /// Default constructor for the Fish class.
        /// </summary>
        protected Fish()
        {
        }

        /// <summary>
        /// Constructor for the Fish class with specified name and age.
        /// </summary>
        /// <param name="name">The name of the fish.</param>
        /// <param name="age">The age of the fish.</param>
        public Fish(string name, int age) : base(name, age)
        {
        }

        /// <summary>
        /// Makes the fish move by swimming.
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Swimming...");
        }

        /// <summary>
        /// Produces a sound specific to fish.
        /// </summary>
        public sealed override void Speak()
        {
            Console.WriteLine("bubble bubble...");
        }
    }
}