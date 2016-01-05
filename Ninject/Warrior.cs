using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject
{
    public class Warrior
    {
        IWeapon weapon;

        public Warrior(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Kill()
        {
            weapon.Kill();
        }
    }
}