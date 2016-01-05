using Microsoft.Practices.Unity;

namespace Unity
{
    public interface IFeature
    {
    }

    class MyComponent : IFeature
    {
    }

    class TestComponent : IFeature
    {
    }
     
    class Program
    {
        private IFeature _mc;

        public Program(IFeature mc)
        {
            this._mc = mc;
        }
        static void Main(string[] args)
        {
            var uc = new UnityContainer();
            uc.RegisterType<IFeature, TestComponent>();
            var program = uc.Resolve<Program>();
        }
    }
}