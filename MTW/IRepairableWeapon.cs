using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal interface IRepairableWeapon : IWeapon
    {
        public int Durability { get; set; }
    }
}
