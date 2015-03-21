using System;
using System.Collections.ObjectModel;

namespace CaliburnNinject.Infrastructure.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        ObservableCollection<IAlbum> Albums { get; set; }

        IAlbum Album { get; set; }
        IAlbum GetDefaultAlbum();
        IAlbum GetAlbum(Guid id);
    }
}