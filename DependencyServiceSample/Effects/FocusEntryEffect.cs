using Xamarin.Forms;

namespace DependencyServiceSample.Effects
{
    public class FocusEntryEffect: RoutingEffect
    {
        public FocusEntryEffect() : base($"DependencyServiceSample.{nameof(FocusEntryEffect)}")
        {
        }
    }
}
