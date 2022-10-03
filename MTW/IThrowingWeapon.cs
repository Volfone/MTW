using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal interface IThrowingWeapon : IWeapon
    {
        public int Amount { get; set; }
        public void Throw() { }
    }
}
