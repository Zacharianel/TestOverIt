using Newtonsoft.Json;

namespace TestOverIT.SearchPhoto.Model;

public class FlickrPhotos
{
    [JsonProperty("page")]
    public int Page { get; set; }

    [JsonProperty("pages")]
    public int TotalPages { get; set; }

    [JsonProperty("photo")]
    public List<FlickrPhoto> Photo { get; set; }
}
