using Prism.Navigation;

namespace DependencyServiceSample.ViewModels
{
    public class PlacesViewModel: BaseViewModel
    {
        public PlacesViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }

        public override string Title => "Places";
    }
}