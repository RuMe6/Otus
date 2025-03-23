namespace Otus_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quad = new Quadcopter();

            IFlyingRobot flyRob = quad;
            IChargeable charge = quad;

            Console.WriteLine(flyRob.GetRobotType());
            flyRob.GetComponents();
            charge.Charge();
            Console.WriteLine(quad.GetInfo());


        }
    }
}
