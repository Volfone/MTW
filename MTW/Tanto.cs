using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal class Tanto : IMeleeWeapon, IRepairableWeapon, IUpgradeableWeapon
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }

        public Tanto()
        {
            Durability = 40;
            Level = 1;
            Name = "Tanto";
        }
        public void Attack()
        {
            this.Durability -= 5;
            if (this.Durability <= 0)
            {
                this.Durability = 0;
                this.Damage = 0;
                Console.WriteLine($"nothing damaged something, durability - {this.Durability}");
                return;
            }
            else
            {
                this.Damage = this.Level * 5;
            }
            Console.WriteLine($"{this.Name}  damaged something, durability - {this.Durability}");
        }
    }
}
