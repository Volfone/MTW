using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal interface IUpgradeableWeapon : IWeapon
    {
        public int Level { get; set; }
    }
}
