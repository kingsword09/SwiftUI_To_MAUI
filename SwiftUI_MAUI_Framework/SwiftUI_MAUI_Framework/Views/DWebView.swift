//
//  DWebView.swift
//  SwiftUI_MAUI_Framework
//
//  Created by bfs-kingsword09 on 2023/6/3.
//

import WebKit
import SwiftUI

struct DWebViewItem: UIViewRepresentable {
    let webView: WKWebView
    
    func makeUIView(context: Context) -> WKWebView {
        webView
    }
    
    func updateUIView(_ uiView: WKWebView, context: Context) {}
}

struct DWebView : View {
    @ObservedObject var wrapper: DWebViewWrapper
    
    var body: some View {
        VStack {
            DWebViewItem(webView: wrapper.webview)
        }
    }
}

struct DWebView_Previews: PreviewProvider {
    static var wrapper = DWebViewWrapper()
    
    static var previews: some View {
        DWebView(wrapper: wrapper)
    }
}
