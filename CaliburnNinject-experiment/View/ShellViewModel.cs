using System.Windows;
using CaliburnNinjectExperiment.Model;
using Ninject;

namespace CaliburnNinjectExperiment.View
{
    public class ShellViewModel : DependencyObject
    {
        public static readonly DependencyProperty UserProperty =
            DependencyProperty.Register("User", typeof (User), typeof (ShellViewModel));

        [Inject]
        public User User
        {
            get { return (User) GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }
    }
}