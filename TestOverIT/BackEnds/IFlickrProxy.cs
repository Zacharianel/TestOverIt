using TestOverIT.SearchPhoto.Model;

namespace TestOverIT.BackEnds;

public interface IFlickrProxy
{
    Task<List<FlickrPhoto>> SearchPhotosAsync(string query, int page, int perPage);
}
