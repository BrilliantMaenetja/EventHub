﻿using EventHub.Views;

namespace EventHub
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(EventDetails), typeof(EventDetails));

        }
    }
}
