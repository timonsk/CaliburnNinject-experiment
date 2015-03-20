using System.Collections.Generic;
using System.Linq;

namespace CaliburnNinjectExperiment.Model
{
    public class User
    {
        public User(Album album)
        {
            Id = 12;
            Name = "Jack";
            Surname = "Holand";
            Albums = new List<Album>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Album> Albums { get; set; }

        public Album GetAlbum(int id)
        {
            var album = Albums.FirstOrDefault(a => a.Id.Equals(id));
            return album;
        }
    }
}