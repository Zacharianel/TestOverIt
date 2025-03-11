using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TestOverIT.BackEnds;
using TestOverIT.SearchPhoto.Model;

namespace TestOverIT.SearchPhoto.ViewModel;

public partial class SearchPhotoViewModel : ObservableObject
{
    private readonly FlickrProxy _flickrProxy;
    private int _currentPage = 1;
    private bool _isLoading = false;

    public SearchPhotoViewModel(FlickrProxy flickrProxy)
    {
        _flickrProxy = flickrProxy;
        PhotoSelectedCommand = new RelayCommand<FlickrPhoto>(OnPhotoSelected);
    }

    public ObservableCollection<FlickrPhoto> Photos { get; } = new();

    [ObservableProperty]
    private string searchQuery;

    [ObservableProperty]
    private FlickrPhoto selectedPhoto;

    public IRelayCommand<FlickrPhoto> PhotoSelectedCommand { get; }

    private void OnPhotoSelected(FlickrPhoto photo)
    {
        if (photo == null) return;

        SelectedPhoto = photo;
    }


    [RelayCommand]
    public async Task SearchPhotos()
    {
        if (string.IsNullOrWhiteSpace(SearchQuery) || _isLoading) return;

        _currentPage = 1;
        Photos.Clear();

        await LoadMorePhotos();

        _isLoading = true;
    }

    [RelayCommand]
    public async Task LoadMorePhotos()
    {
        if (_isLoading) return;

        _isLoading = true;

        List<FlickrPhoto> newPhotos = new List<FlickrPhoto>();  
        try
        {
            newPhotos = await _flickrProxy.SearchPhotosAsync(SearchQuery, _currentPage);
        }
        catch (Exception ex)
        {
            await ShowErrorAsync($"Error during search: {ex.Message}");
        }
        
        foreach (var photo in newPhotos)
        {
            Photos.Add(photo);
        }

        _currentPage++; 

        _isLoading = true;
    }

    private async Task ShowErrorAsync(string message)
    {
        await MainThread.InvokeOnMainThreadAsync(async () =>
        {
            await Application.Current.MainPage.DisplayAlert("Error", message, "OK");
        });
    }

}
