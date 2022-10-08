using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace 元素与物质
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class 设置 : Page
    {
        public 设置()
        {
            this.InitializeComponent();
        }


        private void R1_Checked_1(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).RequestedTheme = ElementTheme.Light;

        }

        private void R2_Checked_1(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).RequestedTheme = ElementTheme.Dark;

        }
        private async void FeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            var launcher = Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.GetDefault();
            await launcher.LaunchAsync();
            if (Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.IsSupported())
            {
                this.FeedbackButton.Visibility = Visibility.Visible;
            }
        }

        private async void FeedbackButtony_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?productid=9N6RC7JTKLN3"));
        }
    }
}
