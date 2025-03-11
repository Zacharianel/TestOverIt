using Newtonsoft.Json;

using TestOverIT.SearchPhoto.Model;

namespace TestOverIT.BackEnds;

public class FlickrProxy : IFlickrProxy
{
    private const string BaseUrl = "https://api.flickr.com/services/rest/";
    private const string ApiKey = "255ac8fdac4726aa339fa1c2161b9e5b";

    private readonly HttpClient _httpClient;

    public FlickrProxy()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<FlickrPhoto>> SearchPhotosAsync(string query, int page = 1, int perPage = 20)
    {
        try
        {
            string url = $"{BaseUrl}?method=flickr.photos.search" +
                         $"&api_key={ApiKey}" +
                         $"&format=json&nojsoncallback=1" +
                         $"&text={Uri.EscapeDataString(query)}" +
                         $"&per_page={perPage}" +
                         $"&page={page}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                return new List<FlickrPhoto>();

            string json = await response.Content.ReadAsStringAsync();
            var flickrResponse = JsonConvert.DeserializeObject<FlickrResponse>(json); 

            return flickrResponse.Photos?.Photo ?? new List<FlickrPhoto>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore nella chiamata API: {ex.Message}");
            return new List<FlickrPhoto>();
        }
    }
}
