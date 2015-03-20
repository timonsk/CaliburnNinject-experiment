using System.Collections.Generic;
using System.Linq;

namespace CaliburnNinjectExperiment.Model
{
    public class Album
    {
        public Album()
        {
            Id = 32;
            Name = "My album";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Photo> Photos { get; set; }

        public Photo GetPhoto(int id)
        {
            var photo = Photos.FirstOrDefault(p => p.Id.Equals(id));
            return photo;
        }
    }
}