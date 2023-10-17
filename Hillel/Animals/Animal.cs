namespace Animals;

public abstract class Animal
{
    /// <summary>
    /// Gets the unique identifier for the animal.
    /// </summary>
    private static int Id { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the animal.
    /// </summary>
    public string Name { get; protected set; }
    
    /// <summary>
    /// Gets or sets the age of the animal.
    /// </summary>
    public int Age { get; protected set; }

    /// <summary>
    /// Makes the animal move.
    /// </summary>
    public virtual void Move()
    {
        Console.WriteLine("Moving...");
    }

    /// <summary>
    /// Makes the animal produce sounds.
    /// </summary>
    public virtual void Speak()
    {
        Console.WriteLine("Strange sounds");
    }
    //In my opinion is better to use abstract methods
    
    
    //public abstract void Move(); 
    //public abstract void Speak();

    /// <summary>
    /// Default constructor for the Animal class.
    /// </summary>
    protected Animal()
    {
        Id++;
    }

    /// <summary>
    /// Constructor for the Animal class with specified name and age.
    /// </summary>
    /// <param name="name">The name of the animal.</param>
    /// <param name="age">The age of the animal.</param>
    protected Animal(string name, int age)
    {
        Id++;
        Name = name;
        Age = age;
    }
}
