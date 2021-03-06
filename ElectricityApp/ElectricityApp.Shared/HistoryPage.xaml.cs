﻿using ElectricityApp.model;
using ElectricityApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class HistoryPage : Page
    {
        ObservableCollection<HistoryViewModel> histories= null;
        HistoriesViewModel history = null;
        HistoryViewModel myHistory = null;
        List<History> listHistory = null;
        public HistoryPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            history = new HistoriesViewModel();
            histories = history.getHistory();
            //listViewHistory.Items.Add(histories);
            try
            {
                if (histories != null)
                {
                    foreach (var hist in histories)
                    {
                        listViewHistory.Items.Add("-Number of Appliances :" + hist.NUMBER + " appliance'(s) \n-Consumed Units :" 
                            + hist.USED_UNITS + " Units  \n-Remained units :" + hist.REMAINING_UNITS + " \n-Date :" + hist.DATE + "\n");
                    }
                }
                else
                {
                    messageBox("No history in the database");
                }
            }
            catch (Exception ex)
            {
                messageBox("error " + ex.Message);
            }
            base.OnNavigatedTo(e);
        }
        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            
            await msgDlg.ShowAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnitsPage1));
        }
        private void clear()
        { 
            
        }

        private async void btnClearHistory_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Do you really want to clear history?");
            dialog.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(Commandhandler)));
            dialog.Commands.Add(new UICommand("No", new UICommandInvokedHandler(Commandhandler)));
            await dialog.ShowAsync();
            
        }

        private  void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
        private void Commandhandler(IUICommand cmd)
        {
            var lable = cmd.Label;
            myHistory = new HistoryViewModel();
            switch(lable)
            {
                case "Yes":
                    
                    try { 
                        myHistory.clearHistory();
                        //messageBox("History has been cleared");
                        this.Frame.Navigate(typeof(HistoryPage));
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
    }
}
