using MauiButtonCommandTest1.ViewModels;

namespace MauiButtonCommandTest1;

public partial class MainPage : ContentPage
{

	public MainPage(ViewModel1 viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

}

