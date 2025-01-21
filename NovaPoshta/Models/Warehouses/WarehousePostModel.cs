using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Models.Warehouses;

public class WarehousePostModel
{
    [JsonProperty("apiKey")]
    public string ApiKey { get; set; } = string.Empty;
    [JsonProperty("modelName")]
    public string ModelName { get; set; } = string.Empty;
    [JsonProperty("calledMethod")]
    public string CalledMethod { get; set; } = string.Empty;
    [JsonProperty("methodProperties")]
    public WarehouseMethodProperties? MethodProperties { get; set; }
}
public class WarehouseMethodProperties
{
    public string CityRef { get; set; } = String.Empty;
}
