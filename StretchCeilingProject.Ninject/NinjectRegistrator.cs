using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using StretchCeilingProject.BLL;
using StretchCeilingProject.DAL;

namespace StretchCeilingProject.Ninject
{
    public class NinjectRegistrator
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<ImageLogic>().ToSelf();
            kernel.Bind<ImageDao>().ToSelf();
        }
    }
}
