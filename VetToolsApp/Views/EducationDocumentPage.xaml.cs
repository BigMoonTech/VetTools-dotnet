using System.Diagnostics;
using VetToolsApp.Models;

namespace VetToolsApp.Views;

public partial class EducationDocumentPage : ContentPage, IQueryAttributable
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string ClinicalSigns { get; private set; }
    public string ContractedBy { get; private set; }
    public string AdditionalInfo { get; private set; }
    public string PreventionTips { get; private set; }

    public EducationDocumentPage()
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Debug.WriteLine(query["SelectedDisease"]);

        if (query["SelectedDisease"] is Disease diseaseObject)
        {
            Debug.WriteLine(diseaseObject.Name);
            Name = diseaseObject.Name;
            Description = diseaseObject.Description;
            ClinicalSigns = diseaseObject.ClinicalSigns;
            ContractedBy = diseaseObject.ContractedBy;
            AdditionalInfo = diseaseObject.AdditionalInfo;
            PreventionTips = diseaseObject.PreventionTips;
        }
        this.BindingContext = this;
    }

    async void EndButton1_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    async void NextButton1_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/QueryPage");
    }

}