namespace Animals.Fish
{
    /// <summary>
    /// Represents a Shark, a type of Fish.
    /// </summary>
    public class Shark : Fish
    {
        /// <summary>
        /// Makes the shark move by hunting.
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Hunting...");
        }

        /// <summary>
        /// Creates a new instance of Shark with specified name and age.
        /// </summary>
        /// <param name="name">The name of the shark.</param>
        /// <param name="age">The age of the shark.</param>
        public Shark(string name, int age) : base(name, age)
        {
        }
    }
}