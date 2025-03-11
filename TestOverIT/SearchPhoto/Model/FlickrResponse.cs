using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace TestOverIT.SearchPhoto.Model;

public class FlickrResponse
{
    [JsonProperty("photos")]
    public FlickrPhotos Photos { get; set; }

    [JsonPropertyName("stat")]
    public string Stat { get; set; }
}
