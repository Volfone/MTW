using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTW
{
    internal class Human
    {
        public string Name { get; set; }

        public Human(string name)
        {
            Name = name;
        }

        public void Attack(IMeleeWeapon weapon, Human human)
        {
            weapon.Attack();
            Console.WriteLine($"{this.Name} damaged {human.Name} with {weapon.Name} dealing {weapon.Damage}");
        }
        public void Throw(IThrowingWeapon weapon, Human human)
        {    
            weapon.Throw();
            Console.WriteLine($"{this.Name} throw {weapon.Name} at {human.Name} dealing {weapon.Damage}");
        }
    }
}
