namespace ExerciseOnsdag2
{
    // Abstraktion 


    // Huvudklass Abstrakt

    public abstract class MotorBike
    {
      public abstract void Brake();  
    }

    // Subklass
    public class MountainBike : MotorBike
    {
        public override void Brake()
        {
            Console.WriteLine("Mountainbike brakes");
        }
    }
}