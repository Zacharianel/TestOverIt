using TestOverIT.SearchPhoto.Model;

namespace TestOverIT.SearchPhoto.Item;

[QueryProperty(nameof(SelectedPhoto), "SelectedPhoto")]
public partial class PagePhoto : ContentPage
{
    public FlickrPhoto SelectedPhoto { get; set; }

    public PagePhoto()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        BindingContext = SelectedPhoto;
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}