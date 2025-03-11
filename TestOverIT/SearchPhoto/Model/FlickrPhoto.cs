using System.Collections.Generic;
using Newtonsoft.Json;

namespace TestOverIT.SearchPhoto.Model;

public class FlickrPhoto
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("owner")]
    public string Owner { get; set; }

    [JsonProperty("secret")]
    public string Secret { get; set; }

    [JsonProperty("server")]
    public string Server { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    public string ImageUrl => $"https://live.staticflickr.com/{Server}/{Id}_{Secret}.jpg";
}
