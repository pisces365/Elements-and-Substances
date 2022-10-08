using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace 元素与物质
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public LicenseInformation AppLicenseInformation { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            rootFrame.Navigate(typeof(yuansuzhouqibiao));
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            Window.Current.SetTitleBar(Header);
        }


        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                rootFrame.Navigate(typeof(设置));
            }
            else
            {

                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag.ToString())
                {
                    case "y":
                        rootFrame.Navigate(typeof(yuansuzhouqibiao));
                        

                        break;
                    case "w":
                        rootFrame.Navigate(typeof(wuzhi));
                        

                        break;
                }
            }

        }
        private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            On_BackRequested();
        }

        private void BackInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
        {
            On_BackRequested();
            args.Handled = true;
        }

        private bool On_BackRequested()
        {
            bool navigated = false;

            // don't go back if the nav pane is overlayed
            if (NavView.IsPaneOpen && (NavView.DisplayMode == NavigationViewDisplayMode.Compact || NavView.DisplayMode == NavigationViewDisplayMode.Minimal))
            {
                return false;
            }
            else
            {
                if (rootFrame.CanGoBack)
                {
                    rootFrame.GoBack();
                    navigated = true;
                }
            }
            return navigated;
        }

        private async void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?productid=9N6RC7JTKLN3"));
        }

        private void Yuansuzhouqibiao_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(yuansuzhouqibiao));
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame.CanGoBack)
            {
                // Show UI in title bar if opted-in and in-app backstack is not empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;
            }
            else
            {
                // Remove the UI from the title bar if in-app back stack is empty.
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Collapsed;
            }
        }

        private async void FEEDBACK_Click(object sender, RoutedEventArgs e)
        {
            var launcher = Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.GetDefault();
            await launcher.LaunchAsync();
            if (Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.IsSupported())
            {
                this.FEEDBACK.Visibility = Visibility.Visible;
            }
        }




            private async void Pisces365_Click(object sender, RoutedEventArgs e)
            {
                await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://publisher/?Name=Pisces365"));
            }


    }
}
