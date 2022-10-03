using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal class Shuriken : IThrowingWeapon, IRepairableWeapon, IUpgradeableWeapon
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }

        public Shuriken()
        {
            Durability = 40;
            Level = 1;
            this.Amount = 40;
            Name = "Shuriken";
        }

        public void Throw()
        {
            this.Amount -= 1;
            if (this.Amount <= 0)
            {
                this.Amount = 0;
                this.Damage = 0;
                Console.WriteLine($"nothing was thrown, amount - {this.Amount}");
                return;
            }
            else
            {
                this.Damage = this.Level * 5;
            }
            Console.WriteLine($"{this.Name} was thrown, amount - {this.Amount}");
        }
    }
}
