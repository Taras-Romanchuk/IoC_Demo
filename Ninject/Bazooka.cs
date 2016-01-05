using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject
{
    class Bazooka: IWeapon
    {
        public void Kill()
        {
            Console.WriteLine("BIG BADABUM!");
        }
    }
}