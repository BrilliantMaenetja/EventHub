using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
        }

        private const uint AnimationDuration = 800;
        [RelayCommand]
        async Task OpenProfile()
        {
            Grid grid = new Grid();
            
            _ = grid.TranslateTo(+grid.Width* 0.5, grid.Height * 0.30, AnimationDuration, Easing.CubicIn);
            await grid.ScaleTo(0.8, AnimationDuration);
            _ = grid.FadeTo(0.5, AnimationDuration);   
        }
    }
}
