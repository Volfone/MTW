using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal class Tanto : IMeleeWeapon
    {
        public int Damage { get; set; }
        public void Attack()
        {
            Console.WriteLine("Tanto damaged something");
        }
    }
}
