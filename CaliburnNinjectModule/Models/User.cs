using System.Collections.ObjectModel;
using System.Linq;
using Ninject;

namespace CaliburnNinjectModule.Models
{
    public class User
    {
        public User()
        {
            Id = 12;
            Name = "Jack";
            Surname = "Holand";
            Albums = new ObservableCollection<Album>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ObservableCollection<Album> Albums { get; set; }

        [Inject]
        public Album Album { private get; set; }

        public Album GetDefaultAlbum()
        {
            return Album;
        }

        public Album GetAlbum(int id)
        {
            var album = Albums.FirstOrDefault(a => a.Id.Equals(id));
            return album;
        }
    }
}