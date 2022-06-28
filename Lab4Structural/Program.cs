namespace Lab4Structural
{
    internal class Program
    {
        static void Main()
        {
            Bouquet bouquet1 = new Bouquet("Bouquet of roses");
            bouquet1 = new GreetingCard(bouquet1, "Happy birthday!");
            bouquet1 = new Ribbon(bouquet1);

            Bouquet bouquet2 = new Bouquet("Bouquet of tulips");
            bouquet2 = new Ribbon(bouquet2);
            bouquet2 = new GreetingCard(bouquet2, "Happy Valentine's Day!");

            Console.WriteLine(bouquet1.Name);
            Console.WriteLine(bouquet2.Name);
        }
    }
}