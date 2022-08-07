using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoWallExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeBrowser();
        }
        public async void InitializeBrowser()
        {
            await left.EnsureCoreWebView2Async(null);
            await leftMiddle.EnsureCoreWebView2Async(null);
            await rightMiddle.EnsureCoreWebView2Async(null);
            await right.EnsureCoreWebView2Async(null);
            left.CoreWebView2.DOMContentLoaded += enableFullScreenAzure;
            leftMiddle.CoreWebView2.DOMContentLoaded += enableFullScreenAzure;
            rightMiddle.CoreWebView2.DOMContentLoaded += enableFullScreenAzure;
            right.CoreWebView2.DOMContentLoaded += enableFullScreenAzure;
        }

        private void enableFullScreenAzure(object sender, CoreWebView2DOMContentLoadedEventArgs e)
        {
            ((CoreWebView2)sender).ExecuteScriptAsync("document.body.classList.add('fxs-portal-fullscreen')");
        }
    }
}
