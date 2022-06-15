namespace AppMarkupValidator;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPageCSharpMarkup), typeof(MainPageCSharpMarkup));
        Routing.RegisterRoute(nameof(ContadorPage), typeof(ContadorPage));
        


    }


}
