using Ninject.Modules;
using System;

namespace Ninject
{
    class Program
    {
        public static IKernel AppKernel;
        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new WeaponNinjectModule());
            var weapon = AppKernel.Get<Warrior>();
            weapon.Kill();
            Console.ReadLine();
        }
    }

    public class WeaponNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWeapon>().To<Sword>();
        }
    }
}