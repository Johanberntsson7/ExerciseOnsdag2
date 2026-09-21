namespace ExerciseOnsdag2
{
    public class Employee
    {
        // Privat fält: bara Employee själv kommer åt det direkt
        private string name;

        // Konstruktör: tvingar den som skapar objektet att ange ett namn
        public Employee(string name)
        {
            this.name = name;
        }

        // Property: den publika "dörren" till det privata fältet
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}