using CommunityToolkit.Maui.Views;

namespace behaviorPopup;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		await this.ShowPopupAsync(new TestPopup());
    }
}


