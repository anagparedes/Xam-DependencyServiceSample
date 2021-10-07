using DependencyServiceSample.ViewModels;
using DependencyServiceSample.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace DependencyServiceSample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer): base(platformInitializer)
        {
            InitializeComponent();

           
        }
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync($"{NavigationConstants.NavigationPage}/{NavigationConstants.Main}");
           
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConstants.NavigationPage);
            containerRegistry.RegisterForNavigation<MainTabbedPage>(NavigationConstants.Main);
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>(NavigationConstants.Home);
            containerRegistry.RegisterForNavigation<PlacesPage, PlacesViewModel>(NavigationConstants.Places);
            containerRegistry.RegisterForNavigation<AboutPage, AboutViewModel>(NavigationConstants.About);
        }

    }
}
