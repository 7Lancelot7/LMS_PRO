namespace Animals.Fish
{
    /// <summary>
    /// Represents a Dorado, a type of Fish.
    /// </summary>
    public class Dorado : Fish
    {
        /// <summary>
        /// Makes the Dorado move by swimming.
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Just swimming...");
        }

        /// <summary>
        /// Creates a new instance of Dorado with specified name and age.
        /// </summary>
        /// <param name="name">The name of the Dorado.</param>
        /// <param name="age">The age of the Dorado.</param>
        public Dorado(string name, int age) : base(name, age)
        {
        }
    }
}