namespace VetToolsApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(Views.EducationDocumentPage), typeof(Views.EducationDocumentPage));
        Routing.RegisterRoute(nameof(Views.QueryPage), typeof(Views.QueryPage));
    }
}
