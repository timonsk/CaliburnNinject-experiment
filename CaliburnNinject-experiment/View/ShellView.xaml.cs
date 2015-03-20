using System.Windows;
using Ninject;

namespace CaliburnNinjectExperiment.View
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        [Inject]
        public ShellViewModel ViewModel { get; set; }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var album = ViewModel.User.GetDefaultAlbum();
            ViewModel.User.Albums.Add(album);
        }
    }
}