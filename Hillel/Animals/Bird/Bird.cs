namespace Animals.Bird
{
    /// <summary>
    /// Represents a Bird, a type of Animal.
    /// </summary>
    public class Bird : Animal
    {
        /// <summary>
        /// Makes the bird move by flying.
        /// </summary>
        public sealed override void Move()
        {
            Console.WriteLine("Flying...");
        }

        /// <summary>
        /// Makes the bird produce its characteristic sound - tweeting.
        /// </summary>
        public override void Speak()
        {
            Console.WriteLine("Tweeting...");
        }

        /// <summary>
        /// Default constructor for the Bird class.
        /// </summary>
        protected Bird()
        {
        }

        /// <summary>
        /// Constructor for the Bird class with specified name and age.
        /// </summary>
        /// <param name="name">The name of the bird.</param>
        /// <param name="age">The age of the bird.</param>
        public Bird(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}