using Foundation;
using Microsoft.Maui.Handlers;
using SwiftUI_MAUI_Framework;
using UIKit;
using WebKit;
using CoreGraphics;

namespace MAUI_Library;

public partial class DWebViewHandler : ViewHandler<DWebViewControl, UIView>
{
    private DWebViewWrapper Wrapper { get; set; }

    public DWebViewHandler() : base(PropertyMapper)
    {
    }

    private static IPropertyMapper<DWebViewControl, DWebViewHandler> PropertyMapper =
        new PropertyMapper<DWebViewControl, DWebViewHandler>(ViewMapper)
        {
            [nameof(DWebViewControl.Url)] = MapUrl,
            [nameof(DWebViewControl.Webview)] = MapWebview,
        };

    private static void MapUrl(DWebViewHandler handler, DWebViewControl dWebViewControl)
    {
        if (handler == null || handler.Wrapper.Url == dWebViewControl.Url)
            return;

        handler.Wrapper.Url = dWebViewControl.Url;
    }

    private static void MapWebview(DWebViewHandler handler, DWebViewControl dWebViewControl)
    {
        if (handler == null || handler.Wrapper.Webview == dWebViewControl.Webview)
            return;

        handler.Wrapper.Webview = dWebViewControl.Webview;
    }

    protected override UIView CreatePlatformView()
    {
        Wrapper = new DWebViewWrapper();
        return Wrapper.UiView;
    }
}