using TestOverIT.SearchPhoto.ViewModel;

namespace TestOverIT.SearchPhoto;

public partial class SearchPhoto : ContentPage
{
	public SearchPhoto(SearchPhotoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}