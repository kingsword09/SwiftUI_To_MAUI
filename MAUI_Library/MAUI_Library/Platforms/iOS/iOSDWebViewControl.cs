using WebKit;
using CoreGraphics;
namespace MAUI_Library;

public partial class DWebViewControl : View
{
    public static readonly BindableProperty UrlProperty = BindableProperty.Create(nameof(Url), typeof(string), typeof(DWebViewControl), default(string));
    public static readonly BindableProperty WebviewProperty = BindableProperty.Create(nameof(Webview), typeof(WKWebView), typeof(DWebViewControl), new WKWebView(CGRect.Empty, new()));

    public string Url
    {
        get => (string)GetValue(UrlProperty);
        set => SetValue(UrlProperty, value);
    }
    public WKWebView Webview
    {
        get => (WKWebView)GetValue(WebviewProperty);
        set => SetValue(WebviewProperty, value);
    }
}

