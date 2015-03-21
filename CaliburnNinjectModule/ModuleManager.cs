using CaliburnNinjectModule.Models;
using Ninject.Modules;

namespace CaliburnNinjectModule
{
    public class ModuleManager : NinjectModule
    {
        public override void Load()
        {
            Bind<User>().ToSelf();
            Bind<Album>().ToSelf();
            Bind<Photo>().ToSelf();
        }
    }
}
