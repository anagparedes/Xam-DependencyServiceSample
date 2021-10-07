using DependencyServiceSample.Services;
using UIKit;
using Xamarin.Forms.Internals;

namespace DependencyServiceSample.iOS.Services
{
    public class DeviceOrientationService: IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait || orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }

        
    }
}