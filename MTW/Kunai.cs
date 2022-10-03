using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal class Kunai : IMeleeWeapon, IThrowingWeapon, IRepairableWeapon, IUpgradeableWeapon
    {
        public int Damage { get; set; }
        public int Durability { get; set; }
        public int _level { get; set; }
        public int Level 
        { 
            get
            {
                return this._level;
            }
            set
            {
                this._level = value;
                this.Damage = 5 * _level;
            }
        }
        public string Name { get; set; }
        public int Amount { get; set; }

        public Kunai ()
        {
            Durability = 40;
            Level = 1;
            this.Amount = 4;
            Name = "Kunai";
        }

        public void Attack ()
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
            Console.WriteLine($"{this.Name} damaged something, durability - {this.Durability}");
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
