using BinaryTreeStructures.Nodes;
using System.Diagnostics;
using VetToolsApp.Models;

namespace VetToolsApp.Views;

public partial class QueryPage : ContentPage, IQueryAttributable
{
    Node<QueryNode> currentNode;
    public Node<QueryNode> CurrentNode
    {
        get { return currentNode; }
        set
        {
            if (currentNode != value)
            {
                currentNode = value;
                OnPropertyChanged();
            }
        }
    }

    Node<QueryNode> rootNode;
    public Node<QueryNode> RootNode
    {
        get { return rootNode; }
        set
        {
            if (rootNode != value)
            {
                rootNode = value;
                OnPropertyChanged();
            }
        }
    }

    List<QueryNode> queries1;
    public List<QueryNode> Queries
    {
        get { return queries1; }
        set
        {
            if (queries1 != value)
            {
                queries1 = value;
                OnPropertyChanged();
            }
        }
    }
    
    public IDictionary<string, object> NavParameter { get; private set; }

    public QueryPage()
	{
        InitializeComponent();
        this.BindingContext = this;
    }

    public void ApplyQueryAttributes(IDictionary<string, object> navParameter)
    {
        if (navParameter["SelectedDisease"] is Disease selectedDisease)
        {
            NavParameter = navParameter;
            Queries = selectedDisease.QueryList;
            var rootNodes = Node<QueryNode>.CreateTree(Queries, l => l.Id, l => l.ParentId);
            RootNode = rootNodes.Single();
            CurrentNode = RootNode;
        }
    }

    async void EndButton_Clicked(object sender, EventArgs e)
	{
        CurrentNode = RootNode;
        NoButton.IsVisible = true;
        YesButton.IsVisible = true;
        await Shell.Current.GoToAsync("//MainPage");
    }

    private void YesButton_Clicked(object sender, EventArgs e)
    {
        if (CurrentNode.Children.Any())
        {
            CurrentNode = CurrentNode.Children.Last();
            if (!CurrentNode.Children.Any())
            {
                NoButton.IsVisible = false;
                YesButton.IsVisible = false;
            }
        }
    }

    private void NoButton_Clicked(object sender, EventArgs e)
    {
        // if there are children nodes, set the current node to the last child
        if (CurrentNode.Children.Any())
        {
            CurrentNode = CurrentNode.Children.First();
            if (!CurrentNode.Children.Any())
            {
                NoButton.IsVisible = false;
                YesButton.IsVisible = false;
            }
        }
    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {
        // if the buttons are hidden show them
        if (!NoButton.IsVisible)
        {
            NoButton.IsVisible = true;
            YesButton.IsVisible = true;
        }
        // if there is a parent node navigate to it by setting the current node to the parent node
        if (CurrentNode.Parent != null)
        {
            CurrentNode = CurrentNode.Parent;
        }
        else // if there is no parent node then we should navigate back to the education page
        {
            CurrentNode = RootNode;
            Shell.Current.GoToAsync("//EducationDocumentPage", NavParameter);
        }
    }
}