using Ninject;
using StretchCeilingProject.BLL;
using StretchCeilingProject.DAL;

namespace StretchCeilingProject.Ninject
{
    public static class NinjectRegistrator
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<ImageLogic>().ToSelf();
            kernel.Bind<ImageDao>().ToSelf();
        }
    }
}