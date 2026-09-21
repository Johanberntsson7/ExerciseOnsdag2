namespace ExerciseOnsdag2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Här skapar jag ett objekt av typen Spelare
            Spelare spelare1 = new Spelare("Johan", 10);
            spelare1.Springa();
        }
    }

    // Här är klassen Spelare
    public class Spelare
    {
        public string Namn { get; set; }
        public int TrojNummer { get; set; }

        public Spelare(string namn, int trojNummer)
        {
            Namn = namn;
            TrojNummer = trojNummer;
        }

        public void Springa()
        {
            Console.WriteLine($"{Namn} springer");
        }
    }
}