﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal class Shuriken : IThrowingWeapon
    {
        public int Damage { get; set; }

        public void Throw() 
        {
            Console.WriteLine("Shuriken was thrown");
        }
    }
}