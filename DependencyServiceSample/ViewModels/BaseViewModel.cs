using Prism.Navigation;
using System.ComponentModel;

namespace DependencyServiceSample.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public abstract string Title { get; }
        protected INavigationService NavigationService { get; }
        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
