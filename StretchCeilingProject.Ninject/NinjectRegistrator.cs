using Ninject;
using StretchCeilingProject.BLL;
using StretchCeilingProject.DAL;

namespace StretchCeilingProject.Ninject
{
    public static class NinjectRegistrator
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<IImageLogic>().To<ImageLogic>();
            kernel.Bind<IImageDao>().To<ImageDao>();
            kernel.Bind<ICellingLogic>().To<CellingLogic>();
            kernel.Bind<ICeilingDao>().To<CellingDao>();
        }
    }
}