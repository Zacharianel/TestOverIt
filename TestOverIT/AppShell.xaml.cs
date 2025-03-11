using TestOverIT.SearchPhoto.Item;

namespace TestOverIT;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(PagePhoto), typeof(PagePhoto));
    }
}
