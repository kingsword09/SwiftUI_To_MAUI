//
//  DWebView.swift
//  SwiftUI_MAUI_Framework
//
//  Created by bfs-kingsword09 on 2023/6/3.
//

import WebKit
import SwiftUI

struct DWebView: UIViewRepresentable {
    let webView: WKWebView
    
    func makeUIView(context: Context) -> WKWebView {
        webView
    }
    
    func updateUIView(_ uiView: WKWebView, context: Context) {}
}

class DWebView_Test {
    var webview: WKWebView
    init() {
        self.webview = WKWebView(frame: CGRect(x: 0, y: 100, width: 100, height: 100));
        self.webview.load(URLRequest(url: URL(string: "https://www.baidu.com")!))
    }
    
}

struct DWebView_Previews: PreviewProvider {
    static var wrapper = DWebViewWrapper(webView: DWebView_Test().webview)
    
    static var previews: some View {
        DWebView(webView: wrapper.webView!)
    }
}
