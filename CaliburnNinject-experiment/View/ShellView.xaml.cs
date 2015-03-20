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
    }
}