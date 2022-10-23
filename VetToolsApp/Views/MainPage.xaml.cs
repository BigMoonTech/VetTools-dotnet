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

        // manually set the picker's displayed item to the first item in the list
        // because the built-in placeholder system is broken for windows on (VS Community v17.3.6)
        // https://github.com/dotnet/maui/issues/6845
        Picker pk = this.FindByName("picker") as Picker;
        pk.SelectedIndex = 0;
    }

    async void StartButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//EducationDocumentPage", navigationParameter);
    }

    void picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedDisease = ((Picker)picker).SelectedItem as Disease;

        navigationParameter = new Dictionary<string, object>
        {
            { "SelectedDisease", selectedDisease}
        };
    }
}

