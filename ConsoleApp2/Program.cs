namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int height = 0;
            string gender = "";

            Console.WriteLine("Hello, World!");
            Console.WriteLine("My name is Ekkasit Srisuk");
            Console.WriteLine("Please input your full name (ENG):");
            Console.WriteLine("Computer Science Program");
            while (name.Length < 2)
            {
                name = Console.ReadLine();

            }

            Console.Write("Please enter your gender (m or f): "); 
            while (gender.ToLower() != "m" && gender.ToLower() != "f")
            {
                
                gender = Console.ReadLine();
                
                if (gender.ToLower() != "m" && gender.ToLower() != "f")
                {
                    Console.Write("Invalid gender! Please enter m or f: ");
                }
            }
            Console.WriteLine("Please fill in your height (cm): ");
                while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
                {
                    Console.WriteLine("Invalid height! Please enter a number greater than 0:");
                    Console.Write("Try again: ");
                }
                int Weight = height - 100;
                Console.WriteLine("Your ideal weight is " + Weight + " kg");
                Console.ReadKey();
                Console.WriteLine("------------------+++++-------------------");
                Console.Write("My Hometown is ");
                Console.Write("Udon Thani ");
                Console.WriteLine("Thailand");
            
        }
    }
}
