using Prism.Navigation;

namespace DependencyServiceSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }

        public override string Title => "About";
    }
}