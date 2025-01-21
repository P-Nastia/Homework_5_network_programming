using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Data.Entities;

[Table("tbl_warehouses")]
public class WarehouseEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(255)]
    public string SiteKey { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string Description { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string ShortAddress { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string Phone { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string TypeOfWarehouse { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string Ref { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string Number { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string CityRef { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string CityDescription { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string SettlementRef { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string SettlementDescription { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string SettlementAreaDescription { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string SettlementRegionsDescription { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string SettlementTypeDescription { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string Longitude { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string Latitude { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string PostFinance { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string BicycleParking { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string PaymentAccess { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string POSTerminal { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string InternationalShipping { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string SelfServiceWorkplacesCount { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string TotalMaxWeightAllowed { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string PlaceMaxWeightAllowed { get; set; } = string.Empty;
    [Required]
    public DimensionsEntity? SendingLimitationsOnDimensions { get; set; }
    [Required]
    public DimensionsEntity? ReceivingLimitationsOnDimensions { get; set; }
    [Required]
    public WorkScheduleEntity? Reception { get; set; }
    [Required]
    public WorkScheduleEntity? Delivery { get; set; }
    [Required]
    public WorkScheduleEntity? Schedule { get; set; }
    [Required]
    [StringLength(255)]
    public string DistrictCode { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string WarehouseStatus { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string WarehouseStatusDate { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string WarehouseIllusha { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string CategoryOfWarehouse { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string Direct { get; set; } = string.Empty;

    [StringLength(255)]
    public string RegionCity { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string WarehouseForAgent { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string GeneratorEnabled { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string MaxDeclaredCost { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string WorkInMobileAwis { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string DenyToSelect { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string CanGetMoneyTransfer { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string HasMirror { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string HasFittingRoom { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string OnlyReceivingParcel { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string PostMachineType { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string PostalCodeUA { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string WarehouseIndex { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string BeaconCode { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string Location { get; set; } = string.Empty;
    [Required]
    [StringLength(255)]
    public string PostomatFor { get; set; } = string.Empty;
    [ForeignKey("City")]
    public int CityId { get; set; }
    public CityEntity? City { get; set; }
}
