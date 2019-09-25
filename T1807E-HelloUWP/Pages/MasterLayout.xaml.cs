using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1807E_HelloUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MasterLayout : Page
    {
        public MasterLayout()
        {
            this.InitializeComponent();
        }

        // as HyperlinkButton ep kieu?,
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            var hyperlink = sender as HyperlinkButton;
            if(hyperlink != null)
            {
                switch (hyperlink.Tag)
                {
                    case "Login":
                        this.Maincontent.Navigate(typeof(Login));
                        break;
                    case "Register":
                        this.Maincontent.Navigate(typeof(Register));
                        break;
                }
            }
        }

        private void ToogleMenu_Click(object sender, RoutedEventArgs e)
        {
            this.SplitView.IsPaneOpen = !this.SplitView.IsPaneOpen;
        }

    }
}
