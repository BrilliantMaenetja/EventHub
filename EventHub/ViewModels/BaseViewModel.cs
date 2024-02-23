using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(isNotBusy))]
        public bool isBusy;

        [ObservableProperty]
        public string? name;

        public bool isNotBusy => !IsBusy;

    }
}
