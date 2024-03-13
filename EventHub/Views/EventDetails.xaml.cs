using EventHub.ViewModels;

namespace EventHub.Views;

public partial class EventDetails : ContentPage
{
	public EventDetails(MainViewModel viewModel )
	{
		InitializeComponent();
		this.BindingContext = viewModel;
		
	}

   
}