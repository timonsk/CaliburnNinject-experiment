using System;
using System.Collections.ObjectModel;
using System.Linq;

using CaliburnNinject.Infrastructure.Interfaces;
using Ninject;

namespace CaliburnNinjectModule.Models
{
    public class Album : IAlbum
    {
        public Album()
        {
            Id = Guid.NewGuid();
            Name = "My album";
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ObservableCollection<IPhoto> Photos { get; set; }

        [Inject]
        public IPhoto Photo { get; set; }

        public IPhoto GetPhoto(int id)
        {
            var photo = Photos.FirstOrDefault(p => p.Id.Equals(id));
            return photo;
        }
    }


}