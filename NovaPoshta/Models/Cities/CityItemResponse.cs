using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Models.Cities;

public class CityItemResponse
{
    public string Description { get; set; } = String.Empty;
    public string DescriptionRu { get; set; } = String.Empty;
    public string Ref { get; set; } = String.Empty;
    public string Delivery1 { get; set; } = String.Empty;
    public string Delivery2 { get; set; } = String.Empty;
    public string Delivery3 { get; set; } = String.Empty;
    public string Delivery4 { get; set; } = String.Empty;
    public string Delivery5 { get; set; } = String.Empty;
    public string Delivery6 { get; set; } = String.Empty;
    public string Delivery7 { get; set; } = String.Empty;
    public string Area { get; set; } = String.Empty;
    public string SettlementType { get; set; } = String.Empty;
    public string IsBranch { get; set; } = String.Empty;
    public string PreventEntryNewStreetsUser { get; set; } = String.Empty;
    public string CityID { get; set; } = String.Empty;
    public string SettlementTypeDescription { get; set; } = String.Empty;
    public string SettlementTypeDescriptionRu { get; set; } = String.Empty;
    public int SpecialCashCheck { get; set; }
    public string AreaDescription { get; set; } = String.Empty;
    public string AreaDescriptionRu { get; set; } = String.Empty;
}
