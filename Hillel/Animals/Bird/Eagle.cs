namespace Animals.Bird
{
    /// <summary>
    /// Represents an Eagle, a type of Bird.
    /// </summary>
    public class Eagle : Bird
    {
        /// <summary>
        /// Makes the eagle produce its characteristic sound - a screech.
        /// </summary>
        public override void Speak()
        {
            Console.WriteLine("Screech...");
        }

        /// <summary>
        /// Creates a new instance of Eagle with specified name and age.
        /// </summary>
        /// <param name="name">The name of the eagle.</param>
        /// <param name="age">The age of the eagle.</param>
        public Eagle(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}