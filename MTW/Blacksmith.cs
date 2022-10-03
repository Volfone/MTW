using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal class Blacksmith
    {
        public void Repair(IRepairableWeapon weapon)
        {
            weapon.Durability += 20;
            Console.WriteLine($"{weapon.Name} repaired");
        }
        public void Upgrade(IUpgradeableWeapon weapon)
        {
            weapon.Level += 1;
            Console.WriteLine($"{weapon.Name} was upgraded");
        }
    }
}
