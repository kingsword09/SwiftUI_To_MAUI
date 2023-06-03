
import SwiftUI
import WebKit

@objc public class DWebViewWrapper: NSObject, UIViewHost, UIKitWrapper {
    typealias SwiftUIView = DWebView
    typealias Controller = HostingController<DWebView>
    var swiftUIView: DWebView?
    var hostingController: HostingController<DWebView>?
    
    @objc public var webview: WKWebView
    @objc public var uiView: UIView? { hostingController?.view }
    @objc public var url: String?
    {
        didSet {
            self.webview.load(URLRequest(url: URL(string: url!)!))
        }
    }
    
    required public override init() {
        webview = WKWebView(frame: CGRect.zero);
        super.init()
        createSwiftUIView()
    }
    func createSwiftUIView() {
        swiftUIView = DWebView(wrapper: self)
        createController(view: swiftUIView!);
    }
}
