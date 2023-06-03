using System;
namespace MAUI_Library;

//Implement handler for Android platform here
public partial class DWebViewHandler : ViewHandler<DWebViewControl, Android.Views.View>
{
    public DWebViewHandler() : base(PropertyMapper) { }

    public static IPropertyMapper<DWebViewControl, DWebViewHandler> PropertyMapper =
        new PropertyMapper<DWebViewControl, DWebViewHandler>(ViewHandler.ViewMapper) { };

    protected override Android.Views.View CreatePlatformView()
    {
        //it is just a mock view
        //create something real for a correct implementation
        return new View(null);
    }
}

