using CaliburnNinject.Infrastructure.Interfaces;
using CaliburnNinjectModule.Models;
using Ninject.Modules;

namespace CaliburnNinjectModule
{
    public class ModuleManager : NinjectModule
    {
        public override void Load()
        {
            Bind<IUser>().To<User>();
            Bind<IAlbum>().To<Album>();
            Bind<IPhoto>().To<Photo>();
        }
    }
}