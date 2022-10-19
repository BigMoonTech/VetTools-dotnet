namespace VetToolsApp.Views;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	async void OnStartButtonClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("/EducationDocumentPage");
    }
}

