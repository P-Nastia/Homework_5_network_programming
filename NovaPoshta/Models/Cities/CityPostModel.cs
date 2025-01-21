using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Models.Cities;

public class CityPostModel
{
    [JsonProperty("apiKey")]
    public string ApiKey { get; set; } = string.Empty;
    [JsonProperty("modelName")]
    public string ModelName { get; set; } = string.Empty;
    [JsonProperty("calledMethod")]
    public string CalledMethod { get; set; } = string.Empty;
    [JsonProperty("methodProperties")]
    public CityMethodProperties? MethodProperties { get; set; }
}
public class CityMethodProperties
{
    [JsonProperty("AreaRef")]
    public string AreaRef { get; set; } = String.Empty;
}
