
import SwiftUI
import WebKit

@objc public class DWebViewWrapper: NSObject, ObservableObject {
    var webView: WKWebView?
    var hostingController: UIHostingController<DWebView>?
    
    @objc public var uiView: UIView? { hostingController?.view }
    
    public init(webView: WKWebView) {
        super.init()
        self.webView = webView
        let webView = DWebView(webView: webView)
        hostingController = UIHostingController(rootView: webView)
    }
}
