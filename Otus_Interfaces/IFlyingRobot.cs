using System;
using System.Threading.Tasks;

namespace Otus_Interfaces
{
    public interface IFlyingRobot : IRobot
    {
        string GetRobotType()
        {
            return "I am a flying Robot.";
        }
        
    }
}
