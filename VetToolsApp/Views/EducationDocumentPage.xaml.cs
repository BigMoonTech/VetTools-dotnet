using BinaryTreeStructures.Nodes;
using System.Diagnostics;
using VetToolsApp.Models;

namespace VetToolsApp.Views;

public partial class EducationDocumentPage : ContentPage, IQueryAttributable
{
    // Probably should move the properties to a viewmodel
    private string _name { get; set; }
    private string _description { get; set; }
    private string _clinicalSigns { get; set; }
    public string _contractedBy { get; private set; }
    public string _additionalInfo { get; private set; }
    public string _preventionTips { get; private set; }
    public List<QueryNode> _queryList { get; private set; }

    private IDictionary<string, object> _navParam;


    public EducationDocumentPage()
    {
        InitializeComponent();
        this.BindingContext = this;
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query["SelectedDisease"] is Disease disease)
        {
            Name = disease.Name;
            Description = disease.Description;
            ClinicalSigns = disease.ClinicalSigns;
            ContractedBy = disease.ContractedBy;
            AdditionalInfo = disease.AdditionalInfo;
            PreventionTips = disease.PreventionTips;
            QueryList = disease.QueryList;
            
            _navParam = query;
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public string Description
    {
        get => _description;
        set
        {
            _description = value;
            OnPropertyChanged(nameof(Description));
        }
    }

    public string ClinicalSigns
    {
        get => _clinicalSigns;
        set
        {
            _clinicalSigns = value;
            OnPropertyChanged(nameof(ClinicalSigns));
        }
    }

    public string ContractedBy
    {
        get => _contractedBy;
        set
        {
            _contractedBy = value;
            OnPropertyChanged(nameof(ContractedBy));
        }
    }

    public string AdditionalInfo
    {
        get => _additionalInfo;
        set
        {
            _additionalInfo = value;
            OnPropertyChanged(nameof(AdditionalInfo));
        }
    }

    public string PreventionTips
    {
        get => _preventionTips;
        set
        {
            _preventionTips = value;
            OnPropertyChanged(nameof(PreventionTips));
        }
    }

    public List<QueryNode> QueryList
    {
        get => _queryList;
        set
        {
            _queryList = value;
            OnPropertyChanged(nameof(QueryList));
        }
    }

    async void EndButton1_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

    async void NextButton1_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//QueryPage", _navParam);
    }

}