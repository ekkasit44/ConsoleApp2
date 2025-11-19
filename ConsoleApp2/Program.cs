namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ekkasit Srisuk";
            int height = 0;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("My name is Ekkasit srisuk");
            Console.WriteLine("please, input your full name (ENG):");
            Console.WriteLine("Computer science Program");
            name = Console.ReadLine();
            Console.WriteLine("Hello Welcome"+name);
            Console.WriteLine("Please, fill in you height(cm) : ");
            height = Convert.ToInt16(Console.ReadLine());
            int Weight = height - 100;
            Console.WriteLine("You ideal weight is" + Weight.ToString());
            Console.ReadKey();



            Console.WriteLine("------------------+++++-------------------");
            Console.Write("My Hometown is");
            Console.Write("Udon thani");
            Console.WriteLine("Thailand");

        }
    }
}
