using Animals.Bird;
using Animals.Fish;
using Animals.Mammal;

namespace Animals
{
    public class Program
    {
        public static void Main()
        {
            var mammal = new Mammal.Mammal("mammal", 1);
            var cat = new Cat("cat", 2);
            var dog = new Dog("dog", 3);

            mammal.Move();
            mammal.Speak();
            Console.WriteLine("##############");
            cat.Move();
            cat.Speak();
            Console.WriteLine("##############");
            dog.Move();
            dog.Speak();
            //---------------------------//

            var fish = new Fish.Fish("Fish", 4);
            var shark = new Shark("Shark", 5);
            var dorado = new Dorado("Dorado", 6);

            fish.Move();
            fish.Speak();
            Console.WriteLine("##############");
            shark.Move();
            shark.Speak();
            Console.WriteLine("##############");
            dorado.Move();
            dorado.Speak();
            //---------------------------//

            var bird = new Bird.Bird("Bird", 7);
            var eagle = new Eagle("Eagle", 8);
            var owl = new Owl("Owl", 9);

            bird.Move();
            bird.Speak();
            Console.WriteLine("##############");
            eagle.Move();
            eagle.Speak();
            Console.WriteLine("##############");
            owl.Move();
            owl.Speak();
            Console.WriteLine();
            
        }
    }
}