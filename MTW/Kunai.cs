using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal class Kunai : IMeleeWeapon, IThrowingWeapon
    {
        public int Damage { get; set; }

        public void Attack ()
        {
            Console.WriteLine("Kunai damaged something");
        }

        public void Throw()
        {
            Console.WriteLine("Kunai was thrown");
        }
    }
}
