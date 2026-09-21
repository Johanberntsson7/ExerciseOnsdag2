using System.Runtime.CompilerServices;

namespace ExerciseOnsdag2
{
    // polymorphism = många former, samma namn men olika implementationer

    public class Vehicle
    {
        public string Namn = string.Empty;

        public string Modell = string.Empty;

        public virtual void StartaMotor()
        {
            Console.WriteLine("Motorn startar");
        }

    }

    public class Bil : Vehicle
    {
        public override void StartaMotor()
        {
            Console.WriteLine("Bilen startar motorn");
        }

    }
    public class Motorcykel : Vehicle
    {
        public override void StartaMotor()
        {
            Console.WriteLine("Motorcykeln startar motorn");
        }
    }

}