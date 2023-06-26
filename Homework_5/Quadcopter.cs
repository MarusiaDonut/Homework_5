using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public Quadcopter()
        {
            _components = _components.ToList();
        }

        public List<string> GetComponents()
        {
            return _components;
        }

        void IChargeable.Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        string IRobot.GetInfo()
        {
            throw new NotImplementedException();
        }

        string IChargeable.GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
