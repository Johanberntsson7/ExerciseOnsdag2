namespace ExerciseOnsdag2
{
    public class Animal
    {
        public string Namn = "";   // startvärde tar bort varning CS8618
        public int Age;

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }

    public class Bat : Animal
    {
        public int WingSpan;

        // Samma namn som i Animal, nu gör "new" det den ska
        public new void Sleep()
        {
            Console.WriteLine("This animal does not sleep");
        }
    }
}