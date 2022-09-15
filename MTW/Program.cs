using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MTW;

Console.WriteLine("Hello, World!");

IMeleeWeapon weapon = new Kunai();
weapon.Attack();
IThrowingWeapon weapon1 = new Kunai();
weapon1.Throw();
weapon = new Tanto();
weapon.Attack();
weapon1 = new Shuriken();
weapon1.Throw();