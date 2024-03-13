using EventHub.Models;
using EventHub.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics.Platform;
using System.Collections.ObjectModel;

namespace EventHub
{
    public partial class MainPage : ContentPage
    {
        private const uint AnimationDuration = 800u;
        public MainPage(MainViewModel mainView)
        {
            InitializeComponent();
            BindingContext = mainView;
            carouselView.ItemsSource = events;
        }

        public ObservableCollection<Event> events = new()
        {
            new Event()
            {
                EventSponsor = "Sumsang",
                StartTime = new TimeOnly(16,00),
                Description = "Music festivals across Limpopo",
                EventDate = DayOfWeek.Saturday,
                ImageUrl = "https://img.freepik.com/free-photo/artist-playing-guitar-jumping-sideways_23-2148751598.jpg"
            },
            new Event()
            {
                EventSponsor = "Sumsang",
                StartTime = new TimeOnly(16,00),
                Description = "Music festivals across Limpopo",
                EventDate = DayOfWeek.Saturday,
                ImageUrl = "https://img.freepik.com/free-photo/woman-playing-guitar-local-event_23-2149188099.jpg"
            },
            new Event()
            {
                EventSponsor = "Sumsang",
                StartTime = new TimeOnly(16,00),
                Description = "Music festivals across Limpopo",
                EventDate = DayOfWeek.Saturday,
                ImageUrl = "https://img.freepik.com/free-photo/artist-playing-guitar-jumping-sideways_23-2148751598.jpg"
            },
            new Event()
            {
                EventSponsor = "Sumsang",
                StartTime = new TimeOnly(16,00),
                Description = "Music festivals across Limpopo",
                EventDate = DayOfWeek.Saturday,
                ImageUrl = "https://img.freepik.com/free-photo/artist-playing-guitar-jumping-sideways_23-2148751598.jpg"
            },
            new Event()
            {
                EventSponsor = "Sumsang",
                StartTime = new TimeOnly(16,00),
                Description = "Music festivals across Limpopo",
                EventDate = DayOfWeek.Saturday,
                ImageUrl = "https://img.freepik.com/free-photo/artist-playing-guitar-jumping-sideways_23-2148751598.jpg"
            }
        };


        private async void avatarTapped_Tapped(object sender, TappedEventArgs e)
        {
            _ = mainContentGrid.TranslateTo(+this.Width * 0.5,this.Height * 0.30 ,AnimationDuration, Easing.CubicIn );
            await mainContentGrid.ScaleTo(0.8, AnimationDuration);
            _ = mainContentGrid.FadeTo(0.5, AnimationDuration);
        }

        private async void OpenAreaTabbed_Tapped(object sender, TappedEventArgs e)
        {
            _ = mainContentGrid.FadeTo(1, AnimationDuration);
            _ = mainContentGrid.ScaleTo(1,AnimationDuration);
            await mainContentGrid.TranslateTo(0,0,AnimationDuration, Easing.CubicInOut);
        }
    }
}
 