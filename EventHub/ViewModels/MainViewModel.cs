using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EventHub.Models;
using EventHub.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventHub.ViewModels
{
   
    public partial class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            GetDeviceScreenSize(); 
        }

        [ObservableProperty]
        public double screenWidth;

        [ObservableProperty]
        public double screenHeight;

        [ObservableProperty]
        public double imageDetailHeight;

      
        private void GetDeviceScreenSize()                              
        {
            ScreenHeight = DeviceDisplay.MainDisplayInfo.Height;
            ScreenWidth = DeviceDisplay.MainDisplayInfo.Width;
            ImageDetailHeight = this.ScreenHeight * 0.5;    
        }

        [RelayCommand]
        async Task GotoDetails()
        {
            if (IsBusy == true)
                return;
            try
            {
                IsBusy = true;
                
                await Shell.Current.GoToAsync(nameof(EventDetails));
                IsBusy = true;
                
            }
            catch(Exception ex)
            {
                Debug.Write(ex);
            }
            finally
            {
                IsBusy = false;
                
            }
        }

        [RelayCommand]
        async Task ExitDetails()
        {
            if (IsBusy == true)
                return;
            try
            {
                IsBusy = true;

                await Shell.Current.GoToAsync("..");
                
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
            }
            finally
            {
                IsBusy = false;

            }
        }


    }
}
