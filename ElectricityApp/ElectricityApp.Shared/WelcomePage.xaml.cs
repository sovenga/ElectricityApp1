
using ElectricityApp.model;
using ElectricityApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ElectricityApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WelcomePage : Page
    {
        MeterViewModel meterView = new MeterViewModel();
        ApplianceViewModel appliance = null;
        public WelcomePage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MeterBox unitObject = meterView.getMeterUnits();
            //double current = unitObject.currentUnits;
            if (unitObject == null)
            {
                lblMessage.Text = "Meter Box must be added first to add appliances,\n and to check calculate units";
                linkAddAppliances.IsEnabled = false;
                linkCheckButton.IsEnabled = false;
                messageBox("You have to add a meter box first");
            }
            base.OnNavigatedTo(e);
        }
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddAppliancePage));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CheckUnitsPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage1));

        }

        private void linkView_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnitsPage1));
        }
        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }
        private void linkRemoveAppliances_Click(object sender, RoutedEventArgs e)
        {
            appliance = new ApplianceViewModel();
            appliance.deleteAllAppliances();
            messageBox("All Appliances Removed");
        }

        private async void linkDropTable_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("All appliances will be deleted, Continue?");
    
            
            dialog.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(DropAppliancesCommandhandler)));
            dialog.Commands.Add(new UICommand("Cancel", new UICommandInvokedHandler(DropAppliancesCommandhandler)));
          
            //dialog.Commands.Add(new UICommand("Delete Each", new UICommandInvokedHandler(DropAppliancesCommandhandler)));
           
            
            
            await dialog.ShowAsync();
        }

        private void linkremoveaccount_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RemoveUserPage));
        }

        private async void linkLogout_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Do you want to logout?");
            dialog.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(Commandhandler)));
            dialog.Commands.Add(new UICommand("No", new UICommandInvokedHandler(Commandhandler)));
            await dialog.ShowAsync();
        }

        private void HyperlinkButton_Click_2(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(UnitsPage1));
        }
        private void Commandhandler(IUICommand cmd)
        {
            HistoryViewModel myHistory = null;
            var lable = cmd.Label;
            myHistory = new HistoryViewModel();
            switch (lable)
            {
                case "Yes":

                    try
                    {
                        this.Frame.Navigate(typeof(MainPage1));
                    }
                    catch (Exception ex)
                    {
                        //messageBox("error " + ex.Message);
                    }
                    break;
                case "No":
                    break;

            }
        }
        private void DropAppliancesCommandhandler(IUICommand cmd)
        {
            HistoryViewModel myHistory = null;
            var lable = cmd.Label;
            myHistory = new HistoryViewModel();
            switch (lable)
            {
                case "Yes":

                    try
                    {
                        appliance = new ApplianceViewModel();
                        appliance.deleteAllAppliances();
                        //this.Frame.Navigate(typeof(MainPage));
                    }
                    catch (Exception ex)
                    {
                        //messageBox("error " + ex.Message);
                    }
                    break;
                case "Calcel":
                    break;
                

            }
        }
        private void linkDropHistory_Click(object sender, RoutedEventArgs e)
        {
            HistoryViewModel history = new HistoryViewModel();
            history.dropHistory();
            messageBox("success");
        }

        private void linkAddMeter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddMeterPage));
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
