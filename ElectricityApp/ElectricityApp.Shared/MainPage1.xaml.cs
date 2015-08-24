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
using ElectricityApp;
using ElectricityApp.model;
using SQLite;
using System.Diagnostics;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ElectricityApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage1 : Page
    {
        private App app = (Application.Current as App);
        UserViewModel user = null;
        public string DBPath { get; set; }
        public MainPage1()
        {
            this.InitializeComponent();
            /*var bounds = Window.Current.Bounds;

            double height = bounds.Height;
            double width = bounds.Width;


            mygrid.Width = width * 10.5f;
            PageGrid.Width = width + 10000;*/
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;

            string password = txtPassword.Password;
            user = new UserViewModel();
            var valid = user.getUser(username, password);

            if (valid != null)
            {
                this.Frame.Navigate(typeof(WelcomePage));
            }
            else
            {
                messageBox("Invalid Credentials Entered");
            }
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ForgotPasswordPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewPage));
        }

        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CheckUnitsPage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnitsPage1));
        }

        private void btnLoginButton_Click(object sender, RoutedEventArgs e)
        {
            Page page = new Page();

            string username = txtUsername.Text;

            string password = txtPassword.Password;
            user = new UserViewModel();
            var valid = user.getUser(username, password);
            
       
            if (valid != null)
            {
                this.Frame.Navigate(typeof(WelcomePage),user.USERNAME);
            }
            else
            {
                messageBox("Invalid Credentials Entered");
            }//LoadStateEventArgs
        }
       

        private void HyperlinkButton_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CalculatorPage));
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));
        }
    }
}
