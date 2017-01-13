using Ninject;
using StretchCeilingProject.BLL;
using StretchCeilingProject.DAL;

namespace StretchCeilingProject.Ninject
{
    public static class NinjectRegistrator
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IImageLogic>().To<ImageLogic>().InSingletonScope();
            kernel.Bind<IImageDao>().To<ImageDao>().InSingletonScope();
            kernel.Bind<ICellingLogic>().To<CellingLogic>().InSingletonScope();
            kernel.Bind<ICeilingDao>().To<CellingDao>().InSingletonScope();
        }
    }
}