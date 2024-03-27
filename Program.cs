using CodingChallenge.MainMenu;

namespace CodingChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PetPals";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("            WELCOME TO Pet Pals           ");
            Console.WriteLine("-------------------------------------------------\n");
            Console.ResetColor();

            PetPals petPals = new PetPals();
            petPals.Handlemenu();

            Console.WriteLine("\nThank you for visiting! Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
