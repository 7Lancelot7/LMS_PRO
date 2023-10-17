namespace Animals.Bird
{
    /// <summary>
    /// Represents an Owl, a type of Bird.
    /// </summary>
    public class Owl : Bird
    {
        /// <summary>
        /// Makes the owl produce its characteristic sound - hooting.
        /// </summary>
        public override void Speak()
        {
            Console.WriteLine("Hooting...");
        }

        /// <summary>
        /// Creates a new instance of Owl with specified name and age.
        /// </summary>
        /// <param name="name">The name of the owl.</param>
        /// <param name="age">The age of the owl.</param>
        public Owl(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}