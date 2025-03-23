using System;
using System.Threading.Tasks;

namespace Otus_Interfaces
{
    public interface IRobot
    {
        string GetInfo();

        string GetRobotType()
        {
            return "I am a simple Robot.";
        }

        List<string> GetComponents();
    }
}
