using Android.App;
using Android.Webkit;
using Android.OS;

namespace Webview.BugRepro
{
    [Activity(Label = "Webview.BugRepro", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Main);

            var webView = FindViewById<WebView>(Resource.Id.webView);
            
            webView.SetWebViewClient(new WebViewClient());
            
            webView.LoadUrl("http://www.google.com/"); // Set breakpoint here

        }
    }
}

