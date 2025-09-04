namespace cs_classCDA25
{

    public class Human
    {
        public String Name;
        public int Age;
        public int StepsWalked = 0;

        public void Introduce()
        {
            Console.WriteLine($"Hello my name is {Name} and I am {Age} years old.");
        }

        public void Walk(int steps)
        {
            StepsWalked += steps; //(sum = sum + n) = (+=)

            if (steps > 1)
            {
                Console.WriteLine($"{Name} took {steps} steps.\nTotal: {StepsWalked} steps.");
            }
            else if (steps == 1)
            {
                Console.WriteLine($"{Name} took a step. \nTotal: {StepsWalked} steps.");
            }
            else
            {
                Console.WriteLine($"{Name} took no steps. \nTotal: {StepsWalked} steps.");
            }

        }

        public void Greet(Human h)
        {
            Console.WriteLine($"{Name} Greets {h.Name}");
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {



            //HUMAN OBJECTS

            //Me (human1)
            Human human1 = new Human();
            human1.Name = "Artin";
            human1.Age = 21;

            human1.Introduce();
            human1.Walk(5);

            //Baba (human2)
            Human human2 = new Human();
            human2.Name = "Mehdi";
            human2.Age = 54;

            human2.Introduce();

            human1.Greet(human2);

            /*//Mama (human3)
            Human human3 = new Human();
            human3.Name = "Simin";
            human3.Age = 56;

            human3.Introduce();*/


        }
    }
}