using System;
using System.Collections.ObjectModel;
using System.Linq;
using Ninject;

namespace CaliburnNinjectModule.Models
{
    public class Album
    {
        public Album()
        {
            Id = Guid.NewGuid();
            Name = "My album";
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ObservableCollection<Photo> Photos { get; set; }

        [Inject]
        public Photo Photo { get; set; }
        public Photo GetPhoto(int id)
        {
            var photo = Photos.FirstOrDefault(p => p.Id.Equals(id));
            return photo;
        }
    }
}