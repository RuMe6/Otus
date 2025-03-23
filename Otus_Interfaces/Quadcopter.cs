using System;
using System.Threading.Tasks;

namespace Otus_Interfaces
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        public List<string> List_Components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };
        
        public void Charge()
        {
            Console.WriteLine("Charging");
            Thread.Sleep(5000);
            Console.WriteLine("Charged!");
        }

        public List<string> GetComponents()
        {
            foreach (var component in List_Components)
            {
                Console.WriteLine(component);
            }

            return List_Components;
        }

        public string GetInfo()
        {
            return "I am a Quadro-Bober!";
        }

        public string GetRobotType()
        {
            return "I am a simple Robot.";
        }
    }
}
