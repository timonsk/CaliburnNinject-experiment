using System.Windows;
using CaliburnNinject.Infrastructure.Interfaces;
using Ninject;

namespace CaliburnNinjectExperiment.View
{
    public class ShellViewModel : DependencyObject
    {
        public static readonly DependencyProperty UserProperty =
            DependencyProperty.Register("User", typeof(IUser), typeof(ShellViewModel));

        [Inject]
        public IUser User
        {
            get { return (IUser)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }
    }
}