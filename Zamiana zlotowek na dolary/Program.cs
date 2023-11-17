namespace Zamiana_zlotowek_na_dolary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zamiana złotówek na dolary");
            Console.WriteLine("Podaj kwotę w złotówkach:");
            float pln = float.Parse(Console.ReadLine());

            Console.WriteLine("Podana kwota zamieniona na dolary wynosi: $" + Math.Round((pln * 4.03), 2));
        }
    }
}