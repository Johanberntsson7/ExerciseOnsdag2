namespace ExerciseOnsdag2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Employee employee1 = new Employee("Johan");
            Console.WriteLine(employee1.Name);
    
                Vehicle vehicle1 = new Vehicle();
                vehicle1.StartaMotor();
    
                Bil bil1 = new Bil();
                bil1.StartaMotor();
    
                Motorcykel motorcykel1 = new Motorcykel();
                motorcykel1.StartaMotor();

            MountainBike mountainBike1 = new MountainBike();
            mountainBike1.Brake();
        }
    }
}