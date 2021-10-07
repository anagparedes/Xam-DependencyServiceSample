using DependencyServiceSample.Services;
using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace DependencyServiceSample.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        public ICommand OrientationCommand { get; }
        public HomeViewModel(INavigationService navigationService): base(navigationService)        
        {
            OrientationCommand = new DelegateCommand(() =>
            {
                DependencyService.Get<IDeviceOrientationService>().GetOrientation();
            });
        }

        public override string Title => "Home";
    }
}