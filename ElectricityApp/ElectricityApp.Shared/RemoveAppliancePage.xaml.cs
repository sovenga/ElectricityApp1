using ElectricityApp.ViewModels;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ElectricityApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RemoveAppliancePage : Page
    {
        ApplianceViewModel applianceModel;
        public RemoveAppliancePage()
        {
            this.InitializeComponent();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            applianceModel = new ApplianceViewModel();
            string applianceName = txtAppliance.Text;
            try
            {
                applianceModel.deleteEachAppliance(applianceName);
            }
            catch(Exception ex)
            {
                
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RemoveAppliancePage));
        }
    }
}
