using Android.Content;
using DependencyServiceSample.Controls;
using DependencyServiceSample.Droid.Renderers;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRender))]
namespace DependencyServiceSample.Droid.Renderers
{
   public class CustomEntryRender: EntryRenderer
    {
        public CustomEntryRender(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.OrangeRed);
            
                
            }
        }
       
    }
}