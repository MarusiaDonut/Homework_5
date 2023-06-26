using Homework_5;

namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new();

            List<string> components = quadcopter.GetComponents();
            foreach (string component in components)
            {
                Console.Write(" " + component);
            }
            Console.WriteLine("\n");

            IChargeable chargeable = new Quadcopter();
            chargeable.Charge();

            Console.WriteLine("\n");
            IFlyingRobot flyingRobot = new Quadcopter();
            string textFlyingRobot = flyingRobot.GetRobotType();
            Console.WriteLine(textFlyingRobot);
        }
    }
}