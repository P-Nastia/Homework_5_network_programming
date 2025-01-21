using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Data.Entities;

[Table("tbl_cities")]
public class CityEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(250)]
    public string Ref { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string Description { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string Delivery1 { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string Delivery2 { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string Delivery3 { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string Delivery4 { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string Delivery5 { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string Delivery6 { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string Delivery7 { get; set; } = String.Empty;

    [ForeignKey("Area")]
    [StringLength(250)]
    public string Area { get; set; } = String.Empty;

    [ForeignKey("SettlementType")]
    [StringLength(250)]
    public string SettlementType { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string IsBranch { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string PreventEntryNewStreetsUser { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string CityID { get; set; } = String.Empty;

    [Required]
    [StringLength(250)]
    public string SettlementTypeDescription { get; set; } = String.Empty;

    [Required]
    public int SpecialCashCheck { get; set; }
    [Required]
    [StringLength(250)]
    public string AreaDescription { get; set; } = String.Empty;
    [ForeignKey("AreaEntity")]
    public int AreaEntityId { get; set; }
    public AreaEntity? AreaEntity { get; set; }
    public ICollection<WarehouseEntity> Departments { get; set; } = new List<WarehouseEntity>();
}
