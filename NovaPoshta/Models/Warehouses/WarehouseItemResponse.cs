using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Models.Warehouses;

public class WarehouseItemResponse
{
    public string SiteKey { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionRu { get; set; } = string.Empty;
    public string ShortAddress { get; set; } = string.Empty;
    public string ShortAddressRu { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string TypeOfWarehouse { get; set; } = string.Empty;
    public string Ref { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string CityRef { get; set; } = string.Empty;
    public string CityDescription { get; set; } = string.Empty;
    public string CityDescriptionRu { get; set; } = string.Empty;
    public string SettlementRef { get; set; } = string.Empty;
    public string SettlementDescription { get; set; } = string.Empty;
    public string SettlementAreaDescription { get; set; } = string.Empty;
    public string SettlementRegionsDescription { get; set; } = string.Empty;
    public string SettlementTypeDescription { get; set; } = string.Empty;
    public string SettlementTypeDescriptionRu { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
    public string Latitude { get; set; } = string.Empty;
    public string PostFinance { get; set; } = string.Empty;
    public string BicycleParking { get; set; } = string.Empty;
    public string PaymentAccess { get; set; } = string.Empty;
    public string POSTerminal { get; set; } = string.Empty;
    public string InternationalShipping { get; set; } = string.Empty;
    public string SelfServiceWorkplacesCount { get; set; } = string.Empty;
    public string TotalMaxWeightAllowed { get; set; } = string.Empty;
    public string PlaceMaxWeightAllowed { get; set; } = string.Empty;
    public Dimensions? SendingLimitationsOnDimensions { get; set; }
    public Dimensions? ReceivingLimitationsOnDimensions { get; set; }
    public WorkSchedule? Reception { get; set; }
    public WorkSchedule? Delivery { get; set; }
    public WorkSchedule? Schedule { get; set; }
    public string DistrictCode { get; set; } = string.Empty;
    public string WarehouseStatus { get; set; } = string.Empty;
    public string WarehouseStatusDate { get; set; } = string.Empty;
    public string WarehouseIllusha { get; set; } = string.Empty;
    public string CategoryOfWarehouse { get; set; } = string.Empty;
    public string Direct { get; set; } = string.Empty;
    public string RegionCity { get; set; } = " ";
    public string WarehouseForAgent { get; set; } = string.Empty;
    public string GeneratorEnabled { get; set; } = string.Empty;
    public string MaxDeclaredCost { get; set; } = string.Empty;
    public string WorkInMobileAwis { get; set; } = string.Empty;
    public string DenyToSelect { get; set; } = string.Empty;
    public string CanGetMoneyTransfer { get; set; } = string.Empty;
    public string HasMirror { get; set; } = string.Empty;
    public string HasFittingRoom { get; set; } = string.Empty;
    public string OnlyReceivingParcel { get; set; } = string.Empty;
    public string PostMachineType { get; set; } = string.Empty;
    public string PostalCodeUA { get; set; } = string.Empty;
    public string WarehouseIndex { get; set; } = string.Empty;
    public string BeaconCode { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string PostomatFor { get; set; } = string.Empty;
}
