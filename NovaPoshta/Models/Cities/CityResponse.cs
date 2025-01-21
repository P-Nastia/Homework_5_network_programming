using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Models.Cities;

public class CityResponse
{
    public bool Success { get; set; }
    public List<CityItemResponse> Data { get; set; }
    public List<string> Errors { get; set; }
    public List<string> Warnings { get; set; }
    public CityInfo Info { get; set; }
    public List<string> MessageCodes { get; set; }
    public List<string> ErrorCodes { get; set; }
    public List<string> WarningCodes { get; set; }
    public List<string> InfoCodes { get; set; }

}
public class CityInfo
{
    public int TotalCount { get; set; }
}
