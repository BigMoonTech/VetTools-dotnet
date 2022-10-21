using System.Diagnostics;
using VetToolsApp.Models;

namespace VetToolsApp.Views;

public partial class MainPage : ContentPage
{
    private Dictionary<string, object> navigationParameter;

    public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new ViewModels.DiseaseViewModel();
	}

    async void StartButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/EducationDocumentPage", navigationParameter);
    }

    void picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selection = ((Picker)picker).SelectedItem as Disease;

        navigationParameter = new Dictionary<string, object>
        {
            { "SelectedDisease", selection}
        };
    }
}

