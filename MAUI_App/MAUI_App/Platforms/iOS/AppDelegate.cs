using Foundation;
using UIKit;
using CoreGraphics;
using WebKit;

namespace MAUI_App;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate {
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    //public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    //{
    //    _ = base.FinishedLaunching(application, launchOptions);
    //    return true;
    //}
}

public class DWebViewTest {
    public static void DWebViewTestFunc()
    {
        Console.WriteLine("DWebViewTestFunc");
    }
}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        //dwebview.Webview = new WKWebView(new CGRect(10, 100, 100, 100), new());
        //dwebview.Url = "https://www.qq.com";
        //dwebview.Webview.LoadRequest(new NSUrlRequest(new NSUrl("https://www.qq.com")));
        //dwebview.Webview.Frame = UIScreen.MainScreen.Bounds;
        //dwebview.BackgroundColor = Color.FromRgba(255, 0, 0, 255);
        //dwebview.Frame = new Rect(0, 100, UIScreen.MainScreen.Bounds.Width, 100);
    }

    public void Load_Url(object sender, EventArgs e)
    {
        dwebview.Webview.Frame = new Rect(0, 100, UIScreen.MainScreen.Bounds.Width, 100);
        dwebview.Url = "https://www.qq.com";
        DWebViewTest.DWebViewTestFunc();
    }
}